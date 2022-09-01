using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Interfaces;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Threading;
using Aplicacao.Base;
using Aplicacao.Modulos.Financeiro;
using cwkGestao.Modelo.Util;
using DevExpress.XtraGrid;

namespace Aplicacao
{
    public partial class GridDocumentoGen : Aplicacao.IntermediariasTela.GridDocumentoIntermediaria
    {
        #region Factory

        public static GridDocumentoGen Get(Documento selecionado, TipoDocumentoType tipo, bool somenteBaixados)
        {
            var configuracao = ConfiguracaoController.Instancia.GetConfiguracao();
            var modeloFiltro = somenteBaixados ? configuracao.ListagemBaixados : configuracao.ListagemAbertos;

            var filtroService = new ModeloFiltroUtil(modeloFiltro);
            var dataInicial = filtroService.ObterDataInicial();
            var dataFinal = filtroService.ObterDataFinal();

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("tipoDocumento", tipo);
            parametros.Add("somenteBaixados", somenteBaixados);

            var grid = new GridDocumentoGen(null, selecionado, tipo, true, dataInicial, dataFinal, parametros);

            Action<GridDocumentoGen> act = new Action<GridDocumentoGen>(CreateFormDocumento);
            Thread threadSubForm = new Thread(new ThreadStart(() => act(grid)));
            threadSubForm.Name = "ThreadFormDocumento";
            threadSubForm.Start();

            grid.Text = "Tabela de Documento a " + tipo + (somenteBaixados ? " [Baixado]" : "");
            if (selecionado != null)
                grid.Selecionando = true;
            return grid;
        }

        private static void CreateFormDocumento(GridGenerica<Documento> grid)
        {
            grid.FormManut = new FormDocumentoRateio();
        }

        #endregion

        #region Prop, construtores, layout

        public enum DestinoImpressao { Gráfica, Matricial, Cancelar }

        private readonly TipoDocumentoType? tipoDocumento;

        private FormFinanceiro formManut;

        private GridDocumentoGen(IFormManut<Documento> formManut, Documento seleecc, TipoDocumentoType? tipo, bool adicionaFiltro, DateTime? inicio,
            DateTime? fim, Dictionary<string, object> parametros)
            : base(null, formManut, seleecc, null, adicionaFiltro, inicio, fim, parametros)
        {
            tipoDocumento = tipo;
            Size = new Size(970, 479);
            gcPrincipal.Size = new Size(931, 364);
            ConfiguraBotoes();
        }

        protected override void GridGenerica_Shown(object sender, EventArgs e)
        {
            base.GridGenerica_Shown(sender, e);

            if (Convert.ToBoolean(ConfiguracaoController.Instancia.GetConfiguracao().UtilizaTelefonia))
            {
                AdicionaColunaTelefonia(gcPrincipal);
            }
        }

