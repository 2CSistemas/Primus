using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using cwkGestao.Negocio;

namespace Aplicacao.Relatorios
{
    public partial class CReceberPorTipoDocumento : Aplicacao.Relatorios.FormBaseContas
    {
        int Tipo;
        DocumentoController controllerDocumento = DocumentoController.Instancia;
        protected List<Modelo.Portador> listaPortador = new List<Modelo.Portador>();
        protected List<int> listaRowHandlePortador = new List<int>();
        protected Modelo.Portador objPortador = new Modelo.Portador();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pTipo">quando pTipo for igual a 0 chama o relatorio por tipo documento
        /// quando o pTipo form igual a 1 chama o relatorio por portador</param>
        public CReceberPorTipoDocumento(int pTipo)
        {
            InitializeComponent();
            Tipo = pTipo;
        }

        protected override void FormBase_Load(object sender, System.EventArgs e)
        {
            base.FormBase_Load(sender, e);
            if (Tipo == 0)
            {
                base.Carrega();
            }
            else
            {
                Carrega();
                this.Text = "Contas a Receber por Portador";
                labelControl10.Text = "Portadores";
            }
        }

        protected void Carrega()
        {
            this.gvTipoDocumento.OptionsSelection.MultiSelect = true;
            gcTipoDocumento.DataSource = (from t in db.Portadors
                                          select new
                                          {
                                              Codigo = t.Codigo,
                                              Nome = t.Nome,
                                              ID = t.ID
                                          });
            base.CarregaPortador();
        }

        protected override void btOk_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                base.btOk_Click(sender, e);
                List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", Titulo);
                Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", txtDtInicial.DateTime.ToString());
                Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", txtDtFinal.DateTime.ToString());
                Microsoft.Reporting.WinForms.ReportParameter p4 = new Microsoft.Reporting.WinForms.ReportParameter("Situacao", cbSituacao.Text);
                Microsoft.Reporting.WinForms.ReportParameter p5 = new Microsoft.Reporting.WinForms.ReportParameter("Tipo", "Contas a receber por " + (Tipo != 0 ? "Portador" : ""));
                parametros.Add(p1);
                parametros.Add(p2);
                parametros.Add(p3);
                parametros.Add(p4);
                parametros.Add(p5);
                if (Tipo == 0)
                {
                    Relatorio.cwkGestaoDataSet dt = new Relatorio.cwkGestaoDataSet();
                    Relatorio.cwkGestaoDataSetTableAdapters.p_CReceberTableAdapter p_CReceberTableAdapter = new Relatorio.cwkGestaoDataSetTableAdapters.p_CReceberTableAdapter();
                    Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase("rptContasPorTipoDocumento.rdlc", "cwkGestaoDataSet_p_CReceber", p_CReceberTableAdapter.GetData("VEN", cbSituacao.Text, txtDtInicial.DateTime, txtDtFinal.DateTime, (int)Modelo.TipoDocumentoType.Receber, MontaString(), 0), parametros);
                    form.Show();
                }
                else
                {
                    IList<object> resultado = controllerDocumento.GetContaPorPortador(txtDtInicial.DateTime, txtDtFinal.DateTime, (int)Modelo.TipoDocumentoType.Receber, MontaStringEmpresas(), MontaStringPortadores(), cbSituacao.Text);

                    if (resultado.Count == 0)
                    {
                        MessageBox.Show("Não foram encontrados registros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase("rptContasPorPortador.rdlc", "cwkGestaoDataSet_ContasPorPortador", resultado, parametros);
                    form.Show();
                }
                //this.Close();
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente.");
            }
        }

        protected override void ValidaSelectManutencao()
        {
            if (Tipo == 0)
            {
                base.ValidaSelectManutencao();
            }
            else
            {
                if (gvTipoDocumento.OptionsSelection.MultiSelect == true)
                {
                    listaPortador.Clear();
                    listaRowHandlePortador.Clear();
                    if (gvTipoDocumento.GroupCount == 0)
                    {
                        for (int y = 0; y < gvTipoDocumento.SelectedRowsCount; y++)
                        {
                            if (gvTipoDocumento.GetSelectedRows()[y] >= 0)
                            {
                                listaRowHandlePortador.Add(gvTipoDocumento.GetSelectedRows()[y]);
                                listaPortador.Add((Modelo.Portador)objPortador.getObjeto(db, (int)gvTipoDocumento.GetRowCellValue(gvTipoDocumento.GetSelectedRows()[y], "ID")));
                            }
                        }
                    }
                }
            }
        }

        protected string MontaStringEmpresas()
        {
            string empresas = "";
            int cont = 0;
            foreach (Modelo.Filial f in listaEmpresas)
            {
                if (cont == 0)
                    empresas += "(";
                if (cont != (listaEmpresas.Count - 1))
                    empresas += f.ID + ",";
                else
                    empresas += f.ID + ")";
                cont++;
            }
            return empresas.ToString();
        }

        protected string MontaStringPortadores()
        {
            string portadores = "";
            int cont = 0;
            foreach (Modelo.Portador f in listaPortador)
            {
                if (cont == 0)
                    portadores += "(";
                if (cont != (listaPortador.Count - 1))
                    portadores += f.ID + ",";
                else
                    portadores += f.ID + ")";
                cont++;
            }
            return portadores.ToString();
        }

        protected bool ValidaCampos()
        {
            bool ret = true;
            foreach (Control c in tabPage1.Controls)
            {
                errorProvider1.SetError(c, "");
                switch (c.Name)
                {
                    case "cbGrupo":
                        if (c.Text == "")
                        {
                            errorProvider1.SetError(c, "Escolha um grupo.");
                            ret = false;
                        }
                        break;
                    case "cbSituacao":
                        if (c.Text == "")
                        {
                            errorProvider1.SetError(c, "Campo não pode ficar em branco.");
                            ret = false;
                        }
                        else
                        {
                            if (!((DevExpress.XtraEditors.ComboBoxEdit)c).Properties.Items.Contains(c.Text))
                            {
                                errorProvider1.SetError(c, "Valor incorreto.");
                                ret = false;
                            }
                        }
                        break;
                    case "txtDtInicial":
                        if (c.Text == "")
                        {
                            errorProvider1.SetError(c, "Selecione a data inicial.");
                            ret = false;
                        }
                        break;
                    case "txtDtFinal":
                        if (c.Text == "")
                        {
                            errorProvider1.SetError(c, "Selecione a data final.");
                            ret = false;
                        }
                        break;
                }
            }
            return ret;
        }
    }
}
