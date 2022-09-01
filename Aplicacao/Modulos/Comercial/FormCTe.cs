using System;
using System.Windows.Forms;
using Aplicacao.Base;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using EnvDTE;
using Relatorio;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormCTe : Form
    {
        public FormCTe()
        {
            InitializeComponent();
        }

        private void FormCTe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) // Esc
                Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lkbPessoa_Click(object sender, EventArgs e)
        {
            try
            {
                GridGenerica<Pessoa> grid = new  GridGenerica<Pessoa>(PessoaController.Instancia.GetAll(),new FormPessoa(), (Pessoa)lkpPessoa.Selecionado, false);
                grid.Selecionando = true;

                if (cwkControleUsuario.Facade.ControleAcesso(grid))
                    grid.ShowDialog();

                lkpPessoa.EditValue = grid.Selecionado;
            }
            catch (Exception ex)
            {
           
            }
        }

        private void lkbCondicao_Click(object sender, EventArgs e)
        {
            try
            {
                GridGenerica<Condicao> grid = new  GridGenerica<Condicao>(CondicaoController.Instancia.GetAll(),new FormCondicao(), (Condicao)lkpCondicao.Selecionado, false);
                grid.Selecionando = true;

                if (cwkControleUsuario.Facade.ControleAcesso(grid))
                    grid.ShowDialog();

                lkpCondicao.EditValue = grid.Selecionado;
            }
            catch (Exception Ex)
            {
           
            }
        }

        private void lkbFilial_Click(object sender, EventArgs e)
        {
            try
            {
                GridGenerica<Filial> grid = new GridGenerica<Filial>(FilialController.Instancia.GetAll(), new  FormFilial(), (Filial)lkpFilial.Selecionado, false);
                grid.Selecionando = true;

                if (cwkControleUsuario.Facade.ControleAcesso(grid))
                    grid.ShowDialog();

                lkpFilial.EditValue = grid.Selecionado;
            }
            catch (Exception ex)
            {
             
            }
        }

        private void lkbCFOP_Click(object sender, EventArgs e)
        {
            try
            {
                GridGenerica<TabelaCFOP> grid = new GridGenerica<TabelaCFOP>(TabelaCFOPController.Instancia.GetAll(), new FormTabelaCFOP(),(TabelaCFOP)lkpCFOP.Selecionado, false);
                grid.Selecionando = true;

                lkpCFOP.EditValue = grid.Selecionado;
            }
            catch (Exception ex)
            {
                
            }
        }

        private void txtValorServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Program.FormataTextBoxDecimal
        }
    }
}
