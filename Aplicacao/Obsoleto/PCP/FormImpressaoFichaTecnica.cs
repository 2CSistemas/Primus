using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using cwkGestao.Negocio;
using System.Linq;
using cwkGestao.Modelo;
using Relatorio.Relatorios;
using Aplicacao.Interfaces;
using Aplicacao.Util;
using System.IO;
using System.Reflection;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Obsoleto.PCP
{
    public partial class FormImpressaoFichaTecnica :  Base.ManutBase, IFormGrid  
    {
        private readonly IList<TupleIFormGrid> grids = new List<TupleIFormGrid>();
        public IList<TupleIFormGrid> Grids { get { return grids; } }
        private IList<FichaTecnicaPCP> lista;
        public DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler CustomSort { get; set; }
        private bool salvar = true;
        public FormImpressaoFichaTecnica()
        {
            InitializeComponent();
            grids.Add(new TupleIFormGrid {
                View = gvFT,
                Control = gcFT,
                Tipo = typeof(FichaTecnica),
                XmlLayout = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Telas\\Grid" + new System.Text.RegularExpressions.Regex("[\\\\|:/*?\"><]").Replace(Text, "") + "_" + 
                             cwkControleUsuario.Facade.getUsuarioLogado.Login + ".xml"                
            });
            gcFT.DataSource = lista = FichaTecnicaPCPController.Instancia.GetImpressao();
        }
        
        protected override void sbGravar_Click(object sender, EventArgs e)
        {
                int i = 0;
                string idPCP = null;
                IList<FichaTecnicaPCP> lAux = new List<FichaTecnicaPCP>();
                foreach (FichaTecnicaPCP item in lista)
                {
                    if (item.Selecionado)
                    {
                        i++;
                        idPCP += item.ID+",";
                    }
                }

                if (i == 0)
                {
                    MessageBox.Show("Selecione algum registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    rptPCPFt relatorio = new rptPCPFt(idPCP);
                    if (ImpressaoCompleta())
                         relatorio.Imprimir.Value = true;
                    else
                        relatorio.Imprimir.Value = false;

                    relatorio.ShowPreview();
                }
        }

        private bool ImpressaoCompleta()
        {
            return MessageBox.Show("Deseja imprimir as regras e fórmulas?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void AlterarSelecaoGrid(bool selecionado)
        {
            List<FichaTecnicaPCP> lPCP = new List<FichaTecnicaPCP>();
            for (int i = 0; i < gvFT.RowCount; i++)
            {
                lPCP.Add((FichaTecnicaPCP) gvFT.GetRow(i));
            }

            lPCP.ToList().ForEach(f => f.Selecionado = selecionado);
            gcFT.DataSource = lista;
            gcFT.RefreshDataSource();
        }

        private void sbSelecionarTodos_Click(object sender, EventArgs e)
        {
            AlterarSelecaoGrid(true);
        }

        private void sbLimparSelecao_Click(object sender, EventArgs e)
        {
            AlterarSelecaoGrid(false);
        }

        private void FormImpressaoFichaTecnica_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Impressao de ficha tecnica - pcp");
                    break;
                case Keys.Delete:
                    if (Form.ModifierKeys == Keys.Control)
                    {
                        salvar = false;
                        this.DeletarLayoutGrids();                        
                    }
                    break;
            }

        }

        private void FormImpressaoFichaTecnica_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.SalvarLayoutGrids();
                
            }
            catch (Exception ex)
            {
                throw new Exception (ex.Message);
            }
        }

        private void FormImpressaoFichaTecnica_Load(object sender, EventArgs e)
        {
            try
            {
                this.CarregarLayoutSalvo();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void gvFT_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
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