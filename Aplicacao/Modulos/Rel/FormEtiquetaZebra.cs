using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ACBrLib;
using Aplicacao.Base;
using cwkGestao.Integracao.ACBr.Core;
using cwkGestao.Integracao.ACBr.Core.ETQ;
using cwkGestao.Integracao.ACBr.Etiqueta;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Rel
{
    public partial class FormEtiquetaZebra : Form
    {
        private readonly ACBrETQ acbrEtq;
        private readonly Configuracao objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();

        public FormEtiquetaZebra()
        {
            InitializeComponent();

            acbrEtq = new ACBrETQ();
            acbrEtq.Desativar();

            gcProdutosEtiquetas.DataSource = ProdutoController.Instancia.GetAll().Where(o => !string.IsNullOrEmpty(o.Barra)).OrderBy(prod => prod.NomeOrdenado).Distinct().ToList();
            gcProdutosEtiquetas.RefreshDataSource();
            gcProdutosEtiquetas.Refresh();

            try
            {
                cbbPortas.SelectedIndex = cbbPortas.Items.Count - 1;
                foreach (string printer in PrinterSettings.InstalledPrinters)
                    cbbPortas.Items.Add($"{printer}");

                comboBoxModelo.EnumDataSource(ETQModelo.etqNenhum);
                comboBoxDPI.EnumDataSource(ETQDPI.dpi300);
                comboBoxBackFeed.EnumDataSource(ETQBackFeed.bfNone);

                // Altera as config de log
                acbrEtq.ConfigGravarValor(ACBrSessao.Principal, "LogNivel", "4");

                var logPath = Path.Combine(Application.StartupPath, "Docs");
                if (!Directory.Exists(logPath))
                    Directory.CreateDirectory(logPath);

                acbrEtq.ConfigGravarValor(ACBrSessao.Principal, "LogPath", logPath);

                acbrEtq.ConfigGravar();
                LoadConfig();
            }
            catch (Exception Ex)
            {
                new FormErro(Ex.Message, Ex.StackTrace).Show();
            }
        }

        private void LoadConfig()
        {
            acbrEtq.ConfigLer();

            cbbPortas.SelectedItem = acbrEtq.ConfigLerValor<string>(ACBrSessao.ETQ, "Porta");
            comboBoxModelo.SetSelectedValue(acbrEtq.ConfigLerValor<ETQModelo>(ACBrSessao.ETQ, "Modelo"));
            numericUpDownTemperatura.Value = acbrEtq.ConfigLerValor<decimal>(ACBrSessao.ETQ, "Temperatura");
            comboBoxDPI.SetSelectedValue(acbrEtq.ConfigLerValor<ETQDPI>(ACBrSessao.ETQ, "DPI"));
            numericUpDownVelocidade.Value = acbrEtq.ConfigLerValor<decimal>(ACBrSessao.ETQ, "Velocidade");
            comboBoxBackFeed.SetSelectedValue(acbrEtq.ConfigLerValor<ETQBackFeed>(ACBrSessao.ETQ, "BackFeed"));
            numericUpDownAvancoEtq.Value = acbrEtq.ConfigLerValor<decimal>(ACBrSessao.ETQ, "Avanco");
            checkBoxLimparMemoria.Checked = acbrEtq.ConfigLerValor<bool>(ACBrSessao.ETQ, "LimparMemoria");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModeloImpressaoEtiquetaZebraTLP2844 f = new ModeloImpressaoEtiquetaZebraTLP2844();
            f.ShowDialog();
            f.Dispose();
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMarcarTodos_Click(object sender, EventArgs e)
        {
            // Marcar Todos
            (gcProdutosEtiquetas.DataSource as List<Produto>).ForEach(o => { o.Selecionado = true; });
            gcProdutosEtiquetas.RefreshDataSource();
            gcProdutosEtiquetas.Refresh();
        }

        private void btnDesmarcarTodos_Click(object sender, EventArgs e)
        {
            // Desmarcar Todos
            (gcProdutosEtiquetas.DataSource as List<Produto>).ForEach(o => { o.Selecionado = false; });
            gcProdutosEtiquetas.RefreshDataSource();
            gcProdutosEtiquetas.Refresh();
        }

        private IList<Produto> GetSelecionados()
        {
            return ((IList<Produto>) gvProdutosEtiquetas.DataSource).Where(o => o.Selecionado).ToList();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            // Imprimir Etiqueta Padrão
            foreach (var item in GetSelecionados())
            {
                SaveConfig();
                if (item.Quantidade.HasValue && item.Quantidade.Value > 0)
                    for (int i = 0; i < item.Quantidade; i++)
                        ImprimirEtiqueta(item);
            }
        }

        private void SaveConfig()
        {
            acbrEtq.Desativar();

            acbrEtq.ConfigGravarValor(ACBrSessao.ETQ, "Porta", cbbPortas.Text);
            acbrEtq.ConfigGravarValor(ACBrSessao.ETQ, "Modelo", comboBoxModelo.GetSelectedValue<ETQModelo>());
            acbrEtq.ConfigGravarValor(ACBrSessao.ETQ, "Temperatura", numericUpDownTemperatura.Value);
            acbrEtq.ConfigGravarValor(ACBrSessao.ETQ, "DPI", comboBoxDPI.GetSelectedValue<ETQDPI>());
            acbrEtq.ConfigGravarValor(ACBrSessao.ETQ, "Velocidade", numericUpDownVelocidade.Value);
            acbrEtq.ConfigGravarValor(ACBrSessao.ETQ, "BackFeed", comboBoxBackFeed.GetSelectedValue<ETQBackFeed>());
            acbrEtq.ConfigGravarValor(ACBrSessao.ETQ, "Avanco", numericUpDownAvancoEtq.Value);
            acbrEtq.ConfigGravarValor(ACBrSessao.ETQ, "LimparMemoria", checkBoxLimparMemoria.Checked);
            acbrEtq.ConfigGravar();
        }

        private decimal GetPreco(Produto objProduto)
        {
            if (objProduto == null)
                return 0;

            return ProdutoController.Instancia.getPreco(objProduto, objConfiguracao.TabelaPrecoFrenteCaixa, TipoPrecoType.Normal);
        }

        private void ImprimirEtiqueta(Produto prodGrid) // Primeiro layout implementado - Etique Padrão
        {
            try
            {
                acbrEtq.Ativar();

                var prod = ProdutoController.Instancia.GetProdutoByID(prodGrid.ID);

                var numeroCopias = (int) numericUpDownCopias.Value <= 0 ? 1 : (int) numericUpDownCopias.Value;
                for (int i = 0; i < numeroCopias; i++)
                {
                    acbrEtq.IniciarEtiqueta();

                    acbrEtq.ImprimirBarras(ETQOrientacao.orNormal, TipoCodBarra.barEAN13, 2, 2, 00, 15, prodGrid.Barra, 080, ETQBarraExibeCodigo.becNAO);

                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 1, 1, 2, 95, 15, $"Cod.{prodGrid.Codigo}");
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 1, 1, 1, 130, 15, prod.Nome);

                    if (prodGrid.ImprimirPreco)
                        acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 1, 1, 3, 155, 140, GetPreco(prod).ToString("n2"));

                    acbrEtq.ImprimirBarras(ETQOrientacao.orNormal, TipoCodBarra.barEAN13, 2, 2, 00, 365, prodGrid.Barra, 080, ETQBarraExibeCodigo.becNAO);
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 1, 1, 2, 95, 365, $"Cod.{prodGrid.Codigo}");
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 1, 1, 1, 130, 365, prod.Nome);

                    if (prodGrid.ImprimirPreco)
                        acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 1, 1, 3, 155, 490, GetPreco(prod).ToString("n2"));

                    acbrEtq.ImprimirBarras(ETQOrientacao.orNormal, TipoCodBarra.barEAN13, 2, 2, 00, 720, prodGrid.Barra, 080, ETQBarraExibeCodigo.becNAO);
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 1, 1, 2, 95, 720, $"Cod.{prodGrid.Codigo}");
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 1, 1, 1, 130, 720, prod.Nome);

                    if (prodGrid.ImprimirPreco)
                        acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 1, 1, 3, 155, 845, GetPreco(prod).ToString("n2"));

                    acbrEtq.FinalizarEtiqueta(1, (int) numericUpDownAvancoEtq.Value);
                }

                acbrEtq.Imprimir(1, (int) numericUpDownAvancoEtq.Value);
                acbrEtq.Desativar();
            }
            catch (Exception Ex)
            {
                new FormErro(Ex.Message, Ex.StackTrace).Show();
            }
        }

        private void ImprimirEtiquetaJoias(Produto prodGrid)
        {
            try
            {
                acbrEtq.Ativar();

                var prod = ProdutoController.Instancia.GetProdutoByID(prodGrid.ID);

                var numeroCopias = (int)numericUpDownCopias.Value <= 0 ? 1 : (int)numericUpDownCopias.Value;
                for (int i = 0; i < numeroCopias; i++)
                {
                    acbrEtq.IniciarEtiqueta();

                    acbrEtq.ImprimirBarras(ETQOrientacao.orNormal, TipoCodBarra.barEAN13, 2, 2, 00, 15, prodGrid.Barra, 080, ETQBarraExibeCodigo.becNAO);
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 1, 1, 2, 95, 15, $"Cod.{prodGrid.Codigo}");
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 1, 1, 3, 155, 140, GetPreco(prod).ToString("n2"));

                    //acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 1, 1, 1, 130, 15, prod.Nome);
                    

                    //if (prodGrid.ImprimirPreco)
                    //    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 1, 1, 3, 155, 140, GetPreco(prod).ToString("n2"));

                    //acbrEtq.ImprimirBarras(ETQOrientacao.orNormal, TipoCodBarra.barEAN13, 2, 2, 00, 365, prodGrid.Barra, 080, ETQBarraExibeCodigo.becNAO);
                    //acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 1, 1, 2, 95, 365, $"Cod.{prodGrid.Codigo}");
                    //acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 1, 1, 1, 130, 365, prod.Nome);

                    //if (prodGrid.ImprimirPreco)
                    //    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 1, 1, 3, 155, 490, GetPreco(prod).ToString("n2"));

                    //acbrEtq.ImprimirBarras(ETQOrientacao.orNormal, TipoCodBarra.barEAN13, 2, 2, 00, 720, prodGrid.Barra, 080, ETQBarraExibeCodigo.becNAO);
                    //acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 1, 1, 2, 95, 720, $"Cod.{prodGrid.Codigo}");
                    //acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 1, 1, 1, 130, 720, prod.Nome);

                    //if (prodGrid.ImprimirPreco)
                    //    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 1, 1, 3, 155, 845, GetPreco(prod).ToString("n2"));

                    acbrEtq.FinalizarEtiqueta(1, (int)numericUpDownAvancoEtq.Value);
                }

                acbrEtq.Imprimir(1, (int)numericUpDownAvancoEtq.Value);
                acbrEtq.Desativar();
            }
            catch (Exception Ex)
            {
                new FormErro(Ex.Message, Ex.StackTrace).Show();
            }
        }


        private void ImprimirEtiqueta03(Produto prodGrid)  // Implementado 08/04/2022 - (Nome Empresa, Nome Produto, Código Produto, Preço e Código de Barras)
        {
            try
            {
                acbrEtq.Ativar();

                var prod = ProdutoController.Instancia.GetProdutoByID(prodGrid.ID);
                var empr = FilialController.Instancia.GetFilialPrincipal();

                var numeroCopias = (int)numericUpDownCopias.Value <= 0 ? 1 : (int)numericUpDownCopias.Value;
                for (int i = 0; i < numeroCopias; i++)
                {
                    acbrEtq.IniciarEtiqueta();

                    //Nome Empresa
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 1, 1, 1, 130, 15, prod.Nome); // Nome Empresa
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 1, 1, 1, 130, 15, empr.Nome); // Nome Produto
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 1, 1, 2, 95, 15, $"Cod.{prodGrid.Codigo}"); // Código Produto
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 1, 1, 3, 155, 140, GetPreco(prod).ToString("n2")); // Preço Produto
                    acbrEtq.ImprimirBarras(ETQOrientacao.orNormal, TipoCodBarra.barEAN13, 2, 2, 00, 15, prodGrid.Barra, 080, ETQBarraExibeCodigo.becNAO); // Código Barras
                  
                
                    //if (prodGrid.ImprimirPreco)
                    //    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 1, 1, 3, 155, 140, GetPreco(prod).ToString("n2"));

                    //acbrEtq.ImprimirBarras(ETQOrientacao.orNormal, TipoCodBarra.barEAN13, 2, 2, 00, 365, prodGrid.Barra, 080, ETQBarraExibeCodigo.becNAO);
                    //acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 1, 1, 2, 95, 365, $"Cod.{prodGrid.Codigo}");
                    //acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 1, 1, 1, 130, 365, prod.Nome);

                    //if (prodGrid.ImprimirPreco)
                    //    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 1, 1, 3, 155, 490, GetPreco(prod).ToString("n2"));

                    //acbrEtq.ImprimirBarras(ETQOrientacao.orNormal, TipoCodBarra.barEAN13, 2, 2, 00, 720, prodGrid.Barra, 080, ETQBarraExibeCodigo.becNAO);
                    //acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 1, 1, 2, 95, 720, $"Cod.{prodGrid.Codigo}");
                    //acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 1, 1, 1, 130, 720, prod.Nome);

                    //if (prodGrid.ImprimirPreco)
                    //    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 1, 1, 3, 155, 845, GetPreco(prod).ToString("n2"));

                    //acbrEtq.FinalizarEtiqueta(1, (int)numericUpDownAvancoEtq.Value);
                }

                acbrEtq.Imprimir(1, (int)numericUpDownAvancoEtq.Value);
                acbrEtq.Desativar();
            }
            catch (Exception Ex)
            {
                new FormErro(Ex.Message, Ex.StackTrace).Show();
            }
        }

        private void btnImpressãoEtiquetaJoias_Click(object sender, EventArgs e)
        {
            // Imprimir Etiqueta Jóias
            foreach (var item in GetSelecionados())
            {
                SaveConfig();
                if (item.Quantidade.HasValue && item.Quantidade.Value > 0)
                    for (int i = 0; i < item.Quantidade; i++)
                        ImprimirEtiquetaJoias(item);
            }
        }

        private void btnEtiqueta03_Click(object sender, EventArgs e)
        {
            // Imprimir Etiqueta03 (Nome Empresa, Nome Produto, Código Produto, Preço e Código de Barras)
            foreach (var item in GetSelecionados())
            {
                SaveConfig();
                if (item.Quantidade.HasValue && item.Quantidade.Value > 0)
                    for (int i = 0; i < item.Quantidade; i++)
                        ImprimirEtiqueta03(item);
            }
        }
    }
}