using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using Relatorio.dsComissaoVendedorProdutoServicoTableAdapters;
using Modelo.Objeto;

namespace Aplicacao.Relatorios
{
    public partial class ComissaoVendedorFinanceiroProdutoServico : Aplicacao.Relatorios.Base.FormBaseEmpresa
    {
        Modelo.Vendedor objVendedor = new Modelo.Vendedor();
        Modelo.TipoNota objTipoNota = new Modelo.TipoNota();
        public ComissaoVendedorFinanceiroProdutoServico()
        {
            InitializeComponent();
            Name = "ComissaoVendedorFinanceiroProdutoServico";

            cbVendedor.Properties.DisplayMember = "Nome";
            cbVendedor.Properties.ValueMember = "ID";
            cbVendedor.EditValue = 0;
            InicializaCampos();
            Carrega();
            
        }

        private void InicializaCampos()
        {
            cbVendedor.Properties.DataSource = objVendedor.getListaCombo(db);
            //cbVendedor.Properties.DataSource = ((List<Modelo.Vendedor>)objVendedor.getLista(db)).OrderBy(x => x.Pessoa.Nome);
            gcTipoNota.DataSource = objTipoNota.getLista(db);
            
            gcTipoNota.RefreshDataSource();
            //cbVendedor.Enabled = true;
            //cbVendedor.Refresh();
            //cbGrupo.ItemIndex = 1;
            
            cbGrupo.Refresh();
        }

        private bool ValidaCampos()
        {
            StringBuilder erros = new StringBuilder();
            if (cbGrupo.EditValue == null)
                erros.AppendLine("Selecione um Grupo.");
            if (gvEmpresas.SelectedRowsCount == 0)
                erros.AppendLine("Selecione uma Empresa.");
            if (gvTipoNota.SelectedRowsCount == 0)
                erros.AppendLine("Selecione um ou mais Tipos de Nota.");
            if (txtFim.EditValue == null || txtInicio.EditValue == null)
                erros.AppendLine("Selecione as datas inicial e final.");
            else if ((DateTime)txtFim.EditValue < (DateTime)txtInicio.EditValue)
                erros.AppendLine("Data inicial maior que final.");
            if (cbVendedor.EditValue == null && !cbTodos.Checked)
                erros.AppendLine("Selecione um Vendedor.");
            String msg = erros.ToString();
            if (msg.Length > 0)
            {
                MessageBox.Show(msg);
            }
            return msg.Length == 0;
        }

        private void cbTodos_CheckedChanged(object sender, EventArgs e)
        {
            cbVendedor.Enabled = !cbTodos.Checked;
            sbVendedor.Enabled = !cbTodos.Checked;
        }

