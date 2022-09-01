using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;
using Aplicacao.Modulos.Cadastro;
using cwkGestao.Negocio;

namespace Aplicacao
{
    public partial class GridCliente : Aplicacao.IntermediariasTela.GridPessoaIntermediaria
    {
        private string tipoPessoas;
        public GridCliente(IList<Pessoa> lista, IFormManut<Pessoa> formManut, bool adicionarFiltro)
            : this(lista, formManut, null, adicionarFiltro)
        {

        }

        public GridCliente(IList<Pessoa> lista, IFormManut<Pessoa> formManut,Pessoa selecionado, bool adicionarFiltro)
            : this(lista, formManut, selecionado, "Pessoa", adicionarFiltro)
        {
           
        }


        public GridCliente(IList<Pessoa> lista, IFormManut<Pessoa> formManut, Pessoa selecionado, String tipoPessoas, bool adicionarFiltro)
            : base(lista, formManut, selecionado, adicionarFiltro)
        {
            InitializeComponent();
            this.tipoPessoas = tipoPessoas;
            var configuracao = ConfiguracaoController.Instancia.GetConfiguracao();

            if (configuracao.UtilizaControleDaRevenda == 1)
            {
                sbFuncao11.Text = "Cliente Revenda";
                sbFuncao11.Visible = true;
                sbFuncao11.Enabled = true;                
                sbFuncao11.Image = Aplicacao.Properties.Resources.Funcionários_copy;
                sbFuncao11.Size = new Size(120, 23);
                sbFuncao11.Location = sbFuncao10.Location;
                sbFuncao11.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            }

            sbFuncao10.Text = "Parcelamento";
            sbFuncao10.Visible = true;
            sbFuncao10.Enabled = true;
            sbFuncao10.Click += new EventHandler(sbFuncao10_Click);
            sbFuncao10.Image = Aplicacao.Properties.Resources.Parcelamento;
            sbFuncao10.Size = new Size(100, 23);
            sbFuncao10.Location = new Point(416, 392);
            sbFuncao10.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.Text = "Tabela de " + tipoPessoas;

            if (tipoPessoas == "Fornecedor")
            {                
                sbFuncao12.Enabled = sbFuncao12.Visible = true;
                //sbFuncao12.Location = sbSelecionar.Location;
                sbFuncao12.Text = "Manutenção Vínculos";
                sbFuncao12.Size = new Size(120, 23);
            }
        }

        public GridCliente(IList<Pessoa> lista, Pessoa selecionado, String tipoPessoas, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, selecionado, adicionarFiltro, formManut, parametros)
        {
            InitializeComponent();
            this.tipoPessoas = tipoPessoas;
            var configuracao = ConfiguracaoController.Instancia.GetConfiguracao();

            if (configuracao.UtilizaControleDaRevenda == 1)
            {
                sbFuncao11.Text = "Cliente Revenda";
                sbFuncao11.Visible = true;
                sbFuncao11.Enabled = true;
                sbFuncao11.Image = Aplicacao.Properties.Resources.Funcionários_copy;
                sbFuncao11.Size = new Size(120, 23);
                sbFuncao11.Location = sbFuncao10.Location;
                sbFuncao11.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            }

            sbFuncao10.Text = "Parcelamento";
            sbFuncao10.Visible = true;
            sbFuncao10.Enabled = true;
            sbFuncao10.Click += new EventHandler(sbFuncao10_Click);
            sbFuncao10.Image = Aplicacao.Properties.Resources.Parcelamento;
            sbFuncao10.Size = new Size(100, 23);
            sbFuncao10.Location = new Point(416, 392);
            sbFuncao10.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.Text = "Tabela de " + tipoPessoas;

            if (tipoPessoas == "Fornecedor")
            {
                sbFuncao12.Enabled = sbFuncao12.Visible = true;
                //sbFuncao12.Location = sbSelecionar.Location;
                sbFuncao12.Text = "Manutenção Vínculos";
                sbFuncao12.Size = new Size(120, 23);
            }
        }

        void sbFuncao10_Click(object sender, EventArgs e)
        {
            GridPessoaParcelamento formParcelamento = new GridPessoaParcelamento(GetRegistroSelecionado().ID);
            formParcelamento.ShowDialog();
            formParcelamento.Dispose();
        }

        private void sbFuncao11_Click(object sender, EventArgs e)
        {
            int id = RegistroSelecionado();
            if (id > 0)
            {
                FormGridClienteRevenda form = new FormGridClienteRevenda("Tabela de Cliente da Revenda", id, null, null, false);
                form.ShowDialog();
                form.Dispose();
            }
            else
                MessageBox.Show("Nenhum registro selecionado.");
        }

        private Int32 RegistroSelecionado()
        {
            Int32 id;
            try
            {
                id = Convert.ToInt32(gvPrincipal.GetFocusedRowCellValue("ID"));
            }
            catch (Exception)
            {
                id = 0;
            }
            return id;
        }

        protected override void Incluir()
        {
            base.VerificaForm();
            if (FormManut != null)
            {
                ((FormPessoa)FormManut).TipoPessoa = tipoPessoas;
            }
            base.Incluir();
        }

        private void sbFuncao12_Click(object sender, EventArgs e)
        {
            var form = new FormVinculo(PessoaController.Instancia.LoadObjectById(RegistroSelecionado()));
            form.ShowDialog();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            var Pessoa = PessoaController.Instancia.LoadObjectById(RegistroSelecionado());
            new FormFotoPessoa(Pessoa?.CaminhoFoto).ShowDialog();
        }
    }
}
