using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao
{
    public partial class FormTransferenciaBanco : IntermediariasTela.FormManutCidadeIntermediaria
    {


        public FormTransferenciaBanco()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            LookupSetup();
            txtData.DateTime = DateTime.Now;
        }

        private void LookupSetup()
        {
            //lkbPlanoConta.SubForm = new FormPlanoConta();
            //lkbOrigem.SubForm = new FormBanco();
            //lkbDestino.SubForm = new FormBanco();
            //lkbEmpresa.SubForm = new FormFilial();            
            //lkbHistorico.SubForm = new FormHistorico();

            lkbPlanoConta.SubFormType = typeof(FormPlanoConta);
            lkbOrigem.SubFormType = lkbDestino.SubFormType = typeof(FormBanco);
            lkbEmpresa.SubFormType = typeof(FormFilial);
            lkbHistorico.SubFormType = typeof(FormHistorico);

            lkpOrigem.Sessao = lkpHistorico.Sessao =
                               lkpPlanoConta.Sessao = lkpDestino.Sessao =
                                                      lkpEmpresa.Sessao = cwkGestao.Negocio.CidadeController.Instancia.getSession();
            lkpOrigem.Exemplo = lkpDestino.Exemplo = new Banco();
            lkpEmpresa.Exemplo = new Filial();
            lkpHistorico.Exemplo = new Historico();
            lkpPlanoConta.Exemplo = new PlanoConta();
        }

        protected override bool ValidacoesAdicionais()
        {
            dxErroProvider.SetError(lkpOrigem, lkpOrigem.Selecionado.Equals(lkpDestino.Selecionado) ? "Origem e destino não podem ser o mesmo." : "");
            dxErroProvider.SetError(lkpDestino, lkpOrigem.Selecionado.Equals(lkpDestino.Selecionado) ? "Origem e destino não podem ser o mesmo." : "");

            if (lkpPlanoConta.Selecionado != null && ((PlanoConta)lkpPlanoConta.Selecionado).BTitulo)
                dxErroProvider.SetError(lkpPlanoConta, "Não é permitido realizar uma transferência com plano de contas título.");

            return !dxErroProvider.HasErrors;
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                TentarTransferencia();
            }
        }

        private void TentarTransferencia()
        {
            try
            {
                RealizarTransferencia();
                MessageBox.Show("Transferência criada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Util.ControlUtil.LimparControles(tpPrincipal);
            }
            catch (Exception ex)
            {
                new Aplicacao.Base.FormErro(ex).ShowDialog();
            }
        }

        private void RealizarTransferencia()
        {
            MovCaixa saida = new MovCaixa(), entrada = new MovCaixa();
            Movimento movimentoSaida = new Movimento(), movimentoEntrada = new Movimento();
            saida.Codigo = cwkGestao.Negocio.MovCaixaController.Instancia.GetNovoCodigoMovimento();
            saida.NumDocumento = saida.Codigo.ToString();
            entrada.Codigo = MovCaixaController.Instancia.GetNovoCodigoMovimento();
            entrada.NumDocumento = entrada.Codigo.ToString();
            entrada.DtDigitacao = saida.DtDigitacao = saida.Dt = entrada.Dt = txtData.DateTime;
            movimentoEntrada.Dt = movimentoSaida.Dt = txtData.DateTime;
            movimentoEntrada.IncData = movimentoSaida.IncData = DateTime.Now;
            entrada.MovCaixaRelacionado = saida;
            saida.MovCaixaRelacionado = entrada;
            saida.Banco = (Banco)lkpOrigem.Selecionado;
            entrada.Banco = (Banco)lkpDestino.Selecionado;
            saida.Valor = entrada.Valor = (decimal)txtValor.EditValue;
            saida.Filial = entrada.Filial = (Filial)lkpEmpresa.Selecionado;
            saida.Historico = entrada.Historico = (Historico)lkpHistorico.Selecionado;
            saida.ComplementoHist = entrada.ComplementoHist = txtHistoricoComplemento.Text;
            entrada.Ent_Sai = Ent_SaiMovCaixa.Entrada;
            saida.Ent_Sai = Ent_SaiMovCaixa.Saída;


            movimentoEntrada.MovCaixa = entrada;
            movimentoSaida.MovCaixa = saida;
            movimentoEntrada.Operacao = movimentoSaida.Operacao = OperacaoMovimentoType.Lancamento;
            movimentoEntrada.Tipo = movimentoSaida.Tipo = TipoMovimentoType.Documento;
            movimentoEntrada.Valor = movimentoSaida.Valor = (decimal)txtValor.EditValue;
            movimentoEntrada.PlanoConta = movimentoSaida.PlanoConta = (PlanoConta)lkpPlanoConta.Selecionado;
            movimentoEntrada.Codigo = movimentoSaida.Codigo = MovimentoController.Instancia.GetNovoCodigoMovimento();
            movimentoEntrada.Origem = (int)cwkGestao.Modelo.OrigemMovimentoType.Caixa;
            movimentoSaida.Origem = (int)cwkGestao.Modelo.OrigemMovimentoType.Caixa;

            saida.Movimentos.Add(movimentoSaida);
            entrada.Movimentos.Add(movimentoEntrada);
            cwkGestao.Negocio.MovCaixaController.TrataDatas(saida);
            cwkGestao.Negocio.MovCaixaController.TrataDatas(entrada);
            cwkGestao.Negocio.MovCaixaController.Instancia.Salvar(saida, Acao.Incluir);
        }

        private void lkbEmpresa_Click(object sender, EventArgs e)
        {
        }

        private void FormTransferenciaBanco_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Transferência Banco");
                    break;
                default:
                    break;
            }
        }

    }
}
