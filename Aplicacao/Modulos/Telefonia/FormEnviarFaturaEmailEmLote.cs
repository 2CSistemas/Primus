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
using System.Threading;

namespace Aplicacao.Modulos.Telefonia
{
    public partial class FormEnviarFaturaEmailEmLote : Form
    {
        private IList<pxyPesquisaTel_Fatura> faturas;
        private IList<Tel_Cliente> clientes;
        private List<pxyPesquisaTel_Fatura> faturasComErro = new List<pxyPesquisaTel_Fatura>();
        private string referencia;
        Filial filial = FilialController.Instancia.GetFilialPrincipal();
        private Thread threadAual = Thread.CurrentThread;

        public FormEnviarFaturaEmailEmLote(IList<pxyPesquisaTel_Fatura> faturas, IList<Tel_Cliente> Clientes, string Referencia)
        {
            InitializeComponent();

            lkpRemessa.Exemplo = new Remessa();
            lkpRemessa.Sessao = cwkGestao.Negocio.RemessaController.Instancia.getSession();

            txtCorpo.EditValue = PegaCorpoTextoEmail(null, null);
            this.faturas = faturas;
            txtRemetente.Text = filial.UsuarioEmail;
            this.clientes = Clientes;
            this.referencia = Referencia;
        }

        public FormEnviarFaturaEmailEmLote(IList<pxyPesquisaTel_Fatura> faturas, IList<Tel_Cliente> Clientes, string Referencia, ref List<pxyPesquisaTel_Fatura> pFaturasComErro)
        {
            InitializeComponent();

            lkpRemessa.Exemplo = new Remessa();
            lkpRemessa.Sessao = cwkGestao.Negocio.RemessaController.Instancia.getSession();

            txtCorpo.EditValue = PegaCorpoTextoEmail(null, null);
            this.faturas = faturas;
            txtRemetente.Text = filial.UsuarioEmail;
            this.clientes = Clientes;
            this.referencia = Referencia;
            this.faturasComErro = pFaturasComErro;
        }

        private string PegaCorpoTextoEmail(Tel_Cliente cliente, string referencia)
        {
            string retorno = "";
            if ((cliente != null) & (referencia != null))
            {
                retorno = "Segue em anexo a Fatura referente a \r\n" +
                          "\tEmpresa: " + cliente.Pessoa.Nome + ",\r\n" +
                          "\tReferência: " + referencia + ",\r\n" +
                          "\tAtenciosamente.  \r\n" +
                          "\t" + filial.Telefone + " - " + filial.Fax + ""; 
            }
            else
            {
                retorno = "Segue em anexo a Fatura referente a \r\n" +
                         "\tEmpresa: ,\r\n" +
                         "\tReferência: ,\r\n" +
                         "\tAtenciosamente.  \r\n" +
                         "\t" + filial.Telefone + " - " + filial.Fax + ""; 
            }

            return retorno;
        }

        private void sbEnviar_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;
            progressBar1.Maximum = faturas.Count;

            sbEnviar.Enabled = false;
            sbCancelar.Enabled = false;
            progressBar1.Visible = true;
            lbPercentagem.Visible = true;

            this.Text = "Por Favor aguarde, os e-mails estão sendo enviados";
            if (CamposValidos())
            {
                Thread t = new Thread(() => EnviarEmailLote(lbPercentagem, txtCorpo.EditValue.ToString(), txtAssunto.EditValue.ToString()));
                t.Start();
            }

        }

        private void EnviarEmailLote(DevExpress.XtraEditors.LabelControl lbl, string corpoEmail, string assuntoEmail)
        {
            int enviados = 0;
            bool retorno = true;
            bool ClientesSemEmail = false;
            string Erro = String.Empty;

            IList<pxyPesquisaTel_Fatura> listaFaturaSelecionada;
            pxyPesquisaTel_Fatura faturaSelecionada;
            List<string> codigosFaturaComErro = new List<string>();

            DateTime dataEnvio;
            Tel_Fatura telFatura = new Tel_Fatura();
            lbl.BeginInvoke(((Action)(() => lbl.Text = enviados.ToString() +
                            " de " + faturas.Count.ToString())));

            if (CamposValidos())
            {
                EnviadorFaturasEmail enviador = new EnviadorFaturasEmail(filial);
                enviador.Remessa = (Remessa)lkpRemessa.Selecionado;

                foreach (var item in clientes)
                {
                    listaFaturaSelecionada = new List<pxyPesquisaTel_Fatura>();
                    try
                    {
                        dataEnvio = DateTime.Now;
                        listaFaturaSelecionada = faturas.Where(c => c.clienteCarregado.ID == item.ID).ToList();
                        faturaSelecionada = faturas.Where(c => c.clienteCarregado.ID == item.ID).ToList().FirstOrDefault();

                        if ((item.Pessoa.PrimeiroEmail(f => f.ID > 0) == null) ||
                       (item.Pessoa.PrimeiroEmail(f => f.ID > 0)) == "")
                        {
                            ClientesSemEmail = true;
                            faturasComErro.AddRange(listaFaturaSelecionada);
                            continue;
                        }

                        corpoEmail = PegaCorpoTextoEmail(item, referencia);

                        enviador.EnviarFaturas(listaFaturaSelecionada, item.Pessoa.PrimeiroEmail(f => f.ID > 0), assuntoEmail, corpoEmail, Tipo, ref retorno);
                        enviados++;
                        if (retorno)
                        {
                            AtualizaTelFatura(ref dataEnvio, ref telFatura, faturaSelecionada);
                        }
                        lbl.BeginInvoke(((Action)(() => lbl.Text = enviados.ToString() +
                            " de " + faturas.Count.ToString())));
                        progressBar1.BeginInvoke(new Action(() => progressBar1.Value = enviados));
                    }
                    catch (Exception)
                    {
                        faturasComErro.AddRange(listaFaturaSelecionada);                        
                    }
                }

            }
            if (faturasComErro.Count > 0)
            {
                Erro = "Algumas remessas não foram emviadas, por favor verifique se existem clientes sem E-mail cadastrado.";
                Erro += Environment.NewLine;
                Erro += "Corrija os problemas e tente novamente.";
                Erro += Environment.NewLine;
                Erro += "As Remessas não enviadas serão filtradas na tela de envio.";
                MessageBox.Show(Erro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            MessageBox.Show("O envio de e-mails terminou.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.BeginInvoke(new Action(() => this.Close()));
        }

        private static void AtualizaTelFatura(ref DateTime dataEnvio, ref Tel_Fatura telFatura, pxyPesquisaTel_Fatura faturaSelecionada)
        {
            faturaSelecionada.dataEnvio = dataEnvio;
            telFatura = Tel_FaturaController.Instancia.LoadObjectById(faturaSelecionada.IdFatura);
            telFatura.DataEnvio = faturaSelecionada.dataEnvio;
            telFatura.bEnviadoEmail = true;
            Tel_FaturaController.Instancia.Salvar(telFatura, Acao.Alterar);
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
