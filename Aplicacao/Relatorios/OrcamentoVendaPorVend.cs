using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using cwkGestao.Negocio;

namespace Aplicacao.Relatorios
{
    public partial class OrcamentoVendaPorVend : Aplicacao.Relatorios.Base.FormBaseEmpresa
    {
        Modelo.Vendedor objVendedor = new Modelo.Vendedor();
        List<Modelo.Vendedor> listaVendedores = new List<Modelo.Vendedor>();
        List<int> listaRowHandleVendedores = new List<int>();

        List<Modelo.TipoPedido> listaTipoOrcamento = new List<Modelo.TipoPedido>();
        List<int> listaRowHandleOrcamento = new List<int>();
        int TipoRelatorio = 0;
        /// <summary>
        /// 0->Orcamento Vendedor 1-> Orcamento Data 2-> Orcamento Tipo Orcamento
        /// 3->Pedido Vendedor 4-> Pedido Data 5-> Pedido Tipo Pedido
        /// </summary>
        /// <param name="pTipoRelatorio"></param>
        public OrcamentoVendaPorVend(int pTipoRelatorio)
        {
            TipoRelatorio = pTipoRelatorio;
            InitializeComponent();

            switch (TipoRelatorio)
            {
                case 0:
                    this.Text = "Relatório de Orçamento por Vendedor";
                    PreencheDataSourcesOrcamento();
                    cbStatus.Properties.Items.Clear();
                    cbStatus.Properties.Items.Add("Aberto");
                    cbStatus.SelectedItem = "Aberto";
                    this.Name = "FormRelOrcamento";
                    break;
                case 1:
                    this.Text = "Relatório de Orçamento por Data";
                    PreencheDataSourcesOrcamento();
                    cbStatus.Properties.Items.Clear();
                    cbStatus.Properties.Items.Add("Aberto");
                    cbStatus.SelectedItem = "Aberto";
                    this.Name = "FormRelOrcamento";
                    break;
                case 2:
                    this.Text = "Relatório de Orçamento por Tipo Orçamento";
                    PreencheDataSourcesOrcamento();
                    cbStatus.Properties.Items.Clear();
                    cbStatus.Properties.Items.Add("Aberto");
                    cbStatus.SelectedItem = "Aberto";
                    this.Name = "FormRelOrcamento";
                    break;
                case 3:
                    this.Text = "Relatório de Pedido por Vendedor";
                    labelControl5.Text = "Tipo Pedido";
                    PreencheDataSourcesPedido();
                    cbStatus.SelectedItem = "Aberto";
                    this.Name = "FormRelPedido";
                    break;
                case 4:
                    this.Text = "Relatório de Pedido por Data";
                    labelControl5.Text = "Tipo Pedido";
                    PreencheDataSourcesPedido();
                    cbStatus.SelectedItem = "Aberto";
                    this.Name = "FormRelPedido";
                    break;
                case 5:
                    this.Text = "Relatório de Pedido por Tipo Pedido";
                    labelControl5.Text = "Tipo Pedido";
                    PreencheDataSourcesPedido();
                    cbStatus.SelectedItem = "Aberto";
                    this.Name = "FormRelPedido";
                    break;
            }

        }

        protected override void GravaXML(bool gravar)
        {
            XElement documentoXml = new XElement(this.Name);
            XElement element = null;
            XElement empresas = null;
            XElement orcamentos = null;
            XElement vendedores = null;

            if (gravar)
            {
                documentoXml.SetElementValue("ler", gravar.ToString());

                documentoXml.SetElementValue("titulo", Titulo);

                element = new XElement("filtros", new XComment("Filtros do formulario"));

                if (listaRowHandle.Count > 0)
                {
                    empresas = new XElement("empresas");

                    foreach (int f in listaRowHandle)
                    {
                        XElement empresa = new XElement("empresa");
                        empresa.SetValue(f);
                        empresas.Add(empresa);
                    }

                    element.Add(empresas);
                }

                if (listaRowHandleOrcamento.Count > 0)
                {
                    orcamentos = new XElement("orcamentos");

                    foreach (int f in listaRowHandleOrcamento)
                    {
                        XElement orcamento = new XElement("orcamento");
                        orcamento.SetValue(f);
                        orcamentos.Add(orcamento);
                    }

                    element.Add(orcamentos);
                }

                if (listaRowHandleVendedores.Count > 0)
                {
                    vendedores = new XElement("vendedores");

                    foreach (int f in listaRowHandleVendedores)
                    {
                        XElement vendedor = new XElement("vendedor");
                        vendedor.SetValue(f);
                        vendedores.Add(vendedor);
                    }

                    element.Add(vendedores);
                }

                foreach (Control campo in tabPage1.Controls)
                {
                    if (campo is DevExpress.XtraEditors.CheckEdit)
                    {
                        element.SetElementValue(campo.Name, ((DevExpress.XtraEditors.CheckEdit)campo).Checked);
                    }
                    else if (campo is DevExpress.XtraEditors.DateEdit)
                    {
                        element.SetElementValue(campo.Name, ((DevExpress.XtraEditors.DateEdit)campo).EditValue);
                    }
                    else if (campo is DevExpress.XtraEditors.BaseEdit)
                    {
                        element.SetElementValue(campo.Name, ((DevExpress.XtraEditors.BaseEdit)campo).EditValue);
                    }
                }

                documentoXml.Add(element);
            }
            else
            {
                documentoXml.SetElementValue("ler", gravar.ToString());
            }
            documentoXml.Save(Arquivo.ToString());

        }

