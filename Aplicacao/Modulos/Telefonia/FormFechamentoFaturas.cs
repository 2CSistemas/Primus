using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Modulos.Financeiro;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Negocio.Telefonia;
using System.Collections.Generic;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Telefonia
{
    public partial class FormFechamentoFaturas : Form
    {
        private bool finalizou;
        private bool contemErros;
        private FechadorFaturas fechador;
        private Thread thread;

        public FormFechamentoFaturas()
        {
            InitializeComponent();
            txtReferencia.EditValue = String.Format("{0:00}/{1:0000}", DateTime.Today.Month, DateTime.Today.Year);
            lblInformacao.Text = String.Empty;
            InicializarLookups();
        }

        private void InicializarLookups()
        {
            lkpGrupoCliente.OnIDChanged += lkpGrupoCliente_IDChanged;
            var sessao = cwkGestao.Negocio.Tel_GrupoClienteController.Instancia.getSession();
            lkpBanco.Sessao = sessao;
            lkpCliente.Sessao = sessao;
            lkpGrupoCliente.Sessao = sessao;
            lkpRemessa.Sessao = sessao;
            lkpBanco.Exemplo = new Banco();
            lkpGrupoCliente.Exemplo = new Tel_GrupoCliente();
            lkpRemessa.Exemplo = new Remessa();
            lkpCliente.Exemplo = new Tel_Cliente();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var param = base.CreateParams;
                param.ClassStyle = param.ClassStyle | 0x200;
                return param;
            }
        }

        private void sbGerar_Click(object sender, EventArgs e)
        {
            if (CamposValidos() && PodeFechar())
            {
                this.Size = new Size(554, 206);
                lblInformacao.Location = new Point(93, sbAjuda.Location.Y + 5);
                lblInformacao.Text = "Fechando faturas...";
                progressBarGravando.Visible = true;
                sbGravar.Enabled = false;
                sbCancelar.Enabled = false;
                xtraTabPage1.Refresh();
                InicializarThread();
                AguardarImportacao();
            }
        }

        private bool CamposValidos()
        {
            dxErrorProvider.ClearErrors();

            if (String.IsNullOrEmpty(txtReferencia.Text))
                dxErrorProvider.SetError(txtReferencia, "Campo obrigatório");

            if (lkpGrupoCliente.Selecionado == null)
                dxErrorProvider.SetError(lkpGrupoCliente, "Campo obrigatório");

            if (lkpBanco.Selecionado == null)
                dxErrorProvider.SetError(lkpBanco, "Campo obrigatório");

            if (lkpRemessa.Selecionado == null)
                dxErrorProvider.SetError(lkpRemessa, "Campo obrigatório");

            return !dxErrorProvider.HasErrors;
        }

        private bool PodeFechar()
        {
            return MessageBox.Show("Deseja fechar as faturas do grupo selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void InicializarThread()
        {
            finalizou = false;
            contemErros = false;
            thread = new Thread(new ThreadStart(Gerar));
            thread.Start();
        }

        private void AguardarImportacao()
        {
            while (!finalizou)
            {
                Thread.Sleep(60);
                Application.DoEvents();
            }

            if (contemErros)
            {
                this.Size = new Size(554, 203);
                lblInformacao.Location = new Point(93, sbAjuda.Location.Y + 5);
                lblInformacao.Text = String.Empty;
                progressBarGravando.Visible = false;
                sbGravar.Enabled = true;
                sbCancelar.Enabled = true;
            }
            else
            {
                Form form = new FormEscolhaBoletos(fechador.GetLogicaBoleto());
                form.Show();
                this.Close();
            }
        }

        private void Gerar()
        {
            try
            {
                fechador = new FechadorFaturas((Tel_GrupoCliente)lkpGrupoCliente.Selecionado, Convert.ToDateTime("01/" + txtReferencia.Text)
                                        , (Banco)lkpBanco.Selecionado, (Remessa)lkpRemessa.Selecionado, (Tel_Cliente)lkpCliente.Selecionado);
                fechador.Fechar();
            }
            catch (Exception ex)
            {
                contemErros = true;
                FormErro.ShowDialog(ex);
            }
            finally
            {
                finalizou = true;
            }
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormFechamentoFaturas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Fechamento Faturas Telefonia");
                    break;
            }
        }

        private void FormFechamentoFaturas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread != null)
                thread.Abort();
        }

        private void lkbGrupoCliente_Click(object sender, EventArgs e)
        {
            Util.LookupUtil.GridLookup<cwkGestao.Modelo.Tel_GrupoCliente>(lkpGrupoCliente, typeof(FormGrupoCliente));
        }

        private void lkbBanco_Click(object sender, EventArgs e)
        {
            Util.LookupUtil.GridLookup<cwkGestao.Modelo.Banco>(lkpBanco, typeof(FormBanco));
        }

        private void lkbRemessa_Click(object sender, EventArgs e)
        {
            Util.LookupUtil.GridLookup<cwkGestao.Modelo.Remessa>(lkpRemessa, typeof(FormRemessa));
        }

        private void sbAjuda_Click(object sender, EventArgs e)
        {
            this.ChamarHelp();
        }

        private void lkbCliente_Click(object sender, EventArgs e)
        {
            if (lkpGrupoCliente.Selecionado != null)
            {
                GridGenerica<Tel_Cliente> grid = new GridGenerica<Tel_Cliente>(Tel_ClienteController.Instancia.GetAllByGrupo((Tel_GrupoCliente)lkpGrupoCliente.Selecionado), new FormTel_Cliente(), (Tel_Cliente)lkpCliente.Selecionado, false);
                grid.Selecionando = true;
                if (cwkControleUsuario.Facade.ControleAcesso(grid))
                    grid.ShowDialog();
                if (grid.Selecionado != null)
                    lkpCliente.EditValue = grid.Selecionado;
                lkpCliente.Focus();
            }
            else
                MessageBox.Show("Selecione um grupo antes de selecionar o cliente.");
        }

        private void lkpGrupoCliente_IDChanged(object sender, EventArgs e)
        {
            if (lkpGrupoCliente.Selecionado != null)
            {
                var grupo = ((Tel_GrupoCliente)lkpGrupoCliente.Selecionado);
                lkpCliente.Exemplo = new Tel_Cliente { GrupoCliente = new Tel_GrupoCliente { ID = grupo.ID } };
                lkpCliente.CamposRestricoesAND = new List<string> { "GrupoCliente.ID" };
            }
        }
    }
}
