using Aplicacao.Interfaces;
using cwkGestao.Modelo;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPivotGrid.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;

using MO = Modelo;

namespace Aplicacao.Util
{
    public static class GridUtil
    {
        public static void CarregarLayoutSalvo(this IFormGrid form)
        {
            foreach (var grid in form.Grids)
            {
                if (!string.IsNullOrEmpty(grid.XmlLayout)
                    && cwkGestao.Negocio.ConfiguracaoController.Instancia.GetConfiguracao().BSalvarFiltroGrid
                    && File.Exists(grid.XmlLayout))
                {
                    grid.View.RestoreLayoutFromXml(grid.XmlLayout, DevExpress.Utils.OptionsLayoutBase.FullLayout);
                }
            }
        }

        public static void SalvarLayoutGrids(this IFormGrid form)
        {
            foreach (var grid in form.Grids)
            {
                if (!string.IsNullOrEmpty(grid.XmlLayout) && cwkGestao.Negocio.ConfiguracaoController.Instancia.GetConfiguracao().BSalvarFiltroGrid)
                    grid.View.SaveLayoutToXml(grid.XmlLayout, DevExpress.Utils.OptionsLayoutBase.FullLayout);
            }
        }

        public static void DeletarLayoutGrids(this IFormGrid form)
        {
            foreach (var grid in form.Grids)
            {
                if (File.Exists(grid.XmlLayout))
                {
                    File.Delete(grid.XmlLayout);
                }
            }
        }

        public static void MontarColunasDeTodosGrids(this IFormGrid form)
        {
            foreach (var grid in form.Grids)
            {
                MontarColunasGrid(form, grid);
            }
        }

        private static void MontarColunasGrid(IFormGrid form, TupleIFormGrid grid)
        {
            grid.View.Columns.Clear();
            grid.View.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            int totalColWidth = 0;
            Dictionary<InformacaoExibicao, string> infosExib = new Dictionary<InformacaoExibicao, string>();
            foreach (System.Reflection.PropertyInfo propriedade in grid.Tipo.GetProperties())
            {
                foreach (cwkGestao.Modelo.InformacaoExibicao atributo in propriedade.GetCustomAttributes(typeof(cwkGestao.Modelo.InformacaoExibicao), true))
                {
                    if (!atributo.BNaoInserirColuna)
                    {
                        infosExib.Add(atributo, propriedade.Name);
                    }
                }
            }

            List<InformacaoExibicao> infos = infosExib.Keys.OrderBy(atrib => atrib.Sequencia).ToList();
            grid.View.SortInfo.Clear();
            grid.View.SortInfo.ClearSorting();

            foreach (InformacaoExibicao atributo in infos)
            {
                DevExpress.XtraGrid.Columns.GridColumn coluna = new DevExpress.XtraGrid.Columns.GridColumn();

                coluna.VisibleIndex = atributo.Sequencia;
                coluna.Caption = atributo.Header;
                coluna.Visible = true;
                coluna.OptionsColumn.AllowEdit = false;
                coluna.Width = atributo.ColumnWidth;
                totalColWidth += atributo.ColumnWidth;
                coluna.Resize(atributo.ColumnWidth);
                coluna.Visible = true;
                coluna.FieldName = infosExib[atributo];
                coluna.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                coluna.AppearanceHeader.Options.UseTextOptions = true;
                coluna.Name = atributo.Header;
                if (form.CustomSort != null) coluna.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom;
                if (atributo.FormatString != "")
                {
                    coluna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                    coluna.DisplayFormat.FormatString = atributo.FormatString;
                }
                if (atributo.Alinhamento != InformacaoExibicao.HAlinhamento.Padrao)
                {
                    coluna.AppearanceCell.TextOptions.HAlignment = (DevExpress.Utils.HorzAlignment)(int)atributo.Alinhamento;
                    coluna.AppearanceCell.Options.UseTextOptions = true;
                }

                if (atributo.Ordenacao != null)
                {
                    coluna.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom;
                    coluna.SortOrder = atributo.Ordenacao.Value == InformacaoExibicao.FormaOrdenacao.Crescente ? DevExpress.Data.ColumnSortOrder.Ascending : DevExpress.Data.ColumnSortOrder.Descending;
                }

                //if (grid.Tipo.GetProperties().Where(o => o.Name == coluna.FieldName).FirstOrDefault().PropertyType == typeof(DateTime))
                //{
                //    RepositoryItemDateEdit Edit = new RepositoryItemDateEdit();
                //    Edit.EditFormat.FormatType = FormatType.DateTime;
                //    Edit.DisplayFormat.FormatType = FormatType.DateTime;
                //    coluna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                //    coluna.ColumnEdit = Edit;
                //}

                grid.View.Columns.Add(coluna);
            }
            // Mesmo com colunas escondidas este código não era executado.
            //int lostSize = 0;
            //if (grid.ColunasEscondidas != null)
            //{
            //    foreach (var colunasEscondida in grid.ColunasEscondidas)
            //    {
            //        lostSize += grid.View.Columns.ColumnByFieldName(colunasEscondida).Width - 2;
            //        grid.View.Columns.ColumnByFieldName(colunasEscondida).Visible = false;
            //    }
            //}
            //grid.View.VisibleColumns[grid.View.VisibleColumns.Count - 1].Width += lostSize;
            grid.View.RefreshData();
            grid.View.RefreshEditor(false);
            if (grid.View.Columns.Count == 0) throw new NotImplementedException("Classe de entidade " + grid.Tipo.FullName + " não anotada com " + typeof(InformacaoExibicao).Name);
            grid.View.Columns[1].Width += Math.Abs(778 - totalColWidth) > 15 ? (778 - totalColWidth > 0 ? 778 - totalColWidth : 0) : 0;
        }

