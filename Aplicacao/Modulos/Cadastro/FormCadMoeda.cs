using Aplicacao.Base;
using Aplicacao.IntermediariasTela;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Cadastro
{
    public partial class FormCadMoeda : FormManutMoeda
    {
        private Moeda moeda = null;
        private Acao ac;

        public FormCadMoeda()
        {
            InitializeComponent();
            moeda = new Moeda();
            ac = Acao.Incluir;
        }

        public FormCadMoeda(Moeda _moeda, Acao _ac)
        {
            InitializeComponent();
            moeda = _moeda;
            ac = _ac;
        }

        protected void sbGravar_Click(object sender, EventArgs e)
        {
            try
            {
                moeda.Codigo = Convert.ToInt32(txtCodigo.Text);
                moeda.Descricao = txtDescricao.Text;
                moeda.IDPais = (lkpPais.Selecionado as Pais)?.ID;
        
                if (string.IsNullOrEmpty(moeda.Descricao))
                {
                    MessageBox.Show("A Descrição não pode ser vazia.", "ATENÇÃO");
                    return;
                }
        
                MoedaController.Instancia.Salvar(moeda, ac);
                Selecionado = moeda;
                Close();
            }
            catch (Exception Ex)
            {
                FormErro Form = new FormErro(Ex);
                Form.ShowDialog(this);
            }
        
            //base.sbGravar_Click(sender, e);
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCadMoeda_Shown(object sender, EventArgs e)
        {
            if (moeda == null)
                moeda = new Moeda();

            if (ac == Acao.Incluir)
                moeda.Codigo = MoedaController.Instancia.MaxCodigo();
            
            lkpPais.Exemplo = new Pais();
            lkpPais.Sessao = PaisController.Instancia.getSession();
            lkbPais.SubFormType = typeof(FormPais);

            if (ac == Acao.Consultar)
            {
                txtDescricao.Enabled = false;
                lkbPais.Enabled = false;
                lkpPais.Enabled = false;

                sbGravar.Enabled = false;
            }

            PreencherTela();
            txtDescricao.Focus();
        }

        private void PreencherTela()
        {
            txtCodigo.Text = moeda.Codigo.ToString();
            txtDescricao.Text = moeda.Descricao;

            if (moeda.IDPais.HasValue)
                lkpPais.Localizar(moeda.IDPais.Value);
        }

        private void lkbPais_Click(object sender, EventArgs e)
        {
            try
            {
                GridGenerica<Pais> grid = new GridGenerica<Pais>(PaisController.Instancia.GetAll(), new FormPais(), (Pais)lkpPais.Selecionado, false);
               
                grid.Selecionando = true;
              
                if (cwkControleUsuario.Facade.ControleAcesso(grid))
                    grid.ShowDialog();

                lkpPais.EditValue = grid.Selecionado;
            }
            catch (Exception)
            {

            }
        }

        private void FormCadMoeda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) // Esc
            {
                this.Close();
            }
        }
    }
}