        protected override void LeXML()
        {
            try
            {
                XElement xml = XElement.Load(Arquivo.ToString(), LoadOptions.SetBaseUri | LoadOptions.SetLineInfo);
                if (xml.Elements("ler").Single().Value.ToLower() == "true")
                {
                    chbSalvarFiltro.Checked = true;

                    foreach (Control campo in tabPage1.Controls)
                    {
                        if (campo is DevExpress.XtraEditors.PopupBaseEdit)
                        {
                            switch (campo.GetType().ToString())
                            {
                                case "Componentes.devexpress.cwk_DevLookup":
                                    ((DevExpress.XtraEditors.PopupBaseEdit)campo).EditValue = Convert.ToInt32(xml.Elements("filtros").Elements(campo.Name).Single().Value);
                                    break;
                                case "DevExpress.XtraEditors.DateEdit":
                                    ((DevExpress.XtraEditors.DateEdit)campo).EditValue = Convert.ToDateTime(xml.Elements("filtros").Elements(campo.Name).Single().Value);
                                    break;
                                default:
                                    ((DevExpress.XtraEditors.PopupBaseEdit)campo).EditValue = (Object)xml.Elements("filtros").Elements(campo.Name).Single().Value;
                                    break;
                            }
                        }
                        else if (campo is DevExpress.XtraEditors.CheckEdit)
                        {
                            ((DevExpress.XtraEditors.CheckEdit)campo).Checked = Convert.ToBoolean(xml.Elements("filtros").Elements(campo.Name).Single().Value);

                        }
                    }
                    int count = 0;
                    foreach (var item in xml.Elements("filtros").Elements("empresas").Elements())
                    {
                        if (count == 0)
                        {
                            gvEmpresas.ClearSelection();
                        }
                        int aux = Convert.ToInt32(item.Value);
                        listaRowHandle.Add(aux);
                        gvEmpresas.FocusedRowHandle = aux;
                        gvEmpresas.SelectRow(gvEmpresas.FocusedRowHandle);
                        count++;
                    }

                    foreach (var item in xml.Elements("filtros").Elements("orcamentos").Elements())
                    {
                        if (count == 0)
                        {
                            gvTipoOrcamento.ClearSelection();
                        }
                        int aux = Convert.ToInt32(item.Value);
                        listaRowHandleOrcamento.Add(aux);
                        gvTipoOrcamento.FocusedRowHandle = aux;
                        gvTipoOrcamento.SelectRow(gvTipoOrcamento.FocusedRowHandle);
                        count++;
                    }

                    foreach (var item in xml.Elements("filtros").Elements("vendedores").Elements())
                    {
                        if (count == 0)
                        {
                            gvVendedores.ClearSelection();
                        }
                        int aux = Convert.ToInt32(item.Value);
                        listaRowHandleVendedores.Add(aux);
                        gvVendedores.FocusedRowHandle = aux;
                        gvVendedores.SelectRow(gvVendedores.FocusedRowHandle);
                        count++;
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void PreencheDataSourcesOrcamento()
        {
            gcTipoOrcamento.DataSource = null;
            gcTipoOrcamento.DataSource = (from t in db.TipoPedidos
                                          where t.Tipo == Modelo.TipoPedidoType.Orçamento
                                          select new
                                          {
                                              nome = t.Nome,
                                              id = t.ID
                                          }).ToList();
            gvTipoOrcamento.ClearSelection();

            
            gcVendedores.DataSource = null;
            gcVendedores.DataSource = (from v in db.Vendedors
                                       where v.Pessoa.bVendedor == 1
                                       select new
                                       {
                                           nome = v.Pessoa.Nome,
                                           codigo = v.Pessoa.Codigo,
                                           id = v.ID
                                       }).ToList();
            gvVendedores.ClearSelection();
        }

        private void PreencheDataSourcesPedido()
        {
            gvTipoOrcamento.ClearSelection();
            gcTipoOrcamento.DataSource = null;
            gcTipoOrcamento.DataSource = (from t in db.TipoPedidos
                                          where t.Tipo == Modelo.TipoPedidoType.Pedido
                                          select new
                                          {
                                              nome = t.Nome,
                                              id = t.ID
                                          }).ToList();

            
            gcVendedores.DataSource = null;
            gcVendedores.DataSource = (from v in db.Vendedors
                                       where v.Pessoa.bVendedor == 1
                                       select new
                                       {
                                           nome = v.Pessoa.Nome,
                                           codigo = v.Pessoa.Codigo,
                                           id = v.ID
                                       }).ToList();
            gvVendedores.ClearSelection();
        }

        protected override void FormBase_Load(object sender, System.EventArgs e)
        {
            base.FormBase_Load(sender, e);
            Carrega();
        }

        protected override void btOk_Click(object sender, EventArgs e)
        {
            BLL.Pedido bllPedido = new BLL.Pedido(db);
            List<int> listaIdVendedores = new List<int>();
            List<int> listaIdOrcamentos = new List<int>();
            List<int> listaIdEmpresas = new List<int>();
            IList<object> listaOrcamentos = new List<object>();
            string Relatorio = "", TextoRelatorio = "";
           

            if (ValidaCampos())
            {
                ValidaSelectVendedor();
                listaIdVendedores = MontaListaVendedores();
                ValidaSelectTipoOrcamento();
                listaIdOrcamentos = MontaListaTipoOrcamento();
                MontaStringEmpresas();
                ValidaSelectManutencao();
                listaIdEmpresas = (from f in listaEmpresas select f.ID).ToList();

                switch (TipoRelatorio)
                {
                    case 0:
                        Relatorio = "rptOrcamentoPorVendedor.rdlc";
                        listaOrcamentos = bllPedido.getListaOrcamentos(listaIdEmpresas, cbStatus.Text, listaIdVendedores, listaIdOrcamentos, txtDtInicial.DateTime, txtDtFinal.DateTime);
                        TextoRelatorio = "Orçamentos Por Vendedor";
                        break;
                    case 1:
                        Relatorio = "rptOrcamentoPorDatanew.rdlc";
                        listaOrcamentos = bllPedido.getListaOrcamentos(listaIdEmpresas, cbStatus.Text, listaIdVendedores, listaIdOrcamentos, txtDtInicial.DateTime, txtDtFinal.DateTime);
                        TextoRelatorio = "Orçamentos Por Data";
                        break;
                    case 2:
                        Relatorio = "rptOrcamentoPorTipo.rdlc";
                        listaOrcamentos = bllPedido.getListaOrcamentos(listaIdEmpresas, cbStatus.Text, listaIdVendedores, listaIdOrcamentos, txtDtInicial.DateTime, txtDtFinal.DateTime);
                        TextoRelatorio = "Orçamentos Por Tipo Orçamento";
                        break;
                    case 3:
                        Relatorio = "rptPedidoPorVendedor.rdlc";
                        listaOrcamentos = PedidoController.Instancia.getListaPedidos(listaIdEmpresas, cbStatus.Text, listaIdVendedores, listaIdOrcamentos, txtDtInicial.DateTime, txtDtFinal.DateTime);
                        TextoRelatorio = "Vendas Por Vendedor";
                        break;
                    case 4:
                        Relatorio = "rptPedidoPorData.rdlc";
                        listaOrcamentos = PedidoController.Instancia.getListaPedidos(listaIdEmpresas, cbStatus.Text, listaIdVendedores, listaIdOrcamentos, txtDtInicial.DateTime, txtDtFinal.DateTime);
                        TextoRelatorio = "Pedidos Por Data";
                        break;
                    case 5:
                        Relatorio = "rptPedidoPorTipo.rdlc";
                        listaOrcamentos = PedidoController.Instancia.getListaPedidos(listaIdEmpresas, cbStatus.Text, listaIdVendedores, listaIdOrcamentos, txtDtInicial.DateTime, txtDtFinal.DateTime);
                        TextoRelatorio = "Pedidos Por Tipo Pedido";
                        break;
                }
                base.btOk_Click(sender, e);
                List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", txtDtInicial.DateTime.ToString());
                Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", txtDtFinal.DateTime.ToString());
                Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("Status", cbStatus.Text);
                Microsoft.Reporting.WinForms.ReportParameter p4 = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", Titulo);
                Microsoft.Reporting.WinForms.ReportParameter p5 = new Microsoft.Reporting.WinForms.ReportParameter("Tipo", TextoRelatorio);
                parametros.Add(p1);
                parametros.Add(p2);
                parametros.Add(p3);
                parametros.Add(p4);
                parametros.Add(p5);                
                Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase(Relatorio, "cwkGestaoDataSet_Orcamento", listaOrcamentos, parametros);
                form.Show();                
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente.");
            }
        }

        private void ValidaSelectVendedor()
        {
            if (gvVendedores.OptionsSelection.MultiSelect == true)
            {
                List<Modelo.Vendedor> vendedores = (from v in db.Vendedors select v).ToList();
                listaVendedores.Clear();
                listaRowHandleVendedores.Clear();
                if (gvVendedores.GroupCount == 0)
                {
                    for (int y = 0; y < gvVendedores.SelectedRowsCount; y++)
                    {
                        if (gvVendedores.GetSelectedRows()[y] >= 0)
                        {
                            listaRowHandleVendedores.Add(gvVendedores.GetSelectedRows()[y]);
                            listaVendedores.AddRange(vendedores.Where(f => f.ID == (int)gvVendedores.GetRowCellValue(gvVendedores.GetSelectedRows()[y], gvVendedores.Columns["id"])).ToList());
                        }
                    }
                }
            }
        }

        private List<int> MontaListaVendedores()
        {
            List<int> lista = new List<int>();

            foreach (Modelo.Vendedor e in listaVendedores)
            {
                lista.Add(e.ID);
            }
            return lista;
        }

        private List<int> MontaListaTipoOrcamento()
        {
            List<int> lista = new List<int>();

            foreach (Modelo.TipoPedido e in listaTipoOrcamento)
            {
                lista.Add(e.ID);
            }
            return lista;
        }

        private void ValidaSelectTipoOrcamento()
        {
            if (gvTipoOrcamento.OptionsSelection.MultiSelect == true)
            {
                List<Modelo.TipoPedido> TipoOrcamentos = (from t in db.TipoPedidos select t).ToList();
                listaTipoOrcamento.Clear();
                listaRowHandleOrcamento.Clear();
                if (gvVendedores.GroupCount == 0)
                {
                    for (int y = 0; y < gvTipoOrcamento.SelectedRowsCount; y++)
                    {
                        if (gvTipoOrcamento.GetSelectedRows()[y] >= 0)
                        {
                            listaRowHandleOrcamento.Add(gvTipoOrcamento.GetSelectedRows()[y]);
                            listaTipoOrcamento.AddRange(TipoOrcamentos.Where(f => f.ID == (int)gvTipoOrcamento.GetRowCellValue(gvTipoOrcamento.GetSelectedRows()[y], gvTipoOrcamento.Columns["id"])).ToList());
                        }
                    }
                }
            }
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

        /// <summary>
        /// Método que chama o grid para selecionar um elemento
        /// </summary>
        /// <param name="ptitulo">Título do grid</param>
        /// <param name="pCb">combobox que irá chamar o grid</param>
        /// <param name="gl">objeto que irá retornar a lista para preencher o combo</param>
        private void GridSelecao(string ptitulo, Componentes.devexpress.cwk_DevLookup pCb, Modelo.IMetodosCwork gl)
        {
            Aplicacao.GridPadrao pGp = new Aplicacao.GridPadrao(ptitulo, true, (int)pCb.EditValue);
            if (cwkControleUsuario.Facade.ControleAcesso(pGp))
            {
                pGp.ShowDialog();
                if (pGp.atualiza == true)
                {
                    pCb.Properties.DataSource = gl.getLista(db);
                }
                if (pGp.Retorno.Length != 0)
                {
                    pCb.EditValue = int.Parse(pGp.Retorno);
                }
            }
            pCb.Focus();
        }

        private void sbSelecionarFuncionarios_Click(object sender, EventArgs e)
        {
            gvTipoOrcamento.SelectAll();
        }

        private void sbLimparFuncionarios_Click(object sender, EventArgs e)
        {
            gvTipoOrcamento.ClearSelection();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            gvVendedores.SelectAll();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gvVendedores.ClearSelection();
        }
    }
}
