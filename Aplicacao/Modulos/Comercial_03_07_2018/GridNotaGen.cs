using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Interfaces;
using Aplicacao.IntermediariasTela;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using cwkGestao.Negocio.RelatoriosMatriciais;
using DevExpress.XtraGrid;
using Aplicacao.Base;
using Aplicacao.Modulos.Financeiro;
using System.Linq;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Integracao.Magento.Exportacao;
using Aplicacao.Modulos.Cadastro;
using cwkGestao.Negocio.Impressao;
using Aplicacao.Modulos.Comercial;
using Aplicacao.Util;
using DevExpress.XtraGrid.Views.Grid;
using cwkGestao.NFe;
using cwkGestao.Negocio.Comercial;
using cwkGestao.Negocio.Padroes;
using cwkGestao.Negocio.Utils;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;

namespace Aplicacao
{
    public partial class GridNotaGen : Aplicacao.IntermediariasTela.GridNotaIntermediaria
    {
        private bool notasCanceladas;
        private InOutType inOut;
        private ProdutoServicoType produtoServico;
        private bool selecionandoComplementada;
        private bool selecionandoReferenciada;
        private LogicaTelaNotaFiscal logicaTelaNota;
        private Configuracao configuracao;

        public DevExpress.XtraEditors.SimpleButton sbFuncao29;

        private Cw_acesso acessoCampoGrupoUsuario;
        public bool SelecionandoComplementada
        {
            get { return selecionandoComplementada; }
            set
            {
                if (value)
                {
                    sbFuncao10.Visible = false;
                    sbFuncao11.Visible = false;
                    sbFuncao12.Visible = false;
                    sbFuncao13.Visible = false;
                    sbFuncao22.Visible = false;
                    sbFuncao23.Visible = false;
                    sbDuplicarNota.Visible = false;
                    btNotaComplementar.Visible = false;

                }
                selecionandoComplementada = value;
                Selecionando = value;
            }
        }

        public bool SelecionandoReferenciada
        {
            get { return selecionandoReferenciada; }
            set
            {
                if (value)
                {
                    sbFuncao10.Visible = false;
                    sbFuncao11.Visible = false;
                    sbFuncao12.Visible = false;
                    sbFuncao13.Visible = false;
                    sbFuncao22.Visible = false;
                    sbFuncao23.Visible = false;
                    sbDuplicarNota.Visible = false;
                    btNotaComplementar.Visible = false;
                }
                selecionandoReferenciada = value;
                Selecionando = value;
            }
        }

        public static GridNotaGen Get(InOutType inOut, ProdutoServicoType produtoServico, bool notasCanceladas)
        {
            return new GridNotaGen(NotaController.Instancia.GetAll(inOut, produtoServico, notasCanceladas), inOut, notasCanceladas, produtoServico, null, false, typeof(FormNota), new object[] { inOut });
        }

        public static GridNotaGen Get(InOutType inOut, ProdutoServicoType produtoServico, bool notasCanceladas, int idPessoa, string situacao)
        {
            return new GridNotaGen(NotaController.Instancia.GetAutorizadasPorCliente(inOut, produtoServico, notasCanceladas, idPessoa, situacao), inOut, notasCanceladas, produtoServico, null, false, typeof(FormNota), new object[] { inOut });
        }

        private GridNotaGen(IList<Nota> lista, InOutType inOut, bool notasCanceladas, ProdutoServicoType produtoServico, Nota selecionado, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, selecionado, adicionarFiltro, formManut, parametros)
        {
            this.inOut = inOut;
            this.notasCanceladas = notasCanceladas;
            this.produtoServico = produtoServico;

            Size = new Size(941, 491);
            gcPrincipal.Size = new Size(905, 382);

            if (!notasCanceladas)
            {
                ConfiguraBotaoBoleto();
                ConfiguraBotaoImpressaoNota();
                ConfiguraBotaoCupomFiscal();
            }
            else
            {
                sbIncluir.Enabled = false;
                sbAlterar.Enabled = false;
                sbExcluir.Enabled = false;
            }

            ConfiguraBotaoCusto();
            ConfiguraBotaoCancelarNF();
            ConfiguraBotaoDuplicata();
            ConfiguraBotaoNFe();
            ConfiguraBotaoDuplicarNFe();
            ConfiguraBotaoEmail();
            ConfiguraBotaoNotaComplementar();
            ConfigurarBotaoImprimir();
            ConfigurarBotaoNFSe();
            ConfigurarBotaoSubstituida();
            ConfiguraBotaoStatusLocal();

            sbConsultar.Location = new Point(599, 399);
            sbIncluir.Location = new Point(680, 399);
            sbAlterar.Location = new Point(761, 399);
            sbExcluir.Location = new Point(842, 399);
            sbFechar.Location = new Point(842, 426);
            sbImprimirFiltro.Location = new Point(600, 426);

            sbSelecionar.Location = new Point(93, 400);

            if (produtoServico == ProdutoServicoType.Servicos)
                this.Text += " de Serviço";

            this.Text += " de " + inOut.ToString();
            if (notasCanceladas)
                this.Text += " [Cancelada]";

            this.configuracao = ConfiguracaoController.Instancia.GetConfiguracao();

            this.acessoCampoGrupoUsuario = Cw_acessoController.Instancia.LoadAcessoByGrupoTextoForm(Modelo.cwkGlobal.objUsuarioLogado.IdGrupo, this.Text);
        }


