using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aplicacao.Base;
using cwkGestao.Modelo;

namespace Aplicacao.Modulos.Comercial.Impressao
{
    public class ImpressaoOrcamentoNaoMatriciais
    {
        private Aplicacao.InputBox input = new Aplicacao.InputBox();
        private string email;
        private string observacaoEmail;

        public ImpressaoOrcamentoNaoMatriciais(ImpressaoOrcamentoMulti _Impressao, Pedido ObjPedido) 
        {
           Imprimir(_Impressao, ObjPedido);
        }

        public bool ColetarDadosEmail(ImpressaoOrcamentoMulti Impressao)
        {
            if (!input.Show(email, "Email da Pessoa", out email) && !input.confirmado)
            {
                Impressao.EnvioEmailCancelado = true;
                return false;
            }
            if (!input.Show(String.Empty, "Observação Email", out observacaoEmail))
                return false;

            return true;
        }

        public void Imprimir(ImpressaoOrcamentoMulti Impressao, Pedido ObjPedido)
        {
            try
            {
                Impressao.DestinoImpressao = new Aplicacao.DestinoImpressaoPedido(0).ShowDialog();
                
                if (Impressao.DestinoImpressao == cwkGestao.Modelo.DestinoImpressao.Email)
                {
                    email = String.Empty;
                    observacaoEmail = String.Empty;
                    var pessoaEmails = ObjPedido.Pessoa.PessoaEmails.OrderByDescending(p => p.BVenda);
                    if (pessoaEmails != null && pessoaEmails.Count() > 0)
                        email = pessoaEmails.First().Email;
                    if (!ColetarDadosEmail(Impressao))
                        return;
                    Impressao.Email = email;
                    Impressao.ObservacaoEmail = observacaoEmail;
                }
            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
        }
    }
}
