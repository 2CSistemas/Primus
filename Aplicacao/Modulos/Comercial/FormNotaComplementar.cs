using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Base;
using cwkGestao.Negocio;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Exceptions;

namespace Aplicacao
{
    public partial class FormNotaComplementar : Aplicacao.IntermediariasTela.FormManutNotaIntermediaria
    {
        private LogicaTelaNotaFiscal logicaTelaNota;
        private Nota notaComplementada;

        private NotaItem NotaItemSelecionado
        {
            get
            {
                try
                {

                    return Selecionado.NotaItems[gvNotaItems.GetSelectedRows()[0]];
                }
                catch
                {
                    return null;
                }
            }
        }

        public FormNotaComplementar()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            DiscriminaTabs();
        }

        private void DiscriminaTabs()
        {
            tcPrincipal.Tag = Selecionado;
            tcItems.Tag = Selecionado;
            tcComplementar.Tag = Selecionado;
            tpDados.Tag = Selecionado;
            tpProdutos.Tag = Selecionado;
            tpICMS.Tag = Selecionado;
            tpImposto.Tag = Selecionado;
            tpObservacao.Tag = Selecionado;
            tpParcelas.Tag = Selecionado;
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            logicaTelaNota = new LogicaTelaNotaFiscal(Selecionado) { EhNotaComplementar = true };
            notaComplementada = Selecionado.NotaComplementada;
            DiscriminaTabs();            
        }

