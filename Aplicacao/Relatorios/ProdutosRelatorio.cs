using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Modelo;
using Cwork.Utilitarios.Componentes.Mascaras;

namespace Aplicacao.Relatorios
{
    public partial class ProdutosRelatorio : Aplicacao.Relatorios.Base.FormBase
    {
        private Configuracao configuracaoSistema;
        public TipoRelatorioProduto TipoRelatorio
        {
            get { return (TipoRelatorioProduto)cbeTipo.SelectedIndex; }
        }

        public ProdutosRelatorio()
        {
            InitializeComponent();

            lkpGrupoEstoque.Exemplo = new cwkGestao.Modelo.GrupoEstoque();
            lkpGrupoEstoque.Sessao = GrupoEstoqueController.Instancia.getSession();
            configuracaoSistema = ConfiguracaoController.Instancia.GetConfiguracao();
            SetaMascaraInicialFinal();
        }

        public override void CarregaCampos()
        {
            cbGrupo.Properties.DataSource = EmpresaController.Instancia.GetAll();
        }

        private void cbGrupo_EditValueChanged(object sender, EventArgs e)
        {
            gcPrincipal.DataSource = FilialController.Instancia.GetEmpresasDoGrupo(((cwkGestao.Modelo.Empresa)cbGrupo.EditValue).ID);
        }

        private void cbeTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TipoRelatorio == TipoRelatorioProduto.GrupoEstoque)
            {
                txtInicial.Enabled = false;
                txtFinal.Enabled = false;
                HabilitaGrupoEstoque(true);
            }
            else
            {
                txtInicial.EditValue = String.Empty;
                txtFinal.EditValue = String.Empty;
                txtInicial.Enabled = true;
                txtFinal.Enabled = true;
                HabilitaGrupoEstoque(false);
                SetaMascaraInicialFinal();
            }
        }

        private void SetaMascaraInicialFinal()
        {
            Mascara? maskInicialFinal = null;
            txtInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            txtFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            if (TipoRelatorio       == TipoRelatorioProduto.Codigo && !configuracaoSistema.CodigoProdutoStr)
                maskInicialFinal    = Mascara.CODIGO;
            txtInicial.CwkMascara   = maskInicialFinal;
            txtFinal.CwkMascara     = maskInicialFinal;
        }

        private void HabilitaGrupoEstoque(bool habilita)
        {
            lkpGrupoEstoque.Enabled = habilita;
            lkbGrupoEstoque.Enabled = habilita;
        }

        protected override bool GerarRelatorio()
        {
            if (gvPrincipal.GetSelectedRows().Length == 0)
            {
                MessageBox.Show("Selecione pelo menos uma empresa.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (TipoRelatorio == TipoRelatorioProduto.GrupoEstoque)
                return GerarRelatorioPorGrupoEstoque();
            else
                return GerarRelatorioNomeCodigo();
        }

        private bool GerarRelatorioNomeCodigo()
        {
            IList<object> resultado = ProdutoController.Instancia.GetRelatorio(TipoRelatorio, txtInicial.Text, txtFinal.Text, configuracaoSistema.CodigoProdutoStr, cb_Status.SelectedIndex);
            List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            
            Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("Empresa", GetEmpresaRelatorio());
            Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", GetTituloRelatorio());
            parametros.Add(p1);
            parametros.Add(p2);
            nomeRelatorio = @"rptProdutos.rdlc";
            dataSet = "dsProduto_Produto";

            VisualizarRelatorio(resultado, parametros);
            return true;
        }

        private bool GerarRelatorioPorGrupoEstoque()
        {
            IList<object> resultado = ProdutoController.Instancia.GetRelatorioPorGrupoEstoque((cwkGestao.Modelo.GrupoEstoque)lkpGrupoEstoque.Selecionado);
            List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();

            Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("Empresa", GetEmpresaRelatorio());
            parametros.Add(p1);
            nomeRelatorio = @"rptProdutosPorGrupoEstoque.rdlc";
            dataSet = "dsProduto_PorGrupoEstoque";

            VisualizarRelatorio(resultado, parametros);
            return true;
        }

        private void VisualizarRelatorio(IList<object> resultado, List<Microsoft.Reporting.WinForms.ReportParameter> parametros)
        {
            Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase(nomeRelatorio, dataSet, resultado, parametros);
            form.Text = this.Text;
            form.Show();
        }

        private string GetEmpresaRelatorio()
        {
            if (gvPrincipal.SelectedRowsCount > 1)
                return ((cwkGestao.Modelo.Empresa)cbGrupo.EditValue).Nome;
            else
                return ((cwkGestao.Modelo.Filial)gvPrincipal.GetRow(gvPrincipal.GetSelectedRows()[0])).Nome;
        }

        private string GetTituloRelatorio()
        {
            switch (TipoRelatorio)
            {
                case TipoRelatorioProduto.Codigo:
                    return "Código";
                case TipoRelatorioProduto.Nome:
                    return "Nome";
                case TipoRelatorioProduto.GrupoEstoque:
                    return "Grupo Estoque";
                default:
                    return String.Empty;
            }
        }

        private void btnlkpGrupoEstoque_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.GrupoEstoque> grid = new GridGenerica<cwkGestao.Modelo.GrupoEstoque>(GrupoEstoqueController.Instancia.GetAll(), new FormGrupoEstoque(), (cwkGestao.Modelo.GrupoEstoque)lkpGrupoEstoque.Selecionado, false);
            grid.Selecionando = true;
            grid.ShowDialog();

            if (grid.Selecionado != null)
                lkpGrupoEstoque.Localizar(grid.Selecionado.ID);

            lkpGrupoEstoque.Focus();
        }

        private void gvPrincipal_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            Bitmap groupPanelImage;
            groupPanelImage = (Bitmap)Aplicacao.Properties.Resources.HeaderGrid;
            groupPanelImage.MakeTransparent();
            Brush brush = e.Cache.GetGradientBrush(e.Bounds, Color.White, Color.WhiteSmoke,
              System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(brush, e.Bounds);
            Image img = groupPanelImage;
            Rectangle r = new Rectangle(e.Bounds.X + e.Bounds.Width - img.Size.Width - 5,
              e.Bounds.Y + (e.Bounds.Height - img.Size.Height) / 2, img.Width, img.Height);
            e.Graphics.DrawImageUnscaled(img, r);
            e.Handled = true;
        }

    }
}
