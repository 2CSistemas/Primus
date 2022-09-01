using cwkGestao.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormPessoaAviso : Aplicacao.IntermediariasTela.FormManutPessoaAvisoIntermediaria
    {
        public FormPessoaAviso()
        {
            
        }

        public FormPessoaAviso(PessoaAviso Aviso)
        {
            Selecionado = Aviso;
        }

        protected override void SetarMascaras()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
        }

        protected override bool ValidarFormulario()
        {
            bool validarFormulario = base.ValidarFormulario();
            bool temErro = true;
            dxErroProvider.ClearErrors();
            if (String.IsNullOrEmpty("" + txtOrdem.EditValue))
            {
                dxErroProvider.SetError(txtOrdem, "Campo obrigatório");
                temErro = false;
            }
            if (txtDtCadastro.DateTime == DateTime.MinValue)
            {
                dxErroProvider.SetError(txtDtCadastro, "Campo obrigatório");
                temErro = false;
            }
            if (txtDtValidade.DateTime == DateTime.MinValue)
            {
                dxErroProvider.SetError(txtDtValidade, "Campo obrigatório");
                temErro = false;
            }
            if (String.IsNullOrEmpty("" + txtAviso.EditValue))
            {
                dxErroProvider.SetError(txtAviso, "Campo obrigatório");
                temErro = false;
            }

            return validarFormulario && temErro;
        }
    }
}
