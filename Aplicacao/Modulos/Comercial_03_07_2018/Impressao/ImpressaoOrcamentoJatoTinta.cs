using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Reporting.WinForms;
using System.IO;
using Relatorio;
using System.Data;
using Relatorio.Relatorios;
using DevExpress.XtraReports.UI;
using System.Net.Mail;
using System.Net;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Comercial.Impressao
{
    public class ImpressaoOrcamentoJatoTinta : ImpressaoOrcamento
    {
        private string nomerel;
        private DateTime dataEntrega;
        private decimal desconto;
        private int Pagina = 1;
        private int TotalPaginas = 0;
        public string Email;
        public string ObservacaoEmail;
        public DestinoImpressao DestinoImpressao;

        public ImpressaoOrcamentoJatoTinta(cwkGestao.Modelo.Pedido objPedido) : base(objPedido) { }

        public override void Imprimir()
        {
            dataEntrega = objPedido.DtPrazoEntrega;
            SetNomeRelatorio();
            SetPercentualDesconto();
            GeraRelatorio();
        }

        private List<Microsoft.Reporting.WinForms.ReportParameter> GetParametros()
        {
            List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
           

            String Parcelas = string.Empty;
            int i = 0;

            foreach (var item in objPedido.Parcelas)
            {

               var tipoDocumento = TipoDocumentoController.Instancia.LoadObjectById(item.TipoDocumento.ID);

                 if (nomerel == "rptImpressaoNotaRetratoAgalux.rdlc")
                 {
                    string valor2 = string.Empty;
                   
                    int qtdEspacoEmBranco2 = 19 - item.Valor.ToString().Length;

                    for (int j = 0; j < qtdEspacoEmBranco2; j++)
                    {
                        valor2 = "";
                    }
                    valor2 += (item.Valor);
                    double valor3 = Convert.ToDouble(valor2);
                    string a = string.Format("{0:N}", valor3);
                    Parcelas += (String.Format("{0:#0}", ++i) + "º " + item.Vencimento.ToShortDateString() + "   R$ " + a + " " + tipoDocumento.DescReduzida + "  |    ");
                                        
                }
                else
                {
                    string valor = string.Empty;
                    int qtdEspacoEmBranco = 19 - item.Valor.ToString().Length;

                    for (int j = 0; j < qtdEspacoEmBranco; j++)
                    {
                        valor += " ";
                    }

                    valor += ("   R$" + item.Valor.ToString());

                    Parcelas += (String.Format("{0:#0}", ++i) + "º   " + item.Vencimento.ToShortDateString() + valor + "  |    ");
                }
                

            }

            #region DadosEmpresa
            parametros.Add(new ReportParameter("Empresa", objPedido.Filial.Nome.ToUpper()));
            parametros.Add(new ReportParameter("EnderecoEmpresa", objPedido.Filial.Endereco + ", " + objPedido.Filial.Numero));
            parametros.Add(new ReportParameter("TelefoneEmpresa", objPedido.Filial.Telefone));
            parametros.Add(new ReportParameter("CidadeEmpresa", objPedido.Filial.Cidade.Nome));
            parametros.Add(new ReportParameter("BairroEmpresa", objPedido.Filial.Bairro));
            parametros.Add(new ReportParameter("EstadoEmpresa", objPedido.Filial.Cidade.UF.Nome));
            string vendedor = "";
            if (objPedido.Vendedor != null)
                vendedor = objPedido.Vendedor.Apelido ?? "";
            parametros.Add(new ReportParameter("Vendedor", vendedor));
            parametros.Add(new ReportParameter("Data", objPedido.Dt.ToString()));
            if (nomerel == "rptImpressaoNotaRetratoAgalux.rdlc")
                parametros.Add(new ReportParameter("TotalPedido", String.Format("{0:C2}", (objPedido.TotalPedido/1000))));
            else
                parametros.Add(new ReportParameter("TotalPedido", objPedido.TotalPedido.ToString()));
            parametros.Add(new ReportParameter("CepEmpresa", objPedido.Filial.CEP));
            parametros.Add(new ReportParameter("CnpjEmpresa", objPedido.Filial.CNPJ));
            parametros.Add(new ReportParameter("IEEmpresa", objPedido.Filial.Inscricao));
            parametros.Add(new ReportParameter("Observacao", objPedido.Observacao1 ?? ""));
            parametros.Add(new ReportParameter("Desconto", String.IsNullOrEmpty(desconto.ToString()) ? "" : (desconto / 100).ToString()));
            parametros.Add(new ReportParameter("Condicao", objPedido.Condicao.Nome));
            parametros.Add(new ReportParameter("DataEntrega", dataEntrega.ToString()));
            parametros.Add(new ReportParameter("img", global::Modelo.cwkGlobal.DirApp + @"\LogoEmpresa.jpg"));
            parametros.Add(new ReportParameter("SiteEmpresa", objPedido.Filial.Site != null ? objPedido.Filial.Site : ""));
            parametros.Add(new ReportParameter("EmailEmpresa", objPedido.Filial.Email != null ? objPedido.Filial.Email : ""));
            parametros.Add(new ReportParameter("Cotacao", objPedido.Observacao3 ?? ""));
            parametros.Add(new ReportParameter("Observacao1Licitacao", objPedido.Observacao1Licitacao ?? ""));
            parametros.Add(new ReportParameter("Observacao2Licitacao", objPedido.Observacao2Licitacao ?? ""));
            parametros.Add(new ReportParameter("Validade", objPedido.Validade.ToString()));
            parametros.Add(new ReportParameter("TotalProduto", objPedido.TotalProduto.ToString()));
            parametros.Add(new ReportParameter("TotalST", objPedido.TotalST.ToString()));
            parametros.Add(new ReportParameter("Parcelas", Parcelas));

            
            

            #endregion

            #region DadosClientes
            if (nomerel == "rptImpressaoNotaRetrato.rdlc")
                parametros.Add(new ReportParameter("TipoRelatorio", objPedido.TipoPedido.Tipo == cwkGestao.Modelo.TipoPedidoType.Orçamento ? "Orçamento: " + objPedido.Numero + objPedido.ComplementoNumero : "Pedido: " + objPedido.Numero + objPedido.ComplementoNumero));
            else if (nomerel == "rptImpressaoNotaRetratoMultiparafusos.rdlc")
            {
                parametros.Add(new ReportParameter("TipoRelatorio", objPedido.TipoPedido.Tipo == cwkGestao.Modelo.TipoPedidoType.Orçamento ? "Orçamento" : "Pedido: " + objPedido.Numero + objPedido.ComplementoNumero)); parametros.Add(new ReportParameter("TipoRelatorio", objPedido.TipoPedido.Tipo == cwkGestao.Modelo.TipoPedidoType.Orçamento ? "Orçamento" : "Pedido: " + objPedido.Numero + objPedido.ComplementoNumero));
                parametros.Add(new ReportParameter("NomeCliente", objPedido.Pessoa.Nome));
                parametros.Add(new ReportParameter("FantasiaCliente", objPedido.Pessoa.Fantasia));
                parametros.Add(new ReportParameter("EnderecoCliente", String.Format("{0} {1}", objPedido.Pessoa.EnderecoPrincipal().Endereco, objPedido.Pessoa.EnderecoPrincipal().Numero)));
                //parametros.Add(new ReportParameter("EmailCliente", objPedido.Pessoa.PessoaEmails.Where(a => a.BVenda == true).First().Email));
                parametros.Add(new ReportParameter("TelefoneCliente", objPedido.Pessoa.TelefonePrincipal));
                parametros.Add(new ReportParameter("CPF_CNPJCliente", objPedido.Pessoa.CNPJ_CPF));
                parametros.Add(new ReportParameter("IECliente", objPedido.Pessoa.Inscricao));
                parametros.Add(new ReportParameter("CidadeCliente", objPedido.Pessoa.Cidade));
                parametros.Add(new ReportParameter("EstadoCliente", objPedido.Pessoa.EnderecoPrincipal().Cidade.UF.Sigla));
                parametros.Add(new ReportParameter("NumeroOrcamento", objPedido.Numero.ToString()));
                parametros.Add(new ReportParameter("DataOrcamento", objPedido.DtDigitacao.ToShortDateString()));
                parametros.Add(new ReportParameter("Pagina", Pagina.ToString()));
                parametros.Add(new ReportParameter("TotalPaginas", TotalPaginas.ToString()));
                parametros.Add(new ReportParameter("VendedorCliente", objPedido.Vendedor.Apelido == String.Empty ? objPedido.Vendedor.Nome : objPedido.Vendedor.Apelido));
            }
            else if (nomerel == "rptImpressaoNotaRetratoCompra.rdlc")
            {
                parametros.Add(new ReportParameter("TipoRelatorio", objPedido.TipoPedido.Tipo == cwkGestao.Modelo.TipoPedidoType.Orçamento ? "Orçamento" : "Pedido"));
                parametros.Add(new ReportParameter("CodigoPedido", objPedido.Codigo.ToString()));
            }
            else
                parametros.Add(new ReportParameter("TipoRelatorio", objPedido.TipoPedido.Tipo == cwkGestao.Modelo.TipoPedidoType.Orçamento ? "Orçamento" : "Pedido: " + objPedido.Numero + objPedido.ComplementoNumero));

            #endregion

            return parametros;
        }

        //TODO: Substituir este metodo pelo da Clase ImpressaoOrcamento!!!
        private void SetPercentualDesconto()
        {
            desconto = 100 - (((decimal)objPedido.TotalPedido / objPedido.Items.Sum(s => (s.ValorCalculado * s.Quantidade))) * 100);
            desconto = System.Math.Round(desconto, 2);
        }

        private void SetNomeRelatorio()
        {
            /*
            if (objImpressora.TipoImpressao == cwkGestao.Modelo.TipoImpressao.Retrato)
                nomerel = "rptImpressaoNotaRetrato";
            else
                nomerel = "rptImpressaoNota";
            */

            if (objPedido.TipoPedido.NomeRelatorio == null)
                nomerel = "rptImpressaoNota";
            else
                nomerel = objPedido.TipoPedido.NomeRelatorio;

            if (objPedido.Ent_Sai == (int)InOutType.Entrada)
                nomerel += "Compra";

            nomerel += ".rdlc";
        }

        private void GeraRelatorio()
        {
            var Dados = new Relatorio.dsImpressaoOrdemServicoTableAdapters.RelOrcamentoTableAdapter().GetData(objPedido.ID);

            if (nomerel != "rptImpressaoNotaRetratoAgalux.rdlc")
            {
                for (int i = 0; i < Dados.Count; i++)
                {
                    Dados[i]["Grupo1"] = objPedido.Items[i].Produto.Grupo1 == null ? "" : objPedido.Items[i].Grupo1Nome;
                    Dados[i]["Grupo2"] = objPedido.Items[i].Produto.Grupo2 == null ? "" : objPedido.Items[i].Grupo2Nome;
                    Dados[i]["Grupo3"] = objPedido.Items[i].Produto.Grupo3 == null ? "" : objPedido.Items[i].Grupo3Nome;
                }

                switch (DestinoImpressao)
                {
                    case DestinoImpressao.Vídeo:
                        Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase(nomerel, "dsImpressaoOrdemServico_RelOrcamento", Dados, GetParametros()) { Text = "Impressão Orçamento" };
                        form.Show();
                        break;
                    case DestinoImpressao.Email:
                        if (String.IsNullOrEmpty(Email) || Email.Trim() == String.Empty)
                            throw new Exception("Não foi informado um email.\nVerifique.");
                        else
                            EnviarEmail(objPedido.Filial, "", Email);
                        break;
                }   
            }

            else
            {
                for (int i = 0; i < Dados.Count; i++)
                {
                    Dados[i]["Grupo1"] = " ";
                    Dados[i]["Grupo2"] = " ";
                    Dados[i]["Grupo3"] = " ";
                }

                switch (DestinoImpressao)
                {
                    case DestinoImpressao.Vídeo:
                        Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase(nomerel, "dsImpressaoOrdemServico_RelOrcamento", Dados, GetParametros()) { Text = "Impressão Orçamento" };
                        form.Show();
                        break;
                    case DestinoImpressao.Email:
                        if (String.IsNullOrEmpty(Email) || Email.Trim() == String.Empty)
                            throw new Exception("Não foi informado um email.\nVerifique.");
                        else
                            EnviarEmail(objPedido.Filial, "", Email);
                        break;
                }   
            }
        }

        private void EnviarEmail(cwkGestao.Modelo.Filial objFilial, string pNomeArquivo, string pEmailCliente)
        {
            try
            {
                SmtpClient cliente = new SmtpClient(objFilial.ServidorSMTP);
                cliente.Credentials = new NetworkCredential(objFilial.UsuarioEmail, objFilial.SenhaEmail);
                MailMessage mensagem = new MailMessage(new MailAddress(objFilial.UsuarioEmail), new MailAddress(pEmailCliente));
                mensagem.Subject = "Orçamento";
                cliente.Port = objFilial.PortaSmtp;

                mensagem.IsBodyHtml = true;
                mensagem.Body = ObservacaoEmail.TrimEnd() + "<br><br>Pedido em anexo";

                Attachment arqPedido = new Attachment(pNomeArquivo);
                mensagem.Attachments.Add(arqPedido);

                cliente.Send(mensagem);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao enviar email.\n", ex);
            }
        }

        public override void Imprimir(bool a) {}
    }
}
