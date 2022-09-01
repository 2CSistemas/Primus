using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Financeiro.BoletoRemessa;
using cwkGestao.Modelo;
using System.IO;
using Aplicacao.Util;
using Aplicacao.Base;
using DevExpress.XtraEditors;

namespace Aplicacao.Modulos.Financeiro
{
    public partial class FormGerarArquivoRemessa : Form
    {
        int tamanhoDocumentosIniciais;
        int contadorArquivoRemessa = 0;
        int contadorDocumentos = 0;
        IList<ArquivoRemessa> remessas = new List<ArquivoRemessa>();
        LogicaImpressaoBoletoRemessa logicaLocal;
        public FormGerarArquivoRemessa(IList<ArquivoRemessa> remessasSelecionados, LogicaImpressaoBoletoRemessa logica)
        {
            InitializeComponent();
            remessas = remessasSelecionados;
            logicaLocal = logica;
            lblStatus.Text = "Status: Parado";
            tamanhoDocumentosIniciais = (DocumentoController.Instancia.GetDocumentosPorArquivoRemessa(remessasSelecionados.FirstOrDefault().ID)).Count;
            lblArquivoRemessa.Text = 0 + "/" + remessasSelecionados.Count;
            lblDocumentos.Text = 0 + "/" + tamanhoDocumentosIniciais;
            tamanhoDocumentosIniciais = 0;
        }

        private void GerarRemessa(IList<ArquivoRemessa> remessasSelecionados, LogicaImpressaoBoletoRemessa logica)
        {
            ExibeCursorEspera cursor = new ExibeCursorEspera();
            using (cursor)
            {
                contadorArquivoRemessa = 0;
                List<string> remessasSemDocumento = new List<string>();

                //try
                //{
                    lblStatus.Text = "Status: Trabalhando";
                    foreach (var item in remessasSelecionados)
                    {
                        contadorDocumentos = 0;
                        contadorArquivoRemessa++;
                        logica.DevolveListaPxyRemessaParaGerarArquivoRemessa(item.ID);
                        logica.Documentos.ForEach(s => s.Selecionado = true);

                        if (logica.Documentos.Count > 0)
                        {
                            if (logica.Remessa != null)
                            {
                                Gerar(logica);
                                AtualizarTela(pbcArquivoRemessa, lblArquivoRemessa, (contadorArquivoRemessa + "/" + remessasSelecionados.Count));
                            }
                            else
                                MessageBox.Show("Selecione o arquivo de remessa antes de efetuar essa operação.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            remessasSemDocumento.Add(Convert.ToString(item.NumRemessa));
                        }
                    }
                    lblStatus.Text = "Status: Sucesso";
                    string mensagemFinal = "";
                    if (remessasSemDocumento.Count > 0)
                    {
                        mensagemFinal = "Não foi possiveis gerar os arquivos para as Remessas de Número "
                        + String.Join(",", remessasSemDocumento.ToArray()) + " pois elas não possuem Documentos relacionados";
                        MessageBox.Show(mensagemFinal, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        mensagemFinal = "Sucesso na geração das Remessas. ";
                        MessageBox.Show(mensagemFinal, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Close();
                //}
                //catch (Exception ex)
                //{
                //    lblStatus.Text = "Status: Erro";
                //    FormErro fErro = new FormErro(ex);
                //    fErro.ShowDialog();
                //    this.Close();
                //}
            }
        }


        public void AtualizarTela(ProgressBarControl progress, Label label, string valorLabel)
        {
            progress.PerformStep();
            progress.Update();
            AtualizarLabelsListBox(label, valorLabel);
            Application.DoEvents();
        }

        public void Gerar(LogicaImpressaoBoletoRemessa logica)
        {

            if (logica.Remessa.LayoutRemessa == String.Empty || logica.Remessa.CaminhoRemessa == String.Empty)
            {
                MessageBox.Show("Por favor prencha corretamente o layout remessa e o caminho da remessa.", "Remessa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                logica.LimparDados();
                var Boleto = logica.retornaListaBoleto();
                InicializaProgressBar(pbcDocumentos, Boleto.ListaDocumento.Count);
                AtualizarTela(pbcDocumentos, lblDocumentos, (contadorDocumentos + "/" + Boleto.ListaDocumento.Count));
                var contador = 0;
                foreach (var item in Boleto.ListaDocumento)
                {
                    contadorDocumentos++;
                    logica.SalvarBoleto(item, contador);
                    AtualizarTela(pbcDocumentos, lblDocumentos, (contadorDocumentos + "/" + Boleto.ListaDocumento.Count));
                    contador++;
                }
                logica.AtualizaRemessa();
                logica.PersistirDados(false);
            }
        
        }

        private void AtualizarLabelsListBox(Label label, string valorLabel)
        {
            label.Text = valorLabel;
        }

        private void InicializaProgressBar(ProgressBarControl progress, int tamanho)
        {
            progress.EditValue = 0;
            progress.Properties.Step = 1;
            progress.Properties.PercentView = true;
            progress.Properties.Maximum = tamanho;
            progress.Properties.Minimum = 0;
        }

        private void sbGerar_Click(object sender, EventArgs e)
        {
            InicializaProgressBar(pbcArquivoRemessa, remessas.Count);
            sbGerar.Visible = false;
            sbCancelar.Visible = false;
            
            GerarRemessa(remessas, logicaLocal);
        }

    }
    
    
}