        private void ConfiguraBotaoNotaComplementar()
        {
            btNotaComplementar = new DevExpress.XtraEditors.SimpleButton();
            btNotaComplementar.Location = new System.Drawing.Point(291, 426);
            btNotaComplementar.Name = "btNotaComplementar";
            btNotaComplementar.Size = new System.Drawing.Size(105, 23);
            btNotaComplementar.TabIndex = 14;
            btNotaComplementar.Text = "Complementa&r";
            btNotaComplementar.Click += new System.EventHandler(this.btNotaComplementar_Click);
            btNotaComplementar.Anchor = (AnchorStyles.Left | AnchorStyles.Bottom);
            btNotaComplementar.Image = global::Aplicacao.Properties.Resources.Acerto_copy;
            Controls.Add(this.btNotaComplementar);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            gvPrincipal.OptionsSelection.MultiSelect = true;
            gvPrincipal.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;
            gvPrincipal.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(gvPrincipal_SelectionChanged);
            gvPrincipal.Columns.Remove(gvPrincipal.Columns["NumeroRecibo"]);
            gvPrincipal.Columns.Remove(gvPrincipal.Columns["NumeroProtocolo"]);
            gvPrincipal.Columns.Remove(gvPrincipal.Columns["TransNome"]);
        }

        private void ConfigurarBotaoNFSe()
        {
            if (inOut != InOutType.Entrada)
            {
                btNFSe = new DevExpress.XtraEditors.SimpleButton();
                btNFSe.Location = new System.Drawing.Point(94, 426);
                btNFSe.Name = "btNFSe";
                btNFSe.Size = new System.Drawing.Size(83, 23);
                btNFSe.TabIndex = 18;
                btNFSe.Text = "NF&Se";
                btNFSe.Click += new System.EventHandler(btNFSe_Click);
                btNFSe.Anchor = (AnchorStyles.Left | AnchorStyles.Bottom);
                btNFSe.Image = global::Aplicacao.Properties.Resources.Modify;
                btNFSe.Visible = true;
                Controls.Add(this.btNFSe);
            }
        }

        private void ConfigurarBotaoSubstituida()
        {
            if (inOut != InOutType.Entrada)
            {
                sbSubstituida = new DevExpress.XtraEditors.SimpleButton();
                sbSubstituida.Location = new System.Drawing.Point(401, 426);
                sbSubstituida.Name = "sbSubstituida";
                sbSubstituida.Size = new System.Drawing.Size(105, 23);
                sbSubstituida.TabIndex = 18;
                sbSubstituida.Text = "Substituida";
                sbSubstituida.Click += new System.EventHandler(sbSubstituida_Click);
                sbSubstituida.Anchor = (AnchorStyles.Left | AnchorStyles.Bottom);
                sbSubstituida.Image = global::Aplicacao.Properties.Resources._48px_Crystal_Clear_app_korganizer;
                sbSubstituida.Visible = false;
                sbSubstituida.Enabled = false;
                Controls.Add(this.sbSubstituida);
            }
        }

        private void ConfigurarBotaoImprimir()
        {
            if (inOut != InOutType.Saída)
            {

                btImprimir = new DevExpress.XtraEditors.SimpleButton();
                btImprimir.Location = new System.Drawing.Point(402, 399);
                btImprimir.Name = "btImprimir";
                btImprimir.Size = new System.Drawing.Size(105, 23);
                btImprimir.TabIndex = 14;
                btImprimir.Text = "I&mprimir";
                btImprimir.Click += new System.EventHandler(btImprimir_Click);
                btImprimir.Anchor = (AnchorStyles.Left | AnchorStyles.Bottom);
                btImprimir.Image = global::Aplicacao.Properties.Resources.Importação_de_Bilhetes_copy;
                Controls.Add(this.btImprimir);
                sbFuncao11.Enabled = false;
            }

        }

        private void ConfiguraBotaoDuplicarNFe()
        {
            sbDuplicarNota = new DevExpress.XtraEditors.SimpleButton();
            sbDuplicarNota.Click += new EventHandler(btDuplicarNfe_Click);
            sbDuplicarNota.Image = global::Aplicacao.Properties.Resources.ImprimirCartaoPonto;
            sbDuplicarNota.Visible = true;
            sbDuplicarNota.Enabled = true;
            sbDuplicarNota.Location = new Point(403, 399);

            sbDuplicarNota.Size = new Size(105, 23);
            sbDuplicarNota.Text = "D&uplicar";

            sbDuplicarNota.Anchor = (AnchorStyles.Left | AnchorStyles.Bottom);
            Controls.Add(this.sbDuplicarNota);
        }

        private void ConfiguraBotaoNFe()
        {
            sbFuncao10.Click += new EventHandler(btNFe_Click);
            sbFuncao10.Text = "NF&e";
            sbFuncao10.Image = global::Aplicacao.Properties.Resources.ImprimirCartaoPonto;
            sbFuncao10.Visible = true;
            sbFuncao10.Enabled = true;
            sbFuncao10.Location = new Point(12, 399);
            sbFuncao10.Size = new Size(75, 23);
        }


        private void ConfiguraBotaoEmail()
        {
            sbFuncao25.Click += new EventHandler(btEmail_Click);
            sbFuncao25.Text = "E&mail";
            sbFuncao25.Image = global::Aplicacao.Properties.Resources._1371664476_14028;
            sbFuncao25.Visible = true;
            sbFuncao25.Enabled = true;
            sbFuncao25.Location = new Point(12, 426);
            sbFuncao25.Size = new Size(75, 23);
        }

