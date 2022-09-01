using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Relatorio.Relatorios;
using System.Data;
using System.Net.Mail;
using System.Net;
using cwkGestao.Modelo;
using System.IO;
using Aplicacao.Base;
using cwkGestao.Negocio;
using cwkGestao.Modelo.Util;

namespace Aplicacao.Modulos.Comercial.Impressao
{
    public class ImpressaoPedidoCompra02 : ImpressaoOrcamento
    {
        private string nomerel;
        private DateTime dataEntrega;
        private decimal desconto;
        private const int QtdRegistros = 16;
        public string Email;
        public string ObservacaoEmail;
        public DestinoImpressao DestinoImpressao;
        public bool EnvioEmailCancelado = false;
        private Aplicacao.InputBox input = new Aplicacao.InputBox();
        private string email;
        private string assuntoEmail;


        private List<rptImpressaoNotaCompra02> ListaDeOrcs = new List<rptImpressaoNotaCompra02>();

        public ImpressaoPedidoCompra02(cwkGestao.Modelo.Pedido objPedido) : base(objPedido) { }

        

        public override void Imprimir()
        {
            desconto = SetPercentualDesconto();
            dataEntrega = objPedido.DtPrazoEntrega;
            DestinoImpressao = new Aplicacao.DestinoImpressaoPedido().ShowDialog();
            ReparteQtdProdutos(objPedido.ID);
        }

        public override void Imprimir(bool a)
        {
            desconto = SetPercentualDesconto();
            dataEntrega = objPedido.DtPrazoEntrega;

            if (a)
                DestinoImpressao = DestinoImpressao.Impressora;

            ReparteQtdProdutos(objPedido.ID);
        }

        private void ReparteQtdProdutos(Int32 ID)
        {
            var Dados = new Relatorio.dsImpressaoPedidoCompraTableAdapters.PedidoCompraTableAdapter().GetData(objPedido.ID);
            
            object TotalPedido = 0;
            object CodigoPedido = 0;

            Relatorio.dsImpressaoPedidoCompra.PedidoCompraDataTable DadosParciais = new Relatorio.dsImpressaoPedidoCompra.PedidoCompraDataTable();
            DataTableReader dr = Dados.CreateDataReader();
            GeraRelatorio(DadosParciais, 0);
            //DadosParciais = new Relatorio.dsImpressaoPedidoCompra.PedidoCompraDataTable();
            DecideCaminhoImpressao();
        }

        private DevExpress.XtraReports.UI.XtraReport ImprimeRelatorio()
        {
            rptImpressaoNotaCompra02 PrimeiroReport = new rptImpressaoNotaCompra02(objPedido.ID);

            PrimeiroReport.CreateDocument();

            PrimeiroReport.PrintingSystem.ContinuousPageNumbering = true;

            return PrimeiroReport;
        }

        private void GeraRelatorio(Relatorio.dsImpressaoPedidoCompra.PedidoCompraDataTable Dados, int a)
        {
            var dataSet = new DataSet { DataSetName = "dsImpressaoPedidoCompra" };
            dataSet.Tables.Add(Dados);
            rptImpressaoNotaCompra02 form = new rptImpressaoNotaCompra02(objPedido.ID) { DataSource = dataSet };
            ListaDeOrcs.Add(form);
        }

        private void DecideCaminhoImpressao()
        {
            try
            {
                switch (DestinoImpressao)
                {
                    case DestinoImpressao.Vídeo:
                        ImprimeRelatorio().ShowPreview();
                        objPedido.BImpressa = true;
                        cwkGestao.Negocio.PedidoController.Instancia.Salvar(objPedido, cwkGestao.Modelo.Acao.Alterar);
                        break;
                    case DestinoImpressao.Email:
                        bool podeEnviar = ColetarDadosEmail(new ImpressaoOrcamentoModelo3(objPedido), objPedido);
                        if (String.IsNullOrEmpty(email) || email.Trim() == String.Empty || !podeEnviar)
                            throw new Exception("Não foi informado um email.\nVerifique.");
                        else
                            EnviarEmail(objPedido.Filial, GeraPDF(), email);
                        break;
                    case DestinoImpressao.Impressora:
                        ImprimeRelatorio().PrintDialog();
                        objPedido.BImpressa = true;
                        cwkGestao.Negocio.PedidoController.Instancia.Salvar(objPedido, cwkGestao.Modelo.Acao.Alterar);
                        break;
                }
            }
            catch (Exception ex)
            {
                if (!EnvioEmailCancelado)
                    new FormErro(ex).ShowDialog();
            }
        }

        private void EnviarEmail(cwkGestao.Modelo.Filial objFilial, string pNomeArquivo, string pEmailCliente)
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
                            EnviarEmailGen(config, usuario.SMTP, usuario.Email, usuario.SenhaEmail, usuario.Porta, usuario.SSL, pNomeArquivo, pEmailCliente);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Verifique suas configurações de envio no cadastro de usuário \r\n" + ex.Message);
                        }

                    }
                }
                else
                {
                    EnviarEmailGen(config, objFilial.ServidorSMTP, objFilial.UsuarioEmail, objFilial.SenhaEmail, objFilial.PortaSmtp.ToString(), objFilial.GMailAutenticacao, pNomeArquivo, pEmailCliente);
                }


            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao enviar email.\r\n" + ex);
            }

        }

        private void EnviarEmailGen(Configuracao config, string SMTP, string UsuarioEmail, string SenhaEmail, string PortaSMTP, bool SSL, string pNomeArquivo, string pEmailCliente)
        {
            SmtpClient cliente = new SmtpClient(SMTP, Convert.ToInt32(PortaSMTP) /* TLS */);
            MailMessage mensagem = new MailMessage(new MailAddress(UsuarioEmail), new MailAddress(pEmailCliente));
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
                    mensagem.Subject = assuntoEmail;
                }

                mensagem.IsBodyHtml = true;

                if (config.SolicitaConfirmaEmailPedido)
                    mensagem.Headers.Add("Disposition-Notification-To", UsuarioEmail);

                if (StringUtil.VerificaSeEHtml(config.TextoEmailPedido))
                    mensagem.Body = config.TextoEmailPedido;
                else
                    mensagem.Body = StringUtil.ConvertRtfToHtml(config.TextoEmailPedido).Replace("<div align=\"center\">Trial version can convert up to 30000 symbols.<br><a href=\"http://www.sautinsoft.com/convert-rtf-to-html/order.php\">Get the full featured version!</a></div>", "");
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

            if (!Directory.Exists(Caminho += @"\PedidoCompraPDF"))
                Directory.CreateDirectory(Caminho);

            Caminho += @"\Pedido_" + objPedido.Numero.ToString() + ".pdf";

            ImprimeRelatorio().ExportToPdf(Caminho);
            return Caminho;
        }

        public bool ColetarDadosEmail(ImpressaoOrcamentoModelo3 Impressao, Pedido pedido)
        {
            Configuracao confSistema = ConfiguracaoController.Instancia.GetAll()[0];

            email = pedido.Pessoa.PessoaEmails.Where(i => i.BVenda == true).FirstOrDefault() == null ? "" : pedido.Pessoa.PessoaEmails.Where(i => i.BVenda== true).FirstOrDefault().Email;
            if (!input.Show(email, "Email da Pessoa", out email) && !input.confirmado)
            {
                Impressao.EnvioEmailCancelado = true;
                return false;
            }

            if (confSistema.EditarAssuntoEmailPedido)
            {
                if (!input.Show("", "Assunto", out assuntoEmail))
                    return false;
            }

            return true;
        }
    }
}
