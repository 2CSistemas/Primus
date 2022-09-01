using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using ACBrLib;
using Aplicacao.Base;
using cwkGestao.Integracao.ACBr.Core;
using cwkGestao.Integracao.ACBr.Core.ETQ;
using cwkGestao.Integracao.ACBr.Etiqueta;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Padroes;
using DBUtils.Classes;

namespace Aplicacao.Modulos.Rel
{
    public partial class FormImprimiEtiquetas : Form
    {
        private readonly ACBrETQ acbrEtq;

        // Chama Tabela de Produtos para Impressão das Etiquetas Gôndola    

        private readonly Configuracao objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();

        private readonly IniFile _arquivoIni;
        private readonly string _nomeLoja;

        private string CaminhoIni => Debugger.IsAttached
            ? $"{Path.GetFullPath(".").Substring(0, Path.GetFullPath(".").IndexOf("cwkGestao"))}cwkGestao\\App_Data\\Start.ini"
            : $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\App_Data\\Start.ini";

        public FormImprimiEtiquetas()
        {
            InitializeComponent();

            _arquivoIni = new IniFile(CaminhoIni);
            _nomeLoja = _arquivoIni.GetValue("Configuracoes_PDV", "LOJA", "");

            acbrEtq = new ACBrETQ();
            acbrEtq.Desativar();

            gcProdutosEtiquetas.DataSource = ProdutoController.Instancia.GetAll().Where(o => !string.IsNullOrEmpty(o.Barra)).OrderBy(prod => prod.NomeOrdenado).Distinct().ToList();
            gcProdutosEtiquetas.RefreshDataSource();
            gcProdutosEtiquetas.Refresh();
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormImprimiEtiquetas_Shown(object sender, EventArgs e)
        {
            try
            {
                cbbPortas.SelectedIndex = cbbPortas.Items.Count - 1;
                foreach (string printer in PrinterSettings.InstalledPrinters)
                    //cbbPortas.Items.Add($"{printer}");
                    cbbPortas.Items.Add($"RAW:{printer}");

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

        private decimal GetPreco(Produto objProduto)
        {
            if (objProduto == null)
                return 0;

            return ProdutoController.Instancia.getPreco(objProduto, objConfiguracao.TabelaPrecoFrenteCaixa, TipoPrecoType.Normal);
        }

        private void GetPrecoAtacado(Produto objProduto)
        {
            if (objProduto == null)
            {
                ZerarValorAtacado();
                return;
            }

            var listaPrecos = ProdutoVarejoController.Instancia.GetPorProduto(objProduto.ID);
            var preco = listaPrecos?.OrderBy(x => x.QuantidadeInicial).FirstOrDefault();

            if (preco == null)
            {
                ZerarValorAtacado();
                return;
            }

            valorAtacado = preco.Preco;
            quantidade1 = preco.QuantidadeInicial;
            quantidade2 = preco.QuantidadeFinal;
        }

        private void ZerarValorAtacado()
        {
            valorAtacado = 0;
            quantidade1 = 0;
            quantidade2 = 0;
        }

        //Botão Etiqueta Gondola 1 Preço
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            foreach (var item in GetSelecionados())
                ImprimirEtiqueta01(item);
        }

        private int quantidade1;
        private int quantidade2;
        private decimal valorAtacado;

        // Botão Etiqueta Gondola 2 Preços
        private void buttonEtqSimples_Click(object sender, EventArgs e)
        {
            foreach (var item in GetSelecionados())
                ImprimirEtiqueta02(item);
        }

        // Botão Etiqueta  3  Colunas
        private void buttonEtq3Colunas_Click(object sender, EventArgs e)
        {
            foreach (var item in GetSelecionados())
                Imprimir3Colunas(item);
        }

        // Botão - Bloco de Etiquetas
        private void buttonEtqBloco_Click(object sender, EventArgs e)
        {
            foreach (var item in GetSelecionados())
                ImprimirBloco(item);
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

        private void cbbPortas_Leave(object sender, EventArgs e)
        {
            try
            {
                SaveConfig();
            }
            catch (Exception Ex)
            {
                new FormErro(Ex.Message, Ex.StackTrace).Show();
            }
        }

        private IList<Produto> GetSelecionados()
        {
            return ((IList<Produto>) gvProdutosEtiquetas.DataSource).Where(o => o.Selecionado).ToList();
        }

        private void ImprimirEtiqueta01(Produto prodGrid)
        {
            try
            {
                SaveConfig();
                acbrEtq.Ativar();

                var prod = ProdutoController.Instancia.GetProdutoByID(prodGrid.ID);

                var numeroCopias = (int) numericUpDownCopias.Value <= 0 ? 1 : (int) numericUpDownCopias.Value;
                for (int i = 0; i < numeroCopias; i++)
                {
                    acbrEtq.IniciarEtiqueta();
                    acbrEtq.ImprimirTexto(0, 2, 2, 2, 3, 3, prod.Nome);
                    acbrEtq.ImprimirTexto(0, 2, 2, 1, 8, 3, $"Marca: {prod.Grupo1?.Nome}");
                    acbrEtq.ImprimirTexto(ETQOrientacao.or90, 2, 1, 1, 6, 86, _nomeLoja);
                    acbrEtq.ImprimirBarras(0, 0, 2, 2, 13, 5, prod.Barra, 10);
                    acbrEtq.ImprimirTexto(0, 2, 3, 2, 18, 35, "R$");
                    acbrEtq.ImprimirTexto(0, 2, 3, 4, 15, 48, GetPreco(prod).ToString("n2"), 99);
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

        private void ImprimirEtiqueta02(Produto prodGrid)
        {
            try
            {
                SaveConfig();
                acbrEtq.Ativar();

                var prod = ProdutoController.Instancia.GetProdutoByID(prodGrid.ID);

                // Busca produto e Valor
                var valorVarejo = GetPreco(prod);
                GetPrecoAtacado(prod);

                valorAtacado = valorAtacado <= 0 ? valorVarejo : valorAtacado;

                var numeroCopias = (int) numericUpDownCopias.Value <= 0 ? 1 : (int) numericUpDownCopias.Value;
                for (int i = 0; i < numeroCopias; i++)
                    if (new[] {1, 2, 3}.Contains(comboBoxModelo.SelectedIndex))
                    {
                        acbrEtq.IniciarEtiqueta();
                        acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 2, 2, 2, 3, 3, prod.Nome, 0, true);
                        acbrEtq.ImprimirTexto(ETQOrientacao.or90, 2, 1, 1, 4, 90, $"COD: {prod.Codigo}");
                        acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 2, 2, 1, 9, 3, "R$ VAREJO");
                        acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 2, 2, 1, 9, 50, "R$ ATACADO");
                        acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 2, 1, 1, 12, 50, $"DE {quantidade1} a {quantidade2} Unidades");
                        acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 2, 4, 4, 15, 3, valorVarejo.ToString("n2"));
                        acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 2, 4, 4, 15, 49, valorAtacado.ToString("n2"), 0, true);
                        acbrEtq.FinalizarEtiqueta(1, (int) numericUpDownAvancoEtq.Value);
                    }
                    else
                    {
                        acbrEtq.IniciarEtiqueta();
                        acbrEtq.ImprimirCaixa(3, 3, 90, 5, 5, 0);
                        acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, "T", 10, 10, 3, 3, prod.Nome, 0, true);
                        acbrEtq.ImprimirTexto(ETQOrientacao.or180, "S", 10, 10, 8, 3, prod.DescReduzida);
                        acbrEtq.ImprimirBarras(ETQOrientacao.orNormal, TipoCodBarra.barEAN13, 2, 2, 13, 5, prod.Barra, 10, ETQBarraExibeCodigo.becSIM);
                        acbrEtq.ImprimirCaixa(13, 32, 56, 17, 1, 1);
                        acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, "G", 40, 80, 18, 35, "R$");
                        acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, "G", 55, 100, 15, 50, GetPreco(prod).ToString("n2"));
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

