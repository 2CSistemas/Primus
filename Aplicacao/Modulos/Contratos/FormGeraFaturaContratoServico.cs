using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Linq;
using cwkGestao.Negocio.Contratos;
using System.Collections.Generic;

namespace Aplicacao.Modulos.Contratos
{
    public partial class FormGeraFaturaContratoServico : Form
    {
        private FaturadorContratoServico gerador;
        private bool finalizou;
        private bool contemErros;
        public bool sucesso;
        int idTipoNota;
        public string refe;

        public FormGeraFaturaContratoServico()
        {
            InitializeComponent();
            IniciaExemplos();
            if (rbVencimento.Checked == true)
            {
                txtReferencia.Enabled = false;
                txtVencimento.Enabled = true;
            }
            else if (rbReferencia.Checked == true)
            {
                txtReferencia.Enabled = true;
                txtVencimento.Enabled = false;
            }
        }

        private void sbGerar_Click(object sender, EventArgs e)
        {
            if (CamposValidos() && PodeImportar())
            {
                xtraTabPage1.Refresh();
                Gerar();
            }
        }

        private bool CamposValidos()
        {
            dxErrorProvider.ClearErrors();

            if (lkpTipoNotaServivo.Selecionado == null)
                dxErrorProvider.SetError(lkpTipoNotaServivo, "Campo obrigatório");

            if (String.IsNullOrEmpty(txtReferencia.Text))
                dxErrorProvider.SetError(txtReferencia, "Campo obrigatório");

            if (txtVencimento.EditValue == null)
                dxErrorProvider.SetError(txtVencimento, "Campo obrigatório");

            if (Convert.ToDateTime(txtVencimento.EditValue).Date < DateTime.Now.Date)
            {
                dxErrorProvider.SetError(txtVencimento, "Vencimento não pode ser menor que a data atual.");
                MessageBox.Show(this, "Vencimento não pode ser menor que a data atual.", "ATENÇÃO!");
            }

            return !dxErrorProvider.HasErrors;
        }

        private bool PodeImportar()
        {
            return MessageBox.Show("Deseja gerar os Documentos para o grupo selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void Gerar()
        {
            ParametrosContratoProduto parmProd = new ParametrosContratoProduto();
            parmProd = ParametrosContratoProdutoController.Instancia.GetAll().FirstOrDefault();
            try
            {
                bool diaVenc;
                TipoNota tipoNotaServico = new TipoNota();
                if (rbReferencia.Checked == true)
                {
                    diaVenc = false;
                }
                else
                {
                    diaVenc = true;
                }
                tipoNotaServico = (TipoNota)lkpTipoNotaServivo.Selecionado;

                gerador = new FaturadorContratoServico(txtReferencia.Text, txtVencimento.DateTime, tipoNotaServico, diaVenc, ckbFaturarProximoMes.Checked, cbGerarNotasComDataAtual.Checked);
                gerador.GerarFaturas(ref sucesso);
                if (sucesso)
                {
                    MessageBox.Show("Documentos gerados com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                else
                    this.Close();
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

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sbAjuda_Click(object sender, EventArgs e)
        {
            this.ChamarHelp();
        }

        private void lkbTipoNota_Click(object sender, EventArgs e)
        {
            try
            {
                GridGenerica<TipoNota> grid = new GridGenerica<TipoNota>(TipoNotaController.Instancia.GetAllPorCategoria(cwkGestao.Modelo.TipoNota.CategoriaMovimentacao.Servicos), new FormTipoNota(), (TipoNota)lkpTipoNotaServivo.Selecionado, false);
                TipoNota tipoNota = new TipoNota() { Categoria = TipoNota.CategoriaMovimentacao.Servicos };
                grid.Selecionando = true;

                if (cwkControleUsuario.Facade.ControleAcesso(grid))
                    grid.ShowDialog();

                if (grid.Selecionado == null)
                {
                    grid.Close();
                }
                else
                {
                    tipoNota = TipoNotaController.Instancia.LoadObjectById(grid.Selecionado.ID);
                    lkpTipoNotaServivo.Localizar(tipoNota.ID);
                    idTipoNota = tipoNota.ID;
                }
                lkpTipoNotaServivo.Focus();
            }
            catch (Exception ex)
            {
                throw new Exception("", ex);
            }
        }

        private int cont = 0;


        private void IniciaExemplos()
        {
            txtReferencia.EditValue = String.Format("{0:00}/{1:0000}", DateTime.Today.Month, DateTime.Today.Year);
            txtVencimento.DateTime = DateTime.Today;
            lblInformacao.Text = String.Empty;
            lkpTipoNotaServivo.Exemplo = new cwkGestao.Modelo.TipoNota() { Categoria = TipoNota.CategoriaMovimentacao.Servicos };
            lkpTipoNotaServivo.CamposRestricoesAND = new List<string>() { "Categoria" };
            lkpTipoNotaServivo.Sessao = cwkGestao.Negocio.TipoNotaController.Instancia.getSession();
        }

        private void sbMostrarContrato_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                if (idTipoNota == 0 && lkpTipoNotaServivo.ID > 0)
                {
                    idTipoNota = lkpTipoNotaServivo.ID;
                }
                TipoNota tip = TipoNotaController.Instancia.LoadObjectById(idTipoNota);
                bool DiaVenc;
                if (rbReferencia.Checked == true)
                {
                    DiaVenc = false;
                }
                else
                {
                    DiaVenc = true;
                }

                if (tip == null)
                {
                    MessageBox.Show("Tipo de nota não informado !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                GridPesquisaFaturasContratoServico form = new GridPesquisaFaturasContratoServico(Convert.ToDateTime(txtVencimento.EditValue), tip, txtReferencia.EditValue.ToString(), DiaVenc, ckbFaturarProximoMes.Checked, cbGerarNotasComDataAtual.Checked);

                //form.Ref = txtReferencia.EditValue.ToString();
                //form.referencia = txtReferencia.EditValue.ToString();
                form.ShowDialog();
            }
        }

        private void rgTipo_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {

        }

        private void rbReferencia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbReferencia.Checked == true)
            {
                txtReferencia.Enabled = true;
                txtVencimento.Enabled = false;
            }
        }

        private void rbVencimento_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVencimento.Enabled == true)
            {
                txtReferencia.Enabled = false;
                txtVencimento.Enabled = true;
            }
        }

        private void txtVencimento_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(txtVencimento.EditValue).Date < DateTime.Now.Date)
            {
                txtVencimento.Focus();
                dxErrorProvider.SetError(txtVencimento, "Vencimento não pode ser menor que a data atual.");
                MessageBox.Show(this, "Vencimento não pode ser menor que a data atual.", "ATENÇÃO!");
            }
        }
    }
}
