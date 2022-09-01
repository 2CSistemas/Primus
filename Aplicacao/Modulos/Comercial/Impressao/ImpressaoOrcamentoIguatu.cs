using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Relatorio.Relatorios;
using Aplicacao.Base;
using System.Net.Mail;
using System.Net;
using System.IO;
using cwkGestao.Negocio;
using cwkGestao.Modelo.Util;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Modulos.Comercial.Impressao
{
    public class ImpressaoOrcamentoIguatu : ImpressaoOrcamento
    {
        public string Email;
        public string ObservacaoEmail;
        public DestinoImpressao DestinoImpressao;
        public bool EnvioEmailCancelado = false;
        private Aplicacao.InputBox input = new Aplicacao.InputBox();
        private string email;
        private string assuntoEmail;

        public ImpressaoOrcamentoIguatu(cwkGestao.Modelo.Pedido objPedido) : base(objPedido) { }

        public override void Imprimir()
        {
            DestinoImpressao = new Aplicacao.DestinoImpressaoPedido().ShowDialog();
            string varCREA = @"7ª Região nª 7587/2552";
            string varSITE = @"www.yguatu.com.br";
            TimeSpan prazoEntrega = objPedido.Dt - objPedido.DtPrazoEntrega;
            string dataAtualStr = DateTime.Today.Day + "    de    " + EscreveMesStr(DateTime.Today.Month) + "    de    " + DateTime.Today.Year;

            PessoaEndereco endPrincipal = new PessoaEndereco();
            PessoaEndereco endEntrega = new PessoaEndereco();

            if (objPedido.Pessoa.PessoaEnderecos != null)
            {
                endPrincipal = objPedido.Pessoa.PessoaEnderecos.Where(pr => pr.BPrincipal == true).FirstOrDefault();
                endEntrega = objPedido.Pessoa.PessoaEnderecos.Where(pr => pr.BPrincipal == false).Where(en => en.BEntrega == true).FirstOrDefault();
            }
            
            rptOrcamentoProdutoServico rel = new rptOrcamentoProdutoServico(objPedido.ID);
            PreenchePropertiesRelatorio(varCREA, varSITE, dataAtualStr, prazoEntrega, endPrincipal, endEntrega, rel);
            DecideCaminhoImpressao(rel);
        }

        public override void Imprimir(bool a)
        {
            if (a)
            {
                DestinoImpressao = new Aplicacao.DestinoImpressaoPedido().ShowDialog();
                string varCREA = @"7ª Região nª 7587/2552";
                string varSITE = @"www.yguatu.com.br";
                TimeSpan prazoEntrega = objPedido.Dt - objPedido.DtPrazoEntrega;
                string dataAtualStr = DateTime.Today.Day + "    de    " + EscreveMesStr(DateTime.Today.Month) + "    de    " + DateTime.Today.Year;

                PessoaEndereco endPrincipal = new PessoaEndereco();
                PessoaEndereco endEntrega = new PessoaEndereco();

                if (objPedido.Pessoa.PessoaEnderecos != null)
                {
                    endPrincipal = objPedido.Pessoa.PessoaEnderecos.Where(pr => pr.BPrincipal == true).FirstOrDefault();
                    endEntrega = objPedido.Pessoa.PessoaEnderecos.Where(pr => pr.BPrincipal == false).Where(en => en.BEntrega == true).FirstOrDefault();
                }

                rptOrcamentoProdutoServico rel = new rptOrcamentoProdutoServico(objPedido.ID);
                PreenchePropertiesRelatorio(varCREA, varSITE, dataAtualStr, prazoEntrega, endPrincipal, endEntrega, rel);
                DecideCaminhoImpressao(rel);
            }
        }

        private void PreenchePropertiesRelatorio(string varCREA, string varSITE, string dataAtualStr, 
                                                 TimeSpan prazoEntrega, PessoaEndereco endPrincipal,
                                                 PessoaEndereco endEntrega, rptOrcamentoProdutoServico rel)
        {
            string endEntregaStr = "";
            string endPrincipalStr = "";
            if (endEntrega != null)
                endEntregaStr = endEntrega.Cidade + " - " + endEntrega.Cidade.UF;
            if (endPrincipal != null)
                endPrincipalStr = endPrincipal.Endereco + ", " + endPrincipal.Bairro;
                        
            rel.NomeFilial.Value = objPedido.Filial.Nome;
            rel.CNPJEmpresa.Value = objPedido.Filial.CNPJ;
            rel.IEEmpresa.Value = objPedido.Filial.Inscricao;
            rel.TelEmpresa.Value = objPedido.Filial.Telefone;
            rel.EndEmpresa.Value = objPedido.Filial.Endereco;
            rel.RegCREAEmpresa.Value = varCREA;
            rel.EmailEmpresa.Value = objPedido.Filial.Email;
            rel.SITEEmpresa.Value = varSITE;

            rel.NumOrcamento.Value = objPedido.Numero;

            rel.CidadeEstadoLocalPerfuracoes.Value = endEntregaStr;
            rel.CoordenadasLocalPerfuracoes.Value = objPedido.Observacao1;

            rel.NomeContato.Value = objPedido.Pessoa.Contato;
            rel.NomeCidadeCliente.Value = objPedido.Pessoa.Cidade;
            rel.CidadeEstadoCliente.Value = objPedido.Pessoa.Cidade + " - " + objPedido.Pessoa.Estado;
            rel.NomeCliente.Value = objPedido.Pessoa.Nome;
            rel.EndCliente.Value = endPrincipalStr;
            rel.TelCliente.Value = objPedido.Pessoa.TelefonePrincipal;
            rel.CPFCNPJCliente.Value = objPedido.Pessoa.CNPJ_CPF;
            rel.IECliente.Value = objPedido.Pessoa.Inscricao;

            rel.DescricaoCondPagamento.Value = objPedido.Condicao.Descricao;
            rel.PrazoEntrega.Value = prazoEntrega.Days;
            rel.CidadeDataRel.Value = objPedido.Pessoa.Cidade+",   " + dataAtualStr;

            rel.TotalOrcamento.Value = objPedido.TotalPedido;
        }

        public string EscreveMesStr(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "Janeiro";                   
                case 2:
                    return "Feveiro";                   
                case 3:
                    return "Março";                    
                case 4:
                    return "Abril";                  
                case 5:
                    return "Maio";                   
                case 6:
                    return "Junho";                   
                case 7:
                    return "Julho";                   
                case 8:
                    return "Agosto";                    
                case 9:
                    return "Setembro";                  
                case 10:
                    return "Outubro";                    
                case 11:
                    return "Novembro";                    
                case 12:
                    return "Dezembro";                   
                default:
                    return "";                   
            }
        }

        private void DecideCaminhoImpressao(DevExpress.XtraReports.UI.XtraReport report)
        {
            try
            {
                switch (DestinoImpressao)
                {
                    case DestinoImpressao.Vídeo:
                        report.ShowPreview();
                        objPedido.BImpressa = true;
                        cwkGestao.Negocio.PedidoController.Instancia.Salvar(objPedido, cwkGestao.Modelo.Acao.Alterar);
                        break;
                    case DestinoImpressao.Email:
                        bool podeEnviar = ColetarDadosEmail(new ImpressaoOrcamentoIguatu(objPedido), objPedido);
                        if (String.IsNullOrEmpty(email) || email.Trim() == String.Empty || !podeEnviar)
                            throw new Exception("Não foi informado um email.\nVerifique.");
                        else
                            EnviarEmail(objPedido.Filial, GeraPDF(report), email);
                        break;
                    case DestinoImpressao.Impressora:
                        report.PrintDialog();
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

                if (config.SolicitaRecebimentoEmail)
                {
                    mensagem.DeliveryNotificationOptions = System.Net.Mail.DeliveryNotificationOptions.OnSuccess;    
                }

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

        public String GeraPDF(DevExpress.XtraReports.UI.XtraReport report)
        {
            string Caminho = Modelo.cwkGlobal.DirApp;

            if (!Directory.Exists(Caminho += @"\OrcamentoPDF"))
                Directory.CreateDirectory(Caminho);

            Caminho += @"\Orcamento_" + objPedido.Numero.ToString() + ".pdf";

            report.ExportToPdf(Caminho);
            return Caminho;
        }

        public bool ColetarDadosEmail(ImpressaoOrcamentoIguatu Impressao, Pedido pedido)
        {
            Configuracao confSistema = ConfiguracaoController.Instancia.GetAll()[0];

            email = pedido.Pessoa.PessoaEmails.Where(i => i.BCompra == true).FirstOrDefault() == null ? "" : pedido.Pessoa.PessoaEmails.Where(i => i.BCompra == true).FirstOrDefault().Email;
            if (!input.Show(email, "Email da Pessoa", out email) && !input.confirmado)
            {
                Impressao.EnvioEmailCancelado = true;
                return false;
            }

            if (confSistema.EditarAssuntoEmailPedido)
            {
                if (!input.Show(confSistema.Assunto, "Assunto", out assuntoEmail))
                    return false;
            }

            return true;
        }
    }
}
