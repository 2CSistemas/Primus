using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Telefonia;

namespace Aplicacao.Modulos.Telefonia
{
    public partial class FormGeracaoFaturas : Form
    {
        private bool finalizou;
        private bool contemErros;
        private GeradorFaturas gerador;
        private Thread thread;

        public FormGeracaoFaturas()
        {
            InitializeComponent();
            txtReferencia.EditValue = String.Format("{0:00}/{1:0000}", DateTime.Today.Month, DateTime.Today.Year);
            lblInformacao.Text = String.Empty;
            lkpGrupoCliente.Exemplo = new cwkGestao.Modelo.Tel_GrupoCliente();
            lkpGrupoCliente.Sessao = cwkGestao.Negocio.Tel_GrupoClienteController.Instancia.getSession();
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
            if (CamposValidos() && TiposLigacaoOk() && PodeImportar())
            {
                MostrarProgressBarELabelInformacao();
                HabilitarFiltros(false);
                xtraTabPage1.Refresh();
                InicializarThread();
                AguardarImportacao();
            }
        }

        private bool TiposLigacaoOk()
        {
            var cadastrosIncompletos = Tel_TipoLigacaoController.Instancia.GetIncompletos();
            if (cadastrosIncompletos.Count == 0) return true;
            MessageBox.Show(@"Existem cadastros de tipo de ligação incompletos. Finalize o preenchimento deles (resumo fatura e preços) antes de gerar as faturas.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            var grid = new GridGenerica<Tel_TipoLigacao>(cadastrosIncompletos, new FormTel_TipoLigacao(), false);
            grid.ShowDialog();
            return (Tel_TipoLigacaoController.Instancia.GetIncompletos().Count == 0);
        }

        private void HabilitarFiltros(bool hab)
        {
            lkpGrupoCliente.Enabled = hab;
            lkbGrupoCliente.Enabled = hab;
            txtDataInicial.Enabled = hab;
            txtDataFinal.Enabled = hab;
            txtReferencia.Enabled = hab;
            txtVencimento.Enabled = hab;
            sbGerar.Enabled = hab;
            sbCancelar.Enabled = hab;
        }

        private void MostrarProgressBarELabelInformacao()
        {
            this.Size = new Size(636, 181);
            lblInformacao.Location = new Point(93, sbAjuda.Location.Y + 5);
            lblInformacao.Text = "Gerando faturas...";
            progressBarGravando.Visible = true;
        }

        private bool CamposValidos()
        {
            dxErrorProvider.ClearErrors();

            if (lkpGrupoCliente.Selecionado == null)
                dxErrorProvider.SetError(lkpGrupoCliente, "Campo obrigatório");

            if (String.IsNullOrEmpty(txtReferencia.Text))
                dxErrorProvider.SetError(txtReferencia, "Campo obrigatório");

            if (txtDataInicial.EditValue == null)
                dxErrorProvider.SetError(txtDataInicial, "Campo obrigatório");

            if (txtDataFinal.EditValue == null)
                dxErrorProvider.SetError(txtDataFinal, "Campo obrigatório");

            if (txtVencimento.EditValue == null)
                dxErrorProvider.SetError(txtVencimento, "Campo obrigatório");

            return !dxErrorProvider.HasErrors;
        }

        private bool PodeImportar()
        {
            return MessageBox.Show("Deseja gerar as faturas para o grupo selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
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
                EsconderProgressBarELabelInformacao();
                HabilitarFiltros(true);
            }
            else
            {
                MessageBox.Show("Faturas geradas com sucesso.");
                this.Dispose();
            }
        }

        private void EsconderProgressBarELabelInformacao()
        {
            this.Size = new Size(636, 147);
            lblInformacao.Location = new Point(93, sbAjuda.Location.Y + 5);
            lblInformacao.Text = String.Empty;
            progressBarGravando.Visible = false;
        }

        private void Gerar()
        {
            try
            {
                gerador = new GeradorFaturas((Tel_GrupoCliente)lkpGrupoCliente.Selecionado, txtReferencia.Text, txtDataInicial.DateTime, txtDataFinal.DateTime, txtVencimento.DateTime);
                gerador.GerarESalvarFaturas();
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

        private void FormGeracaoFaturas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Geração Faturas Telefonia");
                    break;
            }
        }

        private void FormGeracaoFaturas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread != null)
                thread.Abort();
        }

        private void lkbGrupoCliente_Click(object sender, EventArgs e)
        {
            Util.LookupUtil.GridLookup<cwkGestao.Modelo.Tel_GrupoCliente>(lkpGrupoCliente, typeof(FormGrupoCliente));
        }

        private void sbAjuda_Click(object sender, EventArgs e)
        {
            this.ChamarHelp();
        }
    }
}
