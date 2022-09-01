using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Modelo;

namespace Aplicacao
{
    public partial class FormProduto_Icms : Aplicacao.IntermediariasTela.FormManutProduto_IcmsIntermediaria
    {
        public FormProduto_Icms()
        {
        }

        public FormProduto_Icms(Produto_Icms prodIcms)
        {
            Selecionado = prodIcms;
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            DiscriminaTabs();

            lkpTextoContribuinte.Exemplo = new TextoLei();
            lkpTextoNaoContribuinte.Exemplo = new TextoLei();
        }

        private void DiscriminaTabs()
        {
            groupContribuinte.Tag = Selecionado;
            groupNaoContribuinte.Tag = Selecionado;
            groupSubstituicaoTributaria.Tag = Selecionado;
        }

        protected override void SetarMascaras()
        {
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            DiscriminaTabs();
        }

        private void FormProduto_Icms_Shown(object sender, EventArgs e)
        {
            cbeModBCICMS.SelectedIndex = Selecionado.ModBCICMS;
            cbeModBCST.SelectedIndex = Selecionado.ModBCST;
            cbeTributacao.SelectedIndex = Selecionado.Tributacao;
            txtAliqInterna.Text = Selecionado.AliqInterna.ToString();
        }

        private void btnlkpUFOrigem_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.UF> grid = new GridGenerica<cwkGestao.Modelo.UF>(UFController.Instancia.GetAll(), new FormUF(), (cwkGestao.Modelo.UF)lkpUFOrigem.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            grid.ShowDialog();

            lkpUFOrigem.EditValue = grid.Selecionado;
        }

        private void btnlkpUFDestino_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.UF> grid = new GridGenerica<cwkGestao.Modelo.UF>(UFController.Instancia.GetAll(), new FormUF(), (cwkGestao.Modelo.UF)lkpUFDestino.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            grid.ShowDialog();

            lkpUFDestino.EditValue = grid.Selecionado;
        }

        private void lkbTextoContribuinte_Click(object sender, EventArgs e)
        {
            var grid = new GridGenerica<TextoLei>(TextoLeiController.Instancia.GetAll(), new FormTextoLei(), (TextoLei)lkpTextoContribuinte.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            lkpTextoContribuinte.EditValue = grid.Selecionado;
        }

        private void lkbTextoNaoContribuinte_Click(object sender, EventArgs e)
        {
            var grid = new GridGenerica<TextoLei>(TextoLeiController.Instancia.GetAll(), new FormTextoLei(), (TextoLei)lkpTextoNaoContribuinte.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            lkpTextoNaoContribuinte.EditValue = grid.Selecionado;
        }
    }
}