        private void ConfiguraBotaoImpressaoNota()
        {
            sbFuncao11.Click += new EventHandler(btImpressaoNota_Click);
            sbFuncao11.Text = "I&mprimir";
            sbFuncao11.Image = global::Aplicacao.Properties.Resources.ImprimirCartaoPonto;
            sbFuncao11.Visible = true;
            sbFuncao11.Enabled = true;
            sbFuncao11.Location = new Point(93, 399);
        }

        private void ConfiguraBotaoCupomFiscal()
        {
            sbFuncao12.Click += new EventHandler(btCupomFiscal_Click);
            sbFuncao12.Text = "C&upom Fiscal";
            sbFuncao12.Image = global::Aplicacao.Properties.Resources.ImprimirCartaoPonto;
            sbFuncao12.Visible = true;
            sbFuncao12.Enabled = true;
            sbFuncao12.Size = new Size(103, 23);
            sbFuncao12.Location = new Point(182, 399);
        }

        private void ConfiguraBotaoDuplicata()
        {
            sbFuncao22.Click += new EventHandler(btDuplicata_Click);
            sbFuncao22.Text = "&Duplicata";
            sbFuncao22.Image = global::Aplicacao.Properties.Resources.ImprimirCartaoPonto;
            sbFuncao22.Visible = true;
            sbFuncao22.Enabled = true;
            sbFuncao22.Size = new Size(103, 23);
            sbFuncao22.Location = new Point(182, 426);
        }

        private void ConfiguraBotaoBoleto()
        {
            sbFuncao13.Click += new EventHandler(btBoleto_Click);
            sbFuncao13.Text = "&Boleto";
            sbFuncao13.Image = global::Aplicacao.Properties.Resources.ImprimirCartaoPonto;
            sbFuncao13.Visible = true;
            sbFuncao13.Enabled = true;
            sbFuncao13.Size = new System.Drawing.Size(105, 23);
            sbFuncao13.Location = new Point(291, 399);
        }


        private void ConfiguraBotaoCusto()
        {
            configuracao = configuracao == null ? ConfiguracaoController.Instancia.GetConfiguracao() : configuracao;
            if ((inOut != InOutType.Entrada) && (configuracao.UtilizaCustoNota))
            {
                sbCusto = new DevExpress.XtraEditors.SimpleButton();
                sbCusto.Location = new System.Drawing.Point(761, 426);
                sbCusto.Name = "sbCusto";
                sbCusto.Size = new System.Drawing.Size(75, 23);
                sbCusto.TabIndex = 13;
                sbCusto.Text = "Custo";
                sbCusto.Click += new System.EventHandler(sbCusto_Click);
                sbCusto.Anchor = (AnchorStyles.Left | AnchorStyles.Bottom);
                sbCusto.Image = global::Aplicacao.Properties.Resources._48px_Crystal_Clear_app_korganizer;
                sbCusto.Visible = true;
                sbCusto.Enabled = true;
                Controls.Add(this.sbCusto);
            }
        }

        private void ConfiguraBotaoCancelarNF()
        {

            sbFuncao23.Visible = false;
            sbFuncao23.Enabled = false;

        }
        private void ConfiguraBotaoStatusLocal()
        {
            sbFuncao29 = new DevExpress.XtraEditors.SimpleButton();
            sbFuncao29.Location = new System.Drawing.Point(405, 426);
            sbFuncao29.Name = "btStatusLocal";
            sbFuncao29.Size = new System.Drawing.Size(105, 23);
            sbFuncao29.TabIndex = 14;
            sbFuncao29.Text = "Status Local";
            sbFuncao29.Click += new System.EventHandler(btStatusLocal_Click);
            sbFuncao29.Anchor = (AnchorStyles.Left | AnchorStyles.Bottom);
            sbFuncao29.Image = global::Aplicacao.Properties.Resources.Importação_de_Bilhetes_copy;
            Controls.Add(this.sbFuncao29);
            sbFuncao29.Enabled = true;
        }
        private void btDuplicarNfe_Click(object sender, EventArgs e)
        {
            try
            {
                Duplicar();
            }
            catch (Exception ex)
            {

            }
        }

