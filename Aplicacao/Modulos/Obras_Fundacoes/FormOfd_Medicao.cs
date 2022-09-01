using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Proxy;
using System.Linq;
using Aplicacao.Util;
using cwkGestao.Negocio;
using cwkGestao.Modelo.Util;
using DevExpress.XtraGrid;
using Aplicacao.Base;


namespace Aplicacao
{
    public partial class FormOfd_Medicao : Aplicacao.IntermediariasTela.FormManutOfd_MedicaoIntermediaria
    {
        private IList<Ofd_PropostaMedicaoPerfuracao> perfuracoes = new List<Ofd_PropostaMedicaoPerfuracao>();

        public FormOfd_Medicao()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            NosGridsPegarColunasDefinidasNaEntidade = false;
            tpProposta.Tag = Selecionado;
            tpEmpresa.PageVisible = false;
            lkpProposta.OnIDChanged += lkpProposta_IDChanged;
           

        }

        protected override void OK()
        {
            if (Operacao == Acao.Excluir)
                base.OK();
            else
            {
                try
                {
                    if (ValidarFormulario())
                    {
                        TelaProObjeto(tcPrincipal);
                        if (Operacao < Acao.Consultar)
                        {
                            Ofd_MedicaoController.Instancia.RegisterNewIntoTransaction(Selecionado);
                            Ofd_PropostaMedicaoController.Instancia
                                                         .RegisterNewIntoTransaction(perfuracoes.Select(p => p.PropostaMedicao)
                                                                                                .Distinct());
                            Ofd_PropostaMedicaoPerfuracaoController.Instancia.CommitUnitOfWorkTransaction();
                        }
                        this.Close();
                    }
                }
                catch (Exception e)
                {
                    new FormErro(e).ShowDialog();
                }
            }
        }

        private void AtualizarTotalMedicao()
        {
            var valorPerfuracoes = Selecionado.MedicaoServicos.Sum(p => p.Total);
            var valorMobilizacao = Convert.ToDecimal(txtValorMobilizacao.EditValue);
            var valorProjeto = Convert.ToDecimal(txtValorProjeto.EditValue);
            var valorHoraParada = Convert.ToDecimal(txtValorHoraParada.EditValue);
            txtTotalMedicao.EditValue = valorPerfuracoes + valorMobilizacao + valorProjeto + valorHoraParada;
        }

        private void lkbProposta_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<Ofd_Proposta>(lkpProposta, typeof(FormOfd_Proposta));
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            tpProposta.Tag = Selecionado;            
            lkpProposta.EditValue = null;
            perfuracoes.Clear();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            gcOfd_MedicaoAcompanhamento.DataSource = Ofd_MedicaoAcompanhamentoController.Instancia.GetByMedicao(Selecionado.ID);
            lkpProposta.Enabled = lkbProposta.Enabled = (Operacao != Acao.Alterar);
            if (Operacao == Acao.Incluir)
                txtData.DateTime = DateTime.Now;
        }

        private void lkbFilial_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<Filial>(lkpFilial, typeof(FormFilial));
        }

        private void txtValorMobilizacao_EditValueChanged(object sender, EventArgs e)
        {
            AtualizarTotalMedicao();
        }

        private void txtValorProjeto_EditValueChanged(object sender, EventArgs e)
        {
            AtualizarTotalMedicao();
        }

        private void txtValorHoraParada_EditValueChanged(object sender, EventArgs e)
        {
            AtualizarTotalMedicao();
        }

        private void lkpProposta_IDChanged(object sender, EventArgs e)
        {
            if (PodeBuscarServicos())
            {
                var proposta = Ofd_PropostaController.Instancia.LoadObjectById(((Ofd_Proposta)lkpProposta.Selecionado).ID);
                perfuracoes = Ofd_PropostaMedicaoPerfuracaoController.Instancia.GetByProposta((Ofd_Proposta)lkpProposta.Selecionado);
                Selecionado.MedicaoServicos.Clear();

                foreach (var item in perfuracoes)
                {
                    Ofd_MedicaoServicos ofd_MedicaoServicos = new Ofd_MedicaoServicos();
                    ofd_MedicaoServicos.Metro = item.Total;
                    ofd_MedicaoServicos.Quantidade = item.Quantidade;
                    ofd_MedicaoServicos.Diametro = (TipoDiametro)item.Diametro;

                    var perfuracao = proposta.Revisoes.LastOrDefault().Perfuracoes.Where(p => p.Diametro == item.Diametro).FirstOrDefault();
                    if (perfuracao != null)
                    {
                        ofd_MedicaoServicos.Valor = perfuracao.ValorUnitario;
                    }

                    ofd_MedicaoServicos.Total = (item.Total * ofd_MedicaoServicos.Valor);

                    Selecionado.MedicaoServicos.Add(ofd_MedicaoServicos);
                    ofd_MedicaoServicos.Ofd_Medicao = Selecionado;
                    item.PropostaMedicao.Ofd_Medicao = Selecionado;
                }

                gcMedicaoServicos.RefreshDataSource();
                AtualizarTotalMedicao();
            }
        }

        private bool PodeBuscarServicos()
        {
            return (Operacao == Acao.Incluir && lkpProposta.EditValue != null);
        }

        private void gridView1_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            if (((GridColumnSummaryItem)e.Item).FieldName == "Quantidade")
            {
                e.TotalValue = Selecionado.MedicaoServicos.Sum(i => i.Quantidade);
            }
            else if (((GridColumnSummaryItem)e.Item).FieldName == "Metro")
            {
                e.TotalValue = Selecionado.MedicaoServicos.Sum(i => i.Metro);
            }
            else if (((GridColumnSummaryItem)e.Item).FieldName == "Valor")
            {
                e.TotalValue = Selecionado.MedicaoServicos.Sum(p => p.Valor);
            }
            else if (((GridColumnSummaryItem)e.Item).FieldName == "Total")
            {
                e.TotalValue = Selecionado.MedicaoServicos.Sum(i => i.Total);
                AtualizarTotalMedicao();
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Valor")
            {
                var medicaoServicos = Selecionado.MedicaoServicos[e.RowHandle];
                medicaoServicos.Valor = Convert.ToDecimal(e.Value);
                medicaoServicos.Total = (medicaoServicos.Valor * medicaoServicos.Metro);
                gvPerfuracoes.UpdateSummary();
                AtualizarTotalMedicao();
            }
        }
    }
}
