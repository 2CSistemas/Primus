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
using DevExpress.XtraReports.UI;

namespace Aplicacao.Relatorios
{
    public partial class FormMovimentoRecebimentoPorPeriodo : Aplicacao.Relatorios.Base.FormBase
    {
        private List<int> ListIDEmpresas;
        private List<int> ListIDTipoRecebimentos;
        private List<int> ListIDOperacaoRecebimentos;
        private IList<pxyTipoRelRecebimentos> ListTipoRecebimentos = new List<pxyTipoRelRecebimentos>();
        private IList<pxyOperacaoRelRecebimentos> ListOperacaoRecebimentos = new List<pxyOperacaoRelRecebimentos>();
        private StringBuilder msg = new StringBuilder();
        private Dictionary<int, string> operacao = new Dictionary<int, string>();
        private Dictionary<int, string> tipo = new Dictionary<int, string>();
        private string pConsiderar;
        private StringBuilder Arquivo;

        public FormMovimentoRecebimentoPorPeriodo()
        {
            InitializeComponent();
            this.Text = "Relatório de Recebimentos";
            Arquivo = new StringBuilder(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\XML\\");
            Arquivo.Append(this.Name);
            Arquivo.Append(".xml");
            if (File.Exists(Arquivo.ToString()))
                LeXML(XElement.Load(Arquivo.ToString()));
        }

        public override void CarregaCampos()
        {
            cbGrupo.Properties.DataSource = EmpresaController.Instancia.GetAll();
            CarregarVariavelConsiderar(out pConsiderar);
            CarregaOperacao();
            CarregaTipo();
        }

        private void CarregaTipo()
        {
            tipo.Add(1, "Documento");
            tipo.Add(2, "Multa");
            tipo.Add(3, "Juro");
            tipo.Add(4, "Troco");
            tipo.Add(6, "Desconto");
            tipo.Add(7, "Imposto");
            tipo.Add(8, "JurosDesconto");
            tipo.Add(9, "TaxaBoleto");
            tipo.Add(10, "IOF");
            foreach (var item in tipo)
            {
                ListTipoRecebimentos.Add(new pxyTipoRelRecebimentos(item.Key, item.Value));
            }
            gcTipo.DataSource = ListTipoRecebimentos;
        }

        private void CarregaOperacao()
        {
            operacao.Add(2, "BxParcial");
            operacao.Add(3, "BxTotal");
            operacao.Add(4, "TituloDescontado");
            operacao.Add(89, "Troco");
            operacao.Add(12, "EstBxPArcial");
            operacao.Add(13, "EstBxTotal");
            foreach (var item in operacao)
            {
                ListOperacaoRecebimentos.Add(new pxyOperacaoRelRecebimentos(item.Key, item.Value));
            }
            gcOperacao.DataSource = ListOperacaoRecebimentos;
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

        private List<int> PegaTipos(GridView grid)
        {
            List<int> Tipos = new List<int>();
            int[] Rows = grid.GetSelectedRows();
            for (int i = 0; i < Rows.Length; i++)
            {
                Tipos.Add((int)grid.GetRowCellValue(Rows[i], "Tipo"));
            }

            return Tipos;
        }

        private List<int> PegaOperacoes(GridView grid)
        {
            List<int> Operacoes = new List<int>();
            int[] Rows = grid.GetSelectedRows();
            for (int i = 0; i < Rows.Length; i++)
            {
                Operacoes.Add((int)grid.GetRowCellValue(Rows[i], "Operacao"));
            }

            return Operacoes;
        }

        protected override bool GerarRelatorio()
        {
            if (ValidaTelas()) 
            {
                string codEmpresasStr = "";
                string codTiposRecebimentoStr = "";
                string codOperacoesRecebimentoStr = "";

                try
                {
                    ListIDEmpresas = PegaIDs(gvPrincipal);
                    ListIDTipoRecebimentos = PegaTipos(gvTipo);
                    ListIDOperacaoRecebimentos = PegaOperacoes(gvOperacao);
                    CarregarVariavelConsiderar(out pConsiderar);
                    PreencheCodigosStringsParaPesquisa(ref codEmpresasStr, ref codTiposRecebimentoStr, ref codOperacoesRecebimentoStr);

                    Relatorio.Relatorios.rptMovimentoRecebimentoPorPeriodo rel =
                        new Relatorio.Relatorios.rptMovimentoRecebimentoPorPeriodo(pConsiderar, txtDataInicial.DateTime,
                            txtDataFinal.DateTime, codEmpresasStr, codOperacoesRecebimentoStr, codTiposRecebimentoStr);
                    rel.Periodo.Value = txtDataInicial.DateTime.Date.ToString("dd/MM/yyyy") + " até " + txtDataFinal.DateTime.Date.ToString("dd/MM/yyyy")+ ".";
                    rel.TiposOperacao.Value = PegaStringTipoOperacao(codOperacoesRecebimentoStr);
                    rel.Considerar.Value = PegaStringConsiderar(rgConsiderar.EditValue.ToString());
                    rel.Filial.Value = PegaStringFilial(codEmpresasStr);
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

        private void PreencheCodigosStringsParaPesquisa(ref string codEmpresasStr, ref string codTiposRecebimentoStr, ref string codOperacoesRecebimentoStr)
        {
            for (int i = 0; i < ListIDEmpresas.Count; i++)
            {
                if (i == ListIDEmpresas.Count - 1)
                {
                    codEmpresasStr += ListIDEmpresas[i].ToString(); ;
                }
                else
                {
                    codEmpresasStr += ListIDEmpresas[i].ToString() + ",";
                }
            }

            for (int i = 0; i < ListIDTipoRecebimentos.Count; i++)
            {
                if (i == ListIDTipoRecebimentos.Count - 1)
                {
                    codTiposRecebimentoStr += ListIDTipoRecebimentos[i].ToString();
                }
                else
                {
                    codTiposRecebimentoStr += ListIDTipoRecebimentos[i].ToString() + ",";
                }
            }

            for (int i = 0; i < ListIDOperacaoRecebimentos.Count; i++)
            {
                if (i == ListIDOperacaoRecebimentos.Count - 1)
                {
                    codOperacoesRecebimentoStr += ListIDOperacaoRecebimentos[i].ToString();
                }
                else
                {
                    codOperacoesRecebimentoStr += ListIDOperacaoRecebimentos[i].ToString() + ",";
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


        private string PegaStringConsiderar(string considerar)
        {
            switch (considerar)
            {
                case "1":
                    return "Recebimentos.";
                case "2":
                    return "Descontados.";
                case "3":
                    return "Ambos.";
                default:
                    return "";
            }
        }

        private string PegaStringTipoOperacao(string codOperacoesRecebimentoStr)
        {
            string retorno = "";
            string[] codigos = codOperacoesRecebimentoStr.Split(',');
            for (int i = 0; i < codigos.Length; i++)
            {
                if (i == codigos.Length - 1)
                {
                    switch (codigos[i])
                    {
                        case "2":
                            retorno += "BxParcial.";
                            break;
                        case "3":
                            retorno += "BxTotal.";
                            break;
                        case "4":
                            retorno += "TituloDescontado.";
                            break;
                        case "89":
                            retorno += "Troco.";
                            break;
                        default:
                            retorno += ".";
                            break;
                    }                   
                }
                else
                {
                    switch (codigos[i])
                    {
                        case "2":
                            retorno += "BxParcial,";
                            break;
                        case "3":
                            retorno += "BxTotal,";
                            break;
                        case "4":
                            retorno += "TituloDescontado,";
                            break;
                        case "89":
                            retorno += "Troco,";
                            break;
                        default:
                            retorno += "";
                            break;
                    }
                }
                
            }
            return retorno;           
        }

        private void CarregarVariavelConsiderar(out string pConsiderar)
        {
            if (rgConsiderar.EditValue != null)
            {
                pConsiderar = rgConsiderar.EditValue.ToString();
            }
            else
            {
                pConsiderar = "0";
            }
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

            if (String.IsNullOrEmpty(rgConsiderar.EditValue.ToString()))
            {
                msg.Append("Verifique anomalias Considerar.\n");
                flag = false;
                dxErroProvider.SetError(rgConsiderar, "Campo Obrigátorio.");
            }
            else
            {
                dxErroProvider.SetError(rgConsiderar, String.Empty);
            }

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
