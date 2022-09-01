using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Modelo;

namespace Aplicacao
{
    public partial class FormNCMItem : Aplicacao.IntermediariasTela.FormManutNCMItemIntermediaria
    {
        public FormNCMItem()
        {
        }

        public FormNCMItem(NCMItem item)
        {
            Selecionado = item;
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
            var grid = new GridGenerica<UF>(UFController.Instancia.GetAll(), new FormUF(), (UF)lkpUFOrigem.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            grid.ShowDialog();

            lkpUFOrigem.EditValue = grid.Selecionado;
        }

        private void btnlkpUFDestino_Click(object sender, EventArgs e)
        {
            var grid = new GridGenerica<UF>(UFController.Instancia.GetAll(), new FormUF(), (UF)lkpUFDestino.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            grid.ShowDialog();

            lkpUFDestino.EditValue = grid.Selecionado;
        }

        private void lkbTexto_Click(object sender, EventArgs e)
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

        private void sbGravar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
