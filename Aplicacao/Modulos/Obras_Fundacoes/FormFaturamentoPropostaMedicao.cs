using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Obras_Fundacoes;
using DevExpress.XtraGrid;

namespace Aplicacao.Modulos.Obras_Fundacoes
{
    public partial class FormFaturamentoPropostaMedicao : Form
    {
        private bool finalizou;
        private bool contemErros;
        private Thread thread;
        private IList<pxyFaturamentoPerfuracao> perfuracoes = new List<pxyFaturamentoPerfuracao>();

        public FormFaturamentoPropostaMedicao()
        {
            InitializeComponent();
            InicializarLookups();
            txtDt.DateTime = DateTime.Now.Date;
        }

        public FormFaturamentoPropostaMedicao(Ofd_Proposta proposta)
            : this()
        {
            lkpProposta.EditValue = proposta;
        }

        private void InicializarLookups()
        {
            var sessao = cwkGestao.Negocio.Ofd_PropostaController.Instancia.getSession();
            lkpFilial.Exemplo = new Filial();
            lkpFilial.Sessao = sessao;
            lkpHoraParada.Exemplo = new Servico();
            lkpHoraParada.Sessao = sessao;
            lkpHoraParada.OnIDChanged += lkpHoraParada_IDChanged;
            lkpMobilizacao.Exemplo = new Servico();
            lkpMobilizacao.Sessao = sessao;
            lkpMobilizacao.OnIDChanged += lkpMobilizacao_IDChanged;
            lkpProjeto.Exemplo = new Servico();
            lkpProjeto.Sessao = sessao;
            lkpProjeto.OnIDChanged += lkpProjeto_IDChanged;
            lkpProposta.Exemplo = new Ofd_Proposta();
            lkpProposta.Sessao = sessao;
            lkpProposta.CamposRestricoesAND = new List<string>();
            lkpProposta.CamposRestricoesOR = new List<string>();
            lkpProposta.OnIDChanged += lkpProposta_IDChanged;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var param = base.CreateParams;
                param.ClassStyle = param.ClassStyle | 0x200;
                return param;
            }
        }

        private void lkpProposta_IDChanged(object sender, EventArgs e)
        {
            if (lkpProposta.Selecionado != null)
            {
                var itens = Ofd_PropostaMedicaoController.Instancia.GetMedicoesNaoFaturadasByProposta((Ofd_Proposta)lkpProposta.Selecionado);
                cbMedicao.Properties.Items.Clear();
                cbMedicao.Properties.Items.AddRange(itens);
                if (cbMedicao.Properties.Items.Count > 0)
                    cbMedicao.SelectedIndex = 0;
                else
                    cbMedicao.SelectedIndex = -1;
            }
        }