        protected override void btOk_Click(object sender, EventArgs e)
        {
            Configuracao config = ConfiguracaoController.Instancia.GetAll()[0];


            if (ValidaCampos())
            {
                int idVend = 0;
                base.btOk_Click(sender, e);
                List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("dataInicio", txtInicio.EditValue.ToString().Substring(0, 10));
                Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("dataFim", txtFim.EditValue.ToString().Substring(0,10));
                
                
                String nomeEmpresa = "";
                List<int> empresaIds = new List<int>();
                List<int> tipoNotaIds = new List<int>();
                
                foreach (int handle in gvTipoNota.GetSelectedRows())
                {
                    tipoNotaIds.Add(Convert.ToInt32(gvTipoNota.GetRowCellValue(handle, "ID")));
                }
                foreach (int handle in gvEmpresas.GetSelectedRows())
	            {
            	    empresaIds.Add( Convert.ToInt32(gvEmpresas.GetRowCellValue(handle, "ID")));
	            }

                if (gvEmpresas.SelectedRowsCount > 1)
                    nomeEmpresa = cbGrupo.Text.Substring(0, cbGrupo.Text.IndexOf("|"));
                else
                    nomeEmpresa = gvEmpresas.GetRowCellValue(gvEmpresas.GetSelectedRows()[0], "Nome").ToString();

                Microsoft.Reporting.WinForms.ReportParameter p4 = new Microsoft.Reporting.WinForms.ReportParameter("empresaNome", nomeEmpresa);

                parametros.Add(p1);
                parametros.Add(p2);
                
                parametros.Add(p4);
                
                BLL.ProdutoVendedorComissao produtoVendedorComissaoBLL = new BLL.ProdutoVendedorComissao(db);

                if(!cbTodos.Checked)
                    idVend = cbVendedor.EditValue != null? Convert.ToInt32(cbVendedor.EditValue) : 0;

                ComissaoFinanceiroVendedorProdutoServicoTableAdapter dsComissaoFinanceiroVendedorProdutoServicoTableAdapter = new ComissaoFinanceiroVendedorProdutoServicoTableAdapter();
                DataTable dataTable = null;

                String idsTipoNota = String.Join(",", tipoNotaIds);
                dataTable = dsComissaoFinanceiroVendedorProdutoServicoTableAdapter.GetData(idVend, txtInicio.DateTime, txtFim.DateTime, idsTipoNota);


                IList<pxyComissaoFinanceiroVendedorProdServRel> listaComissaoFinanceiroVendedorProdServRel = new List<pxyComissaoFinanceiroVendedorProdServRel>();
                listaComissaoFinanceiroVendedorProdServRel = dataTable.ConvertTo<pxyComissaoFinanceiroVendedorProdServRel>();


                IList<ProdutoVendedorComissao> lstaProdutoVendedorComissao = ProdutoVendedorComissaoController.Instancia.GetAll();
                IList<ProdutoVendedorComissao> lstaProdutoVendedorComissaoProd = new List<ProdutoVendedorComissao>();
                IList<ProdutoVendedorComissao> lstaProdutoVendedorComissaoGE = new List<ProdutoVendedorComissao>();
                IList<ProdutoVendedorComissao> lstaProdutoVendedorComissaoServico = new List<ProdutoVendedorComissao>();

                Decimal percComissao = 0;

                foreach (pxyComissaoFinanceiroVendedorProdServRel item in listaComissaoFinanceiroVendedorProdServRel)
                {
                    Nota n = NotaController.Instancia.LoadObjectById(item.IDNota);
                    cwkGestao.Modelo.Documento d = DocumentoController.Instancia.LoadObjectById(item.IDDocumento);
                    
                    if ((n.NotaItems != null) && (n.NotaItems.Count() > 0))
                    {
                        item.TipoComissao = "Produtos";

                        lstaProdutoVendedorComissaoProd = BuscaLstComissaoProduto(lstaProdutoVendedorComissaoProd, n);

                        if (lstaProdutoVendedorComissaoProd.Count() == 0)
                        {
                            lstaProdutoVendedorComissaoGE = BuscaLstComissaoGrupoEstoque(lstaProdutoVendedorComissao, lstaProdutoVendedorComissaoGE, n);

                            if (lstaProdutoVendedorComissaoGE.Count() == 0)
                            {
                                percComissao = n.Vendedor.ComissaoVendedor.HasValue ? n.Vendedor.ComissaoVendedor.Value : 0;
                            }
                            else
                            {
                                percComissao = lstaProdutoVendedorComissaoGE.Sum(s => s.ComissaoPctGrupoEstoque) / lstaProdutoVendedorComissaoGE.Count();
                            }
                        }
                        else
                        {
                            percComissao = lstaProdutoVendedorComissaoProd.Sum(s => s.ComissaoPct) / lstaProdutoVendedorComissaoProd.Count();
                        }
                    }
                    else
                    {
                        item.TipoComissao = "Serviços";

                        lstaProdutoVendedorComissaoServico = BuscaLstComissaoServico(lstaProdutoVendedorComissaoServico, n);

                        if (lstaProdutoVendedorComissaoServico.Count() == 0)
                        {
                            percComissao = n.Vendedor.ComissaoServicoVendedor.HasValue ? n.Vendedor.ComissaoServicoVendedor.Value : 0;                      
                        }
                        else
                        {
                            percComissao = lstaProdutoVendedorComissaoServico.Sum(s => s.ComissaoPctServico) / lstaProdutoVendedorComissaoServico.Count();
                        }
                    }

                    item.ComissaoPct = percComissao;
                    item.ComissaoValor = (item.ComissaoPct/100) * item.Valor;
                }

                DataTable dataTableAlterado = Extensions.ToDataTable<pxyComissaoFinanceiroVendedorProdServRel>(listaComissaoFinanceiroVendedorProdServRel);

                Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase("rptComissaoFinanceiroVendedorProdutoServico.rdlc", "dsComissaoVendedorProdutoServico_ComissaoFinanceiroVendedorProdutoServico", dataTableAlterado, parametros);
                form.Show();
            }
        }

