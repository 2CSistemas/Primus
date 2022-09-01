using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicaçãoPrimus.BancoDados;
using AplicaçãoPrimus.model;


namespace AplicaçãoPrimus
{
    public partial class FormProdutosFavoritos : Form
    {
        int produtoSelecionado = 0;
        produto objProduto = new produto();
        dbProduto tbProduto = new dbProduto();
        List<produtosFavoritos> ProdutoList = new List<produtosFavoritos>();
        produtosFavoritos modFavoritos = new produtosFavoritos();
        public FormProdutosFavoritos()
        {
            InitializeComponent();
            carregarGrid();
            IniciarProdutosFavoritos();
        }
        private void IniciarProdutosFavoritos()
        {
            DataTable dados = new DataTable();
            dados = tbProduto.selecionarProdutoFavorito("", 0);
            
            ProdutoList = (from DataRow dr in dados.Rows
                           select new produtosFavoritos()
                           {
                               ID = Convert.ToInt32(dr["ID"]),
                               ID_Produto = Convert.ToInt32(dr["ID_Produto"]),
                               Nome = Convert.ToString(dr["Nome"]),
                               CaminhoImagem = Convert.ToString(dr["CaminhoImagem"]),

                           }).ToList();
            try            {
                btnProduto01.Text = ProdutoList[0].Nome;
                btnProduto01.BackgroundImage = Image.FromFile(@"" + ProdutoList[0].CaminhoImagem);

                btnProduto02.Text = ProdutoList[1].Nome;
                btnProduto02.BackgroundImage = Image.FromFile(@"" + ProdutoList[1].CaminhoImagem);

                btnProduto03.Text = ProdutoList[2].Nome;
                btnProduto03.BackgroundImage = Image.FromFile(@"" + ProdutoList[2].CaminhoImagem);

                btnProduto04.Text = ProdutoList[3].Nome;
                btnProduto04.BackgroundImage = Image.FromFile(@"" + ProdutoList[3].CaminhoImagem);

                btnProduto05.Text = ProdutoList[4].Nome;
                btnProduto05.BackgroundImage = Image.FromFile(@"" + ProdutoList[4].CaminhoImagem);

                btnProduto06.Text = ProdutoList[5].Nome;
                btnProduto06.BackgroundImage = Image.FromFile(@"" + ProdutoList[5].CaminhoImagem);

                btnProduto07.Text = ProdutoList[6].Nome;
                btnProduto07.BackgroundImage = Image.FromFile(@"" + ProdutoList[6].CaminhoImagem);

                btnProduto08.Text = ProdutoList[7].Nome;
                btnProduto08.BackgroundImage = Image.FromFile(@"" + ProdutoList[7].CaminhoImagem);

                btnProduto09.Text = ProdutoList[8].Nome;
                btnProduto09.BackgroundImage = Image.FromFile(@"" + ProdutoList[8].CaminhoImagem);
            }           catch (Exception e)            {            }
        }
        private void FormProdutosFavoritos_Load(object sender, EventArgs e)
        {
            panelSeletor.Visible = true;
            panelSeletor.Dock = DockStyle.Fill;
            painelGrideSelecao.Visible = false;
            painelGrideSelecao.Dock = DockStyle.Fill;
            panelCampos.Visible = false;
            panelCampos.Dock = DockStyle.Fill;
        }
        public void carregarGrid()
        {
            DataTable dados = new DataTable();
            dados = tbProduto.selecionar("", 0);
            dataGridViewProduto.DataSource = dados;
            dataGridViewProduto.Columns[0].Visible = false;
            dataGridViewProduto.Columns[2].Visible = false;
            int cont = 4;
            while (cont <118) {
                dataGridViewProduto.Columns[cont].Visible = false;
                cont++;
            }
         }

