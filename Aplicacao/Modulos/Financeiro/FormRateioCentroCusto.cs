using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using cwkGestao.Modelo;
using System.Linq;
using cwkGestao.Negocio;
using Aplicacao.Util;
using Aplicacao.Base;

namespace Aplicacao.Modulos.Financeiro
{
    public partial class FormRateioCentroCusto : Aplicacao.IntermediariasTela.FormManutRateioCentroCusto
    {
        public Movimento movimento { get; set; }
        public FormRateioCentroCusto()
        {
            
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            lkpProjeto.Exemplo = new Projeto();
            if (Selecionado.Movimento == null)
            {
                Selecionado.Movimento = movimento;
            }
        }

        protected override bool ValidarFormulario()
        {
            dxErroProvider.ClearErrors();
            decimal totalRateios = 0;
            if (Selecionado != null)
            {
                totalRateios = Selecionado.Movimento.Rateio_Movs.Sum(s => s.Valor);
            }

            if ((Operacao ^ Acao.NaoPersistir) == Acao.Incluir)
            {
                if (Convert.ToDecimal(txtValor.EditValue) == Decimal.Zero)
                {
                    dxErroProvider.SetError(txtValor, "O valor do rateio não pode ser zero. Verifique.");
                }
                if ((totalRateios + Convert.ToDecimal(txtValor.EditValue)) > Selecionado.Movimento.Valor)
                {
                    dxErroProvider.SetError(txtValor, "O valor do rateio não pode ser superior à "
                        + (Selecionado.Movimento.Valor - totalRateios).ToString()
                        + ". Verifique.");
                }
            }
            if ((Operacao ^ Acao.NaoPersistir) == Acao.Alterar)
            {
                List<Rateio_Mov> rateios = Selecionado.Movimento.Rateio_Movs.Except(new List<Rateio_Mov>() { Selecionado }).ToList();
                totalRateios = rateios.Sum(s => s.Valor);
                if ((totalRateios + Convert.ToDecimal(txtValor.EditValue)) > Selecionado.Movimento.Valor)
                {
                    dxErroProvider.SetError(txtValor, "O valor do rateio não pode ser superior à "
                        + (Selecionado.Movimento.Valor - totalRateios).ToString()
                        + ". Verifique.");
                }
            }
            
            if (lkpProjeto.Selecionado == null)
            {
                dxErroProvider.SetError(lkpProjeto, "O Centro de Custos é obrigatório. Verifique.");
            }
            return !dxErroProvider.HasErrors;
        }

        protected override void OnShown(EventArgs e)
        {
            if (Operacao == (Acao.Incluir ^ Acao.NaoPersistir))
            {
                //Selecionado.Movimento = movimento;

                if (Selecionado.Movimento.Rateio_Movs.Count > 0)
                    txtValor.EditValue = Selecionado.Movimento.Valor - Selecionado.Movimento.Rateio_Movs.Sum(s => s.Valor);
                else
                    txtValor.EditValue = Selecionado.Movimento.Valor;

                // descomentar as linhas comentadas caso resolva-se futuramente pegar a sequencia máxima que existe no banco
                // pois os rateios são gravados somente após fechar o FormDocumentoRateio, e consequentemente, o 
                // método sera util para pegar os códigos atualizados somente após o fechamento do FormDocumentoRateio

                //int maxCodBanco = Rateio_MovController.Instancia.MaxCodigo(Selecionado.Movimento);
                int maxCodMovtos = 0;
                try
                {
                    maxCodMovtos = movimento.Rateio_Movs.Max(m => m.Sequencia) + 1;
                }
                catch (Exception)
                {
                    maxCodMovtos = 1;
                }
                txtSequencia.EditValue = maxCodMovtos;

                //if (maxCodMovtos >= maxCodBanco)
                //{
                //    txtSequencia.EditValue = maxCodMovtos;
                //}
                
                //else
                //{
                //    txtSequencia.EditValue = maxCodBanco;
                //}
            }
            base.OnShown(e);
        }

        private void lkbProjeto_Click(object sender, EventArgs e)
        {
            GridGenerica<Projeto> grid = new GridGenerica<Projeto>(cwkGestao.Negocio.ProjetoController.Instancia.GetAll(), null, false);
            grid.Selecionando = true;
            grid.EsconderBotoes(
                GridGenerica<Projeto>.Botao.Incluir | 
                GridGenerica<Projeto>.Botao.Alterar | 
                GridGenerica<Projeto>.Botao.Excluir | 
                GridGenerica<Projeto>.Botao.Consultar);

            grid.ShowDialog();
            if (grid.Selecionado != null)
            {
                try
                {
                    lkpProjeto.EditValue = ProjetoController.Instancia.LoadObjectById(grid.Selecionado.ID);
                }
                catch (Exception x)
                {
                    throw x;
                }
            }
            lkpProjeto.Focus();
        }
    }
}