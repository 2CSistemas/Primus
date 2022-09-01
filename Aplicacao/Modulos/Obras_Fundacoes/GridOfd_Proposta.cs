using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Interfaces;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using Aplicacao.Util;
using DevExpress.XtraGrid.Views.Grid;

namespace Aplicacao.Modulos.Obras_Fundacoes
{
    public partial class GridOfd_Proposta : Aplicacao.IntermediariasTela.GridOfd_PropostaIntermediaria
    {
        public GridOfd_Proposta(IList<Ofd_Proposta> lista, bool adicionarFiltro, Type formManut, params object[] parametros)
            : this(lista, null, adicionarFiltro, formManut, parametros)
        {

        }

        public GridOfd_Proposta(IList<Ofd_Proposta> lista, Ofd_Proposta selecionado, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, selecionado, adicionarFiltro, formManut, parametros)
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            gvPrincipal.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(gvPrincipal_FocusedRowChanged);
            base.OnShown(e);
        }

        private void gvPrincipal_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView gv = (GridView)sender;
            if (gv.SelectedRowsCount > 0)
            {
                Ofd_Proposta p = ((Ofd_Proposta)gv.GetRow(gv.GetSelectedRows()[0]));
                if ( p!= null)
	            {
                    sbFuncao23.Enabled = (p.TipoLancamento == 1);
	            }
            }
            else
            {
                sbFuncao23.Enabled = false;
            }
        }

        private void sbFuncao10_Click(object sender, EventArgs e)
        {
            var proposta = GetRegistroSelecionado();
            if (proposta != null)
            {
                var gridDiarios = new GridOfd_PropostaArquivos(Ofd_PropostaController.Instancia.LoadObjectById(proposta.ID), new FormOfd_PropostaArquivos());
                gridDiarios.ShowDialog();
            }
            else
                MessageBox.Show("Nenhum registro selecionado.");
        }

        private void sbFuncao11_Click(object sender, EventArgs e)
        {
            var proposta = GetRegistroSelecionado();
            if (proposta != null)
            {
                if (proposta.Status == StatusPropostaObraFundacao.AguardandoAprovacao)
                {
                    if (EhParaSelecionarObraExistente())
                        VincularObraSelecionada(proposta);
                    else
                        IncluirNovaObra(proposta);
                    AtualizarRegistroNoGrid(proposta, proposta);
                }
                else
                    MessageBox.Show("Para aprovar uma proposta ela deve estar aguardando aprovação.");
            }
            else
                MessageBox.Show("Nenhum registro selecionado.");
        }

        private void IncluirNovaObra(Ofd_Proposta proposta)
        {
            var form = new FormOfd_Obra();
            form.Selecionado = new Ofd_Obra
            {
                Descricao = proposta.NomeObra,
                Status = StatusObraFundacao.Aberta
            };
            form.Operacao = Acao.Incluir;
            form.ShowDialog();
            if (form.Selecionado != null)
            {
                proposta.Obra = form.Selecionado;
                proposta.Status = StatusPropostaObraFundacao.Aprovada;
                Ofd_PropostaController.Instancia.Salvar(proposta, Acao.Alterar);
            }
        }

        private void VincularObraSelecionada(Ofd_Proposta proposta)
        {
            var grid = new GridOfd_Obra(Ofd_ObraController.Instancia.GetAll(), new FormOfd_Obra(), false);
            grid.Selecionando = true;
            grid.ShowDialog();
            if (grid.Selecionado != null)
            {
                proposta.Obra = grid.Selecionado;
                proposta.Status = StatusPropostaObraFundacao.Aprovada;
                Ofd_PropostaController.Instancia.Salvar(proposta, Acao.Alterar);
            }
        }

        private bool EhParaSelecionarObraExistente()
        {
            return MessageBox.Show("Deseja selecionar uma obra já cadastrada no sistema?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes;
        }

        private void sbFuncao12_Click(object sender, EventArgs e)
        {
            var proposta = GetRegistroSelecionado();
            if (proposta != null)
            {
                var prop = Ofd_PropostaController.Instancia.LoadObjectByIdWithMedicoes(proposta.ID);
                var pm = new FormOfd_PropostaMedicao(null);
                var grid = new GridOfd_PropostaMedicao(prop, pm);
                grid.ShowDialog();
            }
            else
                MessageBox.Show("Nenhum registro selecionado.");
        }

        private void sbFuncao13_Click(object sender, EventArgs e)
        {
            var proposta = GetRegistroSelecionado();
            if (proposta != null)
            {
                var form = new FormFaturamentoPropostaMedicao(proposta);
                form.ShowDialog();
            }
            else
                MessageBox.Show("Nenhum registro selecionado.");
        }

        private void btTrocarProduto_Click(object sender, EventArgs e)
        {

        }

        private void sbFuncao23_Click(object sender, EventArgs e)
        {
            Ofd_Proposta selecionado = GetRegistroSelecionado();
            if (selecionado != null)
            {
                if (selecionado.TipoLancamento == 0)
                {
                    MessageBox.Show("Não é possível gerar uma proposta à partir de outra proposta. Verifique.", 
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Selecione um Orçamento para faturar.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("Deseja mesmo transformar este orçamento em uma proposta?",
                "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                FormOfd_Proposta form = new FormOfd_Proposta();
                form.Operacao = Acao.Incluir;
                form.rgTipo.Properties.Items[1].Enabled = false;
                form.ShowDialog();
                
                if (form.Selecionado != null)
                {
                    if (form.Selecionado.ID != 0)
                    {
                        selecionado.StatusOrcamento = StatusOrcamentoObraFundacao.PropostaCriada;
                        selecionado.OrcamentoPropostaVinculada = form.Selecionado;
                        form.Selecionado.OrcamentoPropostaVinculada = selecionado;
                        Ofd_PropostaController.Instancia.Salvar(selecionado, Acao.Alterar);
                        Ofd_PropostaController.Instancia.Salvar(form.Selecionado, Acao.Alterar);
                    }
                }
                AtualizarGrid();
            }
            gcPrincipal.DataSource = Ofd_PropostaController.Instancia.GetAll();
            gcPrincipal.RefreshDataSource();
            gvPrincipal.RefreshData();

        }
    }
}
