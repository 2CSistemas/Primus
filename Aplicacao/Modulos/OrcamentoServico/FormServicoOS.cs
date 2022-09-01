using System;
using System.Windows.Forms;

using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.OrcamentoServico
{
    public partial class FormServicoOS : Form
    {
        public OSServicoItem ServicoItem;
        public bool Salvou;

        private readonly decimal ValorInicial = Convert.ToDecimal(1.9999);
        public FormServicoOS(OSServicoItem _servicoItem)
        {
            InitializeComponent();
            ServicoItem = _servicoItem;

            txtQuantidade.EditValue = ValorInicial;
            txtValor.EditValue = ValorInicial;
            txtTotal.EditValue = ValorInicial;
            txtPercDesconto.EditValue = ValorInicial;

            PreencherTela();
        }
        private void PreencherTela()
        {
            if (ServicoItem.Servico != null)
                txtServico.EditValue = $"{ServicoItem.Servico.Nome} | {ServicoItem.Servico.Codigo}";

            if (ServicoItem.Responsavel != null)
                lkpResponsavel.EditValue = ServicoItem.Responsavel;

            txtQuantidade.EditValue = ServicoItem.Quantidade;
            txtValor.EditValue = ServicoItem.Preco;
            txtPercDesconto.EditValue = ServicoItem.DescontoPerc;
            txtTotal.EditValue = ServicoItem.Total;
        }

        private void Calcular()
        {
            var Quantidade = Convert.ToDecimal(txtQuantidade.EditValue);
            var ValorUnitario = Convert.ToDecimal(txtValor.EditValue);
            var ValorDesconto = (Quantidade * ValorUnitario) * (Convert.ToDecimal(txtPercDesconto.EditValue) / 100);
            var Total = (Quantidade * ValorUnitario) - ValorDesconto;

            txtTotal.EditValue = Total;
        }

        private void FormServicoOs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) // Esc
                Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (ServicoItem.Servico == null)
            {
                MessageBox.Show("Selecione o Serviço.", "ATENÇÃO");
                txtServico.Focus();
                return;
            }

            ServicoItem.Quantidade = Convert.ToDecimal(txtQuantidade.EditValue);
            ServicoItem.Preco = Convert.ToDecimal(txtValor.EditValue);
            ServicoItem.PrecoOriginal = ServicoItem.Servico.Valor;
            ServicoItem.DescontoPerc = Convert.ToDecimal(txtPercDesconto.EditValue);
            ServicoItem.Total = Convert.ToDecimal(txtTotal.EditValue);

            Salvou = true;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Salvou = false;
            Close();
        }

        private void lkbServico_Click(object sender, EventArgs e)
        {
            CallServico();
        }

        private void CallServico()
        {
            GridGenerica<Servico> gridGenerica = new GridGenerica<Servico>(ServicoController.Instancia.GetAll(), new FormServico(), false) { Selecionando = true };
            gridGenerica.ShowDialog();
            if (gridGenerica.Selecionado != null)
            {
                ServicoItem.Servico = gridGenerica.Selecionado;
                txtServico.EditValue = $"{gridGenerica.Selecionado.Nome} | {gridGenerica.Selecionado.Codigo}";
                txtValor.EditValue = ServicoItem.Servico.Valor;
                Calcular();
            }
        }

        private void txtServico_Leave(object sender, EventArgs e)
        {
            CallServico();
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            Calcular();
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            Calcular();
        }

        private void txtPercDesconto_Leave(object sender, EventArgs e)
        {
            Calcular();
        }

        private void lkpResponsavel_Leave(object sender, EventArgs e)
        {
            CallResponsavel();
        }

        private void lkbResponsavel_Click(object sender, EventArgs e)
        {
            CallResponsavel();
        }

        private void CallResponsavel()
        {
            var grid = ServicoItem.Tipo == TipoServico.Propria ?
                new GridGenerica<Pessoa>(PessoaController.Instancia.GetAllFuncionarios(), new FormPessoa(), false) :
                new GridGenerica<Pessoa>(PessoaController.Instancia.GetAllFornecedores(), new FormPessoa(), false);

            grid.Selecionando = true;
            grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                ServicoItem.Responsavel = grid.Selecionado;
                lkpResponsavel.EditValue = grid.Selecionado;
            }
        }
    }
}