        [Obsolete]
        public static void MontarColunas(GridControl gridControl)
        {
            GridView gvPrincipal = (GridView)gridControl.DefaultView;
            gvPrincipal.Columns.Clear();
            Type tipo = gridControl.DataSource.GetType().GetGenericArguments()[0];
            foreach (System.Reflection.PropertyInfo propriedade in tipo.GetProperties())
            {
                foreach (InformacaoExibicao atributo in propriedade.GetCustomAttributes(typeof(InformacaoExibicao), true))
                {
                    GridColumn coluna = new GridColumn();

                    //if (propriedade.PropertyType.Name == "DateTime")
                    //{
                    //    RepositoryItemDateEdit Edit = new RepositoryItemDateEdit();
                    //    Edit.EditFormat.FormatType = FormatType.DateTime;
                    //    Edit.DisplayFormat.FormatType = FormatType.DateTime;
                    //    coluna.ColumnEdit = Edit;

                    //    coluna.OptionsFilter.FilterPopupMode = FilterPopupMode.Date;
                    //}

                    // coluna.ColumnType

                    coluna.VisibleIndex = atributo.Sequencia;
                    coluna.Caption = atributo.Header;
                    coluna.Width = atributo.ColumnWidth;
                    coluna.FieldName = propriedade.Name;
                    coluna.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    coluna.AppearanceHeader.Options.UseTextOptions = true;
                    if (atributo.Alinhamento != InformacaoExibicao.HAlinhamento.Padrao)
                    {
                        coluna.AppearanceCell.TextOptions.HAlignment = (DevExpress.Utils.HorzAlignment)(int)atributo.Alinhamento;
                        coluna.AppearanceCell.Options.UseTextOptions = true;
                    }
                    if (atributo.FormatString != "")
                    {
                        coluna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                        coluna.DisplayFormat.FormatString = atributo.FormatString;
                    }
                    gvPrincipal.Columns.Add(coluna);
                }
            }
        }

        public static void CarregarPadraoCorSistema(this IFormGrid form)
        {
            var arquivoPadraoCor = MO.cwkGlobal.DirApp + "\\PadraoCorSistema.xml";
            if (File.Exists(arquivoPadraoCor))
            {
                foreach (var grid in form.Grids) {
                    grid.View.Appearance.RestoreLayoutFromXml(arquivoPadraoCor);
                }
            }
        }

        public static void SetaFocoCelula(GridView grid, int linha, int coluna)
        {
            grid.RefreshData();
            grid.FocusedColumn = grid.Columns[coluna];
            grid.FocusedRowHandle = linha;
        }

        public static object GetRegistroSelecionado(this GridView grid)
         {
            var rowHandle = grid.GetSelectedRows().FirstOrDefault();
            var linhaSelecionada = grid.GetFocusedRow();
            if (linhaSelecionada != null)
                return grid.GetRow(rowHandle);
            return null;
        }

        public static IList<T> ConvertTo<T>(DataTable table)
        {
            if (table == null)
                return null;

            List<DataRow> rows = new List<DataRow>();

            foreach (DataRow row in table.Rows)
                rows.Add(row);

            return ConvertTo<T>(rows);
        }

        public static IList<T> ConvertTo<T>(IList<DataRow> rows)
        {
            IList<T> list = null;

            if (rows != null)
            {
                list = new List<T>();

                foreach (DataRow row in rows)
                {
                    T item = CreateItem<T>(row);
                    list.Add(item);
                }
            }

            return list;
        }

        public static T CreateItem<T>(DataRow row)
        {
            T obj = default(T);
            if (row != null)
            {
                obj = Activator.CreateInstance<T>();

                foreach (DataColumn column in row.Table.Columns)
                {
                    if (column.ColumnName != "PivotGridNullableColumn")
                    {
                        PropertyInfo prop = obj.GetType().GetProperty(column.ColumnName);
                        try
                        {
                            object value = row[column.ColumnName];
                            prop.SetValue(obj, value, null);
                        }
                        catch (Exception c)
                        {
                        }
                    }
                }
            }

            return obj;
        }

        public static IList<T> ConvertPivotDrillDownDataSourceToList<T>(PivotDrillDownDataSource ds)
        {
            ITypedList dataProperties = ds as ITypedList;
            DataTable result = new DataTable();
            if (dataProperties == null)
            {
                return null;
            }
            foreach (PropertyDescriptor prop in dataProperties.GetItemProperties(null))
            {
                if (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    NullableConverter converter = new NullableConverter(prop.PropertyType);
                    result.Columns.Add(prop.Name, converter.UnderlyingType);
                }
                else
                {
                    result.Columns.Add(prop.Name, prop.PropertyType);
                }
            }
            for (int row = 0; row < ds.RowCount; row++)
            {
                List<object> values = new List<object>();
                foreach (DataColumn col in result.Columns)
                    values.Add(ds.GetValue(row, col.ColumnName));
                result.Rows.Add(values.ToArray());
            }
            IList<T> lista = (List<T>)GridUtil.ConvertTo<T>(result);
            return lista;
        }
    }

    public class GridPivotLocalizer : PivotGridLocalizer
    {
        public override string GetLocalizedString(PivotGridStringId id)
        {
            if (id == PivotGridStringId.GrandTotal)
                return "Total";
            if (id == PivotGridStringId.DataArea)
                return "Área de Dados";

            return base.GetLocalizedString(id);
        }
    }
}
