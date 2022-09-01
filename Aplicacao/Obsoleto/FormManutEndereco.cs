using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aplicacao
{
    public partial class FormManutEndereco : Form
    {
        Modelo.DataClassesDataContext db;
        Modelo.Endereco endereco;
        Modelo.Pessoa pessoa;
        Aplicacao.FormManutPes formPessoa;
        Modelo.Cidade objCidade = new Modelo.Cidade();

        //Variável da Acao da Tela
        int acao;

        public FormManutEndereco(int pAcao, int pSequencia, Modelo.DataClassesDataContext pDb, Modelo.Pessoa pPessoa, Aplicacao.FormManutPes bForm)
        {
            InitializeComponent();
            this.acao = pAcao;
            db = pDb;
            pessoa = pPessoa;
            formPessoa = bForm;

            cbCidade.Properties.DataSource = objCidade.getListaCombo(db);
            cbCidade.Properties.DisplayMember = "Nome";
            cbCidade.Properties.ValueMember = "ID";

            if (pSequencia != 0)
            {

                endereco = pessoa.Enderecos.Where(e => e.Sequencia == pSequencia).Single();
                txtEnd.Text = endereco.Rua;
                txtBairro.Text = endereco.Bairro;
                txtCEP.Text = endereco.CEP;
                cbCidade.EditValue = endereco.IDCidade;
                txtDesc.Text = endereco.Descricao;
                txtTelefone.Text = endereco.Telefone;
                txtContato.Text = endereco.Contato;
                txtNumero.Text = endereco.Numero;
                txtComplemento.EditValue = endereco.Complemento;

                if (endereco.bAtivo == 1)
                {
                    chbAtivo.Checked = true;
                }
                if (endereco.bCobranca == 1)
                {
                    chbCobranca.Checked = true;
                }
                if (endereco.bEntrega == 1)
                {
                    chbEntrega.Checked = true;
                }
                if (endereco.bPrincipal == 1)
                {
                    chbPrincipal.Checked = true;
                }
                //TODO: Caso tenha Grid dentro do Form é neste ponto que faz a atribuição do Objeto do linq par ao Grid
                this.Text = "Alterando registro de Endereço";
                if (acao == 3)
                {
                    if (endereco.ID == 0)
                    {
                        //db.Enderecos.Attach(endereco);
                    }
                    foreach (Control campo in this.Controls)
                    {
                        if ((campo is TextBox) || (campo is ComboBox) || (campo is GroupBox))
                        {
                            campo.Enabled = false;
                        }
                    }
                    this.Text = "Excluindo registro de Endereço";
                    btGravar.Text = "      &OK";
                }
                else
                {
                    if (acao == 4)
                    {
                        this.Text = "Consultando registro de Endereço";
                        btGravar.Enabled = false;
                        btGravar.Visible = false;
                    }
                }
            }
            else
            {
                this.Text = "Incluindo registro de Endereço";
                endereco = new Modelo.Endereco();
                endereco.Sequencia = endereco.RetornaMAXSequencia(pessoa);
                cbCidade.EditValue = 0;
                chbAtivo.Checked = true;
            }
        }

        /// <summary>
        /// Método que valida todos os controles de um conjunto de controles
        /// </summary>
        /// <param name="bControls">conjunto de controles</param>
        public void validaTudo(Control.ControlCollection bControls)
        {
            string bErrorText = "";
            foreach (Control ctrl in bControls)
            {
                ctrl.Refresh();
                if ((ctrl is GroupBox) || (ctrl is TabControl) || (ctrl is TabPage))
                {
                    validaTudo(ctrl.Controls);
                }
                else
                {
                    if (errorProvider1.GetError(ctrl) != "")
                    {
                        bErrorText = errorProvider1.GetError(ctrl);
                        ctrl.Focus();
                        throw new Exception(bErrorText);
                    }
                }
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (acao != 3)
                {
                    if (endereco.Valida(errorProvider1, this.Controls, true) == false)
                    {
                        throw new Exception("Verificar Anomalias");
                    }
                }

                endereco.Rua = txtEnd.Text;
                endereco.Bairro = txtBairro.Text;
                endereco.CEP = txtCEP.Text;
                endereco.IDCidade = (int)cbCidade.EditValue;
                endereco.Descricao = txtDesc.Text;
                endereco.Telefone = txtTelefone.Text;
                endereco.Contato = txtContato.Text;
                endereco.Numero = txtNumero.Text;
                endereco.Complemento = txtComplemento.Text;

                if (chbAtivo.Checked)
                {
                    endereco.bAtivo = 1;
                }
                else
                {
                    endereco.bAtivo = 0;
                }

                if (chbCobranca.Checked)
                {
                    try
                    {
                        var endCobranca = pessoa.Enderecos.Where(b => b.bCobranca == 1);

                        foreach (Modelo.Endereco end in endCobranca)
                        {
                            if (end.bCobranca == 1)
                            {
                                end.bCobranca = 0;
                            }
                        }
                    }
                    finally
                    {
                        endereco.bCobranca = 1;
                        formPessoa.bCobranca = true;
                    }
                }
                else
                {
                    formPessoa.bCobranca = false;
                    
                        endereco.bCobranca = 0;
                    
                }

                if (chbEntrega.Checked)
                {
                    endereco.bEntrega = 1;
                }
                else
                {
                    endereco.bEntrega = 0;
                }

                if (chbPrincipal.Checked)
                {
                    try
                    {
                        Modelo.Endereco end = pessoa.Enderecos.Where(b => b.bPrincipal == 1).Single();
                        end.bPrincipal = 0;
                    }
                    finally
                    {
                        endereco.bPrincipal = 1;
                    }
                }
                else
                {
                    endereco.bPrincipal = 0;
                }

                if (acao == 1)
                {
                    pessoa.Enderecos.Add(endereco);
                }
                if (acao == 3)
                {
                    if (endereco.ID != 0)
                    {
                        db.Enderecos.DeleteOnSubmit(endereco);
                    }
                    pessoa.Enderecos.Remove(endereco);
                }
                this.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(Modelo.MetodosEstaticos.SqlExcecao(ex), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adCidade_Click(object sender, EventArgs e)
        {
            cwkGestao.Modelo.Cidade CidadeSelecionada = null;
            int id = (int)cbCidade.EditValue;
            if (id > 0)
                CidadeSelecionada = cwkGestao.Negocio.CidadeController.Instancia.LoadObjectById(id);
            GridGenerica<cwkGestao.Modelo.Cidade> grid = new GridGenerica<cwkGestao.Modelo.Cidade>(cwkGestao.Negocio.CidadeController.Instancia.GetAll(), new FormCidade(), CidadeSelecionada, false);
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            {
                grid.Selecionando = true;
                grid.ShowDialog();
                if (grid.Selecionado != null)
                {
                    cbCidade.Properties.DataSource = objCidade.getListaCombo(db);
                    cbCidade.EditValue = grid.Selecionado.ID;
                }
            }
        }

        /// <summary>
        /// Método que chama o grid para selecionar um elemento
        /// </summary>
        /// <param name="ptitulo">Título do grid</param>
        /// <param name="pCb">combobox que irá chamar o grid</param>
        /// <param name="gl">objeto que irá retornar a lista para preencher o combo</param>
        private void GridSelecao(string ptitulo, Componentes.devexpress.cwk_DevLookup pCb, Modelo.IMetodosCwork gl)
        {
            GridPadrao pGp = new GridPadrao(ptitulo, true, (int)pCb.EditValue);
            if (cwkControleUsuario.Facade.ControleAcesso(pGp))
            {
                pGp.ShowDialog();
                if (pGp.atualiza == true)
                {
                    pCb.Properties.DataSource = gl.getListaCombo(db);
                }
                if (pGp.Retorno.Length != 0)
                {
                    pCb.EditValue = int.Parse(pGp.Retorno);
                }
            }
            pCb.Focus();
        }

        private void cbEntrega_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEntrega.Checked)
            {
                txtTelefone.Enabled = true;
                txtContato.Enabled = true;
            }
            else
            {
                txtTelefone.Enabled = false;
                txtContato.Enabled = false;
            }
        }

        private void txtEnd_Validating(object sender, CancelEventArgs e)
        {
            validateTxtEnd();
        }

        private void txtNumero_Validating(object sender, CancelEventArgs e)
        {
            validateTxtNumero();
        }

        private void txtBairro_Validating(object sender, CancelEventArgs e)
        {
            validateTxtBairro();
        }

        public bool validateTxtBairro()
        {
            bool bStatus = true;
            if (String.IsNullOrEmpty(txtBairro.Text))
            {
                errorProvider1.SetError(txtBairro, "Preencha o bairro.");
                bStatus = false;
            }
            else
            {
                errorProvider1.SetError(txtBairro, "");
            }
            return bStatus;
        }

        public bool validateTxtNumero()
        {
            bool bStatus = true;
            if (String.IsNullOrEmpty(txtNumero.Text))
            {
                errorProvider1.SetError(txtNumero, "Preencha o número.");
                bStatus = false;
            }
            else
            {
                errorProvider1.SetError(txtNumero, "");
            }
            return bStatus;
        }

        public bool validateTxtEnd()
        {
            bool bStatus = true;
            if (String.IsNullOrEmpty(txtEnd.Text))
            {
                errorProvider1.SetError(txtEnd, "Preencha o endereço.");
                bStatus = false;
            }
            else
            {
                errorProvider1.SetError(txtEnd, "");
            }
            return bStatus;
        }

        private void FormManutEndereco_Load(object sender, EventArgs e)
        {
            if (chbEntrega.Checked)
            {
                txtTelefone.Enabled = true;
                txtContato.Enabled = true;
            }
            else
            {
                txtTelefone.Enabled = false;
                txtContato.Enabled = false;
            }
        }

        private void FormManutEndereco_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F9:
                    if (acao != 4)
                    {
                        btSalvar_Click(sender, e);
                    }
                    break;
                case Keys.Escape:
                    btCancelar_Click(sender, e);
                    break;
            }
        }

    }
}
