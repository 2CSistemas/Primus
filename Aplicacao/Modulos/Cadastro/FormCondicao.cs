using System;
using System.Windows.Forms;
using cwkGestao.Modelo;

namespace Aplicacao
{
    public partial class FormCondicao : Aplicacao.IntermediariasTela.FormManutCondicaoPagamento
    {
        public FormCondicao()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            object[] parms = new[] { new CondicaoParcela() { Condicao = Selecionado } };
            Type formType = typeof(FormCondicaoParcela);

            btIncluirParcelas.SubFormType = btAlterarParcelas.SubFormType = btExcluirParcelas.SubFormType = btConsultarParcelas.SubFormType = formType;
            btIncluirParcelas.SubFormTypeParams = btAlterarParcelas.SubFormTypeParams = btExcluirParcelas.SubFormTypeParams = btConsultarParcelas.SubFormTypeParams = parms;

            //FormCondicaoParcela formCondicaoParcela = new FormCondicaoParcela() { Selecionado = new CondicaoParcela() { Condicao = Selecionado } };
            //btIncluirParcelas.SubForm = formCondicaoParcela;
            //btAlterarParcelas.SubForm = formCondicaoParcela;
            //btExcluirParcelas.SubForm = formCondicaoParcela;
            //btConsultarParcelas.SubForm = formCondicaoParcela;
        }

        protected override void btSubRegistro_Click(object sender, EventArgs e) //where U : ModeloBase, new()
        {
            TelaProObjeto(tcPrincipal);
            base.btSubRegistro_Click(sender, e);
        }

        private void FormCondicao_Shown(object sender, EventArgs e)
        {
            if (Operacao == Acao.Incluir)
            {
                txtCodigo.EditValue = controller.MaxCodigo();
                chbDivide.Checked = false;
            
            }
            txtDescricao.Text = Selecionado.Descricao;
            chbHabilitaCondicaoPDVDelivery.Checked = Selecionado.HabilitaCondicaoPDVDelivery;
        }

        protected override bool ValidarFormulario()
        {
            bool retorno = base.ValidarFormulario();
            if (gridView1.RowCount <= 0)
            {
                retorno = false;
                MessageBox.Show("É preciso cadastrar no mínimo uma parcela antes de gravar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (gridView1.RowCount != Convert.ToInt32(txtQtParcela.EditValue) && retorno != false)
            {
                retorno = false;
                MessageBox.Show("O número de parcelas não corresponde as parcelas adicionadas.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return retorno;
        }

        private void gridCondicaoParcelas_DataSourceChanged(object sender, EventArgs e)
        {
            gridView1.Columns["Parcela"].SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            gridView1.Columns["Parcela"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;           
            gridView1.RefreshData();
        }
    }
}
