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
using Relatorio;
using Relatorio.dsRotaTableAdapters;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Relatorios
{
    public partial class FormRota : Aplicacao.Relatorios.Base.FormBase
    {
        private List<int> ListIDEmpresas;
        private List<int> ListIDClientes;
        private List<int> ListIDResponsaveis;
        private List<int> ListIDOperadores;
        private StringBuilder msg = new StringBuilder();
        private Dictionary<int, string> operacao = new Dictionary<int, string>();
        private Dictionary<int, string> tipo = new Dictionary<int, string>();
        private string pConsiderar;
        private StringBuilder Arquivo;

        public FormRota()
        {
            InitializeComponent();
            this.Text = "Relatório de Rotas";
            Arquivo = new StringBuilder(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\XML\\");
            Arquivo.Append(this.Name);
            Arquivo.Append(".xml");
            if (File.Exists(Arquivo.ToString()))
                LeXML(XElement.Load(Arquivo.ToString()));
        }

        public override void CarregaCampos()
        {
            cbGrupo.Properties.DataSource = EmpresaController.Instancia.GetAll();
            gcClientes.DataSource = PessoaController.Instancia.GetAllClientes();
            gcResponsavel.DataSource = PessoaController.Instancia.GetAllFuncionarios();
            gcOperador.DataSource = PessoaController.Instancia.GetAllFuncionarios();
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
                string codClientesStr = "";
                string codResponsaveisStr = "";
                string codOperadoresStr = "";

                try
                {
                    ListIDEmpresas = PegaIDs(gvEmpresas);
                    ListIDClientes = PegaIDs(gvClientes);
                    ListIDResponsaveis = PegaIDs(gvResponsavel);
                    ListIDOperadores = PegaIDs(gvOperador);
                    PreencheCodigosStringsParaPesquisa(ref codEmpresasStr, ref codClientesStr, ref codResponsaveisStr, ref codOperadoresStr);
                    rptRota rel = new rptRota(txtTipoData.SelectedIndex, txtDataInicial.DateTime, txtDataFinal.DateTime, txtCBStatus.SelectedIndex, codResponsaveisStr, codOperadoresStr, codClientesStr, codEmpresasStr);
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

        private void PreencheCodigosStringsParaPesquisa(ref string codEmpresasStr, ref string codClientesStr, ref string codResponsaveisStr, ref string codOperadoresStr)
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

            for (int i = 0; i < ListIDResponsaveis.Count; i++)
            {
                if (i == ListIDResponsaveis.Count - 1)
                {
                    codResponsaveisStr += ListIDResponsaveis[i].ToString();
                }
                else
                {
                    codResponsaveisStr += ListIDResponsaveis[i].ToString() + ",";
                }
            }

            for (int i = 0; i < ListIDOperadores.Count; i++)
            {
                if (i == ListIDResponsaveis.Count - 1)
                {
                    codOperadoresStr += ListIDOperadores[i].ToString();
                }
                else
                {
                    codOperadoresStr += ListIDOperadores[i].ToString() + ",";
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
    }
}
