using Aplicacao.Base;
using Aplicacao.IntermediariasTela;
using Aplicacao.Modulos.Comercial;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Cadastro
{
    public partial class FormCotacaoDeMoedas : FormManutCotacaoMoeda
    {
        private CotacaoMoeda cotacaoMoeda = null;
        private Acao ac;

        public FormCotacaoDeMoedas()
        {
            InitializeComponent();
            ac = Acao.Incluir;
            cotacaoMoeda = null;
        }

        public FormCotacaoDeMoedas(CotacaoMoeda _cotacaoMoeda, Acao _ac)
        {
            InitializeComponent();
            cotacaoMoeda = _cotacaoMoeda;
            ac = _ac;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCotacaoDeMoedas_Shown(object sender, EventArgs e)
        {
            if (cotacaoMoeda == null)
                cotacaoMoeda = new CotacaoMoeda();

            if (ac == Acao.Incluir)
                cotacaoMoeda.Codigo = CotacaoMoedaController.Instancia.MaxCodigo();

            lkpMoeda.Exemplo = new Moeda();
            lkpMoeda.Sessao = MoedaController.Instancia.getSession();
            lkbMoeda.SubFormType = typeof(FormCadMoeda);

            if (ac == Acao.Consultar)
            {
                txtDataCotacao.Enabled = false;
                lkbMoeda.Enabled = false;
                lkpMoeda.Enabled = false;

                sbGravar.Enabled = false;
            }

            InicializarCamposValor();
            PreencherTela();
            txtDataCotacao.Focus();
        }

        private void InicializarCamposValor()
        {
            txtValorCompra.EditValue = Convert.ToDecimal(0.01);
            txtValorCotacao.EditValue = Convert.ToDecimal(0.01);
            txtValorVenda.EditValue = Convert.ToDecimal(0.01);
        }

        private void PreencherTela()
        {
            txtCodigo.Text = cotacaoMoeda.Codigo.ToString();
            txtDataCotacao.Text = cotacaoMoeda.DataCotacao?.ToString();

            if (cotacaoMoeda.IDMoeda.HasValue)
                lkpMoeda.Localizar(cotacaoMoeda.IDMoeda.Value);

            InicializarCamposValor();

            txtValorCompra.EditValue = cotacaoMoeda.ValorCompra;
            txtValorCotacao.EditValue = cotacaoMoeda.ValorCotacao;
            txtValorVenda.EditValue = cotacaoMoeda.ValorVenda;

            chbHabilitaCotacao.Checked = cotacaoMoeda.HabilitaCotacao == 1;
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDataCotacao.EditValue == null)
                {
                    MessageBox.Show("Informe a Data da Cotação.", "ATENÇÃO");
                    return;
                }

                if (lkpMoeda.Selecionado == null)
                {
                    MessageBox.Show("Informe a Moeda.", "ATENÇÃO");
                    return;
                }

                cotacaoMoeda.Codigo = Convert.ToInt32(txtCodigo.Text);
                cotacaoMoeda.DataCotacao = txtDataCotacao.DateTime;
                cotacaoMoeda.IDMoeda = (lkpMoeda.Selecionado as Moeda)?.ID;

                cotacaoMoeda.ValorCompra = Convert.ToDecimal(txtValorCompra.EditValue);
                cotacaoMoeda.ValorCotacao = Convert.ToDecimal(txtValorCotacao.EditValue);
                cotacaoMoeda.ValorVenda = Convert.ToDecimal(txtValorVenda.EditValue);

                cotacaoMoeda.HabilitaCotacao = chbHabilitaCotacao.Checked ? 1 : 0;


                CotacaoMoedaController.Instancia.Salvar(cotacaoMoeda, ac);
                Close();
            }
            catch (Exception Ex)
            {
                FormErro Form = new FormErro(Ex);
                Form.ShowDialog();
            }

            base.sbGravar_Click(sender, e);
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lkbMoeda_Click(object sender, EventArgs e)
        {
            try
            {
                GridMoeda grid = new GridMoeda(true, this);
                grid.Show();
                
            }
            catch (Exception)
            {
            }
        }

        public void SelecionarMoeda(Moeda moeda)
        {
            lkpMoeda.EditValue = moeda;
        }

        private void FormCotacaoDeMoedas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) // Esc
            {
                this.Close();
            }
        }
    }
}