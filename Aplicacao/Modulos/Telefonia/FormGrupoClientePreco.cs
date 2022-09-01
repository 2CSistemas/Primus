using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;

namespace Aplicacao.Modulos.Telefonia
{
    public partial class FormGrupoClientePreco : Aplicacao.IntermediariasTela.FormManutGrupoClientePrecoIntermediaria
    {
        public FormGrupoClientePreco() { }

        public FormGrupoClientePreco(Tel_GrupoClientePreco precoGrupo) 
        {
            Selecionado = precoGrupo;
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();

            lkpTipoLigacao.Exemplo = new Tel_TipoLigacao();
           //lkbTipoLigacao.SubForm = new FormTel_TipoLigacao();
            lkbTipoLigacao.SubFormType = typeof(FormTel_TipoLigacao);
        }

        private void FormGrupoClientePreco_Shown(object sender, EventArgs e)
        {
            if (Operacao == (cwkGestao.Modelo.Acao)31)
            {
                txtArea_Final.EditValue = 99;
                txtPrefixo_Final.EditValue = 9999;
                txtRange_Final.EditValue = 9999;
            }
        }
    }
}
