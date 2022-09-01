using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using DevExpress.XtraGrid.Views.Grid;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Proxy;
using System.IO;
using System.Reflection;
using System.Xml.Linq;
using Relatorio.Relatorios;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Relatorios
{
    public partial class FormTrocasParaConferencia : Aplicacao.Relatorios.Base.FormBase
    {
        private List<int> ListIDEmpresas;
        private List<int> ListIDTTipoPedidos;
        private List<int> ListIDClientes;
        private IList<pxyTipoRelRecebimentos> ListTipoRecebimentos = new List<pxyTipoRelRecebimentos>();
        private IList<pxyOperacaoRelRecebimentos> ListOperacaoRecebimentos = new List<pxyOperacaoRelRecebimentos>();
        private StringBuilder msg = new StringBuilder();
        private Dictionary<int, string> operacao = new Dictionary<int, string>();
        private Dictionary<int, string> tipo = new Dictionary<int, string>();
        private string pConsiderar;
        private StringBuilder Arquivo;

        public FormTrocasParaConferencia()
        {
            InitializeComponent();
            this.Text = "Relatório de Trocas para Conferência";
            Arquivo = new StringBuilder(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\XML\\");
            Arquivo.Append(this.Name);
            Arquivo.Append(".xml");
            if (File.Exists(Arquivo.ToString()))
                LeXML(XElement.Load(Arquivo.ToString()));
        }

        public override void CarregaCampos()
        {
            cbGrupo.Properties.DataSource = EmpresaController.Instancia.GetAll();
            CarregaClientes();
            CarregaTipo();
        }

        private void CarregaClientes()
        {
            gcClientes.DataSource = PessoaController.Instancia.GetAllClientes();
        }

        private void CarregaTipo()
        {
            gcTipo.DataSource = TipoPedidoController.Instancia.GetByTipoAndEnt_Sai(InOutType.Saída);
        }

        private void cbGrupo_EditValueChanged(object sender, EventArgs e)
        {
            gcEmpresas.DataSource = listaFiliais = FilialController.Instancia.GetEmpresasDoGrupo((int)cbGrupo.EditValue);            
        }

        private List<int> PegaIDs(GridView grid)
        {
            List<int> IDs = new List<int>();
            int[] Rows = grid.GetSelectedRows();
            for (int i = 0; i < Rows.Length; i++)
            {
                IDs.Add((int)grid.GetRowCellValue(Rows[i], "ID")); 
            }

            return IDs;
        }



        protected override bool GerarRelatorio()
        {
            if (ValidaTelas()) 
            {
                string codEmpresasStr = "";
                string codTipoTTipoPedidosStr = "";
                string codClientesStr = "";

                try
                {
                    ListIDEmpresas = PegaIDs(gvEmpresas);
                    ListIDTTipoPedidos = PegaIDs(gvTipo);
                    ListIDClientes = PegaIDs(gvClientes);
                    PreencheCodigosStringsParaPesquisa(ref codEmpresasStr, ref codTipoTTipoPedidosStr, ref codClientesStr);
                    rptTrocasParaConferencia rel = new rptTrocasParaConferencia(codTipoTTipoPedidosStr, codEmpresasStr, codClientesStr, txtDataInicial.DateTime, txtDataFinal.DateTime);
                    rel.ShowPreview();
                   
                    return true;
                }
                catch (Exception ex)
                {
                    new global::Aplicacao.Base.FormErro(ex).ShowDialog();
                }
            }
            else
                MessageBox.Show(msg.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            msg.Remove(0, msg.Length);    
            return false;
        }

        private void PreencheCodigosStringsParaPesquisa(ref string codEmpresasStr, ref string codTipoTTipoPedidosStr, ref string codClientesStr)
        {
            for (int i = 0; i < ListIDEmpresas.Count; i++)
            {
                if (i == ListIDEmpresas.Count - 1)
                {
                    codEmpresasStr += ListIDEmpresas[i].ToString(); 
                }
                else
                {
                    codEmpresasStr += ListIDEmpresas[i].ToString() + ",";
                }
            }

            for (int i = 0; i < ListIDTTipoPedidos.Count; i++)
            {
                if (i == ListIDTTipoPedidos.Count - 1)
                {
                    codTipoTTipoPedidosStr += ListIDTTipoPedidos[i].ToString();
                }
                else
                {
                    codTipoTTipoPedidosStr += ListIDTTipoPedidos[i].ToString() + ",";
                }
            }

            for (int i = 0; i < ListIDClientes.Count; i++)
            {
                if (i == ListIDClientes.Count - 1)
                {
                    codClientesStr += ListIDClientes[i].ToString();
                }
                else
                {
                    codClientesStr += ListIDClientes[i].ToString() + ",";
                }
            }
        }

        private string PegaStringFilial(string codFilialStr)
        {
            string nomeFilial = "";
            string[] codigos = codFilialStr.Split(',');
            for (int i = 0; i < codigos.Length; i++)
            {
                if (i == codigos.Length - 1)
                {
                    nomeFilial += FilialController.Instancia.LoadObjectById(Convert.ToInt32(codigos[i])).Nome + ".";                    
                }
                else
                {
                    nomeFilial += FilialController.Instancia.LoadObjectById(Convert.ToInt32(codigos[i])).Nome + ",";
                }

            }
            return nomeFilial;
        }

        private bool ValidaTelas()
        {
            bool flag = true;

            if (cbGrupo.EditValue == null)
            {
                msg.Append("Verifique anomalias Grupo.\n");
                dxErroProvider.SetError(cbGrupo, "Campo Obrigátorio.");
                flag = false;
            }
            else
                dxErroProvider.SetError(cbGrupo, String.Empty);

            if (txtDataInicial.DateTime > txtDataFinal.DateTime)
            {
                msg.Append("Verifique anomalias data inicial menor ou igual a data final.\n");
                dxErroProvider.SetError(txtDataInicial, "Campos com dados inválidos.");
                flag = false;
            }
            else
                dxErroProvider.SetError(txtDataFinal, String.Empty);

            if (txtDataInicial.Text == String.Empty)
            {
                msg.Append("Verifique anomalias data inicial.\n");
                dxErroProvider.SetError(txtDataInicial, "Campo Obrigátorio.");
                flag = false;
            }
            else
                dxErroProvider.SetError(txtDataInicial, String.Empty);

            if (txtDataFinal.Text == String.Empty)
            {
                msg.Append("Verifique anomalias data final.\n");
                dxErroProvider.SetError(txtDataFinal, "Campo Obrigátorio.");
                flag = false;
            }
            else
                dxErroProvider.SetError(txtDataFinal, String.Empty);

            return flag;
        }

        private String MontaStringIDs(List<Int32> ListaIDs)
        {
            StringBuilder IDs = new StringBuilder();

            IDs.Append("( ");
            foreach (Int32 item in ListaIDs)
            {
                IDs.Append(item);
                IDs.Append(", ");
            }
            IDs.Remove(IDs.Length - 2, 2);
            IDs.Append(" )");

            return IDs.ToString();
        }

        private void gvEmpresas_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
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

        private void gvTipo_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
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

        private void gvClientes_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
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
