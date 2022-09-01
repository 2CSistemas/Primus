using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo.Exceptions;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao
{
    public partial class FormInterestadual : Aplicacao.IntermediariasTela.FormManutInterestadualIntermediaria
    {
        public FormInterestadual()
        {
            
        }
        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            groupControl1.Tag = groupControl2.Tag = groupControl3.Tag = tpPrincipal.Tag;

            //lkbUFDestino.SubForm = new FormUF();
            //lkbUFOrigem.SubForm = new FormUF();

            lkbUFDestino.SubFormType = lkbUFOrigem.SubFormType = typeof(FormUF);

            lkpTextoContribuinte.Exemplo = new TextoLei();
            lkpTextoNaoContribuinte.Exemplo = new TextoLei();
        }

        protected override List<Exception> ObjetoPraTela(Control pai)
        {
            List<Exception> erros = base.ObjetoPraTela(pai);

            foreach (var item in erros)
            {
                AtribuicaoException erro = item as AtribuicaoException;
                MessageBox.Show(erro.Origem + " -> " + erro.Destino + " = " + erro.Valor);
            }
            return erros;
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            groupControl1.Tag = groupControl2.Tag = groupControl3.Tag = tpPrincipal.Tag;
            base.AcoesAntesBase_Load(sender, e);

        }

        private void CampoPct_Leave(object sender, EventArgs e)
        {
            Cwork.Utilitarios.Componentes.CwkBaseEditor baseeditor = sender as Cwork.Utilitarios.Componentes.CwkBaseEditor;
            if (Convert.ToDouble(baseeditor.EditValue) > 99.99)
            {
                baseeditor.EditValue = 99.99;
            }
        }

        private void lookupButton1_Click(object sender, EventArgs e)
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
