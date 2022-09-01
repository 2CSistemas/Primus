using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormTipoDocumento : Aplicacao.IntermediariasTela.FormManutTipoDocumentoIntermediaria
    {
        public FormTipoDocumento()
        {
        }
        protected override void SetarMascaras()
        {
        }
        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            //lkbFormaPagamento.SubForm = new FormFormaPagamentoH();
            lkbFormaPagamento.SubFormType = typeof(FormFormaPagamentoH);
        }
        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
        }
    }
}
