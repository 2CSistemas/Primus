using Aplicacao.Base;
using Aplicacao.Modulos.Cadastro;
using Aplicacao.Modulos.Comercial.Impressao;
using Aplicacao.Modulos.OrcamentoServico;
using Aplicacao.OrcamentoServico.ValueObjects;
using Aplicacao.Util;

using cwkGestao.Modelo;
using cwkGestao.Modelo.Util;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Padroes;

using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormOSOrdemServico : IntermediariasTela.FormOSOrdemServicoIntermediaria
    {
        Configuracao config;

        public IList<OSAcompanhamentoEditavel> Acompanhamentos { get; set; }


        private static class Colunas
        {
            public enum Produto
            {
                Seq = 0, Codigo = 1, Descricao = 2, Qtd = 3, Unidade = 4, Preco = 5, Desconto = 6, Total = 7
            }

            public enum Servico
            {
                Seq = 0, Codigo = 1, Descricao = 2, Qtd = 3, /*Tipo = 4, */Responsavel = 4, /*ValorT = 6, */Valor = 5, Desconto = 6, Total = 7
            }

            public enum Acompanhamento
            {
                Data = 0, Hora = 1, Ocorrencia = 2, Usuario = 3
            }
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();

            lkbEquipamento.SubFormType = typeof(FormOSEquipamento);
            lkbCondicao.SubFormType = typeof(FormCondicao);
            lkbTabelaPreco.SubFormType = typeof(FormTabelaPreco);
            lkbStatus.SubFormType = typeof(FormStatusOS);

            lkpVendedor.Exemplo = new Pessoa { BVendedor = true };
            lkpVendedor.CamposRestricoesAND = new List<string> { "BVendedor" };
            lkpCliente.Exemplo = new Pessoa { BCliente = true };
            lkpCliente.CamposRestricoesAND = new List<string> { "BCliente" };
            lkpTecnico.Exemplo = new Pessoa { BFuncionario = true };
            lkpTecnico.CamposRestricoesAND = new List<string> { "BFuncionario" };

            tpAcompanhamento.Tag = Selecionado;

            tpProduto.Tag = this;
            tpServico.Tag = this;

            Acompanhamentos = TransformaAcompanhamentos(Selecionado);
            tpAcompanhamento.Tag = this;

            tpImei.Tag = this;
        }


        private void MontarColunasGrids()
        {
            MontarColunasProduto();
            MontarColunasServico();
            MontarColunasAcompanhamento();
        }

        private void MontarColunasAcompanhamento()
        {
            ColunaSomenteLeitura(gvAcompanhamentos.Columns[(int)Colunas.Acompanhamento.Usuario], true);
            ColunaData(gvAcompanhamentos.Columns[(int)Colunas.Acompanhamento.Data]);
            ColunaHora(gvAcompanhamentos.Columns[(int)Colunas.Acompanhamento.Hora]);
        }

        private void ColunaData(GridColumn gridColumn)
        {
            RepositoryItemDateEdit dateEdit = new RepositoryItemDateEdit();
            dateEdit.AllowNullInput = DefaultBoolean.False;
            dateEdit.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            dateEdit.Mask.UseMaskAsDisplayFormat = true;
            dateEdit.Mask.EditMask = "d";
            dateEdit.Mask.UseMaskAsDisplayFormat = true;

            gridColumn.ColumnEdit = dateEdit;
        }

        private void ColunaHora(GridColumn gridColumn)
        {
            RepositoryItemTextEdit textEdit = new RepositoryItemTextEdit();
            textEdit.Mask.MaskType = MaskType.RegEx;
            textEdit.Mask.UseMaskAsDisplayFormat = true;
            textEdit.Mask.EditMask = "(([0-1]?[0-9])|([2][0-3])):([0-5]?[0-9])";
            textEdit.Mask.SaveLiteral = true;

            gridColumn.ColumnEdit = textEdit;
        }

        private void MontarColunasServico()
        {
            ColunaInteira(gvServicoItems.Columns[(int)Colunas.Servico.Codigo]);
            ColunaSomenteLeitura(gvServicoItems.Columns[(int)Colunas.Servico.Seq], true);
            ColunaMonetaria(gvServicoItems.Columns[(int)Colunas.Servico.Valor]);
            Coluna4Decimais(gvServicoItems.Columns[(int)Colunas.Servico.Desconto]);
            ColunaMonetaria(gvServicoItems.Columns[(int)Colunas.Servico.Total]);
        }

        private void MontarColunasProduto()
        {
            ColunaInteira(gvProdutoItems.Columns[(int)Colunas.Produto.Codigo]);
            ColunaSomenteLeitura(gvProdutoItems.Columns[(int)Colunas.Produto.Seq], true);
            ColunaSomenteLeitura(gvProdutoItems.Columns[(int)Colunas.Produto.Unidade], true);
            ColunaSomenteLeitura(gvProdutoItems.Columns[(int)Colunas.Produto.Total], true);
            ColunaMonetaria(gvProdutoItems.Columns[(int)Colunas.Produto.Preco]);
            Coluna4Decimais(gvProdutoItems.Columns[(int)Colunas.Produto.Qtd], true);
            Coluna4Decimais(gvProdutoItems.Columns[(int)Colunas.Produto.Desconto], true);
        }

        private void Coluna4Decimais(GridColumn gridColumn, bool VemDoProduto = false)
        {
            RepositoryItemTextEdit textEdit = new RepositoryItemTextEdit();

            textEdit.EditFormat.FormatType = FormatType.Numeric;
            textEdit.EditFormat.FormatString = "n4";
            textEdit.DisplayFormat.FormatType = FormatType.Numeric;
            textEdit.DisplayFormat.FormatString = "n4";
            textEdit.Appearance.TextOptions.HAlignment = HorzAlignment.Far;

            textEdit.Mask.MaskType = MaskType.Numeric;
            textEdit.Mask.EditMask = "n4";

            gridColumn.ColumnEdit = textEdit;

            if (VemDoProduto)
                gridColumn.OptionsColumn.AllowEdit = false;
        }

        private void ColunaInteira(GridColumn gridColumn)
        {
            RepositoryItemTextEdit textEdit = new RepositoryItemTextEdit();

            textEdit.EditFormat.FormatType = FormatType.Numeric;
            textEdit.EditFormat.FormatString = "n0";
            textEdit.DisplayFormat.FormatType = FormatType.Numeric;
            textEdit.DisplayFormat.FormatString = "n0";
            textEdit.Appearance.TextOptions.HAlignment = HorzAlignment.Far;

            textEdit.Mask.MaskType = MaskType.Numeric;
            textEdit.Mask.EditMask = "n0";

            gridColumn.ColumnEdit = textEdit;

            gridColumn.OptionsColumn.AllowEdit = false;
        }

        private void ColunaMonetaria(GridColumn gridColumn)
        {
            RepositoryItemTextEdit textEdit = new RepositoryItemTextEdit();

            textEdit.EditFormat.FormatType = FormatType.Numeric;
            textEdit.EditFormat.FormatString = "c2";
            textEdit.DisplayFormat.FormatType = FormatType.Numeric;
            textEdit.DisplayFormat.FormatString = "c2";
            textEdit.Appearance.TextOptions.HAlignment = HorzAlignment.Far;

            textEdit.Mask.MaskType = MaskType.Numeric;
            textEdit.Mask.EditMask = "c2";

            gridColumn.ColumnEdit = textEdit;

            gridColumn.OptionsColumn.AllowEdit = false;
        }

        private void ColunaProprioTerceiro(GridColumn coluna)
        {
            RepositoryItemComboBox comboBox = new RepositoryItemComboBox();

            comboBox.TextEditStyle = TextEditStyles.DisableTextEditor;

            comboBox.Items.Add("0");
            comboBox.Items.Add("1");

            coluna.ColumnEdit = comboBox;
        }

        private void ColunaSomenteLeitura(GridColumn coluna, bool somenteLeitura)
        {
            coluna.OptionsColumn.AllowEdit = !somenteLeitura;
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            tpAcompanhamento.Tag = Selecionado;

            gcServicoItems.DataSource = TransformaServicoItems(Selecionado);
            gcServicoItems.RefreshDataSource();

            MontarColunasGrids();

            gcAcompanhamentos.DataSource = null;
            gcProdutoItems.DataSource = null;

            gvAcompanhamentos.FocusedRowHandle = -1;
            gvServicoItems.FocusedRowHandle = -1;
            gvProdutoItems.FocusedRowHandle = -1;

            this.Acompanhamentos = TransformaAcompanhamentos(Selecionado);
            OSProdutoItemEditavel.AtualizaTotais = new Action(AtualizaTotais);
            OSServicoItemEditavel.AtualizaTotais = new Action(AtualizaTotais);
            LinhaAcompanhamentoSomenteLeitura();
            tpProduto.Tag = this;
            tpServico.Tag = this;
            tpAcompanhamento.Tag = this;
            tpResultado.Tag = Selecionado;
            tpImei.Tag = Selecionado;

            tcOS.SelectedTabPageIndex = 0;

            if (this.Operacao == Acao.Incluir)
            {
                IList<StatusOS> status = StatusOSController.Instancia.GetAll();
                if (status.Where(w => w.BPadrao).Count() > 0)
                {
                    Selecionado.Status = status.Where(w => w.BPadrao).FirstOrDefault();
                }
            }
        }

        private IList<OSServicoItemEditavel> TransformaServicoItems(OSOrdemServico selecionado)
        {
            IList<OSServicoItemEditavel> retorno = new List<OSServicoItemEditavel>();
            foreach (OSServicoItem item in selecionado.OSServicoItems)
            {
                retorno.Add(new OSServicoItemEditavel(item));
            }
            return retorno;
        }

        private IList<OSAcompanhamentoEditavel> TransformaAcompanhamentos(OSOrdemServico selecionado)
        {
            IList<OSAcompanhamentoEditavel> retorno = new List<OSAcompanhamentoEditavel>();
            foreach (OSAcompanhamento osAcompanhamento in selecionado.OSAcompanhamentos)
            {
                retorno.Add(new OSAcompanhamentoEditavel(osAcompanhamento));
            }
            return retorno;
        }

        protected override void TelaProObjeto(Control pai)
        {
            base.TelaProObjeto(pai);
            Selecionado.UsuarioLogado = cwkControleUsuario.Facade.getUsuarioLogado.Login;
            try
            {
                Selecionado.Data = new DateTime(Selecionado.Data.Year, Selecionado.Data.Month, Selecionado.Data.Day);
                Selecionado.Data = Selecionado.Data.AddHours(Convert.ToInt32(txtHora.Text.Split(':')[0]));
                Selecionado.Data = Selecionado.Data.AddMinutes(Convert.ToInt32(txtHora.Text.Split(':')[1]));
            }
            catch { }
        }

        protected override List<Exception> ObjetoPraTela(Control pai)
        {
            List<Exception> erros = base.ObjetoPraTela(pai);
            try
            {
                rgOrigem.SelectedIndex = Convert.ToInt32(Selecionado.Origem);
                txtHora.EditValue = Selecionado.Data.ToShortTimeString();
                txtHoraInicio.EditValue = Selecionado.HoraInicio.ToShortTimeString();
                txtHoraInicio2.EditValue = Selecionado.HoraInicio2.ToShortTimeString();
                txtHoraFim.EditValue = Selecionado.HoraFim.ToShortTimeString();
                txtHoraFim2.EditValue = Selecionado.HoraFim2.ToShortTimeString();
                //cbStatus.SelectedIndex = (int)Selecionado.Status.Valor;
            }
            catch (Exception exc)
            {
                erros.Add(exc);
            }
            if (Selecionado.ID == 0)
            {
                rgOrigem.SelectedIndex = 0;
                txtData.EditValue = DateTime.Today;
                txtHora.EditValue = DateTime.Now.ToShortTimeString();
            }

            return erros;
        }

        protected override bool ValidarFormulario()
        {
            base.ValidarFormulario();
            dxErroProvider.SetError(txtProblemaRelatado, txtProblemaRelatado.Text.Length == 0 ? "Campo obrigatório" : "");

            //if (config.UtilizaControleIMEI && String.IsNullOrEmpty(txtNumSerie.Text))
            //{
            //    dxErroProvider.SetError(txtNumSerie, "Campo obrigatório");
            //    tcOS.SelectedTabPage = tpImei;
            //}

            return (!dxErroProvider.HasErrors) && ValidaServicos();
        }

        protected override void OK()
        {
            try
            {
                if (ValidarFormulario())
                {
                    TelaProObjeto(tcPrincipal);

                    Selecionado.Observacao = txtObservacao.Text;

                    bool statusalterou = false;
                    bool deveenviaremail = false;
                    if (Operacao < Acao.Consultar)
                    {
                        Configuracao conf = ConfiguracaoController.Instancia.GetAll().FirstOrDefault();
                        cwkGestao.Modelo.StatusOS StatusOSantiga = new StatusOS();
                        if (Selecionado.ID > 0)
                        {
                            StatusOSantiga = OSOrdemServicoController.Instancia.LoadObjectById(Selecionado.ID).Status;
                            if (StatusOSantiga != Selecionado.Status)
                            {
                                statusalterou = true;
                            }
                        }
                        bool enviouemail = false;
                        if (Selecionado.Status.BFechado && Selecionado.Status.BPermissaoGerente)
                        {
                            Modelo.Cw_Usuario usuarioLogado = Modelo.cwkGlobal.objUsuarioLogado;

                            if ((cwkControleUsuario.Facade.getUsuarioLogado.Tipo == 2 || cwkControleUsuario.Facade.LoginGerente()))
                            {
                                if (Selecionado.Status.EmailAutomatico == true)
                                {
                                    deveenviaremail = true;
                                }
                                controller.Salvar(Selecionado, Operacao);
                                PerguntarPorAgendamento();
                                PerguntarPorImpressao(Selecionado);
                                if (conf.EnviarEmailAutomaticoOS && statusalterou && deveenviaremail || conf.EnviarEmailAutomaticoOS && deveenviaremail && Operacao == Acao.Incluir)
                                {
                                    enviouemail = PerguntarPorEmail(Selecionado, StatusOSantiga);
                                    if (enviouemail == true)
                                    {
                                        Selecionado.UltimoEnvioEmail = DateTime.Now;
                                        controller.Salvar(Selecionado, Operacao);
                                    }
                                    else
                                    {
                                        MessageBox.Show("E-mail não enviado! Verifique suas configurações de envio de e-mail no cadastro de usuário \r\n");
                                    }
                                }
                                Modelo.cwkGlobal.objUsuarioLogado = usuarioLogado;
                            }
                        }
                        else
                        {
                            if (Selecionado.Status.EmailAutomatico == true)
                            {
                                deveenviaremail = true;
                            }
                            controller.Salvar(Selecionado, Operacao);
                            PerguntarPorAgendamento();
                            PerguntarPorImpressao(Selecionado);
                            if (conf.EnviarEmailAutomaticoOS && statusalterou && deveenviaremail || conf.EnviarEmailAutomaticoOS && deveenviaremail && Operacao == Acao.Incluir)
                            {
                                enviouemail = PerguntarPorEmail(Selecionado, StatusOSantiga);
                            }
                            if (enviouemail == true)
                            {
                                MessageBox.Show("E-mail enviado com sucesso!");
                                Selecionado.UltimoEnvioEmail = DateTime.Now;
                                if (Operacao == Acao.Incluir)
                                {
                                    Operacao = Acao.Alterar;
                                }
                                controller.Salvar(Selecionado, Operacao);
                            }
                            else
                            {
                                MessageBox.Show("E-mail não enviado! Verifique suas configurações de envio de e-mail no cadastro de usuário \r\n");
                            }
                        }
                    }
                    SalvarMaquinas();
                    this.Close();
                }
            }
            catch (Exception e)
            {
                new FormErro(e).ShowDialog();
            }

        }

        private bool ValidaServicos()
        {
            gvServicoItems.ClearColumnErrors();
            IList<OSServicoItemEditavel> servicos = (List<OSServicoItemEditavel>)gvServicoItems.DataSource;
            for (int i = 0; i < servicos.Count; i++)
            {
                gvServicoItems_ValidateRow(gvServicoItems, new DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs(i, gvServicoItems.GetRow(i)));
                if (gvServicoItems.HasColumnErrors)
                {
                    break;
                }
            }
            if (gvServicoItems.HasColumnErrors)
            {
                tcOS.SelectedTabPage = tpServico;
            }
            return !gvServicoItems.HasColumnErrors;
        }

        private void PerguntarPorAgendamento()
        {
            if (this.Operacao == Acao.Incluir && Selecionado.Origem == OSOrdemServico.OrigemOS.Externa)
            {
                var x = MessageBox.Show(this, "Deseja agendar a Ordem de Serviço criada?", "Agendar", MessageBoxButtons.YesNo);
                if (x == DialogResult.Yes)
                {
                    new FormOSAgendamento() { OSOrdemServico = Selecionado, Tecnico = Selecionado.Tecnico }.ShowDialog();

                    //if (OSOrdemServicoController.Instancia.EstahAgendado(Selecionado))
                    //    Selecionado.Status = StatusOSController.Instancia.GetByValor((int)OSOrdemServico.StatusOS.AguardandoAnalise);
                    //else
                    //    Selecionado.Status = StatusOSController.Instancia.GetByValor((int)OSOrdemServico.StatusOS.AguardandoAgendamento);

                    controller.Salvar(Selecionado, Acao.Alterar);
                }
            }
        }

        private void PerguntarPorImpressao(OSOrdemServico OS)
        {
            if (this.Operacao == Acao.Incluir)
            {
                var x = new CwkMessageBox<OSOrdemServico.ImprimirOS>("Imprimir", "Deseja imprimir a Ordem de Serviço criada?").ShowDialog();
                switch (x)
                {
                    case OSOrdemServico.ImprimirOS.Laser:
                        var selecionado = OS;
                        string Err = String.Empty;
                        if (selecionado != null)
                        {
                            Err = ImpressaoOSOrdemServico.ImprimeOS(selecionado.ID);
                        }
                        else
                        {
                            Err = ImpressaoOSOrdemServico.ImprimeOS(null);
                        }

                        if (Err != String.Empty)
                            MessageBox.Show(Err);
                        break;
                    case OSOrdemServico.ImprimirOS.Fechar:
                        break;

                }
            }
        }

        private bool PerguntarPorEmail(OSOrdemServico OS, StatusOS StatusOS)
        {
            {
                bool EnviouEmail = false;
                var x = MessageBox.Show(this, "Deseja enviar mudança de status da Ordem de Serviço por e-mail?", "E-mail", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (x == DialogResult.Yes)
                {
                    EnviarEmail(OS, StatusOS, ref EnviouEmail);
                }
                return EnviouEmail;

            }
        }

        private bool EnviarEmail(OSOrdemServico OS, StatusOS StatusOS, ref bool EnviouEmail)
        {
            try
            {
                var config = ConfiguracaoController.Instancia.GetConfiguracao();
                var usuario = Cw_usuarioController.Instancia.LoadObjectById(cwkControleUsuario.Facade.getUsuarioLogado.Id);

                if (!string.IsNullOrEmpty(usuario.Email))
                {
                    StringBuilder propVazias = new StringBuilder();
                    if (String.IsNullOrEmpty(usuario.SenhaEmail))
                        propVazias.Append("SenhaEmail não informado, ");
                    if (String.IsNullOrEmpty(usuario.Smtp))
                        propVazias.Append("Servidor SMTP não informado, ");
                    if (String.IsNullOrEmpty(usuario.Porta))
                        propVazias.Append("Porta do Email não informado, ");

                    if (propVazias.ToString() != "")
                    {
                        propVazias.Append("Verifique as informações de email no cadastro do usuário.");
                        EnviouEmail = false;
                        throw new Exception(propVazias.ToString());
                    }
                    else
                    {
                        try
                        {
                            IList<PessoaEmail> listaemails = OS.Cliente.PessoaEmails.Where(x => x.BMsn == true).ToList();
                            IList<string> listaemailstring = new List<string>();
                            foreach (var item in listaemails)
                            {
                                listaemailstring.Add(item.Email);
                            }
                            EnviarEmailOS(config, usuario.Smtp, usuario.Email, usuario.SenhaEmail, usuario.Porta, usuario.SSL, "", listaemailstring, OS.Status, OS);
                            EnviouEmail = true;
                            return EnviouEmail;
                        }
                        catch (Exception ex)
                        {
                            EnviouEmail = false;
                            throw new Exception("Verifique suas configurações de envio no cadastro de usuário \r\n" + ex.Message);
                        }

                    }
                }
                return EnviouEmail;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao enviar email.\r\n" + ex);
            }
        }
        #region métodos para substituir os atributos do corpo do email
        private string substituiAtributos(IList<ModeloBase> modelos, IList<string> atributos, string texto)
        {
            foreach (var att in atributos)
            {
                if (!string.IsNullOrEmpty(texto))
                {
                    int pos = texto.IndexOf(att, 0);
                    // verifica se o atributo esta presente no corpo do e-mail.
                    if (pos >= 0)
                    {
                        texto = substituiAtributosModelos(modelos, att, texto);
                        texto = substituiAtributosSistema(att, texto);
                    }
                }
            }
            return texto;
        }

        private static string substituiAtributosModelos(IList<ModeloBase> modelos, string att, string texto)
        {
            // verifica se existe ponto e onde esta (se existir ponto significa que é para buscar o valor de algum modelo)
            int ponto = att.IndexOf(".");
            if (ponto >= 0)
            {
                string valor = "";
                string modelo = att.ToString().Substring(1, ponto - 1);
                string atributo = att.Remove(0, ponto + 1).Replace("]", "");
                if (modelo == "Orçamento de Serviço")
                {
                    OSOrdemServico OS = (OSOrdemServico)modelos.Where(x => x.ToString() == "cwkGestao.Modelo.OSOrdemServico").FirstOrDefault();
                    valor = OSOrdemServicoController.Instancia.GetValorAtributo(OS, atributo);
                }
                return texto.Replace(att.ToString(), valor);
            }
            return texto;
        }

        private static string substituiAtributosSistema(string att, string texto)
        {

            // Atributos do sistema não podem ter ponto, pois o ponto serve para indicar modelo.atributo
            if (att.IndexOf(".") == -1)
            {
                string valor = "";
                switch (att)
                {
                    case "[Data Atual]":
                        valor = DateTime.Now.ToShortDateString();
                        break;
                    case "[Hora Atual]":
                        valor = DateTime.Now.ToShortTimeString();
                        break;
                    case "[Nome Usuário]":
                        valor = cwkControleUsuario.Facade.getUsuarioLogado.Nome;
                        break;
                        /*case "[ResultadoCliente]":
                            valor = osOrdemServico.ResultadoCliente;
                            break;*/
                }
                return texto.Replace(att.ToString(), valor);
            }
            return texto;
        }
        #endregion

        private List<string> preencheAtributos(List<string> lbAtributos)
        {
            // Estrutura dos atributos: 
            // O que estiver dentro dos Colchetes significa que é um atributo[]
            // O que estiver antes do ponto significa o modelo e depois do ponto atributo. Ex: [Modelo.Atributo] => [Nota.Código]
            // Os atributos são criados de acordo com as annotations da classe
            // Os atributos do sistema(que não serão buscados de objetos, ex: DateTime.Now) devem ser declarados sem o "modelo" ex: [Atributo] => "[Data Atual]"
            // Esse atributos são substituidos com seus valores reais no método: substituiAtributos()
            IList<string> lista = OSOrdemServicoController.Instancia.GetAllCampos();
            lbAtributos.Add("[Data Atual]");
            lbAtributos.Add("[Hora Atual]");
            lbAtributos.Add("[Nome Usuário]");
            foreach (var item in lista.OrderBy(x => x))
            {
                lbAtributos.Add("[" + item + "]");
            }
            return lbAtributos;
        }

        private void EnviarEmailOS(Configuracao config, string SMTP, string UsuarioEmail, string SenhaEmail, string PortaSMTP, bool SSL, string pNomeArquivo, IList<string> pEmailsCliente, StatusOS status, OSOrdemServico OS)
        {
            IList<ModeloBase> modelos = new List<ModeloBase>();
            modelos.Add(OS);
            modelos.Add(OS.Cliente);
            List<string> lbAtributos = new List<string>();
            lbAtributos = preencheAtributos(lbAtributos);
            IList<string> atributos = new List<string>();
            foreach (var att in lbAtributos)
            {
                atributos.Add(att.ToString());
            }

            status.EmailAutomaticoTexto = substituiAtributos(modelos, atributos, status.EmailAutomaticoTexto);
            status.EmailAutomaticoAssunto = substituiAtributos(modelos, atributos, status.EmailAutomaticoAssunto);
            SmtpClient cliente = new SmtpClient(SMTP, Convert.ToInt32(PortaSMTP) /* TLS */);
            MailMessage mensagem = new MailMessage();

            mensagem.From = new MailAddress(UsuarioEmail);
            foreach (var pEmail in pEmailsCliente)
            {
                mensagem.To.Add(new MailAddress(pEmail));
            }


            try
            {
                cliente.EnableSsl = SSL;
                cliente.Credentials = new NetworkCredential(UsuarioEmail, SenhaEmail);

                mensagem.Subject = status.EmailAutomaticoAssunto;

                mensagem.IsBodyHtml = true;

                if (config.SolicitaConfirmaEmailPedido)
                    mensagem.Headers.Add("Disposition-Notification-To", UsuarioEmail);

                if (string.IsNullOrEmpty(status.EmailAutomaticoTexto))
                    mensagem.Body = "";
                else
                {
                    if (StringUtil.VerificaSeEHtml(status.EmailAutomaticoTexto))
                        mensagem.Body = StringUtil.ConvertRtfToHtml(status.EmailAutomaticoTexto);
                    else
                        mensagem.Body = StringUtil.ConvertRtfToHtml(status.EmailAutomaticoTexto).Replace("<div align=\"center\">Trial version can convert up to 30000 symbols.<br><a href=\"http://www.sautinsoft.com/convert-rtf-to-html/order.php\">Get the full featured version!</a></div>", "");
                }

                cliente.Send(mensagem);


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                mensagem.Dispose();
            }
        }

        private void lkbCliente_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookupPessoa(lkpCliente, cwkGestao.Negocio.PessoaController.Instancia.GetAllClientes(), "Cliente", typeof(FormPessoa));
        }

        private void lkbEmpresa_Click(object sender, EventArgs e)
        {
            GridGenerica<Filial> grid = new GridGenerica<Filial>(FilialController.Instancia.GetAll(), new FormFilial(), (cwkGestao.Modelo.Filial)lkpEmpresa.Selecionado, false) { Selecionando = true };
            grid.ShowDialog();
            lkpEmpresa.EditValue = grid.Selecionado;
        }

        #region Produtos

        private void AdicionarItem()
        {
            if (VerificaInsercaoItens())
            {
                OSProdutoItem osProdutoItem = new OSProdutoItem
                {
                    OSOrdemServico = Selecionado,
                    Seq = GetSequencia(),
                    GuidIdentificacao = Guid.NewGuid().ToString()
                };

                var FormAdicionarProduto = new FormProdutoOS(osProdutoItem, Selecionado.TabelaPreco, Selecionado.Condicao);
                FormAdicionarProduto.ShowDialog(this);
                if (FormAdicionarProduto.Salvou)
                {
                    osProdutoItem = FormAdicionarProduto.ProdutoItem;
                    osProdutoItem.Descricao = osProdutoItem.Produto.Nome;
                }

                Selecionado.OSProdutoItems.Add(osProdutoItem);

                gcProdutoItems.DataSource = Selecionado.OSProdutoItems;
                gcProdutoItems.RefreshDataSource();
                gvProdutoItems.Focus();
            }
        }

        private int GetSequencia()
        {
            try { return Selecionado.OSProdutoItems.Max(i => i.Seq) + 1; } catch (InvalidOperationException) { return 1; }
        }

        private int GetSequenciaServico()
        {
            try { return Selecionado.OSServicoItems.Max(i => i.Seq) + 1; } catch (InvalidOperationException) { return 1; }
        }

        private bool RequisitaGerente()
        {
            var usuarioLogado = Modelo.cwkGlobal.objUsuarioLogado;
            if (cwkControleUsuario.Facade.getUsuarioLogado.Tipo == 2 || cwkControleUsuario.Facade.LoginGerente())
            {
                Modelo.cwkGlobal.objUsuarioLogado = usuarioLogado;
                return true;
            }

            return false;
        }

        #endregion

        private void lkpTabelaPreco_Leave(object sender, EventArgs e)
        {
            Selecionado.TabelaPreco = (TabelaPreco)lkpTabelaPreco.Selecionado;

        }

        private void SetaFocoCelula(GridView gridView, int linha, int coluna)
        {
            gridView.RefreshData();

            gridView.FocusedColumn = gridView.Columns[coluna];
            gridView.FocusedRowHandle = linha;
        }

        private bool EstahNaUltimaLinhaEUltimaColuna(GridView grid)
        {
            var colunaSelecionada = grid.FocusedColumn;
            if (colunaSelecionada != null)
                return colunaSelecionada.VisibleIndex == 7 && grid.GetSelectedRows()[0] == ((IList)grid.DataSource).Count - 1;
            return false;
        }

        private void gvProdutoItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (gvProdutoItems.IsFocusedView)
            {
                switch (e.KeyCode)
                {
                    case Keys.Tab when e.Modifiers != Keys.Shift && EstahNaUltimaLinhaEUltimaColuna(gvProdutoItems):
                        AdicionarItem();
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.Delete when e.Modifiers == Keys.Control:
                        RemoverItem();
                        break;
                    case Keys.F2:
                        AcidionarItemMais();
                        break;
                }
            }
        }

        private void AcidionarItemMais()
        {
            if (VerificaInsercaoItens())
                new GridProdutoGenMais(new List<Produto>(), false, typeof(FormProduto)).ShowDialog();
        }

        private bool VerificaInsercaoItens()
        {
            var temErro = false;
            if (Selecionado.TabelaPreco == null)
            {
                dxErroProvider.SetError(lkpTabelaPreco, "Selecione uma Tabela de Preço antes de inserir os produtos");
                temErro = true;
            }
            else
                dxErroProvider.SetError(lkpTabelaPreco, "");

            if (Selecionado.Condicao == null)
            {
                dxErroProvider.SetError(lkpCondicao, "Selecione uma Condição antes de inserir os produtos");
                temErro = true;
            }
            else
                dxErroProvider.SetError(lkpCondicao, "");

            return !temErro;
        }

        private void RemoverItem()
        {
            int linhaSelecionada = gvProdutoItems.FocusedRowHandle;
            if (linhaSelecionada >= 0)
            {
                Selecionado.OSProdutoItems.RemoveAt(linhaSelecionada);

                AtualizaSequenciaItens();
                gvProdutoItems.RefreshData();

                Selecionado.ReCalculaTotais();
                AtualizaTotais();
            }
        }

        private void AtualizaTotais()
        {
            txtProdutoSubTotal.EditValue = Selecionado.ProdutoSubTotal;
            txtProdutoTotal.EditValue = Selecionado.ProdutoTotal;
            txtProdutoDescontoValor.EditValue = Selecionado.ProdutoDescontoValor;
            txtProdutoDescontoPerc.EditValue = Selecionado.ProdutoDescontoPerc;

            txtServicoSubTotal.EditValue = Selecionado.ServicoSubTotal;
            txtServicoTotal.EditValue = Selecionado.ServicoTotal;
            txtServicoDescontoValor.EditValue = Selecionado.ServicoDescontoValor;
            txtServicoDescontoPerc.EditValue = Selecionado.ServicoDescontoPerc;

            txtTotal.EditValue = Selecionado.Total;
        }

        #region Totais Serviços
        private void txtServicoDescontoValor_Leave(object sender, EventArgs e)
        {
            Selecionado.ServicoDescontoValor = Convert.ToDecimal(txtServicoDescontoValor.EditValue);
            Selecionado.ServicoDescontoPerc = cwkGestao.Modelo.Auxiliares.Util.PorcentagemDe(
                    Selecionado.ServicoSubTotal, Selecionado.ServicoDescontoValor);
            Selecionado.ReCalculaTotaisServicos();

            AtualizaTotais();
        }

        private void txtServicoDescontoPerc_Leave(object sender, EventArgs e)
        {
            Selecionado.ServicoDescontoPerc = Convert.ToDecimal(txtServicoDescontoPerc.EditValue);
            Selecionado.ServicoDescontoValor = cwkGestao.Modelo.Auxiliares.Util.ValorDe(
                    Selecionado.ServicoSubTotal, Selecionado.ServicoDescontoPerc);
            Selecionado.ReCalculaTotaisServicos();

            AtualizaTotais();
        }
        #endregion

        #region Totais Produtos
        private void txtProdutoDescontoValor_Leave(object sender, EventArgs e)
        {
            Selecionado.ProdutoDescontoValor = Convert.ToDecimal(txtProdutoDescontoValor.EditValue);
            Selecionado.ProdutoDescontoPerc = cwkGestao.Modelo.Auxiliares.Util.PorcentagemDe(
                    Selecionado.ProdutoSubTotal, Selecionado.ProdutoDescontoValor);
            Selecionado.ReCalculaTotaisProdutos();

            AtualizaTotais();
        }

        private void txtProdutoDescontoPerc_Leave(object sender, EventArgs e)
        {
            Selecionado.ProdutoDescontoPerc = Convert.ToDecimal(txtProdutoDescontoPerc.EditValue);
            Selecionado.ProdutoDescontoValor = cwkGestao.Modelo.Auxiliares.Util.ValorDe(
                    Selecionado.ProdutoSubTotal, Selecionado.ProdutoDescontoPerc);
            Selecionado.ReCalculaTotaisProdutos();

            AtualizaTotais();
        }
        #endregion

        private void AbreGridResponsavel()
        {
            var servicoSelecionado = gvServicoItems.FocusedRowHandle;
            if (servicoSelecionado >= 0)
            {
                OSServicoItem servicoItem = this.Selecionado.OSServicoItems[servicoSelecionado];
                GridGenerica<Pessoa> grid;
                grid = servicoItem.Tipo == TipoServico.Propria ?
                    new GridGenerica<Pessoa>(PessoaController.Instancia.GetAllFuncionarios(), new FormPessoa(), false) :
                    new GridGenerica<Pessoa>(PessoaController.Instancia.GetAllFornecedores(), new FormPessoa(), false);

                grid.Selecionando = true;
                grid.ShowDialog();

                servicoItem.Responsavel = grid.Selecionado;
            }
        }

        private void VerificaColunaValorT()
        {
            //int selecionado = gvServicoItems.FocusedRowHandle;
            //if (Selecionado != null && selecionado >= 0)
            //{
            //    OSServicoItem osServicoItem = Selecionado.OSServicoItems[selecionado];
            //    //ColunaSomenteLeitura(gvServicoItems.Columns[(int)Colunas.Servico.ValorT], osServicoItem.Tipo == TipoServico.Propria);
            //}
        }

        private void AdicionarServicoItem()
        {
            var servicoItem = new OSServicoItem
            {
                Quantidade = 1,
                OSOrdemServico = Selecionado,
                Seq = GetSequenciaServico(),
                GuidIdentificacao = Guid.NewGuid().ToString()
            };

            var FormAdicionarServico = new FormServicoOS(servicoItem);
            FormAdicionarServico.ShowDialog(this);
            if (FormAdicionarServico.Salvou)
            {
                servicoItem = FormAdicionarServico.ServicoItem;
                servicoItem.Descricao = FormAdicionarServico.ServicoItem.Servico.Nome;
            }

            Selecionado.OSServicoItems.Add(servicoItem);

            gcServicoItems.DataSource = TransformaServicoItems(Selecionado);
            gcServicoItems.RefreshDataSource();
            gvServicoItems.Focus();
        }
        private void RemoveElemento<T1, T2>(int remover, IList<T1> listaPropria, IList<T2> listaObjeto, GridView grid)
        {
            listaPropria.RemoveAt(remover);
            listaObjeto.RemoveAt(remover);

            AtualizaSequenciaItens();
            grid.RefreshData();

            Selecionado.ReCalculaTotais();
            AtualizaTotais();
        }

        private void AdicionarAcompanhamento()
        {
            OSAcompanhamento acompanhamento = new OSAcompanhamento();
            acompanhamento.OSOrdemServico = Selecionado;
            acompanhamento.DataHora = DateTime.Now;
            acompanhamento.Usuario = cwkControleUsuario.Facade.getUsuarioLogado.Login;
            Selecionado.OSAcompanhamentos.Add(acompanhamento);
            Acompanhamentos.Add(new OSAcompanhamentoEditavel(acompanhamento));

            gcAcompanhamentos.RefreshDataSource();
            SetaFocoCelula(gvAcompanhamentos, Selecionado.OSAcompanhamentos.Count - 1, 2);
            gvAcompanhamentos.Focus();
        }

        private void gvAcompanhamentos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Control)
            {
                RemoverAcompanhamentoItem();
            }
            else if (e.KeyCode == Keys.F6)
            {
                AbrirManutAcompanhamento();
            }
        }

        private void AbrirManutAcompanhamento()
        {
            var alterar = gvAcompanhamentos.FocusedRowHandle;

            if (alterar >= 0)
            {
                var form = new FormOSAcompanhamento();
                form.Selecionado = Selecionado.OSAcompanhamentos[alterar];
                form.ShowDialog();
            }
        }

        private void RemoverAcompanhamentoItem()
        {
            int remover = gvAcompanhamentos.FocusedRowHandle;
            if (remover >= 0)
            {
                if (!Selecionado.OSAcompanhamentos[remover].EhAutomatica)
                    RemoveElemento(remover, this.Acompanhamentos, Selecionado.OSAcompanhamentos, gvAcompanhamentos);
            }
        }

        private void gvAcompanhamentos_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LinhaAcompanhamentoSomenteLeitura();
        }

        private void LinhaAcompanhamentoSomenteLeitura()
        {
            int linhaSelecionada = gvAcompanhamentos.FocusedRowHandle;
            if (linhaSelecionada >= 0)
            {
                OSAcompanhamento osAcompanhamento = Selecionado.OSAcompanhamentos[linhaSelecionada];
                ColunaSomenteLeitura(gvAcompanhamentos.Columns[(int)Colunas.Acompanhamento.Data],
                                     osAcompanhamento.EhAutomatica);
                ColunaSomenteLeitura(gvAcompanhamentos.Columns[(int)Colunas.Acompanhamento.Hora],
                                     osAcompanhamento.EhAutomatica);
                ColunaSomenteLeitura(gvAcompanhamentos.Columns[(int)Colunas.Acompanhamento.Ocorrencia],
                                     osAcompanhamento.EhAutomatica);
            }
        }

        private void gvAcompanhamentos_DoubleClick(object sender, EventArgs e)
        {
            AbrirManutAcompanhamento();
        }

        private void FormOSOrdemServico_Shown(object sender, EventArgs e)
        {
            config = ConfiguracaoController.Instancia.GetConfiguracao();

            if (Operacao == Acao.Incluir)
                CarregarVendedor();

            txtProdutoSubTotal.Properties.ReadOnly = true;
            txtProdutoTotal.Properties.ReadOnly = true;
            txtServicoSubTotal.Properties.ReadOnly = true;
            txtServicoTotal.Properties.ReadOnly = true;
            txtTotal.Properties.ReadOnly = true;
            txtCodigo.Properties.ReadOnly = true;

            VerificaUtilizacaoImei();

            foreach (OSProdutoItem item in Selecionado.OSProdutoItems)
                item.GuidIdentificacao = Guid.NewGuid().ToString();

            foreach (OSServicoItem item in Selecionado.OSServicoItems)
                item.GuidIdentificacao = Guid.NewGuid().ToString();

            gcServicoItems.DataSource = TransformaServicoItems(Selecionado);
            gcServicoItems.RefreshDataSource();

            gcProdutoItems.DataSource = Selecionado.OSProdutoItems;
            gcProdutoItems.RefreshDataSource();
            gvProdutoItems.Focus();

            CarregarMaquinas();

            txtObservacao.Text = Selecionado.Observacao;
        }

        private void CarregarVendedor()
        {
            var funcionario = PessoaFuncionarioController.Instancia.GetVendedorAssociadoComUsuarioLogado(cwkControleUsuario.Facade.getUsuarioLogado.Login);

            if (funcionario != null && funcionario.Pessoa.BVendedor)
            {
                lkpEmpresa.Localizar(funcionario.Pessoa.Filial.ID);
                lkpVendedor.Localizar(funcionario.Pessoa.ID);
            }
        }

        private void VerificaUtilizacaoImei()
        {
            if (config.UtilizaControleIMEI)
            {
                if (!tcOS.TabPages.Contains(tpImei))
                    tcOS.TabPages.Add(tpImei);
            }
            else
            {
                if (tcOS.TabPages.Contains(tpImei))
                {
                    ControlUtil.LimparControles(tpImei);
                    tcOS.TabPages.Remove(tpImei);
                }
            }
        }

        private void lkbVendedor_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookupPessoa(lkpVendedor, cwkGestao.Negocio.PessoaController.Instancia.GetAllVendedores(), "Vendedor", typeof(FormPessoa));
        }

        private void lkbTecnico_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookupPessoa(lkpTecnico, cwkGestao.Negocio.PessoaController.Instancia.GetAllFuncionarios(), "Funcionários", typeof(FormPessoa));
        }

        private void gvServicoItems_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            VerificaColunaValorT();
        }

        private void btnProdutoInserir_Click(object sender, EventArgs e)
        {
            gvProdutoItems.Focus();
            AdicionarItem();
            Selecionado.ReCalculaTotaisProdutos();

            AtualizaTotais();
        }

        private void btnProdutoExcluir_Click(object sender, EventArgs e)
        {
            gvProdutoItems.Focus();
            RemoverItem();
            Selecionado.ReCalculaTotaisProdutos();

            AtualizaTotais();
        }

        private void btnServicoIncluir_Click(object sender, EventArgs e)
        {
            gvServicoItems.Focus();
            AdicionarServicoItem();

            Selecionado.ReCalculaTotais();
            AtualizaTotais();
        }

        private void btnServicoExcluir_Click(object sender, EventArgs e)
        {
            var linhaSelecionada = gvServicoItems.FocusedRowHandle;
            if (linhaSelecionada >= 0)
            {
                Selecionado.OSServicoItems.RemoveAt(linhaSelecionada);

                AtualizaSequenciaItens();
                gcServicoItems.DataSource = TransformaServicoItems(Selecionado);
                gcServicoItems.RefreshDataSource();

                Selecionado.ReCalculaTotais();
                AtualizaTotais();
            }
        }

        private void btnAcompanhamentoInserir_Click(object sender, EventArgs e)
        {
            gvAcompanhamentos.Focus();
            AdicionarAcompanhamento();
        }

        private void btnAcompanhamentoExcluir_Click(object sender, EventArgs e)
        {
            gvAcompanhamentos.Focus();
            RemoverAcompanhamentoItem();
        }

        private void btnAcompanhamentoAlterar_Click(object sender, EventArgs e)
        {
            gvAcompanhamentos.Focus();
            AbrirManutAcompanhamento();
        }

        private void btnServicoAlterar_Click(object sender, EventArgs e)
        {
            if (gvServicoItems.GetFocusedRow() is OSServicoItemEditavel ServicoSelecionado)
            {
                FormServicoOS FormAdicionarServico = new FormServicoOS(ServicoSelecionado.osServicoItem);
                FormAdicionarServico.ShowDialog(this);
                if (FormAdicionarServico.Salvou)
                    ServicoSelecionado.osServicoItem = FormAdicionarServico.ServicoItem;

                for (int i = 0; i < Selecionado.OSServicoItems.Count; i++)
                    if (Selecionado.OSServicoItems[i].GuidIdentificacao == ServicoSelecionado.osServicoItem.GuidIdentificacao)
                    {
                        Selecionado.OSServicoItems[i] = ServicoSelecionado.osServicoItem;
                        Selecionado.OSServicoItems[i].Descricao = ServicoSelecionado.osServicoItem.Servico.Nome;
                        Selecionado.OSServicoItems[i].Preco = ServicoSelecionado.osServicoItem.Preco;
                        Selecionado.OSServicoItems[i].Quantidade = ServicoSelecionado.osServicoItem.Quantidade;
                        Selecionado.OSServicoItems[i].Total = ServicoSelecionado.osServicoItem.Total;
                        Selecionado.OSServicoItems[i].DescontoPerc = ServicoSelecionado.osServicoItem.DescontoPerc;
                    }

                gcServicoItems.DataSource = TransformaServicoItems(Selecionado);
                gcServicoItems.RefreshDataSource();
                gvServicoItems.Focus();

                Selecionado.ReCalculaTotais();
                AtualizaTotais();
            }
        }

        private void btnProdutoAlterar_Click(object sender, EventArgs e)
        {
            if (gvProdutoItems.GetFocusedRow() is OSProdutoItem ProdSelecionado)
            {
                FormProdutoOS FormAdicionarProduto = new FormProdutoOS(ProdSelecionado, Selecionado.TabelaPreco, Selecionado.Condicao);
                FormAdicionarProduto.ShowDialog(this);
                if (FormAdicionarProduto.Salvou)
                    ProdSelecionado = FormAdicionarProduto.ProdutoItem;

                for (int i = 0; i < Selecionado.OSProdutoItems.Count; i++)
                    if (Selecionado.OSProdutoItems[i].GuidIdentificacao == ProdSelecionado.GuidIdentificacao)
                    {
                        Selecionado.OSProdutoItems[i] = ProdSelecionado;
                        Selecionado.OSProdutoItems[i].Descricao = ProdSelecionado.Produto.Nome;
                    }

                gcProdutoItems.DataSource = Selecionado.OSProdutoItems;
                gcProdutoItems.RefreshDataSource();
                gvProdutoItems.Focus();

                Selecionado.ReCalculaTotaisProdutos();

                AtualizaTotais();
            }
        }

        private void lkpCondicao_Leave(object sender, EventArgs e)
        {
            AtribuiCondicao();
        }

        private void AtribuiCondicao()
        {
            Selecionado.Condicao = (Condicao)lkpCondicao.Selecionado;
        }

        private void gvServicoItems_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (e.Row == null)
            {
                e.Valid = false;
                return;
            }
            GridView gv = (GridView)sender;
            gv.ClearColumnErrors();
            GridColumn cCodigo = gv.Columns["Codigo"];
            GridColumn cDescricao = gv.Columns["Descricao"];
            GridColumn cResponsavel = gv.Columns["Responsavel"];

            string codigo = gv.GetRowCellValue(e.RowHandle, cCodigo).ToString();
            string descricao = gv.GetRowCellValue(e.RowHandle, cDescricao).ToString();
            string responsavel = gv.GetRowCellValue(e.RowHandle, cResponsavel).ToString();

            if (String.IsNullOrEmpty(codigo))
            {
                gv.SetColumnError(cCodigo, "Insira um Serviço");
            }
            if (String.IsNullOrEmpty(descricao))
            {
                gv.SetColumnError(cDescricao, "Insira uma Descrição");
            }
            if (String.IsNullOrEmpty(responsavel))
            {
                gv.SetColumnError(cResponsavel, "Insira um Responsável");
            }
            e.Valid = !gv.HasColumnErrors;
        }

        private void gvServicoItems_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void AtualizaSequenciaItens()
        {
            if (Selecionado?.OSProdutoItems != null)
                for (int i = 0; i < Selecionado.OSProdutoItems.Count; i++)
                    Selecionado.OSProdutoItems[i].Seq = i + 1;

            if (Selecionado?.OSServicoItems != null)
                for (int i = 0; i < Selecionado.OSServicoItems.Count; i++)
                    Selecionado.OSServicoItems[i].Seq = i + 1;
        }


        private IList<OrdemServicoMaquina> Maquinas { get; set; }

        private void CarregarMaquinas(bool Carregar = true)
        {
            if (Carregar)
                Maquinas = OrdemServicoMaquinaController.Instancia.GetAll().Where(o => o.IdOrdemServico == Selecionado.ID).ToList();

            foreach (var Maq in Maquinas)
            {
                if (Maq.IdMaquina.HasValue)
                {
                    var Aux = MaquinaController.Instancia.LoadObjectById(Maq.IdMaquina.Value);

                    Maq.Maquina = Aux.Descricao;

                    if (Aux.IDFabricante.HasValue)
                        Maq.Fabricante = FabricanteController.Instancia.LoadObjectById(Aux.IDFabricante.Value).Descricao;
                }
            }

            gcOSMaquina.DataSource = Maquinas.Where(o => !o.Removido).ToList();
            gcOSMaquina.RefreshDataSource();
            gcOSMaquina.Refresh();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            // Consulta Maquina
            OrdemServicoMaquina Maquina = gvOSMaquina.GetFocusedRow() as OrdemServicoMaquina;
            FormOrdemServicoMaquina f = new FormOrdemServicoMaquina(Maquina, Acao.Consultar);
            f.ShowDialog(this);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            // Inserir Maquina
            OrdemServicoMaquina Maquina = new OrdemServicoMaquina
            {
                Novo = true,
                IdOrdemServico = Selecionado.ID
            };

            FormOrdemServicoMaquina f = new FormOrdemServicoMaquina(Maquina, Acao.Incluir);
            f.ShowDialog();

            if (f.Salvou)
            {
                Maquinas.Add(Maquina);
                CarregarMaquinas(false);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            // Alterar Maquina
            OrdemServicoMaquina Maquina = gvOSMaquina.GetFocusedRow() as OrdemServicoMaquina;
            FormOrdemServicoMaquina f = new FormOrdemServicoMaquina(Maquina, Acao.Alterar);
            f.ShowDialog();
            if (f.Salvou)
            {
                Maquina.Editado = true;
                Maquina.IdOrdemServico = Selecionado.ID;
                CarregarMaquinas(false);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Excluir Maquina
            OrdemServicoMaquina Maquina = gvOSMaquina.GetFocusedRow() as OrdemServicoMaquina;
            if (MessageBox.Show("Deseja remover a Maquina?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Maquina.Removido = true;
                CarregarMaquinas(false);
            }
        }

        private void SalvarMaquinas()
        {
            foreach (OrdemServicoMaquina Maquina in Maquinas)
            {
                Maquina.IdOrdemServico = Selecionado.ID;
                if (Maquina.Novo)
                    OrdemServicoMaquinaController.Instancia.Salvar(Maquina, Acao.Incluir);

                if (Maquina.Editado)
                    OrdemServicoMaquinaController.Instancia.Salvar(Maquina, Acao.Alterar);

                if (Maquina.Removido)
                    OrdemServicoMaquinaController.Instancia.Salvar(Maquina, Acao.Excluir);
            }
        }

        private void gcPedidoMaquina_DoubleClick(object sender, EventArgs e)
        {
            simpleButton3_Click(sender, e);
        }
    }
}
