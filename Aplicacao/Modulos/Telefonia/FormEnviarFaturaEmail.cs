using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Proxy;
using System.IO;
using System.Diagnostics;
using cwkGestao.Negocio;
using Aplicacao.Modulos.Telefonia.Impressao;
using Aplicacao.Util;

namespace Aplicacao.Modulos.Telefonia
{
    public partial class FormEnviarFaturaEmail : Form
    {
        private IList<pxyPesquisaTel_Fatura> faturas;
        Filial filial = FilialController.Instancia.GetFilialPrincipal();

        public FormEnviarFaturaEmail(IList<pxyPesquisaTel_Fatura> faturas, Tel_Cliente Cliente)
        {
            InitializeComponent();
            lkpRemessa.Exemplo = new Remessa();
            lkpRemessa.Sessao = cwkGestao.Negocio.RemessaController.Instancia.getSession();

            this.faturas = faturas;
            txtRemetente.Text = filial.UsuarioEmail;
            txtDestinatario.Text = Cliente.Pessoa.PrimeiroEmail(f=> f.ID > 0);

            foreach (var item in faturas)
            {
                txtCorpo.Text = "Segue em anexo a Fatura referente a \r\n" +
               "\tEmpresa: " + Cliente.Fantasia + ",\r\n" +
               "\tReferência: " + item.Referencia +",\r\n" +
               "\tAtenciosamente. \r\n" +
               "\t" + filial.Telefone + " - " + filial.Fax + ""; 
            }
                      
        }

        private void sbEnviar_Click(object sender, EventArgs e)
        {
            bool retorno = true;
            DateTime dataEnvio = DateTime.Now;
            Tel_Fatura telFatura = new Tel_Fatura();
            if (CamposValidos())
            {                
                EnviadorFaturasEmail enviador = new EnviadorFaturasEmail(filial);
                enviador.Remessa = (Remessa)lkpRemessa.Selecionado;
                try
                {
                    enviador.EnviarFaturas(faturas, txtDestinatario.Text, txtAssunto.Text, txtCorpo.Text, Tipo, ref retorno);
                    if (retorno)
                    {
                        foreach (var itemFatura in faturas)
                        {
                            itemFatura.dataEnvio = dataEnvio;
                            telFatura = Tel_FaturaController.Instancia.LoadObjectById(itemFatura.IdFatura);
                            telFatura.DataEnvio = itemFatura.dataEnvio;
                            telFatura.bEnviadoEmail = true;
                            Tel_FaturaController.Instancia.Salvar(telFatura, Acao.Alterar);
                        }
                        MessageBox.Show("Email enviado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception (ex.Message);
                }
                this.Close();
            }
        }

        private ImpressaoFatura.TipoImpressaoFatura Tipo
        {
            get
            {
                return (ImpressaoFatura.TipoImpressaoFatura)cbTipo.SelectedIndex;
            }
        }

        private bool CamposValidos()
        {
            dxErrorProvider1.ClearErrors();

            if (txtRemetente.Text == String.Empty)
                dxErrorProvider1.SetError(txtRemetente, "Preencha remetente");
            if (txtDestinatario.Text == String.Empty)
                dxErrorProvider1.SetError(txtDestinatario, "Preencha destinatario");
            if (txtAssunto.Text == String.Empty)
                dxErrorProvider1.SetError(txtAssunto, "Preencha assunto");
            if (txtCorpo.Text == String.Empty)
                dxErrorProvider1.SetError(txtCorpo, "Preencha corpo do email");

            if (cbTipo.SelectedIndex > 1 && lkpRemessa.Selecionado == null)
                dxErrorProvider1.SetError(lkpRemessa, "Selecione a remessa");

            return !dxErrorProvider1.HasErrors;
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sbAjuda_Click(object sender, EventArgs e)
        {
            this.ChamarHelp();
        }

        private void lkbRemessa_Click(object sender, EventArgs e)
        {
            Util.LookupUtil.GridLookup<cwkGestao.Modelo.Remessa>(lkpRemessa, typeof(FormRemessa));
        }
    }
}