        private void cbMedicao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbMedicao.Text))
            {
                perfuracoes = Ofd_PropostaMedicaoPerfuracaoController.Instancia
                                                                     .GetByPropostaENumeroMedicao((Ofd_Proposta)lkpProposta.Selecionado, Convert.ToInt32(cbMedicao.Text));
                var propostaselecionada = (Ofd_Proposta)lkpProposta.Selecionado;
                foreach (var item in perfuracoes)
                {
                  var diametro = Convert.ToDecimal(item.DescricaoServico.Substring(11,4));
                  string valor = (TransformaValor(diametro));
                  item.Valor = GetValorPorDiametro(propostaselecionada.Revisoes.LastOrDefault(), valor);
                }

               gcPerfuracoes.DataSource = perfuracoes;
            }
        }

        private string TransformaValor(decimal diametro)
        {
            string valor = String.Concat("_" + Convert.ToString(diametro).Replace(",", "_"));
            return valor;
        }

        private decimal GetValorPorDiametro(Ofd_PropostaRevisaoPerfuracoes propostaRevisao, string diametro)
        {
            var perfuracao = propostaRevisao.Perfuracoes.Where(p => p.Diametro.ToString() == diametro).FirstOrDefault();
            if (perfuracao != null)
                return perfuracao.ValorUnitario;
            return 0;
        }



        private void lkpProjeto_IDChanged(object sender, EventArgs e)
        {
            AtribuirValorServico(lkpProjeto, txtValorProjeto);
        }

        private void lkpMobilizacao_IDChanged(object sender, EventArgs e)
        {
            AtribuirValorServico(lkpMobilizacao, txtValorMobilizacao);
        }

        private void lkpHoraParada_IDChanged(object sender, EventArgs e)
        {
            AtribuirValorServico(lkpHoraParada, txtValorHoraParada);
        }

        private void AtribuirValorServico(Cwork.Utilitarios.Componentes.Lookup lkp, Cwork.Utilitarios.Componentes.CwkBaseEditor txtValor)
        {
            if (lkp.Selecionado != null)
            {
                var servico = (Servico)lkp.Selecionado;
                txtValor.EditValue = servico.Valor;
                AtualizarTotalMedicao();
            }
        }

        private void sbFaturar_Click(object sender, EventArgs e)
        {
            if (CamposValidos() && PodeFaturar())
            {
                sbFaturar.Enabled = false;
                sbCancelar.Enabled = false;
                xtraTabPage1.Refresh();
                InicializarThread();
                AguardarImportacao();
            }
        }

        private bool CamposValidos()
        {
            dxErrorProvider.ClearErrors();

            if (lkpProposta.Selecionado == null)
                dxErrorProvider.SetError(lkpProposta, "Selecione a proposta");

            if (txtDt.EditValue == null)
                dxErrorProvider.SetError(txtDt, "Selecione a data do faturamento");

            if (Convert.ToDecimal(txtTotalMedicao.EditValue) <= 0)
                dxErrorProvider.SetError(txtTotalMedicao, "O total da medição deve ser maior do que zero(0)");

            if (lkpFilial.Selecionado == null)
                dxErrorProvider.SetError(lkpFilial, "Selecione a empresa");

            return !dxErrorProvider.HasErrors;
        }

        private bool PodeFaturar()
        {
            return MessageBox.Show("Confirmar faturamento?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void InicializarThread()
        {
            finalizou = false;
            contemErros = false;
            thread = new Thread(new ThreadStart(Gerar));
            thread.Start();
        }

        private void AguardarImportacao()
        {
            while (!finalizou)
            {
                Thread.Sleep(60);
                Application.DoEvents();
            }

            if (contemErros)
            {
                sbFaturar.Enabled = true;
                sbCancelar.Enabled = true;
            }
            else
                this.Close();
        }

        private void Gerar()
        {
            try
            {
                var faturador = new FaturadorPropostaMedicao((Filial)lkpFilial.Selecionado, (Ofd_Proposta)lkpProposta.Selecionado
                                                            , cbMedicao.Text, PerfuracoesFaturadas, txtDt.DateTime);
                faturador.ServicoHoraParada = GetServico(lkpHoraParada, txtValorHoraParada);
                faturador.ServicoMobilizacao = GetServico(lkpMobilizacao, txtValorMobilizacao);
                faturador.ServicoProjeto = GetServico(lkpProjeto, txtValorProjeto);
                faturador.Faturar();
                MessageBox.Show("Faturamento realizado com sucesso.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                contemErros = true;
                FormErro.ShowDialog(ex);
            }
            finally
            {
                finalizou = true;
            }
        }

        private IList<pxyFaturamentoPerfuracao> PerfuracoesFaturadas
        {
            get { return perfuracoes.Where(p => p.SubTotal > 0).ToList(); }
        }

        private NotaItemServico GetServico(Cwork.Utilitarios.Componentes.Lookup lkp, Cwork.Utilitarios.Componentes.CwkBaseEditor txtValor)
        {
            if (lkp.Selecionado == null) return null;
            return new NotaItemServico
            {
                Servico = (Servico)lkp.Selecionado,
                Quantidade = 1,
                Valor = Convert.ToDecimal(txtValor.EditValue),
                SubTotal = Convert.ToDecimal(txtValor.EditValue)
            };
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormFaturamentoPropostaMedicao_KeyDown(object sender, KeyEventArgs e)
            {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Faturamento Proposta - Medição");
                    break;
            }
        }

        private void FormFaturamentoPropostaMedicao_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread != null)
                thread.Abort();
        }

        private void lkbMobilizacao_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<Servico>(lkpMobilizacao, typeof(FormServico));
        }

        private void lkbProjeto_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<Servico>(lkpProjeto, typeof(FormServico));
        }

        private void lkbHoraParada_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<Servico>(lkpHoraParada, typeof(FormServico));
        }

        private void lkbEmpresa_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<Filial>(lkpFilial, typeof(FormFilial));
        }

        private void lkbProposta_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<Ofd_Proposta>(lkpProposta, typeof(FormOfd_Proposta));
        }

        private void gvPerfuracoes_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            if (((GridColumnSummaryItem)e.Item).FieldName == "Quantidade")
            {
                e.TotalValue = perfuracoes.Sum(i => i.Quantidade);
            }
            else if (((GridColumnSummaryItem)e.Item).FieldName == "Metros")
            {
                e.TotalValue = perfuracoes.Sum(i => i.Metros);
            }
            else if (((GridColumnSummaryItem)e.Item).FieldName == "Valor")
            {
                e.TotalValue = perfuracoes.Sum(i => i.Valor);
            }
            else if (((GridColumnSummaryItem)e.Item).FieldName == "SubTotal")
            {
                e.TotalValue = perfuracoes.Sum(i => i.SubTotal);
                AtualizarTotalMedicao();
            }
        }

        private void gvPerfuracoes_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Valor")
            {
                perfuracoes[e.RowHandle].Valor = Convert.ToDecimal(e.Value);
                gvPerfuracoes.UpdateSummary();
            }
        }

        private void AtualizarTotalMedicao()
        {
            var valorPerfuracoes = perfuracoes.Sum(p => p.SubTotal);
            var valorMobilizacao = Convert.ToDecimal(txtValorMobilizacao.EditValue);
            var valorProjeto = Convert.ToDecimal(txtValorProjeto.EditValue);
            var valorHoraParada = Convert.ToDecimal(txtValorHoraParada.EditValue);
            txtTotalMedicao.EditValue = valorPerfuracoes + valorMobilizacao + valorProjeto + valorHoraParada;
        }

        private void txtValorMobilizacao_Leave(object sender, EventArgs e)
        {
            AtualizarTotalMedicao();
        }
    }
}