        protected override void OnShown(EventArgs e)
        {
            txtInfoComplementada.Text = notaComplementada.Codigo + " | " + notaComplementada.PessoaNome;
            if (Selecionado.Status != "-1")
            {
                LiberaCamposEdicao(tpPrincipal.Controls, false);
                sbGravar.Visible = false;
                MessageBox.Show("Esta NFe complementar não pode ser alterada, pois já foi enviada.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        protected override void OK()
        {
            try
            {
                if (ValidarFormulario())
                {
                    if (Operacao < Acao.Consultar)
                    {
                        logicaTelaNota.SetObservacaoUsuario(txtObservacaoUsuario.Text);
                        logicaTelaNota.Salvar(Operacao, false);
                    }
                    this.Close();
                }
            }
            catch (Exception e)
            {
                new FormErro(e).ShowDialog();
            }
        }

        protected override bool ValidarFormulario()
        {
            var formValido = base.ValidarFormulario();

            if (gvNotaItems.RowCount == 0)
            {
                formValido = false;
                MessageBox.Show("A nota complementar deve ter pelo menos um item.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return formValido;
        }

        protected override List<Exception> ObjetoPraTela(Control pai)
        {
            return base.ObjetoPraTela(pai);
        }

        protected override void TelaProObjeto(Control pai)
        {
        }

        private void btIncluirProduto_Click(object sender, EventArgs e)
        {
            dxErroProvider.ClearErrors();
            try
            {
                LogicaTelaNotaItem logicaTelaNotaItem;
                FormNotaItem formNotaItem;

                do
                {
                    logicaTelaNotaItem = logicaTelaNota.GetLogicaTelaNotaItem();
                    logicaTelaNotaItem.Operacao = Operacao;
                    logicaTelaNotaItem.PessoaSelecionada = (Pessoa)lkpPessoa.Selecionado;
                    logicaTelaNotaItem.FilialSelecionada = (Filial)lkpFilial.Selecionado;
                    logicaTelaNotaItem.tipoNota = (TipoNota)lkpTipoNota.Selecionado;
                    formNotaItem = new FormNotaItem(logicaTelaNotaItem);
                    formNotaItem.ShowDialog();

                    if (formNotaItem.Selecionado != null)
                    {
                        formNotaItem.Selecionado.ProdutoFCI = formNotaItem.produtoFCI;
                        logicaTelaNota.InserirNotaItem(formNotaItem.Selecionado);
                    }
                    gvNotaItems.RefreshData();
                    gvNotaParcelas.RefreshData();
                    gvNotaICMSs.RefreshData();
                    TratarErrosEncontrados();
                    AtualizaTotais();
                } while (formNotaItem.Selecionado != null);
            }
            catch (FormException exc)
            {
                TratarFormException(exc);
            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
        }
        private void btAlterarProduto_Click(object sender, EventArgs e)
        {
            NotaItem notaItemSelecionado = NotaItemSelecionado;
            if (notaItemSelecionado != null)
            {
                LogicaTelaNotaItem logicaTelaNotaItem = logicaTelaNota.GetLogicaTelaNotaItem(notaItemSelecionado);
                logicaTelaNotaItem.tipoNota = notaItemSelecionado.Nota.TipoNota;
                FormNotaItem formNotaItem = new FormNotaItem(logicaTelaNotaItem);
                formNotaItem.Selecionado = notaItemSelecionado;
                formNotaItem.TotalLiberado = true;
                formNotaItem.ShowDialog();
                gvNotaItems.RefreshData();
                AtualizaTotais();
            }
        }

         


        private void btExcluirProduto_Click(object sender, EventArgs e)
        {
            NotaItem notaItemSelecionado = NotaItemSelecionado;
            if (notaItemSelecionado != null)
            {
                Selecionado.NotaItems.Remove(notaItemSelecionado);
                gvNotaItems.RefreshData();
                AtualizaTotais();
            }
        }

        private void btConsultarNotaComplementada_Click(object sender, EventArgs e)
        {
            var form = new FormNota(Selecionado.Ent_Sai);
            form.Operacao = Acao.Consultar;
            form.Selecionado = Selecionado.NotaComplementada;
            form.ShowDialog();
        }

        private bool TratarErrosEncontrados()
        {
            if (logicaTelaNota.ExistemErros)
            {
                var mensagemErro = new StringBuilder();
                mensagemErro.AppendLine("Verificar anomalias:");
                mensagemErro.AppendLine("");
                foreach (var erro in logicaTelaNota.GetErros)
                {
                    mensagemErro.AppendLine(erro);
                }
                new FormErro(new Exception(mensagemErro.ToString())).ShowDialog();
                return true;
            }
            return false;
        }

        private void AtualizaTotais()
        {
            logicaTelaNota.AtualizaSomatoriosTotais();
            txtTotalProduto.Value = Selecionado.TotalProduto;
            txtValorIPI.Value = Selecionado.ValorIPI;
            txtTotalNota.Value = Selecionado.TotalNota;
        }

        private void TratarFormException(FormException exc)
        {
            foreach (string campoErrado in exc.CamposErrados)
            {
                Control controleErrado = ControleComNome(campoErrado);
                dxErroProvider.SetError(controleErrado, "Campo obrigatório para inserção de itens");
            }
        }

        private Control ControleComNome(string nomeCampoErrado)
        {
            FieldInfo[] todosCampos = this.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (FieldInfo candidatoCampoErrado in todosCampos.Where(i => i.Name.Contains(nomeCampoErrado)))
            {
                if (!candidatoCampoErrado.FieldType.IsSubclassOf(typeof(DevExpress.XtraEditors.SimpleButton)))
                    return (Control)candidatoCampoErrado.GetValue(this);
            }

            return null;
        }

        private void tcComplementar_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page.Equals(tpImposto))
            {
                txtPisBase.EditValue = Selecionado.NotaItems.Sum(a => a.VBC_Q07);
                txtPisValor.EditValue = Selecionado.NotaItems.Sum(a => a.VPIS_Q09);
                txtCofinsBase.EditValue = Selecionado.NotaItems.Sum(a => a.VBC_S07);
                txtCofinsValor.EditValue = Selecionado.NotaItems.Sum(a => a.VCOFINS_S11);
            }

            if (e.Page.Equals(tpObservacao))
            {
                logicaTelaNota.AtualizarObservacaoSistema();
                txtObservacaoSistema.Text = Selecionado.ObservacaoSistema;
                txtObservacaoUsuario.Properties.MaxLength = logicaTelaNota.CaracteresRestantesObservacao;
            }
        }

        private void gcNotaItems_DoubleClick(object sender, EventArgs e)
        {
            if (btAlterarProduto.Enabled)
                btAlterarProduto_Click(sender, e);
        }
    }
}
