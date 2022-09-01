using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Ionic.Zip;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Proxy;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;
using DevExpress.XtraGrid.Views.Base;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Reflection;

namespace Aplicacao.Util
{
    public static class TelasUtil
    {
        static string textoFiltroCabecalhoRel;
        public static void CriaHeaderImpressaoFiltro(CreateAreaEventArgs e, GridView gridView, ref PrintableComponentLink printableComponentLink1, String texto)
        {
            textoFiltroCabecalhoRel = String.Empty;
            DevExpress.XtraPrinting.TextBrick brick = new TextBrick();

            string dataAtualStr = DateTime.Today.ToLongDateString();
            if (textoFiltroCabecalhoRel != "" && gridView.FilterPanelText != "")
                textoFiltroCabecalhoRel = textoFiltroCabecalhoRel + ", ";
            string[] rows = { texto, textoFiltroCabecalhoRel + gridView.FilterPanelText, dataAtualStr };


            VerificaSeImprimeRetratoOuPaisagem(gridView, printableComponentLink1);

            for (int i = 0; i < rows.Count(); i++)
            {
                if (i == 0)
                {
                    brick = e.Graph.DrawString(rows[i], Color.Black, new RectangleF(0, 0, 500, 40),
                                               DevExpress.XtraPrinting.BorderSide.None);
                    brick.Font = new Font("Arial", 16);
                    brick.StringFormat = brick.StringFormat.ChangeAlignment(StringAlignment.Center);
                }
                else if (i == 1)
                {
                    VerificaSeImprimeRetratoOuPaisagem(gridView, printableComponentLink1);
                    if (printableComponentLink1.Landscape == true)
                    {
                        string filtro = rows[i];
                        for (int contador = 0; contador < 7; contador++)
                        {
                            filtro = TrataFiltro(filtro);
                        }
                        brick = e.Graph.DrawString("Filtro: " + filtro, Color.Black, new RectangleF(0, 32, 800, 40),
                                                   DevExpress.XtraPrinting.BorderSide.None);
                        brick.Font = new Font("Arial", 9);
                        brick.StringFormat = brick.StringFormat.ChangeAlignment(StringAlignment.Near);
                    }
                    else
                    {
                        string filtro = rows[i];
                        for (int contador = 0; contador < 7; contador++)
                        {
                            filtro = TrataFiltro(filtro);
                        }
                        brick = e.Graph.DrawString("Filtro: " + filtro, Color.Black, new RectangleF(0, 32, 400, 40),
                                                   DevExpress.XtraPrinting.BorderSide.None);
                        brick.Font = new Font("Arial", 9);
                        brick.StringFormat = brick.StringFormat.ChangeAlignment(StringAlignment.Near);
                    }
                }
                else if (i == 2)
                {
                    VerificaSeImprimeRetratoOuPaisagem(gridView, printableComponentLink1);
                    if (printableComponentLink1.Landscape == true)
                    {
                        brick = e.Graph.DrawString(rows[i], Color.Black, new RectangleF(695, 32, 230, 40),
                           DevExpress.XtraPrinting.BorderSide.None);
                        brick.Font = new Font("Arial", 9);
                        brick.StringFormat = brick.StringFormat.ChangeAlignment(StringAlignment.Far);
                    }
                    else
                    {
                        brick = e.Graph.DrawString(rows[i], Color.Black, new RectangleF(465, 32, 230, 40),
                           DevExpress.XtraPrinting.BorderSide.None);
                        brick.Font = new Font("Arial", 9);
                        brick.StringFormat = brick.StringFormat.ChangeAlignment(StringAlignment.Far);
                    }

                }
            }

            printableComponentLink1.PrintingSystem.PageSettings.Landscape = printableComponentLink1.Landscape;
        }
        private static void VerificaSeImprimeRetratoOuPaisagem(GridView gridView, PrintableComponentLink printableComponentLink1)
        {
            ColumnView grid = gridView.Columns.View.VisibleColumns.View;
            int tamanhoGridColunasVisiveis = 0;
            int numeroDeColunasVisiveis = gridView.Columns.View.VisibleColumns.Count;
            for (int i = 0; i < numeroDeColunasVisiveis; i++)
            {
                var coluna = (grid.GetVisibleColumn(i));
                tamanhoGridColunasVisiveis += coluna.Width;
            }

            if ((gridView.Columns.View.VisibleColumns.Count > 6) || (tamanhoGridColunasVisiveis > VerificaTamanhoColunas(printableComponentLink1)))
                printableComponentLink1.Landscape = true;
            else
                printableComponentLink1.Landscape = false;
        }
        private static int VerificaTamanhoColunas(PrintableComponentLink printableComponentLink1)
        {
            return 595 - (printableComponentLink1.Margins.Right + printableComponentLink1.Margins.Left);
        }
        private static string TrataFiltro(string filtro)
        {
            if (filtro.Contains("Contains"))
            {
                filtro = filtro.Replace("Contains", "Contém");
            }
            else if (filtro.Contains("Starts with"))
            {
                filtro = filtro.Replace("Starts with", "Começa com");
            }
            else if (filtro.Contains("Like"))
            {
                filtro = filtro.Replace("Like", "contendo");
            }
            else if (filtro.Contains("Between"))
            {
                filtro = filtro.Replace("Between", "entre");
            }
            else if (filtro.Contains("Not"))
            {
                filtro = filtro.Replace("Not", "Sem");
            }
            else if (filtro.Contains("Is Null"))
            {
                filtro = filtro.Replace("Is Null", "é nulo");
            }
            else if (filtro.Contains("Is Not Null"))
            {
                filtro = filtro.Replace("Is Not Null", "não é nulo");
            }
            else if (filtro.Contains("In"))
            {
                filtro = filtro.Replace("In", "em");
            }
            else if (filtro.Contains("And"))
            {
                filtro = filtro.Replace("And", "e");
            }
            return filtro;
        }