        private static IList<ProdutoVendedorComissao> BuscaLstComissaoServico(IList<ProdutoVendedorComissao> lstaProdutoVendedorComissaoServico, Nota n)
        {
            IList<Int32> servicos = new List<Int32>();
            servicos = n.NotaItemsServicos.Select(s => s.Servico.ID).ToList();
            lstaProdutoVendedorComissaoServico = ProdutoVendedorComissaoController.Instancia.GetComissaoServico(servicos.ToArray(), n.Vendedor.ID);
            return lstaProdutoVendedorComissaoServico;
        }

        private static IList<ProdutoVendedorComissao> BuscaLstComissaoGrupoEstoque(IList<ProdutoVendedorComissao> lstaProdutoVendedorComissao, 
            IList<ProdutoVendedorComissao> lstaProdutoVendedorComissaoGE, Nota n)
        {
            IList<Int32> gruposEstoque = new List<Int32>();
            IList<GrupoEstoque> lstGrupoEstoque = new List<GrupoEstoque>();
            lstGrupoEstoque = n.NotaItems.Select(s => s.Produto.GrupoEstoque).ToList();

            foreach (GrupoEstoque ge in lstGrupoEstoque)
            {
                if ((ge != null) && (ge.ID > 0))
                {
                    gruposEstoque.Add(ge.ID);
                }
            }

            lstaProdutoVendedorComissaoGE = ProdutoVendedorComissaoController.Instancia.GetComissaoGrupoEstoque(gruposEstoque.ToArray(), n.Vendedor.ID);

            return lstaProdutoVendedorComissaoGE;
        }

        private static IList<ProdutoVendedorComissao> BuscaLstComissaoProduto(IList<ProdutoVendedorComissao> lstaProdutoVendedorComissaoProd, Nota n)
        {
            IList<Int32> produtos = new List<Int32>();
            produtos = n.NotaItems.Select(s => s.Produto.ID).ToList();
            lstaProdutoVendedorComissaoProd = ProdutoVendedorComissaoController.Instancia.GetComissaoProduto(produtos.ToArray(), n.Vendedor.ID);
            return lstaProdutoVendedorComissaoProd;
        }

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

        private void sbVendedor_Click(object sender, EventArgs e)
        {
            //GridSelecao("Tabela de Vendedor", cbVendedor, objVendedor);

            GridGenerica<Pessoa> grid = new GridGenerica<Pessoa>(PessoaController.Instancia.GetAllVendedores(), new FormPessoa(), false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();
            if (grid.Selecionado != null)
            {
                cbVendedor.EditValue = grid.Selecionado.ID;
            }
        }

        
        protected override void GravaXML(bool gravar)
        {
            XElement documentoXml = new XElement(this.Name);
            XElement element = null;
            XElement empresas = null;
            XElement tiposnota = null;
            List<int> listaRowHandleTipoNota = gvTipoNota.GetSelectedRows().ToList();
            

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

                if (listaRowHandleTipoNota.Count > 0)
                {
                    tiposnota = new XElement("tiposNota");

                    foreach (int f in listaRowHandleTipoNota)
                    {
                        XElement tipoNota = new XElement("tipoNota");
                        tipoNota.SetValue(f);
                        tiposnota.Add(tipoNota);
                    }

                    element.Add(tiposnota);
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
            List<int> listaRowHandleTipoNota = new List<int>();
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
                    gvTipoNota.ClearSelection();
                    foreach (var item in xml.Elements("filtros").Elements("tiposNota").Elements())
                    {
                        int aux = Convert.ToInt32(item.Value);
                        //listaRowHandleTipoNota.Add(aux);
                        gvTipoNota.FocusedRowHandle = aux;
                        gvTipoNota.SelectRow(aux);
                        //gvTipoNota.FocusedRowHandle = aux;
                        //gvTipoNota.SelectRow(gvTipoNota.FocusedRowHandle);
                        count++;
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }


  
}
