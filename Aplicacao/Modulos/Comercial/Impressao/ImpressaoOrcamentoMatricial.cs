using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Negocio.RelatoriosMatriciais;
using Aplicacao.Base;

namespace Aplicacao.Modulos.Comercial.Impressao
{
    public class ImpressaoOrcamentoMatricial : ImpressaoOrcamento
    {
        public ImpressaoOrcamentoMatricial(cwkGestao.Modelo.Pedido objPedido) : base(objPedido) { }

        private OrcamentoMatricial orcamentoMatricial;
        private Aplicacao.InputBox input = new Aplicacao.InputBox();
        private string email;
        private string observacaoEmail;

        public override void Imprimir()
        {
            try
            {
                orcamentoMatricial = new OrcamentoMatricial();
                orcamentoMatricial.DestinoImpressao = new Aplicacao.DestinoImpressaoPedido().ShowDialog();
                if (orcamentoMatricial.DestinoImpressao == cwkGestao.Modelo.DestinoImpressao.Email)
                {
                    email = String.Empty;
                    observacaoEmail = String.Empty;
                    var pessoaEmails = objPedido.Pessoa.PessoaEmails.OrderByDescending(p => p.BVenda);
                    if (pessoaEmails != null && pessoaEmails.Count() > 0)
                        email = pessoaEmails.First().Email;
                    if (!ColetarDadosEmail())
                        return;
                    orcamentoMatricial.Email = email;
                    orcamentoMatricial.ObservacaoEmail = observacaoEmail;
                }


                orcamentoMatricial.ImprimePedidoMatricial(objPedido, 16);
            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
        }

        public bool ColetarDadosEmail()
        {
            if (!input.Show(email, "Email da Pessoa", out email))
                return false;
            if (!input.Show(String.Empty, "Observação Email", out observacaoEmail))
                return false;

            return true;
        }

        public override void Imprimir(bool a) {}
    }
}