        #region Salvar Filtros

        public static void CarregaFiltros(this DevExpress.XtraEditors.CheckEdit check, Form formulario)
        {
            if (formulario == null) return;

            FileInfo arquivoDeFiltro = new FileInfo(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\XML\\" + formulario.Name + ".xml");

            if (arquivoDeFiltro.Exists)
            {
                using (var St = new StreamReader(arquivoDeFiltro.FullName))
                {
                    XDocument arquivoXml = XDocument.Load(St);
                    LeXML(arquivoXml.Root, formulario);
                    check.Checked = true;
                }
            }
        }

        private static void LeXML(XElement raiz, Form formulario)
        {
            Type tipo = formulario.GetType();
            object pai = formulario;
            if (SubAtributo(raiz))
            {
                pai = tipo.GetField(raiz.Name.ToString(), BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public).GetValue(pai);
                tipo = pai.GetType();
            }

            foreach (XElement item in raiz.Elements())
            {
                string nomeComponente = item.Name.LocalName;

                try
                {
                    object componente = tipo.GetField(nomeComponente, System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | BindingFlags.Public).GetValue(pai);
                    cwkGestao.Visual.Util.Filtros.SerializeFactory.Produce(componente.GetType()).Deserialize(componente, item);
                }
                catch (ArgumentException)
                {
                    LeXML(item, formulario);
                }
                catch (Exception)
                { }
            }
        }

        private static XElement ConstruirXmlFiltro(Control painel, bool subAtributo)
        {
            XElement xmlFinal = new XElement(painel.Name);
            xmlFinal.SetAttributeValue("subAtributo", subAtributo);

            IList<Control> controles = new List<Control>();
            for (int i = 0; i < painel.Controls.Count; i++)
            {
                controles.Add(painel.Controls[i]);
            }

            foreach (var item in controles.OrderBy(i => i.Location.Y))
            {
                if (item.GetType().IsSubclassOf(typeof(Panel)) || item.GetType().IsSubclassOf(typeof(DevExpress.XtraEditors.XtraPanel))
                    || item.GetType().IsSubclassOf(typeof(DevExpress.XtraEditors.GroupControl)))
                {
                    xmlFinal.Add(ConstruirXmlFiltro((Control)item, false));
                }
                else if (item.GetType().IsSubclassOf(typeof(UserControl)))
                {
                    xmlFinal.Add(ConstruirXmlFiltro((Control)item, true));
                }
                else
                {
                    try
                    {
                        XElement elemento = cwkGestao.Visual.Util.Filtros.SerializeFactory.Produce(item.GetType()).Serialize(item);
                        xmlFinal.Add(elemento);
                    }
                    catch (ArgumentException) { }
                }
            }

            return xmlFinal;
        }

        private static bool SubAtributo(XElement raiz)
        {
            try
            {
                bool subAtributo;
                bool.TryParse(raiz.Attribute("subAtributo").Value, out subAtributo);
                return subAtributo;
            }
            catch (NullReferenceException)
            {
                return false;
            }
        }

        public static void GravaXMLFiltros(this DevExpress.XtraEditors.CheckEdit check, Control tabPage, Form formulario)
        {
            if (check.Checked)
            {
                XElement buildXml = ConstruirXmlFiltro(tabPage, false);

                XDocument documento = new XDocument(new XDeclaration("1.0", "UTF-8", "yes"));
                documento.Add(buildXml);
                documento.Save(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\XML\\" + formulario.Name + ".xml");
            }
            else
            {
                FileInfo arquivoXml = new FileInfo(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\XML\\" + formulario.Name + ".xml");
                if (arquivoXml.Exists)
                {
                    arquivoXml.Delete();
                }
            }
        }

        #endregion
    }
}
