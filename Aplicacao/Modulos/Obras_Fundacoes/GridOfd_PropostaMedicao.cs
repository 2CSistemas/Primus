using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Obras_Fundacoes
{
    public partial class GridOfd_PropostaMedicao : Aplicacao.IntermediariasTela.GridOfd_PropostaMedicaoIntermediaria
    {
        private readonly Dictionary<string, Form> telasAbertas = new Dictionary<string, Form>();
        private Ofd_Proposta proposta;

        public GridOfd_PropostaMedicao(IList<Ofd_PropostaMedicao> medicoes, IFormManut<Ofd_PropostaMedicao> formManut)
            : base(medicoes, formManut, false)
        {
            InitializeComponent();
            btTrocarProduto.Image = sbImprimirFiltro.Image;
        }

        public GridOfd_PropostaMedicao(Ofd_Proposta proposta, IFormManut<Ofd_PropostaMedicao> formManut)
            : this(proposta.Medicoes.ToList(), formManut)
        {
            this.proposta = proposta;
            this.Text += String.Format(" [{0} - {1}]", proposta.NomeObra, proposta.Status.ToString());
        }

        protected override Ofd_PropostaMedicao InstanciarNovoSelecionado()
        {
            var medicao = new Ofd_PropostaMedicao() { Sequencia = 1 };
            if (proposta != null)
            {
                proposta = Ofd_PropostaController.Instancia.LoadObjectByIdWithMedicoes(proposta.ID);
                medicao.Proposta = proposta;
                if (proposta.Medicoes.Count > 0)
                    medicao.Sequencia = proposta.Medicoes.Max(d => d.Sequencia) + 1;
                else
                    medicao.Sequencia = 1;
            }
            return medicao;
        }

        protected override void Alterar()
        {
            VerificarOperacaoPermitida(base.Alterar);
        }

        protected override void Excluir()
        {
            VerificarOperacaoPermitida(base.Excluir);
        }

        private void VerificarOperacaoPermitida(Action acao)
        {
            if (GetRegistroSelecionado().MedicaoFaturada)
            {
                MessageBox.Show("Operação não permitida pois a medição já se encontra faturada. Abrindo registro como consulta.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                base.Consultar();
            }
            else
                acao();
        }

        private void GridOfd_PropostaMedicao_DoubleClick(object sender, EventArgs e)
        {
            var prop = Ofd_PropostaMedicaoController.Instancia.LoadObjectById(GetRegistroSelecionado().ID);
            FormManut.Selecionado = prop;
        }

        private void btTrocarProduto_Click(object sender, EventArgs e)
        {
            GridOfd_ComparativoPropostaVerificacoes grid = new GridOfd_ComparativoPropostaVerificacoes(GetRegistroSelecionado().Proposta.ID);
            grid.ShowDialog();
        }
    }
}