        protected override void Duplicar()
        {
            if (gvPrincipal.GetRegistroSelecionado() != null)
            {
                Nota registroSelecionado = (Nota)GetRegistroSelecionado().Clonar();
                VerificaForm();

                FormNota formManut = new FormNota(inOut, true);
                formManut.Selecionado = registroSelecionado;
                formManut.Operacao = cwkGestao.Modelo.Acao.Incluir;
                formManut.ShowDialog();

                if (formManut.Selecionado != null)
                {
                    lista.Add(formManut.Selecionado);
                    SelecionaRegistroNoGrid(gvPrincipal.GetRowHandle(lista.IndexOf(formManut.Selecionado)));
                }

                AtualizarGrid();
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btNFe_Click(object sender, EventArgs e)
        {
            string statusNotaAntigo, statusNotaNovo;
            var registroSelecionado = GetRegistroSelecionado();
            if (registroSelecionado != null)
            {
                if (registroSelecionado.TipoNota.NFOrigem == 0)
                {
                    MessageBox.Show("Não é possivel enviar notas com origem de terceiro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Nota notaAtualizada;
                    bool bRetornoEnvioXMLSHL;
                    NotaItemPedidoItem notaItemPedidoItem;
                    var nota = NotaController.Instancia.LoadObjectById(registroSelecionado.ID);
                    statusNotaAntigo = nota.Status;
                    var pessoa = PessoaController.Instancia.LoadObjectById(nota.Pessoa.ID);

                    if (registroSelecionado.ModeloDocto != 55 && registroSelecionado.ModeloDocto != 65)
                    {
                        MessageBox.Show("O registro selecionado não é uma NFe.", "Operação não Permitida", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        try
                        {
                            FormNFe frmNFe = new FormNFe();
                            frmNFe.IDNota = registroSelecionado.ID;
                            frmNFe.ShowDialog();
                            frmNFe.Dispose();

                            RecarregarGrid();

                            notaItemPedidoItem = PedidoController.Instancia.LoadNotaItemPedidoItemByIdNota(registroSelecionado.ID);
                            notaAtualizada = NotaController.Instancia.LoadObjectById(registroSelecionado.ID);
                            statusNotaNovo = notaAtualizada.Status;
                            if ((statusNotaAntigo) !=
                                (statusNotaNovo))
                            {
                                if (notaItemPedidoItem != null)
                                {
                                    Pedido pedidoRelacionadoNota = notaItemPedidoItem.PedidoItem.Pedido;
                                    if ((pedidoRelacionadoNota.CodShl != 0) &&
                                        (notaAtualizada.Status == "2"))
                                    {
                                        bRetornoEnvioXMLSHL = SHLUtil.EnviarXMLPedidoSHL(pedidoRelacionadoNota, notaAtualizada);
                                        if (bRetornoEnvioXMLSHL)
                                        {
                                            MessageBox.Show("Sucesso no envio do XML da Nota de número " + notaAtualizada.Codigo + " para o SHL", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            new FormErro(ex).ShowDialog();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void btEmail_Click(object sender, EventArgs e)
        {
            IList<Nota> notas = GetRegistrosSelecionados();

            if (notas.Count > 0)
            {
                FormEnviaEmail frmEnviaEmail = new FormEnviaEmail(notas);
                frmEnviaEmail.ShowDialog();
                frmEnviaEmail.Dispose();
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado.");
            }
        }

        private void btStatusLocal_Click(object sender, EventArgs e)
        {

            var registroSelecionado = GetRegistroSelecionado();
            if (registroSelecionado != null)
            {
                var nota = NotaController.Instancia.LoadObjectById(registroSelecionado.ID);
                string statusdanota = "";

                if (nota.StatusLocal == "0")
                {
                    nota.StatusLocal = "1";
                    statusdanota = "Logistica";
                }
                else
                {
                    nota.StatusLocal = "0";
                    statusdanota = "Financeiro";
                }

                if (MessageBox.Show("Deseja Alterar o status Local da Nota para " + statusdanota, "Alteração do Status Local da Nota", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
	                {
                        NotaController.Instancia.Salvar(nota, Acao.Alterar);
                        MessageBox.Show("Status Local alterado com sucesso !");
		 
	                }

                RecarregarGrid();
            }
            else
            {
                MessageBox.Show("Selecione uma nota para realizar a Alteração do Status Local!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gvPrincipal_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            GridView gv = (GridView)sender;
            if (gv.SelectedRowsCount > 1)
            {
                HabilitarBotoesMultiSelect(false);
            }
            else
            {
                HabilitarBotoesMultiSelect(true);
            }
        }

        private void HabilitarBotoesMultiSelect(bool b)
        {          
            sbConsultar.Enabled = b && Cw_acessoController.Instancia.PossuiAcesso(acessoCampoGrupoUsuario, sbConsultar.Name, Modelo.cwkGlobal.objUsuarioLogado.Tipo); 
            sbIncluir.Enabled = b && Cw_acessoController.Instancia.PossuiAcesso(acessoCampoGrupoUsuario, sbIncluir.Name, Modelo.cwkGlobal.objUsuarioLogado.Tipo); 
            sbAlterar.Enabled = b && Cw_acessoController.Instancia.PossuiAcesso(acessoCampoGrupoUsuario, sbAlterar.Name, Modelo.cwkGlobal.objUsuarioLogado.Tipo); 
            sbExcluir.Enabled = b && Cw_acessoController.Instancia.PossuiAcesso(acessoCampoGrupoUsuario, sbExcluir.Name, Modelo.cwkGlobal.objUsuarioLogado.Tipo); 
            sbSelecionar.Enabled = b && Cw_acessoController.Instancia.PossuiAcesso(acessoCampoGrupoUsuario, sbSelecionar.Name, Modelo.cwkGlobal.objUsuarioLogado.Tipo); 
            sbImprimirFiltro.Enabled = b && Cw_acessoController.Instancia.PossuiAcesso(acessoCampoGrupoUsuario, sbImprimirFiltro.Name, Modelo.cwkGlobal.objUsuarioLogado.Tipo); 
            sbFuncao10.Enabled = b && Cw_acessoController.Instancia.PossuiAcesso(acessoCampoGrupoUsuario, sbFuncao10.Name, Modelo.cwkGlobal.objUsuarioLogado.Tipo); 
            sbFuncao12.Enabled = b && Cw_acessoController.Instancia.PossuiAcesso(acessoCampoGrupoUsuario, sbFuncao12.Name, Modelo.cwkGlobal.objUsuarioLogado.Tipo); 
            sbFuncao13.Enabled = b && Cw_acessoController.Instancia.PossuiAcesso(acessoCampoGrupoUsuario, sbFuncao13.Name, Modelo.cwkGlobal.objUsuarioLogado.Tipo); 
            sbFuncao22.Enabled = b && Cw_acessoController.Instancia.PossuiAcesso(acessoCampoGrupoUsuario, sbFuncao22.Name, Modelo.cwkGlobal.objUsuarioLogado.Tipo); 
            sbFuncao23.Enabled = b && Cw_acessoController.Instancia.PossuiAcesso(acessoCampoGrupoUsuario, sbFuncao23.Name, Modelo.cwkGlobal.objUsuarioLogado.Tipo); 
            btNotaComplementar.Enabled = b && Cw_acessoController.Instancia.PossuiAcesso(acessoCampoGrupoUsuario, btNotaComplementar.Name, Modelo.cwkGlobal.objUsuarioLogado.Tipo); 

            sbDuplicarNota.Enabled = b && Cw_acessoController.Instancia.PossuiAcesso(acessoCampoGrupoUsuario, sbDuplicarNota.Name, Modelo.cwkGlobal.objUsuarioLogado.Tipo);

            if (inOut == InOutType.Saída)
            {
                btNFSe.Enabled = b && Cw_acessoController.Instancia.PossuiAcesso(acessoCampoGrupoUsuario, btNFSe.Name, Modelo.cwkGlobal.objUsuarioLogado.Tipo); ;
            }
            else
            {
                btImprimir.Enabled = b && Cw_acessoController.Instancia.PossuiAcesso(acessoCampoGrupoUsuario, btImprimir.Name, Modelo.cwkGlobal.objUsuarioLogado.Tipo); ;
            }
        }

        private void btImpressaoNota_Click(object sender, EventArgs e)
        {
            Nota notaSelecionada = GetRegistroSelecionado();

            IList<Produto> lstProdutos = NotaItem.GetProdutos(notaSelecionada.NotaItems);
            Boolean ImprimeRelatorioControleVenda = configuracao.BImprimeRelatorioControleVenda;

            if (ImprimeRelatorioControleVenda)
            {
                Modelo.DestinoImpressaoVendaType dest =
                    new CwkMessageBox<Modelo.DestinoImpressaoVendaType>("Atenção", "Escolha o destino da impressão", SystemIcons.Question).ShowDialog();

                switch (dest)
                {
                    case Modelo.DestinoImpressaoVendaType.ControleVenda:
                        ImprimirControleVenda();
                        break;
                    case Modelo.DestinoImpressaoVendaType.NFe:
                        ImpressaoNota();
                        break;
                }
            }
            else
            {
                if (MessageBox.Show("Deseja imprimir as notas selecionadas?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    return;
                }

                ImpressaoNota();
            }
        }

        public void ImprimirControleVenda()
        {
            Nota nota = ((Nota)gvPrincipal.GetRegistroSelecionado());
            if (!Nota.IsNullOrEmpty(nota))
            {
                try
                {
                    Relatorio.dsImpressaoImeis.dtImpressaoControleVendaA5DataTable Dados;
                    List<Microsoft.Reporting.WinForms.ReportParameter> parametros;
                    NotaController.Instancia.BuscaParametrosImpressaoControleVenda(nota, out Dados, out parametros);
                    Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase("rptImpressaoControleVendaA5.rdlc",
                        "dsImpressaoImeis_dtImpressaoControleVendaA5", Dados, parametros);
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    FormErro formErro = new FormErro("Erro ao Gerar o Relatório", ex.Message);
                    formErro.ShowDialog();
                }
            }
            else
            {
                FormErro formErro = new FormErro("Erro ao Gerar o Relatório", "Nota nula ou vazia");
                formErro.ShowDialog();
            }
        }

        private void ImpressaoNota()
        {
            IList<Nota> notas = GetRegistrosSelecionados();

            if (notas != null && notas.Count > 0)
            {
                List<Int32> idsNotas = notas.Select(s => s.ID).ToList();

                notas = NotaController.Instancia.LoadAllByIds(idsNotas);

                IList<Nota> nfe = new List<Nota>();
                IList<Nota> nfse = new List<Nota>();
                NFeController nfeController;
                HttpManager httpManager = new HttpManager();
                ConfiguracaoManager configManager = ConfiguracaoManagerController.Instancia.GetAll().FirstOrDefault();

                //bool? utilizaLayout4 = ConfiguracaoController.Instancia.GetConfiguracao().UtilizaLayout4;
                int LayoutNFE = ConfiguracaoController.Instancia.GetConfiguracao().LayoutNFe;

                cwkGestao.NFe.Enums.TipoCertificado tipoCertificado = cwkGestao.NFe.Enums.TipoCertificado.ckFile;
                int countNotasNaoAutorizadas = 0;

                foreach (Nota nota in notas)
                {
                    if (nota.StatusLegivel != "Autorizada" && nota.StatusLegivel != "Contingência")
                    {
                        countNotasNaoAutorizadas++;
                    }
                    else
                    {
                        if (nota.TipoNota.ModeloDocto == TipoNota.ModeloDocumento.NFe || nota.TipoNota.ModeloDocto == TipoNota.ModeloDocumento.NFCe)
                        {
                            if (!String.IsNullOrEmpty(nota.XmlDestinatarioNFe) || nota.Status == "8")
                            {
                                nfe.Add(nota);
                            }
                        }
                        else if (nota.TipoNota.ModeloDocto == TipoNota.ModeloDocumento.NFSe || nota.TipoNota.ModeloDocto == TipoNota.ModeloDocumento.RPS)
                        {
                            nfse.Add(nota);
                        }
                    }
                }

                if (countNotasNaoAutorizadas > 0)
                {
                    if (MessageBox.Show(
                        "Existem notas selecionadas que estão com status diferente de \"Autorizada\"." +
                        " Estas notas \"Não autorizadas\" não serão impressas. Deseja Continuar?",
                        "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        return;
                    }
                }

                foreach (Nota nota in nfe)
                {
                    nfeController = cwkGestao.NFe.NFeController.ProduceFromNHibernate(nota, LayoutNFE, tipoCertificado, null, configManager);
                    nfeController.ImprimirNota(nota);
                }
                foreach (Nota nota in nfse)
                {
                    IList<string> ret = new List<string>();
                    IList<string> ParametrosImprimir = new List<string>();

                    ParametrosImprimir.Add("NomeCidade=" + cwkGestao.Negocio.Utils.NFSEUtils.RemoveAcentos(nota.Filial.Cidade.Nome));
                    ParametrosImprimir.Add("NumNFSe=" + nota.NumeroNFSe.ToString());
                    ParametrosImprimir.Add("ModoImpressao=" + "PDF");
                    ParametrosImprimir.Add("Url=1");
                    ParametrosImprimir.Add("Quantidade=1");

                    try
                    {
                        ExibeCursorEspera cursor = new ExibeCursorEspera();
                        using (cursor)
                        {
                            ret.Add(httpManager.GetManager(configManager, nota, "nfse", "imprime", ParametrosImprimir).FirstOrDefault());
                        }
                        this.WindowState = FormWindowState.Normal;
                        NFSEUtils.ImprimirNFSELote(ret);
                    }
                    catch (Exception z)
                    {
                        MessageBox.Show(z.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhuma Nota selecionada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ChamarImpressaoNota(Nota nota)
        {
            bool video = new Aplicacao.DestinoImpressaoNota().Show() == Modelo.DestinoImpressao.Vídeo;

            switch (nota.TipoNota.Categoria)
            {
                case TipoNota.CategoriaMovimentacao.Servicos:
                    var impressaoNotaServico = new NotaServicoMatricial(nota);
                    impressaoNotaServico.ImprimeNota(video);
                    break;
                case TipoNota.CategoriaMovimentacao.Produtos:
                    bool verificarFaixa = false;
                    if (MessageBox.Show("Deseja imprimir texto para crédito de ICMS?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        verificarFaixa = true;

                    var impressaoNotaProduto = new NotaProdutoMatricial(nota, verificarFaixa);
                    impressaoNotaProduto.ImprimeNota(video);
                    break;
                case TipoNota.CategoriaMovimentacao.ProdutosEServicos:
                    MessageBox.Show("Impressão de nota com serviços e produtos não disponível.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void btCupomFiscal_Click(object sender, EventArgs e)
        {
            var registroSelecionado = GetRegistroSelecionado();
            if (registroSelecionado != null)
            {
                var nota = NotaController.Instancia.LoadObjectById(registroSelecionado.ID);
                if (nota.ModeloDocto != 33)
                {
                    MessageBox.Show("O registro selecionado não é um cupom fiscal.", "Operação não Permitida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (!nota.BImpressa)
                    {
                        if (MessageBox.Show("Deseja imprimir o cupom fiscal?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {

                                List<pxyFormaPagamentoBaixaDoc> objForma = new List<pxyFormaPagamentoBaixaDoc>();
                                foreach (var item in nota.Documentos)
                                {
                                    var documento = DocumentoController.Instancia.LoadObjectById(item.ID);
                                    var movimentos = documento.Movimentos;
                                    foreach (var movimento in movimentos)
                                    {
                                        if (movimento.MovCaixa != null)
                                            objForma.Add(new pxyFormaPagamentoBaixaDoc
                                            {
                                                FormaPagamento = movimento.MovCaixa.FormaPagamento,
                                                Valor = movimento.MovCaixa.Valor
                                            });
                                    }
                                }

                                CupomFiscal cupomFiscal = new CupomFiscal(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE"));

                                bool podeImprimir = true;


                                foreach (NotaItem item in nota.NotaItems)
                                {
                                    var ncm =
                                            NCMController.Instancia.GetAll().Where(s => s.Ncm == item.Produto.NCM).FirstOrDefault();

                                    if (String.IsNullOrEmpty(item.AliqCupom))
                                    {
                                        if (ncm != null)
                                        {
                                            if (String.IsNullOrEmpty(ncm.AliqCupom))
                                            {
                                                throw new Exception("O Produto " + item.Produto.Nome
                                                    + " não possui Configuração tributação de não contribuinte");
                                                podeImprimir = false;
                                            }
                                            else
                                            {
                                                item.AliqCupom = ncm.AliqCupom;
                                            }
                                        }
                                        else
                                        {
                                            throw new Exception("O Produto " + item.Produto.Nome
                                                   + " não possui Configuração de tributação de contribuinte");
                                            podeImprimir = false;
                                        }
                                    }
                                }
                                if (podeImprimir)
                                {
                                    cupomFiscal.Imprime(nota, objForma);
                                }




                                gcPrincipal.RefreshDataSource();
                            }
                            catch (Exception ex)
                            {
                                System.Windows.Forms.MessageBox.Show(ex.Message, "Aviso", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
                                return;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cupom Fiscal já foi impresso.\nVerifique.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado.");
            }
        }

        private void btDuplicata_Click(object sender, EventArgs e)
        {
            var registroSelecionado = GetRegistroSelecionado();

            try
            {
                if (registroSelecionado != null)
                {
                    Relatorios.Duplicata duplicata = new Relatorios.Duplicata(ConfiguracaoController.Instancia.GetConfiguracao().ModeloDuplicata);
                    if (!duplicata.DeNota(registroSelecionado.ID))
                        MessageBox.Show("Esta nota não possui documentos de financeiro.", "Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Nenhum registro selecionado.");
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("LogoEmpresa"))
                    MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    Aplicacao.Base.FormErro.ShowDialog(ex);
            }

        }

        private void btBoleto_Click(object sender, EventArgs e)
        {
            var conf = ConfiguracaoController.Instancia.GetConfiguracao();


            var registroSelecionado = GetRegistroSelecionado();
            Nota nota = NotaController.Instancia.LoadObjectById(registroSelecionado.ID);

            foreach (var documento in nota.Documentos)
            {
                if (documento.Situacao == "BxR")
                {
                    MessageBox.Show("Não é possivel gerar boleto de Documentos de renegociação", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }

            if (nota != null)
            {
                if (MessageBox.Show("Deseja emitir os boletos da nota selecionada?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (conf.IDRemessaPadrao != null)
                    {
                        FormImprimeBoletosRemessa form = new FormImprimeBoletosRemessa(nota);
                        form.SetandoLogicaParaRemessaPadrao();
                    }
                    else
                    {
                        FormImprimeBoletosRemessa form = new FormImprimeBoletosRemessa(nota);
                        form.ShowDialog();
                    }
                }
            }
        }

        private void btCancelarNF_Click(object sender, EventArgs e)
        {
            var registroSelecionado = GetRegistroSelecionado();
            if (registroSelecionado != null)
            {
                var nota = NotaController.Instancia.LoadObjectById(registroSelecionado.ID);
                if (nota.ModeloDocto == 55 || nota.ModeloDocto == 2)
                {
                    MessageBox.Show("Para cancelar NFe ou NFSe, clique nos botões NFe ou NFSe e depois cancelar.", "Operação não Permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (nota.ModeloDocto == 33)
                {
                    MessageBox.Show("Para cancelar um cupom fiscal utilize a opção 'Cancelar Último Cupom' no menu Comercial.", "Operação não Permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (MessageBox.Show("Deseja cancelar a Nota selecionada?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var input = new InputBox();
                    string motivo;
                    if (input.Show(String.Empty, "Motivo Cancelamento", out motivo))
                    {
                        try
                        {
                            NotaController.Instancia.CancelarNF(nota, motivo);
                            lista.Remove(registroSelecionado);
                            gcPrincipal.RefreshDataSource();
                            gvPrincipal.MoveLastVisible();
                        }
                        catch (Exception ex)
                        {
                            new FormErro(ex).ShowDialog();
                        }
                    }
                }
            }
        }

        protected override void GridGenerica_Shown(object sender, EventArgs e)
        {
            base.GridGenerica_Shown(sender, e);
            FormatarColunaStatus();
        }

        private void FormatarColunaStatus()
        {
            StyleFormatCondition estilo = new StyleFormatCondition();
            estilo.Appearance.ForeColor = Color.Green;
            estilo.Appearance.Options.UseForeColor = true;
            estilo.ApplyToRow = false;
            estilo.Column = gvPrincipal.Columns["StatusLegivel"];
            estilo.Condition = FormatConditionEnum.Equal;
            estilo.Value1 = "Autorizada";

            StyleFormatCondition estilo2 = new StyleFormatCondition();
            estilo2.Appearance.ForeColor = Color.Red;
            estilo2.Appearance.Options.UseForeColor = true;
            estilo2.ApplyToRow = false;
            estilo2.Column = gvPrincipal.Columns["StatusLegivel"];
            estilo2.Condition = FormatConditionEnum.Equal;
            estilo2.Value1 = "Negada";

            StyleFormatCondition estilo3 = new StyleFormatCondition();
            estilo3.Appearance.ForeColor = Color.Blue;
            estilo3.Appearance.Options.UseForeColor = true;
            estilo3.ApplyToRow = false;
            estilo3.Column = gvPrincipal.Columns["StatusLegivel"];
            estilo3.Condition = FormatConditionEnum.Equal;
            estilo3.Value1 = "Não enviada";
            estilo3.Value2 = "Aguardando";

            StyleFormatCondition estilo4 = new StyleFormatCondition();
            estilo4.Appearance.ForeColor = Color.Brown;
            estilo4.Appearance.Options.UseForeColor = true;
            estilo4.ApplyToRow = false;
            estilo4.Column = gvPrincipal.Columns["StatusLegivel"];
            estilo4.Condition = FormatConditionEnum.Equal;
            estilo4.Value1 = "Cancelada";

            StyleFormatCondition estilo5 = new StyleFormatCondition();
            estilo5.Appearance.ForeColor = Color.Orange;
            estilo5.Appearance.Options.UseForeColor = true;
            estilo5.ApplyToRow = false;
            estilo5.Column = gvPrincipal.Columns["StatusLegivel"];
            estilo5.Condition = FormatConditionEnum.Equal;
            estilo5.Value1 = "Contingência";

            gvPrincipal.FormatConditions.Add(estilo);
            gvPrincipal.FormatConditions.Add(estilo2);
            gvPrincipal.FormatConditions.Add(estilo3);
            gvPrincipal.FormatConditions.Add(estilo4);
            gvPrincipal.FormatConditions.Add(estilo5);

            gvPrincipal.Columns["TipoNota"].FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
        }

        private void sbCusto_Click(object sender, EventArgs e)
        {
            var registroSelecionado = GetRegistroSelecionado();
            if (registroSelecionado != null)
            {
                GridGenerica<Custo> GridCusto = new GridGenerica<Custo>(CustoController.Instancia.GetAllByIDNota(registroSelecionado.ID), new FormCusto(registroSelecionado), false);
                if (cwkControleUsuario.Facade.ControleAcesso(GridCusto))
                    GridCusto.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhuma Nota Selecionada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btDescancelar_Click(object sender, EventArgs e)
        {
            var registroSelecionado = GetRegistroSelecionado();
            if (registroSelecionado != null)
            {
                var nota = NotaController.Instancia.LoadObjectById(registroSelecionado.ID);

                if (nota.ModeloDocto == 55)
                {
                    MessageBox.Show("Nota Fiscal Eletrônica não pode ser descancelada.", "Operação não Permitida", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if (nota.CancDt == null || nota.CancDt == new DateTime())
                {
                    MessageBox.Show("Esta Nota Fiscal não está cancelada. Verifique!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (MessageBox.Show("Deseja Descancelar a Nota selecionada?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NotaController.Instancia.DescancelarNF(nota);
                    lista.Remove(registroSelecionado);
                    gcPrincipal.RefreshDataSource();
                    gvPrincipal.MoveLastVisible();
                }
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            switch (e.KeyCode)
            {
                case Keys.F5:
                    RecarregarGrid();
                    break;
            }
        }

        private void RecarregarGrid()
        {
            lista = NotaController.Instancia.GetAll(inOut, produtoServico, notasCanceladas);
            AtualizarGrid();
            gvPrincipal.MoveLastVisible();
        }

        private void btNotaComplementar_Click(object sender, EventArgs e)
        {
            var registroSelecionado = GetRegistroSelecionado();
            if (registroSelecionado != null)
            {
                var nota = NotaController.Instancia.LoadObjectById(registroSelecionado.ID);
                if (nota.TipoNota.ModeloDocto == TipoNota.ModeloDocumento.NFe)
                {
                    if (nota.Status == "2") //Autorizada
                    {
                        var notaComplementar = NotaController.Instancia.GetNotaComplementar(nota);
                        var form = new FormNotaComplementar();
                        form.Selecionado = notaComplementar;
                        form.Operacao = notaComplementar.ID > 0 ? Acao.Alterar : Acao.Incluir;
                        form.ShowDialog();

                        if (form.Selecionado != null)
                        {
                            if (MessageBox.Show("Deseja efetuar o envio da nota complementar?", "Nota Complementar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                == DialogResult.Yes)
                            {
                                try
                                {
                                    FormNFe frmNFe = new FormNFe();
                                    frmNFe.IDNota = form.Selecionado.ID;
                                    frmNFe.ShowDialog();
                                    frmNFe.Dispose();
                                }
                                catch (Exception ex)
                                {
                                    new FormErro(ex).ShowDialog();
                                }
                            }
                        }
                    }
                    else
                        MessageBox.Show("Só é possível complementar notas Autorizadas.");
                }
                else
                    MessageBox.Show("Só é possível complementar notas do tipo NFe.");
            }
            else
                MessageBox.Show("Nenhum registro selecionado.");
        }

        protected override void Incluir()
        {
            base.Incluir();
            RefreshGrid();
        }

        private void ImprimeEtiquetas(Nota nota)
        {
            logicaTelaNota = new LogicaTelaNotaFiscal(nota);
            logicaTelaNota.Identificador = nota.identificador;

            var impressaoGs1 = new ImpressaoGs1DataBar(nota, logicaTelaNota);

            var listaImpressao = impressaoGs1.GerarImpressaoEtiqueta().ToList<ImpressaoEtiquetaProdutoView>();

            FormImprimeEtiquetasProdutos form = new FormImprimeEtiquetasProdutos(listaImpressao);
            form.ShowDialog();
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            var registroSelecionado = GetRegistroSelecionado();
            if (registroSelecionado != null)
            {
                var nota = NotaController.Instancia.LoadObjectById(registroSelecionado.ID);
                var _identificador = IdentificadorController.Instancia.LoadObjectById(nota.identificador.ID);
                var localestoque = LocalEstoqueController.Instancia.LoadObjectById(nota.LocalEstoqueNota.ID);
                nota.identificador = _identificador;
                nota.LocalEstoqueNota = localestoque;

                if (nota.Ent_Sai == InOutType.Entrada)
                {
                    ImprimeEtiquetas(nota);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma nota para realizar a impressão", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btNFSe_Click(object sender, EventArgs e)
        {
            var registroSelecionado = GetRegistroSelecionado();

            if (registroSelecionado != null)
            {
                Nota NFSe = NotaController.Instancia.LoadObjectById(registroSelecionado.ID);

                if (NFSe.ModeloDocto != 2 && NFSe.ModeloDocto != 3)
                {
                    MessageBox.Show("O registro selecionado não é um RPS ou NFSe!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //chamar form de envio de NFSe.

                    FormNFSe _form = new FormNFSe(NFSe);
                    _form.ShowDialog();
                    _form.Dispose();
                    RecarregarGrid();
                }
            }
        }

        private void sbSubstituida_Click(object sender, EventArgs e)
        {
            var registroSelecionado = GetRegistroSelecionado();

            if (registroSelecionado.Status != "2")
            {
                MessageBox.Show("Somente notas autorizadas pode-se realizar a substituição !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (registroSelecionado.ModeloDocto != 3)
            {
                MessageBox.Show("Somente NFSe pode-se realizar a substituição !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Nota nota = NotaController.Instancia.LoadObjectById(registroSelecionado.ID);
                FormNota form = new FormNota(InOutType.Saída);
                form.Operacao = Acao.Incluir;
                form.Selecionado = new Nota();
                form.ShowDialog();
            }
        }

    }
}