        protected override void GridGenerica_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Convert.ToBoolean(ConfiguracaoController.Instancia.GetConfiguracao().UtilizaTelefonia))
            {
                DevExpress.XtraGrid.Columns.GridColumn coluna = gvPrincipal.Columns["GrupoClienteTel"];
                gvPrincipal.Columns.Remove(coluna);
                gvPrincipal.RefreshEditor(true);
            }
            base.GridGenerica_FormClosing(sender, e);
        }

        private void AdicionaColunaTelefonia(GridControl grid)
        {
            DevExpress.XtraGrid.Columns.GridColumn coluna = new DevExpress.XtraGrid.Columns.GridColumn();
            coluna.VisibleIndex = gvPrincipal.Columns.Count - 2;
            coluna.Caption = "Grupo de Clientes";
            coluna.Visible = true;
            coluna.OptionsColumn.AllowEdit = false;
            coluna.Width = 250;
            coluna.Visible = true;
            coluna.FieldName = "GrupoClienteTel";
            coluna.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            coluna.AppearanceHeader.Options.UseTextOptions = true;
            coluna.Name = "GrupoClienteTelCol";
            gvPrincipal.Columns.Add(coluna);
            grid.Refresh();
            gvPrincipal.RefreshEditor(true);
        }

        private void ConfiguraBotoes()
        {
            sbFuncao10.Visible = sbFuncao11.Visible = sbFuncao12.Visible = sbFuncao13.Visible = true;
            sbFuncao10.Enabled = sbFuncao11.Enabled = sbFuncao12.Enabled = sbFuncao13.Enabled = true;
            sbFuncao10.Refresh(); sbFuncao11.Refresh(); sbFuncao12.Refresh(); sbFuncao13.Refresh();
            sbFuncao10.Text = "&Baixar";
            sbFuncao10.Image = Properties.Resources.Abaixo;
            sbFuncao10.Click += sbBaixar_Click;

            sbFuncao11.Text = "Co&mprovante";
            sbFuncao11.Click += sbComprovante_Click;
            sbFuncao11.Image = Properties.Resources.ImprimirCartaoPonto;
            sbFuncao11.Size = new Size(115, 23);

            sbFuncao12.Text = "B&oleto";
            sbFuncao12.Click += sbBoleto_Click;

            if (tipoDocumento != TipoDocumentoType.Receber)
                sbFuncao12.Enabled = false;

            //sbFuncao12.Enabled = false;
            sbFuncao12.Image = Properties.Resources.ImprimirCartaoPonto;
            sbFuncao12.Location = new Point(217, 382);
            sbFuncao12.Size = new Size(115, 23);

            sbFuncao13.Text = "&Duplicata";
            sbFuncao13.Click += sbDuplicata_Click;
            sbFuncao13.Image = Properties.Resources.ImprimirCartaoPonto;
            sbFuncao13.Location = new Point(335, 382);
            sbFuncao13.Size = new Size(115, 23);

            sbFuncao22.Visible = true;
            sbFuncao22.Enabled = true;
            sbFuncao22.Text = "C&ancelar Docto";
            sbFuncao22.Click += sbCancelarDocto_Click;
            sbFuncao22.Image = Properties.Resources.cancelar_copy;
            sbFuncao22.Size = new Size(115, 23);
            sbFuncao22.Location = new Point(217, 410);
            sbFuncao22.Refresh();

            sbFuncao23.Location = new Point(335, 410);
            sbFuncao23.Visible = false;

            sbSelecionar.Size = new Size(115, 23);

            sbConsultar.Location = new Point(634, 382);
            sbIncluir.Location = new Point(712, 382);
            sbAlterar.Location = new Point(790, 382);
            sbExcluir.Location = new Point(868, 382);
            sbFechar.Location = new Point(868, 410);
        }
        #endregion

        #region Eventos
        private void sbCancelarDocto_Click(object sender, EventArgs e)
        {
            bool BxTComCancelamento = false;

            var registroSelecionado = GetRegistroSelecionado();

            if (registroSelecionado.Situacao == "BxT")
            {
                var item = registroSelecionado.Movimentos.Where(x => x.Operacao == OperacaoMovimentoType.Cancelado);
                if (item.FirstOrDefault() != null)
                    BxTComCancelamento = true;
            }

            if (registroSelecionado.Situacao != "Canc" && BxTComCancelamento == false)
            {
                if (registroSelecionado.Saldo <= 0)
                {
                    MessageBox.Show("Documento zerado não pode ser cancelado.");
                    return;
                }

                FormDocumentoCancelamento bx = new FormDocumentoCancelamento { documentoACancelar = registroSelecionado };
                bx.ShowDialog();
                gcPrincipal.RefreshDataSource();
            }
            else
            {
                if (MessageBox.Show("Deseja excluir o cancelamento do documento?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DocumentoController.Instancia.DescancelarDocumentoUnico(registroSelecionado);
                    gcPrincipal.RefreshDataSource();
                }
            }
        }

        private void sbDuplicata_Click(object sender, EventArgs e)
        {
            Documento doc = (Documento)gvPrincipal.GetRow(gvPrincipal.GetSelectedRows()[0]);
            if (doc == null)
            {
                MessageBox.Show("Selecione um registro para impressão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var ask = new CwkMessageBox<DestinoImpressao>("Destino da impressão", "Selecione a forma de impressão");
            DestinoImpressao x = ask.ShowDialog();

            switch (x)
            {
                case DestinoImpressao.Gráfica:
                    new Relatorios.Duplicata(ConfiguracaoController.Instancia.GetConfiguracao().ModeloDuplicata).DeDocumento(GetRegistroSelecionado().ID);
                    break;
                case DestinoImpressao.Cancelar:
                    break;
                case DestinoImpressao.Matricial:
                    DocumentoController.Instancia.ImprimeDuplicata(GetRegistroSelecionado());
                    break;
                default:
                    return;
            }
        }

        private void sbBoleto_Click(object sender, EventArgs e)
        {
            var conf = ConfiguracaoController.Instancia.GetConfiguracao();
            Documento documento = GetRegistroSelecionado();
            if (documento.Situacao == "BxR")
            {
                MessageBox.Show("Não é possivel gerar boleto de Documentos de renegociação", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                if (documento != null)
                {
                    if (MessageBox.Show("Deseja emitir o boleto do documento selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (conf.IDRemessaPadrao != null)
                        {
                            FormImprimeBoletosRemessa form = new FormImprimeBoletosRemessa(documento);
                            form.SetandoLogicaParaRemessaPadrao();
                        }
                        else
                        {
                            FormImprimeBoletosRemessa form = new FormImprimeBoletosRemessa(documento);
                            form.ShowDialog();
                        }

                        this.gvPrincipal.RefreshData();
                        gcPrincipal.Refresh();
                        //gvPrincipal.Refresh();
                    }
                }
            }
        }

        private void sbComprovante_Click(object sender, EventArgs e)
        {
            ImprimeComprovante(GetRegistroSelecionado());
        }

        private void sbBaixar_Click(object sender, EventArgs e)
        {
            try
            {
                Documento doc = GetRegistroSelecionado();
                if (doc == null) { MessageBox.Show("Nenhum registro selecionado."); return; }
                if (doc.Saldo <= 0) { MessageBox.Show("Não é possível baixar documentos com saldo zerado."); return; }
                FormBaixarDocumento bx = new FormBaixarDocumento(doc);
                bx.ShowDialog();
                gcPrincipal.RefreshDataSource();
                if (bx.ConfirmouBaixa && MessageBox.Show("Deseja Imprimir o Recibo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    doc = GetRegistroSelecionado();
                    ImprimirRecibo(doc, bx.ValorBaixa);
                }
                AtualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected override void Excluir()
        {
            Documento doc = (Documento)gvPrincipal.GetRow(gvPrincipal.GetSelectedRows()[0]);
            if (doc.Situacao != "Norm")
            {
                MessageBox.Show("Não é permitido excluir documentos com movimentações.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            base.Excluir();
        }

        protected override void Incluir()
        {
            if (tipoDocumento.HasValue)
            {
                if (formManut == null) formManut = new FormFinanceiro();
                formManut.Operacao = cwkGestao.Modelo.Acao.Incluir;
                formManut.Selecionado = new Documento() { Tipo = tipoDocumento.Value };
                formManut.ShowDialog();
                if (formManut.DocsCriados != null) formManut.DocsCriados.ForEach(docCriado => ((IList<Documento>)gcPrincipal.DataSource).Add(docCriado));
                gcPrincipal.RefreshDataSource();
                if (formManut.DocsCriados != null) gvPrincipal.MoveLastVisible();
            }
        }

        protected override void Alterar()
        {
            Documento registroSelecionado = GetRegistroSelecionado();

            if (registroSelecionado != null)
            {
                if (registroSelecionado.Situacao != "BxR")
                {
                    FormDocumento form = new FormDocumento();
                    form.Selecionado = registroSelecionado;
                    form.Operacao = cwkGestao.Modelo.Acao.Alterar;
                    form.Text = "Alterando registro de Documento";
                    if (cwkControleUsuario.Facade.ControleAcesso(form))
                    {
                        form.ShowDialog();
                        if (form.Selecionado != null)
                        {
                            AtualizarRegistroNoGrid(registroSelecionado, form.Selecionado);
                        }
                    }
                }
                else
                {
                    sbConsultar_Click(new object(), new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Metodos
        public void ImprimeComprovante(Documento selecionado)
        {

            String nomerel = "rptComprovanteDocumento.rdlc";
            String ds = "dsImpDocumento_dtDocumento";
            String titulo = "Comprovante Lançamento - Documento a " + selecionado.Tipo;
            String filialNome = FilialController.Instancia.GetFilialPrincipal().Nome;
            var parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            var p1 = new Microsoft.Reporting.WinForms.ReportParameter("Empresa", filialNome.ToUpper());
            var p2 = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", titulo);
            parametros.Add(p1);
            parametros.Add(p2);
            var dt = new Relatorio.dsImpDocumento();
            String endereco = selecionado.Pessoa.EnderecoPrincipal().Endereco + " " +
                              selecionado.Pessoa.EnderecoPrincipal().Numero;
            String telefone = selecionado.Pessoa.TelefonePrincipal;

            foreach (Movimento mov in selecionado.Movimentos.Where(w => w.Sequencia == 1))
            {
                dt.dtDocumento.AdddtDocumentoRow(selecionado.Codigo, selecionado.Filial.Nome, selecionado.Dt,
                    selecionado.DtDigitacao, selecionado.DtVencimento, selecionado.DtPrevisao,
                    selecionado.NumRequisicao, selecionado.NumDocumento, selecionado.Pessoa.Nome, selecionado.TipoDocumento.Nome,
                    selecionado.Banco.Nome, selecionado.Portador.Nome, selecionado.Acrescimo.Nome, selecionado.Condicao.Nome,
                    selecionado.ComplementoHist, selecionado.Valor, endereco, telefone, mov.PlanoConta.Nome, mov.Valor);
            }

            var form = new Aplicacao.Base.FormRelatorioBase(nomerel, ds, dt.dtDocumento, parametros);
            form.ShowDialog();
        }

        private void ImprimirRecibo(Documento objDocumento, decimal ValorTotalBaixa)
        {
            List<Object> ParametrosRecibo = new List<Object>();
            String EndercoEmpresa, Referente, Filial, Pessoa, CNPJ_CPF;
            String EnderecoCliente = "";

            EnderecoCliente = objDocumento.Pessoa.EnderecoPrincipal().Endereco + " " + objDocumento.Pessoa.EnderecoPrincipal().Numero;

            EndercoEmpresa = objDocumento.Filial.Endereco + " " + objDocumento.Filial.Numero.ToString() + " " + objDocumento.Filial.Bairro + " " + objDocumento.Filial.Cidade.Nome;
            Referente = objDocumento.ComplementoHist + " Nº Doc. " + objDocumento.NumDocumento + " Parcela " + objDocumento.Parcela.ToString() + "/" + objDocumento.QtParcela.ToString() + " Vencimento " + String.Format("{0: dd/MM/yyyy}", objDocumento.DtVencimento);
            Filial = objDocumento.Filial.Nome;
            Pessoa = objDocumento.Pessoa.Nome;
            CNPJ_CPF = objDocumento.Filial.CNPJ;

            ParametrosRecibo = DocumentoController.Instancia.recibo(EnderecoCliente, EndercoEmpresa, Referente, ValorTotalBaixa, objDocumento.Tipo.ToString(), Filial, Pessoa, CNPJ_CPF);

            Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase(ParametrosRecibo[0].ToString(), ParametrosRecibo[1].ToString(), ParametrosRecibo[2], (List<Microsoft.Reporting.WinForms.ReportParameter>)ParametrosRecibo[3]);
            form.Text = objDocumento.Tipo.ToString();
            form.ShowDialog();
        }
        #endregion


    }
}
