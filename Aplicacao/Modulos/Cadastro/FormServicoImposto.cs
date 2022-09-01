using System;
using System.Collections.Generic;
using System.Linq;

using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao
{
    public partial class FormServicoImposto : Aplicacao.IntermediariasTela.FormManutServicoImpostoIntermediaria
    {
        public class RegimeTributacao
        {
            public int Codigo { get; set; }
            public string Nome { get; set; }

            public override string ToString()
            {
                return Codigo + " - " + Nome;
            }
        }


        public FormServicoImposto()
        {
        }

        private List<RegimeTributacao> GetRegimes()
        {
            return new List<RegimeTributacao>
            {
                new RegimeTributacao {Codigo = 0, Nome = "Nenhum"},
                new RegimeTributacao {Codigo = 1, Nome = "MicroEmpresaMunicipal"},
                new RegimeTributacao {Codigo = 2, Nome = "Estimativa"},
                new RegimeTributacao {Codigo = 3, Nome = "SociedadeProfissionais"},
                new RegimeTributacao {Codigo = 4, Nome = "Cooperativa"},
                new RegimeTributacao {Codigo = 5, Nome = "MicroEmpresarioIndividual"},
                new RegimeTributacao {Codigo = 6, Nome = "MicroEmpresarioEmpresaPP"},
                new RegimeTributacao {Codigo = 7, Nome = "LucroReal"},
                new RegimeTributacao {Codigo = 8, Nome = "LucroPresumido"},
                new RegimeTributacao {Codigo = 9, Nome = "SimplesNacional"}
            };
        }

        private void IniciarComboBox()
        {
            lkpTipoImposto.Properties.DataSource = ImpostoController.Instancia.GetAll();
            lkpTipoImposto.EditValue = Selecionado.TipoImposto;
            if (Selecionado.TipoImposto != null)
            {
                if (Selecionado.TipoImposto.CSTs.Count > 0)
                {
                    lkpCSTImposto.Properties.DataSource = (IList<CodigoImposto>)Selecionado.TipoImposto.CSTs;
                }
                if (Selecionado.CSTImposto != null)
                {
                    lkpCSTImposto.EditValue = Selecionado.CSTImposto;
                }
            }

            var regimes = GetRegimes().ToArray();
            cmbRegimeTributario.Items.Clear();
            cmbRegimeTributario.Items.AddRange(regimes);
            cmbRegimeTributario.SelectedItem = regimes.FirstOrDefault(o => o.Codigo == (Selecionado.RegimeEspecialTributacao ?? 0));
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            //lkbPlanoConta.SubForm = new FormPlanoConta();
            lkbPlanoConta.SubFormType = typeof(FormPlanoConta);
            cbTipo.Properties.Items.Clear();
            InitializeComboBox(cbTipo, typeof(TipoImposto));
            InitializeComboBox(cbTipoRetencao, typeof(TipoRetencao));
            cbTipo.SelectedIndex = 2;

        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            IniciarComboBox();
            if (Operacao == Acao.Incluir || Operacao == (Acao.Incluir ^ Acao.NaoPersistir))
                txtCodigo.EditValue = controller.MaxCodigo();
        }

        private void txtLimiarPorMes_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtLimiarPorMes.EditValue) > 0)
                txtLimiarPorVenda.EditValue = 0;
        }

        private void txtLimiarPorVenda_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtLimiarPorVenda.EditValue) > 0)
                txtLimiarPorMes.EditValue = 0;
        }

        protected override void OK()
        {
            Selecionado.RegimeEspecialTributacao = (cmbRegimeTributario.SelectedItem as RegimeTributacao)?.Codigo ?? 0;

            base.OK();
        }

        private void lkpTipoImposto_EditValueChanged(object sender, EventArgs e)
        {
            if (((Imposto)lkpTipoImposto.EditValue) != null)
            {
                if (((Imposto)lkpTipoImposto.EditValue).CSTs != null)
                {
                    lbCST.Visible = lbCST.Enabled = lkpCSTImposto.Visible = lkpCSTImposto.Enabled = ((Imposto)lkpTipoImposto.EditValue).CSTs.Count > 0;
                    lkpCSTImposto.Properties.DataSource = (IList<CodigoImposto>)((Imposto)lkpTipoImposto.EditValue).CSTs;
                }

            }
        }

        private void lkpTipoImposto_Leave(object sender, EventArgs e)
        {
            Selecionado.TipoImposto = (Imposto)lkpTipoImposto.EditValue;
        }

        private void lkpCSTImposto_Leave(object sender, EventArgs e)
        {
            Selecionado.CSTImposto = (CodigoImposto)lkpCSTImposto.EditValue;
        }
    }
}
