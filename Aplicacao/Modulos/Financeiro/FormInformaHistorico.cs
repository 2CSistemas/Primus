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
    public partial class FormInformaHistorico : Aplicacao.IntermediariasTela.FormManutHistoricoIntermediaria
    {
        public String ComplementoHist { get { return txtHistoricoComplemento.Text; } }

        public FormInformaHistorico()
        {
            InitializeComponent();
            lkHistorico.Sessao = HistoricoController.Instancia.getSession();
            lkHistorico.Exemplo = new cwkGestao.Modelo.Historico();
            lkbHistorico.Lookup = lkHistorico;
            lkHistorico.OnIDChanged += new EventHandler(lkHistorico_IDChanged);
            Operacao = cwkGestao.Modelo.Acao.NaoPersistir ^ cwkGestao.Modelo.Acao.Alterar;
        }

        private void lkHistorico_IDChanged(object sender, EventArgs e)
        {
            if (lkHistorico.Selecionado != null)
                txtHistoricoComplemento.Text = ((cwkGestao.Modelo.Historico)lkHistorico.Selecionado).Nome;
        }

        protected override void OK()
        {
            base.OK();
            Selecionado = (Historico)lkHistorico.Selecionado;
        }

        private void lkbHistorico_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.Historico> grid = new GridGenerica<cwkGestao.Modelo.Historico>(cwkGestao.Negocio.HistoricoController.Instancia.GetAll(), new FormHistorico(), (cwkGestao.Modelo.Historico)lkHistorico.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            grid.ShowDialog();

            lkHistorico.EditValue = grid.Selecionado;
            lkHistorico.Focus();
        }
    }
}
