using System;
using System.Windows.Forms;
using Aplicacao.Base;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Collections.Generic;
using Relatorio.Relatorios.Obras_Fundacoes;
using System.Linq;
using cwkGestao.Modelo.Util;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Modulos.Obras_Fundacoes.Impressao
{
    public partial class FormImpressaoResumoMedicao : Form
    {
        public FormImpressaoResumoMedicao()
        {
            InitializeComponent();
            InicializarLookups();
        }

        private void InicializarLookups()
        {
            lkpProposta.Sessao = cwkGestao.Negocio.Ofd_PropostaController.Instancia.getSession();
            lkpProposta.Exemplo = new Ofd_Proposta();
            lkpProposta.CamposRestricoesAND = new List<string>();
            lkpProposta.CamposRestricoesOR = new List<string>();
            lkpProposta.OnIDChanged += lkpProposta_IDChanged;
        }

        private void sbImprimir_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                string descricao="";
                decimal quantidade = 0;
                decimal metros = 0;
                decimal valor = 0;
                decimal subTotal = 0;
                try
                {
                    Relatorio.dsObrasFundacoes.PerfuracaoRow p;
                    var proposta = Ofd_PropostaController.Instancia.LoadObjectById(((Ofd_Proposta)lkpProposta.Selecionado).ID);
                    IList<Ofd_PropostaMedicao> medicoes = Ofd_PropostaMedicaoController.Instancia.GetLstByPropostaENumero(proposta, Convert.ToInt32(cbMedicao.Text));


                    List<Ofd_PropostaMedicaoPerfuracao> lstMedicoesExecutadas = new List<Ofd_PropostaMedicaoPerfuracao>();
                    var dataSource = new Relatorio.dsObrasFundacoes();

                    var linhas = new Relatorio.dsObrasFundacoes().Perfuracao.Rows;
                    IList<Ofd_PropostaMedicaoPerfuracao> perfuracoes = new List<Ofd_PropostaMedicaoPerfuracao>();
                    foreach (var medicao in medicoes)
                    {
                        foreach (var perfuracao in medicao.Perfuracoes.OrderBy(o => o.Estaca))
                        {
                            dataSource.MedicaoPerfuracao.AddMedicaoPerfuracaoRow(perfuracao.Estaca, perfuracao.DiametroStr, perfuracao.Quantidade, perfuracao.Profundidade, perfuracao.Total, perfuracao.PropostaMedicao.DataVerificacao.ToShortDateString());
                            perfuracoes.Add(perfuracao);
                        }
                       
                    }

                    
                    var medicoesExecutadas = from per in perfuracoes
                                             group per by per.Diametro into g
                                             select new
                                             {
                                                 Descricao = "Perfuração " + g.Key.TipoDiametroToString() + " (mL)",
                                                 Quantidade = g.Sum(q => q.Quantidade),
                                                 Metros = g.Sum(q => q.Profundidade),
                                                 Valor = GetValorPorDiametro(proposta.Revisoes.LastOrDefault(), g.Key)
                                             };

                    foreach (var med in medicoesExecutadas)
                    {
                        descricao = med.Descricao;
                        quantidade = med.Quantidade;
                        metros = (med.Metros * med.Quantidade);
                        valor = med.Valor;
                        subTotal = (med.Metros * med.Quantidade * med.Valor);
                        dataSource.Perfuracao.AddPerfuracaoRow(descricao, quantidade, metros, valor, subTotal);
                    }
                    

                    var parms = new rptResumoMedicao.ParametroResumo
                    {
                        Assunto = "Medição " + medicoes.FirstOrDefault().Medicao,
                        Construtora = proposta.Cliente.Nome,
                        Data = medicoes.FirstOrDefault().DataVerificacao.ToShortDateString(),
                        Obra = proposta.NomeObra,
                        Responsavel = proposta.Obra.ResponsavelNaObra,
                        ValorMobilizacao = proposta.ValorTaxaMobilizacao,
                        ValorProjetoConsultoria = 0,
                        ValorTotal = dataSource.Perfuracao.Sum(ped => ped.SubTotal)
                    };
                    var report = new rptResumoMedicao(parms);
                    report.subPerfuracoes.ReportSource.DataSource = dataSource;
                    report.subServicos.ReportSource.DataSource = dataSource;
                    report.ShowPreviewDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    FormErro.ShowDialog(ex);
                }
            }
        }

        private decimal GetValorPorDiametro(Ofd_PropostaRevisaoPerfuracoes propostaRevisao, TipoDiametro diametro)
        {
            var perfuracao = propostaRevisao.Perfuracoes.Where(p => p.Diametro == diametro).FirstOrDefault();
            if (perfuracao != null)
                return perfuracao.ValorUnitario;
            return 0;
        }

        private bool CamposValidos()
        {
            dxErrorProvider.ClearErrors();

            if (lkpProposta.Selecionado == null)
                dxErrorProvider.SetError(lkpProposta, "Campo obrigatório");
            else if (((Ofd_Proposta)lkpProposta.Selecionado).Obra == null)
                dxErrorProvider.SetError(lkpProposta, "A proposta selecionada não está vinculada à uma obra");

            if (cbMedicao.SelectedIndex < 0)
                dxErrorProvider.SetError(cbMedicao, "Campo obrigatório");

            return !dxErrorProvider.HasErrors;
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormImpressaoFaturas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, Text);
                    break;
            }
        }

        private void lkpProposta_IDChanged(object sender, EventArgs e)
        {
            if (lkpProposta.Selecionado != null)
            {
                var itens = Ofd_PropostaMedicaoController.Instancia.GetMedicoesFaturadasByProposta((Ofd_Proposta)lkpProposta.Selecionado);
                cbMedicao.Properties.Items.Clear();
                cbMedicao.Properties.Items.AddRange(itens);
                if (cbMedicao.Properties.Items.Count > 0)
                    cbMedicao.SelectedIndex = 0;
                else
                    cbMedicao.SelectedIndex = -1;
            }
        }

        private void lkbProposta_Click(object sender, EventArgs e)
        {
            Util.LookupUtil.GridLookup<cwkGestao.Modelo.Ofd_Proposta>(lkpProposta, typeof(FormOfd_Proposta));
        }
    }
}