        private void btnProduto1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente mudar o produto favorito da posição 01", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                panelSeletor.Visible = false;
                panelSeletor.Dock = DockStyle.Fill;
                painelGrideSelecao.Visible = true;
                painelGrideSelecao.Dock = DockStyle.Fill;
                panelCampos.Visible = false;
                panelCampos.Dock = DockStyle.Fill;
                ///////////////////////
                produtoSelecionado = 1;
                panelSeletor.Visible = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnProduto2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente mudar o produto favorito da posição 01", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                panelSeletor.Visible = false;
                panelSeletor.Dock = DockStyle.Fill;
                painelGrideSelecao.Visible = true;
                painelGrideSelecao.Dock = DockStyle.Fill;
                panelCampos.Visible = false;
                panelCampos.Dock = DockStyle.Fill;
                ///////////////////////
                produtoSelecionado = 2;
                panelSeletor.Visible = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnProduto3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente mudar o produto favorito da posição 01", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                panelSeletor.Visible = false;
                panelSeletor.Dock = DockStyle.Fill;
                painelGrideSelecao.Visible = true;
                painelGrideSelecao.Dock = DockStyle.Fill;
                panelCampos.Visible = false;
                panelCampos.Dock = DockStyle.Fill;
                ///////////////////////
                produtoSelecionado = 3;
                panelSeletor.Visible = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnProduto4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente mudar o produto favorito da posição 01", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                panelSeletor.Visible = false;
                panelSeletor.Dock = DockStyle.Fill;
                painelGrideSelecao.Visible = true;
                painelGrideSelecao.Dock = DockStyle.Fill;
                panelCampos.Visible = false;
                panelCampos.Dock = DockStyle.Fill;
                ///////////////////////
                produtoSelecionado = 4;
                panelSeletor.Visible = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnProduto5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente mudar o produto favorito da posição 01", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                panelSeletor.Visible = false;
                panelSeletor.Dock = DockStyle.Fill;
                painelGrideSelecao.Visible = true;
                painelGrideSelecao.Dock = DockStyle.Fill;
                panelCampos.Visible = false;
                panelCampos.Dock = DockStyle.Fill;
                ///////////////////////
                produtoSelecionado = 5;
                panelSeletor.Visible = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnProduto6_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente mudar o produto favorito da posição 01", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                panelSeletor.Visible = false;
                panelSeletor.Dock = DockStyle.Fill;
                painelGrideSelecao.Visible = true;
                painelGrideSelecao.Dock = DockStyle.Fill;
                panelCampos.Visible = false;
                panelCampos.Dock = DockStyle.Fill;
                ///////////////////////
                produtoSelecionado = 6;
                panelSeletor.Visible = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnProduto7_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente mudar o produto favorito da posição 01", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                panelSeletor.Visible = false;
                panelSeletor.Dock = DockStyle.Fill;
                painelGrideSelecao.Visible = true;
                painelGrideSelecao.Dock = DockStyle.Fill;
                panelCampos.Visible = false;
                panelCampos.Dock = DockStyle.Fill;
                ///////////////////////
                produtoSelecionado = 7;
                panelSeletor.Visible = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnProduto8_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente mudar o produto favorito da posição 01", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                panelSeletor.Visible = false;
                panelSeletor.Dock = DockStyle.Fill;
                painelGrideSelecao.Visible = true;
                painelGrideSelecao.Dock = DockStyle.Fill;
                panelCampos.Visible = false;
                panelCampos.Dock = DockStyle.Fill;
                ///////////////////////
                produtoSelecionado = 8;
                panelSeletor.Visible = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnProduto9_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente mudar o produto favorito da posição 01", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                panelSeletor.Visible = false;
                panelSeletor.Dock = DockStyle.Fill;
                painelGrideSelecao.Visible = true;
                painelGrideSelecao.Dock = DockStyle.Fill;
                panelCampos.Visible = false;
                panelCampos.Dock = DockStyle.Fill;
                ///////////////////////
                produtoSelecionado = 9;
                panelSeletor.Visible = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            panelSeletor.Visible = false;
            panelSeletor.Dock = DockStyle.Fill;
            painelGrideSelecao.Visible = false;
            painelGrideSelecao.Dock = DockStyle.Fill;
            panelCampos.Visible = true;
            panelCampos.Dock = DockStyle.Fill;
            ///////////////////////
            int indice = dataGridViewProduto.CurrentRow.Index;
            
            objProduto.ID = Convert.ToInt16(dataGridViewProduto.Rows[indice].Cells[0].Value);

        }

        private void btnBuscarImagem_Click(object sender, EventArgs e)
        {

            openFileDialogImagem.InitialDirectory = "c:\\Primus\\";
            openFileDialogImagem.Filter = "png files (*.png)|*.png|All (*.jpg)|*.jpg";
            if (openFileDialogImagem.ShowDialog() == DialogResult.OK)
            {
                txtImagem.Text = openFileDialogImagem.FileName;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = dataGridViewProduto.CurrentRow.Index;
                modFavoritos.ID = produtoSelecionado;
                modFavoritos.ID_Produto = Convert.ToInt16(dataGridViewProduto.Rows[indice].Cells[0].Value);
                modFavoritos.Nome = txtNomeResumo.Text;
                modFavoritos.CaminhoImagem = txtImagem.Text;

                tbProduto.ComandoProdutoFavorito(modFavoritos, 1);

                ///////////////////////////////////
                ///
                IniciarProdutosFavoritos();
                ///
                ///////////////////////////////////
                panelSeletor.Visible = true;
                panelSeletor.Dock = DockStyle.Fill;
                painelGrideSelecao.Visible = false;
                painelGrideSelecao.Dock = DockStyle.Fill;
                panelCampos.Visible = false;
                panelCampos.Dock = DockStyle.Fill;
                /////////////////////////////////////
            }catch(Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelSeletor.Visible = true;
            panelSeletor.Dock = DockStyle.Fill;
            painelGrideSelecao.Visible = false;
            painelGrideSelecao.Dock = DockStyle.Fill;
            panelCampos.Visible = false;
            panelCampos.Dock = DockStyle.Fill;
        }
    }
}