        private void Imprimir3Colunas(Produto Prod)
        {
            try
            {
                SaveConfig();
                acbrEtq.Ativar();

                if (new[] {1, 2, 3}.Contains(comboBoxModelo.SelectedIndex))
                {
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 2, 1, 2, 2, 3, Prod.Nome);
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 2, 1, 1, 6, 3, Prod.DescReduzida);
                    acbrEtq.ImprimirBarras(ETQOrientacao.orNormal, TipoCodBarra.barEAN13, 2, 2, 8, 3, Prod.Barra, 10);
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 2, 1, 2, 2, 32, Prod.Nome);
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 2, 1, 1, 6, 32, Prod.DescReduzida);
                    acbrEtq.ImprimirBarras(ETQOrientacao.orNormal, TipoCodBarra.barEAN13, 2, 2, 8, 32, Prod.Barra, 10);
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 2, 1, 2, 2, 61, Prod.Nome);
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 2, 1, 1, 6, 61, Prod.DescReduzida);
                    acbrEtq.ImprimirBarras(ETQOrientacao.orNormal, TipoCodBarra.barEAN13, 2, 2, 8, 61, Prod.Barra, 10);
                }
                else
                {
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, "0", 20, 30, 2, 3, Prod.Nome);
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, "0", 20, 20, 6, 3, Prod.DescReduzida);
                    acbrEtq.ImprimirBarras(ETQOrientacao.orNormal, TipoCodBarra.barEAN13, 2, 2, 8, 3, Prod.Barra, 10);
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, "0", 20, 30, 2, 32, Prod.Nome);
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, "0", 20, 20, 6, 32, Prod.DescReduzida);
                    acbrEtq.ImprimirBarras(ETQOrientacao.orNormal, TipoCodBarra.barEAN13, 2, 2, 8, 32, Prod.Barra, 10);
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, "0", 20, 30, 2, 61, Prod.Nome);
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, "0", 20, 20, 6, 61, Prod.DescReduzida);
                    acbrEtq.ImprimirBarras(ETQOrientacao.orNormal, TipoCodBarra.barEAN13, 2, 2, 8, 61, Prod.Barra, 10);
                }

                acbrEtq.Imprimir((int) numericUpDownCopias.Value, (int) numericUpDownAvancoEtq.Value);
                acbrEtq.Desativar();
            }
            catch (Exception Ex)
            {
                new FormErro(Ex.Message, Ex.StackTrace).Show();
            }
        }

        private void ImprimirBloco(Produto Prod)
        {
            try
            {
                SaveConfig();
                acbrEtq.Ativar();

                if (new[] {1, 2, 3}.Contains(comboBoxModelo.SelectedIndex))
                {
                    acbrEtq.IniciarEtiqueta();
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 2, 2, 2, 3, 3, Prod.Nome, 0, true);
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 2, 2, 1, 8, 3, Prod.DescReduzida);
                    acbrEtq.ImprimirBarras(ETQOrientacao.orNormal, TipoCodBarra.barEAN13, 2, 2, 13, 5, Prod.Barra, 10, ETQBarraExibeCodigo.becSIM);
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 3, 3, 2, 18, 35, "R$");
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 3, 4, 4, 15, 50, GetPreco(Prod).ToString("n2"));
                    acbrEtq.FinalizarEtiqueta((int) numericUpDownCopias.Value, (int) numericUpDownAvancoEtq.Value);

                    acbrEtq.IniciarEtiqueta();
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 2, 2, 2, 3, 3, Prod.Nome, 0, true);
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 2, 2, 1, 8, 3, Prod.DescReduzida);
                    acbrEtq.ImprimirBarras(ETQOrientacao.orNormal, TipoCodBarra.barEAN13, 2, 2, 13, 5, Prod.Barra, 10, ETQBarraExibeCodigo.becSIM);
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 3, 3, 2, 18, 35, "R$");
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 3, 4, 4, 15, 50, GetPreco(Prod).ToString("n2"));
                    acbrEtq.FinalizarEtiqueta((int) numericUpDownCopias.Value, (int) numericUpDownAvancoEtq.Value);

                    acbrEtq.IniciarEtiqueta();
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 2, 2, 2, 3, 3, Prod.Nome, 0, true);
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 2, 2, 1, 8, 3, Prod.DescReduzida);
                    acbrEtq.ImprimirBarras(ETQOrientacao.orNormal, TipoCodBarra.barEAN13, 2, 2, 13, 5, Prod.Barra, 10, ETQBarraExibeCodigo.becSIM);
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 3, 3, 2, 18, 35, "R$");
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, 3, 4, 4, 15, 50, GetPreco(Prod).ToString("n2"));
                    acbrEtq.FinalizarEtiqueta((int) numericUpDownCopias.Value, (int) numericUpDownAvancoEtq.Value);
                }
                else
                {
                    acbrEtq.IniciarEtiqueta();
                    acbrEtq.ImprimirCaixa(3, 3, 90, 5, 5, 0);
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, "T", 10, 10, 3, 3, Prod.Nome, 0, true);
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, "S", 10, 10, 8, 3, Prod.DescReduzida);
                    acbrEtq.ImprimirBarras(ETQOrientacao.orNormal, TipoCodBarra.barEAN13, 2, 2, 13, 5, Prod.Barra, 10, ETQBarraExibeCodigo.becSIM);
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, "G", 40, 80, 18, 35, "R$");
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, "G", 55, 100, 15, 50, GetPreco(Prod).ToString("n2"));
                    acbrEtq.FinalizarEtiqueta((int) numericUpDownCopias.Value, (int) numericUpDownAvancoEtq.Value);

                    acbrEtq.IniciarEtiqueta();
                    acbrEtq.ImprimirCaixa(3, 3, 90, 5, 5, 0);
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, "T", 10, 10, 3, 3, Prod.Nome, 0, true);
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, "S", 10, 10, 8, 3, Prod.DescReduzida);
                    acbrEtq.ImprimirBarras(ETQOrientacao.orNormal, TipoCodBarra.barEAN13, 2, 2, 13, 5, Prod.Barra, 10, ETQBarraExibeCodigo.becSIM);
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, "G", 40, 80, 18, 35, "R$");
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, "G", 55, 100, 15, 50, GetPreco(Prod).ToString("n2"));
                    acbrEtq.FinalizarEtiqueta((int) numericUpDownCopias.Value, (int) numericUpDownAvancoEtq.Value);

                    acbrEtq.IniciarEtiqueta();
                    acbrEtq.ImprimirCaixa(3, 3, 90, 5, 5, 0);
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, "T", 10, 10, 3, 3, Prod.Nome, 0, true);
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, "S", 10, 10, 8, 3, Prod.DescReduzida);
                    acbrEtq.ImprimirBarras(ETQOrientacao.orNormal, TipoCodBarra.barEAN13, 2, 2, 13, 5, Prod.Barra, 10, ETQBarraExibeCodigo.becSIM);
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, "G", 40, 80, 18, 35, "R$");
                    acbrEtq.ImprimirTexto(ETQOrientacao.orNormal, "G", 55, 100, 15, 50, GetPreco(Prod).ToString("n2"));
                    acbrEtq.FinalizarEtiqueta((int) numericUpDownCopias.Value, (int) numericUpDownAvancoEtq.Value);
                }

                acbrEtq.Imprimir(1, (int) numericUpDownAvancoEtq.Value);
                acbrEtq.Desativar();
            }
            catch (Exception Ex)
            {
                new FormErro(Ex.Message, Ex.StackTrace).Show();
            }
        }

        private void btnMarcarTodos_Click(object sender, EventArgs e)
        {
            (gcProdutosEtiquetas.DataSource as List<Produto>).ForEach(o => { o.Selecionado = true; });
            gcProdutosEtiquetas.RefreshDataSource();
            gcProdutosEtiquetas.Refresh();
        }

        private void btnDesmarcarTodos_Click(object sender, EventArgs e)
        {
            (gcProdutosEtiquetas.DataSource as List<Produto>).ForEach(o => { o.Selecionado = false; });
            gcProdutosEtiquetas.RefreshDataSource();
            gcProdutosEtiquetas.Refresh();
        }
    }
}