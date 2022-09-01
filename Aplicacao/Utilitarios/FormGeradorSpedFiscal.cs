using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Aplicacao.IntermediariasTela;
using DevExpress.XtraEditors.Popup;
using DevExpress.Utils.Win;
using cwkGestao.Modelo;
using cwkGestao.Integracao.Sped;
using cwkGestao.Integracao.Sped.Fiscal.Objetos;
using cwkGestao.Negocio;
using Aplicacao.Util;
using System.Linq;
using System.IO;
using cwkGestao.Modelo.Util;

namespace Aplicacao.Utilitarios
{
    public partial class FormGeradorSpedFiscal : FormManutNotaIntermediaria
    {
        Filial filial = new Filial();
        public FormGeradorSpedFiscal()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            lkpFilial.CamposRestricoesAND = new List<string>();
            lkpFilial.Exemplo = new Filial();
        }

        protected override bool ValidarFormulario()
        {
            dxErroProvider.ClearErrors();
            if (lkpFilial.Selecionado == null)
            {
                dxErroProvider.SetError(lkpFilial, "É obrigatório informar uma Filial para gerar o arquivo do SPED Fiscal. Verifique.");
            }
            if (txtDataInicial.EditValue != null && txtDataFinal.EditValue != null)
            {
                if (txtDataInicial.DateTime > txtDataFinal.DateTime)
                    dxErroProvider.SetError(txtDataFinal, "A data final deve ser maior do que a data inicial.");
            }
            else
            {
                if (txtDataInicial.EditValue == null)
                    dxErroProvider.SetError(txtDataInicial, "Informe uma data inicial é válida.");

                if (txtDataFinal.EditValue == null)
                    dxErroProvider.SetError(txtDataFinal, "Informe uma data final é válida.");
            }
            if (String.IsNullOrEmpty(txtArquivo.Text.ToString()) || txtArquivo.EditValue == null)
            {
                dxErroProvider.SetError(txtArquivo, "Informe uma pasta de destino para a geração do arquivo do SPED Fiscal.");
            }
            if (cbtipo.SelectedIndex == -1)
            {
                dxErroProvider.SetError(cbtipo, "Por favor, selecione um tipo válido.");
            }
            if (cbtipo.SelectedIndex == 1)
            {
                if (cbFinalidade.SelectedIndex == -1)
                {
                    dxErroProvider.SetError(cbFinalidade, "Se o tipo do arquivo é ICMS/IPI você deve escolher uma finalidade para ele.");
                }
            }

            return !dxErroProvider.HasErrors;
        }

        protected override void OK()
        {
            if (ValidarFormulario())
            {
                try
                {
                    //FormProgressWindow objPWindow = new FormProgressWindow();
                    //objPWindow.
                    DateTime start = txtDataInicial.DateTime.Date;
                    DateTime end = txtDataFinal.DateTime.Date;
                    IList<Nota> nfs = NotaController.Instancia.GetAllByPeriod(start, end, null);

                    IList<ProdutoConversao> produtoConversoes = ProdutoConversaoController.Instancia.GetAll();
                    PeriodoApuracaoContabil periodoApuracaoContabil = PeriodoApuracaoContabilController.Instancia.GetAllByPeriod(start, end);

                    IList<NCM> listaNCM = NCMController.Instancia.GetAll();

                    IList<LogAlteracaoParticipante> logAlteracaoDadosParticipante = new List<LogAlteracaoParticipante>();
                    logAlteracaoDadosParticipante = LogAlteracaoParticipanteController.Instancia.LoadObjectByData(start, end);

                    PessoaContabilista Contabilista = new PessoaContabilista();
                    if (periodoApuracaoContabil != null)
                        Contabilista = periodoApuracaoContabil.Pessoa.PessoaContabilistas.FirstOrDefault();
                    else
                    {
                        MessageBox.Show("Não foi possivel gerar o Arquivo, pois não existe apuração contabil para esse periodo cadastrada no sistema");
                        return;
                    }

                    IList<LogAlteracaoPedidoItem> logAlteracaoPedidoItem = new List<LogAlteracaoPedidoItem>();
                    logAlteracaoPedidoItem = LogAlteracaoPedidoItemController.Instancia.LoadObjectByData(start, end);

                    nfs = nfs.Where(w =>
                    (w.StatusLegivel == "Autorizada") ||
                    (w.StatusLegivel == "Cancelada") ||
                    (w.StatusLegivel == "Denegada")
                    ).ToList();

                    for (var i = 0; i < nfs.Count; i++)
                    {
                        // Regra: Se for NÃO contribuinte, não gera Sped.
                        var nota = NotaController.Instancia.LoadObjectById(nfs[i].ID);
                        nfs[i] = nota;
                    }

                    filial = (Filial)lkpFilial.Selecionado;

                    IList<Documento> docs = DocumentoController.Instancia.GetAllByPeriod(start, end, null);
                    IList<PlanoConta> plctas = PlanoContaController.Instancia.GetAll();
                    IList<CentroCusto> ctcustos = CentroCustoController.Instancia.GetAll();
                    bool bSemNota = false;

                    if (nfs.Count == 0)
                    {
                        if (MessageBox.Show("Não existem Notas para o filtro selecionado. " +
                            "Caso queira continuar a operação, será gerado um arquivo SPED vazio. Deseja continuar?",
                            "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
                        {
                            return;
                        }
                        bSemNota = true;
                    }
                    VersaoEfdIcmsIpi versaoSped = VersaoEfdIcmsIpiController.Instancia.GetAllByPeriod(start, end, null).FirstOrDefault();
                    SpedFiscal sped = new SpedFiscal(nfs, filial, docs, txtArquivo.EditValue.ToString(), start, end,
                                new List<DateTime>(), plctas, ctcustos, bSemNota, Contabilista, logAlteracaoPedidoItem,
                                cbtipo.SelectedIndex, cbFinalidade.SelectedIndex, produtoConversoes, logAlteracaoDadosParticipante, listaNCM, versaoSped);
                    MessageBox.Show("Arquivo Gerado com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                
                catch (Exception e)
                {
                    new Aplicacao.Base.FormErro(e).ShowDialog();
                }
            }
        }

        private void sbSelecionarArquivo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            DialogResult res = ofd.ShowDialog();
            if (res == DialogResult.OK)
            {
                txtArquivo.EditValue = ofd.SelectedPath;
            }
        }

        private void lkbFilial_Click(object sender, EventArgs e)
        {
            btAbrirSubCadastro_Click(sender, e);
        }

        private void cbtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtipo.SelectedIndex == 0)
            {
                labelControl1.Visible = false;
                cbFinalidade.Visible = false;
            }
            else
            {
                labelControl1.Visible = true;
                cbFinalidade.Visible = true;
            }
        }
        
        private void sdAdEmpresa_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.Filial> grid = new GridGenerica<Filial>(FilialController.Instancia.GetAll(), new FormFilial(), (cwkGestao.Modelo.Filial)lkpFilial.EditValue, false);
            grid.Selecionando = true;
            grid.ShowDialog();

            lkpFilial.EditValue = grid.Selecionado;
        }

        private void sbGravar_Click_1(object sender, EventArgs e)
        {

        }
    }
}