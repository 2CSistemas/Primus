using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao
{
    public partial class FormGrupo2 : Aplicacao.IntermediariasTela.FormManutGrupo2Intermediaria
    {
        public FormGrupo2()
        {
           
        }

        private void FormGrupoEstoque_Shown(object sender, EventArgs e)
        {
            if (Operacao == Acao.Incluir)
                txtCodigo.EditValue = controller.MaxCodigo();
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            nomeEntidadeExibicao = cwkGestao.Negocio.ConfiguracaoController.Instancia.GetConfiguracao().NomeGrupo2 ?? "Grupo2";
        }

    }
}
