using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Cwork.Utilitarios.Componentes.FuncoesValidacao;
using cwkGestao.Negocio;
using cwkGestao.Modelo;

namespace Aplicacao
{
    public partial class FormUF : Aplicacao.IntermediariasTela.FormManutUFIntermediaria
    {
        public FormUF()
        {
            //InitializeComponent();
            //ConfiguraDataSources();
            //SetarMascaras();
        }

        protected override void SetarMascaras()
        {
        }

        protected override void InitializeChildComponents()
        {
            this.InitializeComponent();
            lkpPais.Exemplo = new Pais();
            lkpPais.Sessao = PaisController.Instancia.getSession();
            lkbPais.SubFormType = typeof(FormPais);
        }

        private void FormUF_Shown(object sender, EventArgs e)
        {
            if (Operacao == Acao.Incluir)
            {
                txtCodigo.EditValue = controller.MaxCodigo();
            }
        }
    }
}
