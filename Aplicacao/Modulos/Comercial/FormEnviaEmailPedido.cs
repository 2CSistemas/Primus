using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using cwkGestao.NFe;
using cwkGestao.Modelo;
using Aplicacao.Base;
using cwkGestao.Negocio;
using System.Linq;
using cwkGestao.Negocio.Comercial;
using cwkGestao.Negocio.Padroes;
using System.Collections.Specialized;
using System.Globalization;
using System.Net.Mail;
using System.Net;
using cwkGestao.Modelo.Util;
using System.IO;
using Relatorio.Relatorios;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormEnviaEmailPedido : Form
    {
        private Pedido pedido;
        private string email;
        private IList<string> emails;
        private string assunto;
        private string corpoemail;
        private const int QtdRegistros = 16;

        Configuracao config = ConfiguracaoController.Instancia.GetAll().FirstOrDefault();
        private List<rptOrcamentoMulti> ListaDeOrcs = new List<rptOrcamentoMulti>();
        private List<rptImpressaoPedido05> ListadeOrcs5 = new List<rptImpressaoPedido05>();
        private List<rptImpressaoPedido06> ListadeOrcs6 = new List<rptImpressaoPedido06>();



        public FormEnviaEmailPedido(Pedido _pedido)
        {
            InitializeComponent();
            this.pedido = _pedido;

            txtEmail.EditValue = email = GetEmailsCompra(pedido.Pessoa);
            emails = email.Split(',').ToList();

            txtAssunto.EditValue = assunto = config.AssuntoEmail;
            txtCorpo.RtfText = corpoemail = config.TextoEmailPedido;
        }

        private string GetEmailsCompra(Pessoa pessoa)
        {
            IList<PessoaEmail> pEmail = pessoa.PessoaEmails == null ? new List<PessoaEmail>() : pessoa.PessoaEmails.Where(i => i.BCompra == true).ToList();
            if (pEmail.Count() > 0)
                return String.Join(",", pEmail.Select(e => e.Email));

            return String.Empty;
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HabilitaBotoes()
        {
            btEmail.Enabled = true;
            btFechar.Enabled = true;

            this.Refresh();
        }

        private void DesabilitaBotoes()
        {
            btEmail.Enabled = false;
            btFechar.Enabled = false;

            this.Refresh();
        }

        private void btEmail_Click(object sender, EventArgs e)
        {
            email = txtEmail.Text;
            emails = email.Split(',').ToList();

            assunto = txtAssunto.EditValue.ToString();
            EnviarEmail(pedido.Filial, GeraPDF(), emails);
            btFechar_Click(sender, e);
        }


        private void EnviarEmail(cwkGestao.Modelo.Filial objFilial, string pNomeArquivo, IList<string> pEmailsCliente)
        {
            try
            {
                var config = ConfiguracaoController.Instancia.GetConfiguracao();
                var usuario = cwkControleUsuario.Facade.getUsuarioLogado;

                if (usuario.Email != "" && usuario.Email != null)
                {
                    StringBuilder propVazias = new StringBuilder();
                    if (String.IsNullOrEmpty(usuario.SenhaEmail))
                        propVazias.Append("SenhaEmail não informado, ");
                    if (String.IsNullOrEmpty(usuario.SMTP))
                        propVazias.Append("Servidor SMTP não informado, ");
                    if (String.IsNullOrEmpty(usuario.Porta))
                        propVazias.Append("Porta do Email não informado, ");

                    if (propVazias.ToString() != "")
                    {
                        propVazias.Append("Verifique as informações de email no cadastro do usuário.");
                        throw new Exception(propVazias.ToString());
                    }
                    else
                    {
                        try
                        {
                            EnviarEmailGen(config, usuario.SMTP, usuario.Email, usuario.SenhaEmail, usuario.Porta, usuario.SSL, pNomeArquivo, pEmailsCliente);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Verifique suas configurações de envio no cadastro de usuário \r\n" + ex.Message);
                        }

                    }
                }
                else
                {
                    EnviarEmailGen(config, objFilial.ServidorSMTP, objFilial.UsuarioEmail, objFilial.SenhaEmail, objFilial.PortaSmtp.ToString(), objFilial.GMailAutenticacao, pNomeArquivo, pEmailsCliente);
                }


            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao enviar email.\r\n" + ex);
            }

        }

        private void EnviarEmailGen(Configuracao config, string SMTP, string UsuarioEmail, string SenhaEmail, string PortaSMTP, bool SSL, string pNomeArquivo, IList<string> pEmailsCliente)
        {
            SmtpClient cliente = new SmtpClient(SMTP, Convert.ToInt32(PortaSMTP) /* TLS */);
            MailMessage mensagem = new MailMessage();

            mensagem.From = new MailAddress(UsuarioEmail);
            foreach (var pEmail in pEmailsCliente)
            {
                mensagem.To.Add(new MailAddress(pEmail));
            }

            Attachment arqPedido = new Attachment(pNomeArquivo);

            try
            {
                cliente.EnableSsl = SSL;
                cliente.Credentials = new NetworkCredential(UsuarioEmail, SenhaEmail);

                if (!config.EditarAssuntoEmailPedido)
                {
                    mensagem.Subject = config.Assunto;
                }
                else
                {
                    mensagem.Subject = assunto;
                }

                mensagem.IsBodyHtml = true;

                if (config.SolicitaConfirmaEmailPedido)
                    mensagem.Headers.Add("Disposition-Notification-To", UsuarioEmail);

                if (StringUtil.VerificaSeEHtml(corpoemail))
                    mensagem.Body = StringUtil.ConvertRtfToHtml(txtCorpo.RtfText);
                else
                    mensagem.Body = StringUtil.ConvertRtfToHtml(txtCorpo.RtfText).Replace("<div align=\"center\">Trial version can convert up to 30000 symbols.<br><a href=\"http://www.sautinsoft.com/convert-rtf-to-html/order.php\">Get the full featured version!</a></div>", "");
                mensagem.Attachments.Add(arqPedido);
                cliente.Send(mensagem);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                mensagem.Dispose();
                arqPedido.Dispose();
            }
        }

        public String GeraPDF()
        {
            string Caminho = Modelo.cwkGlobal.DirApp;

            if (!Directory.Exists(Caminho += @"\OrcamentoPDF"))
                Directory.CreateDirectory(Caminho);

            Caminho += @"\Orcamento_" + pedido.Numero.ToString() + ".pdf";

            ImprimeRelatorio().ExportToPdf(Caminho);
            return Caminho;
        }

        private DevExpress.XtraReports.UI.XtraReport ImprimeRelatorio()
        {
            if (config.ModeloImpressaoGrafica == ModeloImpressaoGraficaType.Modelo5)
            {
                rptImpressaoPedido05 PrimeiroReport = new rptImpressaoPedido05(pedido.ID);
                PrimeiroReport.CreateDocument();


                foreach (var item in ListadeOrcs5)
                {
                    item.CreateDocument();
                    PrimeiroReport.Pages.Add(item.Pages[item.Pages.Count - 1]);
                }
                PrimeiroReport.PrintingSystem.ContinuousPageNumbering = true;

                return PrimeiroReport;
            }
            else if (config.ModeloImpressaoGrafica == ModeloImpressaoGraficaType.Modelo6)
            {
                rptImpressaoPedido06 PrimeiroReport = new rptImpressaoPedido06(pedido.ID);
                PrimeiroReport.CreateDocument();

                foreach (var item in ListadeOrcs6)
                {
                    item.CreateDocument();
                    PrimeiroReport.Pages.Add(item.Pages[item.Pages.Count - 1]);
                }
                PrimeiroReport.PrintingSystem.ContinuousPageNumbering = true;

                return PrimeiroReport;
            }
            else
            {
                var Formas = pedido?.Parcelas?.Select(o => o.TipoDocumento.FormaPagamento.Nome);

                rptOrcamentoMulti PrimeiroReport = new rptOrcamentoMulti(string.Join(", ", Formas));
                ReparteQtdProdutos(pedido.ID);
                PrimeiroReport.CreateDocument();


                foreach (var item in ListaDeOrcs)
                {
                    item.CreateDocument();
                    PrimeiroReport.Pages.Add(item.Pages[item.Pages.Count - 1]);
                }
                PrimeiroReport.PrintingSystem.ContinuousPageNumbering = true;

                return PrimeiroReport;
            }

        }

        private void GeraRelatorio(Relatorio.dsImpressaoOrdemServico.RelOrcamentoDataTable Dados, int a)
        {
            DataSet dataSet = new DataSet() { DataSetName = "dsImpressaoOrdemServico" };
            dataSet.Tables.Add(Dados);

            var Formas = pedido?.Parcelas?.Select(o => o.TipoDocumento.FormaPagamento.Nome);

            rptOrcamentoMulti form = new rptOrcamentoMulti(string.Join(", ", Formas)) { DataSource = dataSet };
            ListaDeOrcs.Add(form);
        }

        private void ReparteQtdProdutos(Int32 ID)
        {
            var Dados = new Relatorio.dsImpressaoOrdemServicoTableAdapters.RelOrcamentoTableAdapter().GetData(pedido.ID);

            object TotalPedido = 0;
            object CodigoPedido = 0;

            Relatorio.dsImpressaoOrdemServico.RelOrcamentoDataTable DadosParciais = new Relatorio.dsImpressaoOrdemServico.RelOrcamentoDataTable();

            DataTableReader dr = Dados.CreateDataReader();
            #region Variaveis de controle de posição
            int pValorUnitario = dr.GetOrdinal("ValorUnitario");
            int pValorTotal = dr.GetOrdinal("ValorTotal");
            int pFantasia = dr.GetOrdinal("Fantasia");
            int pTotalPedido = dr.GetOrdinal("TotalPedido");
            int pCodigoPedido = dr.GetOrdinal("CodigoPedido");
            int pFrete = dr.GetOrdinal("Frete");
            int pValidadePedido = dr.GetOrdinal("ValidadePedido");
            int pTotalST = dr.GetOrdinal("TotalST");
            int qtdCampos = dr.FieldCount;
            #endregion

            while (dr.Read())
            {
                object[] a = new object[qtdCampos];

                dr.GetValues(a);

                DadosParciais.Rows.Add(a);

                if ((DadosParciais.Count % QtdRegistros) == 0)
                {
                    GeraRelatorio(DadosParciais, 0);
                    DadosParciais = new Relatorio.dsImpressaoOrdemServico.RelOrcamentoDataTable();
                }
                TotalPedido = a[pTotalPedido];
                CodigoPedido = a[pCodigoPedido];
            }

            if (DadosParciais != null && DadosParciais.Count != 0)
            {
                while (DadosParciais.Count != QtdRegistros)
                {
                    object[] a = new object[qtdCampos];
                    a[pValorUnitario] = 0;
                    a[pValorTotal] = 0;
                    a[pFrete] = 0;
                    a[pValidadePedido] = 0;
                    a[pTotalST] = 0;
                    a[pTotalPedido] = TotalPedido;
                    a[pCodigoPedido] = CodigoPedido;
                    DadosParciais.Rows.Add(a);
                }
                GeraRelatorio(DadosParciais, 0);
            }
        }
    }
}