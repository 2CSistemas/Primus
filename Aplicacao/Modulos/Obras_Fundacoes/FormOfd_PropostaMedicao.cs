using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using Aplicacao.Util;
using System.Reflection;
using System.Linq;

namespace Aplicacao
{
    public partial class FormOfd_PropostaMedicao : Aplicacao.IntermediariasTela.FormManutOfd_PropostaMedicaoIntermediaria
    {
        private Ofd_Obra obraSelecionada;

        public FormOfd_PropostaMedicao(Ofd_Obra obra)
        {
            this.obraSelecionada = obra;
        }
        protected override void InitializeChildComponents()
        {
            InitializeComponent();         
            ConfgurarLookups();
            ConfigurarGridPerfuracoes();
            SetarTags();
            gcOcorrencias.DataSource = Selecionado.Ocorrencias;
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
           base.sbGravar_Click(sender, e);
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            if (obraSelecionada == null)
            {
                List<Ofd_Proposta> p = new List<Ofd_Proposta>();
                cbProposta.Properties.DataSource = new List<Ofd_Proposta>() { Selecionado.Proposta };
                
            }
            else
            {
                cbProposta.Properties.DataSource = Ofd_PropostaController.Instancia.GetAllByObra(obraSelecionada);

            }
        }

        protected override void Cancelar()
        {
            base.Cancelar();
        }

        protected override void btSubRegistro_Click(object sender, EventArgs e)
        {
            TelaProObjeto(tcPrincipal);
            base.btSubRegistro_Click(sender, e);
            Selecionado.CalcularProdutividade();
            txtProdutividade.EditValue = Selecionado.Produtividade;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            SetarTags(); 
            AtualizarTempoTrabalhoEProdutividade();
            if (Selecionado.Medicao == 0)
            {
                txtMedicao.EditValue = Ofd_PropostaController.Instancia.GetMaxNumMedicao(Selecionado.Proposta.ID);
            }          
            if (cbProposta.ItemIndex < 0)
                cbProposta.ItemIndex = 0;
        }

        private void SetarTags()
        {
            tpPerfuracoes.Tag = Selecionado;
        }

        private void ConfgurarLookups()
        {
            lkpOperador1.Exemplo = new Pessoa { BFuncionario = true };
            lkpOperador1.CamposRestricoesAND = new List<string> { "BFuncionario" };
            lkpOperador2.Exemplo = new Pessoa { BFuncionario = true };
            lkpOperador2.CamposRestricoesAND = new List<string> { "BFuncionario" };
            lkpMaquina.Exemplo = new Ofd_Maquinas();
        }

        private void ConfigurarGridPerfuracoes()
        {
            object[] parms = new[] { new Ofd_PropostaMedicaoPerfuracao() { PropostaMedicao = Selecionado } };
            Type formType = typeof(FormOfd_PropostaMedicaoPerfuracao);

            btIncluirPerfuracao.SubFormType = btAlterarPerfuracao.SubFormType = btExcluirPerfuracao.SubFormType = btConsultarPerfuracao.SubFormType = formType;
            btIncluirPerfuracao.SubFormTypeParams = btAlterarPerfuracao.SubFormTypeParams = btExcluirPerfuracao.SubFormTypeParams = btConsultarPerfuracao.SubFormTypeParams = parms;

            //FormOfd_PropostaMedicaoPerfuracao form = new FormOfd_PropostaMedicaoPerfuracao() { Selecionado = new Ofd_PropostaMedicaoPerfuracao() { PropostaMedicao = Selecionado } };
            //btIncluirPerfuracao.SubForm = form;
            //btAlterarPerfuracao.SubForm = form;
            //btExcluirPerfuracao.SubForm = form;
            //btConsultarPerfuracao.SubForm = form;
        }

        


        private void lkbOperador1_Click(object sender, EventArgs e)
        {
            BuscarOperador(lkpOperador1);
        }

        private void lkbOperador2_Click(object sender, EventArgs e)
        {
            BuscarOperador(lkpOperador2);
        }

        private void BuscarOperador(Cwork.Utilitarios.Componentes.Lookup lkp)
        {
            var pessoas = PessoaController.Instancia.GetAllFuncionarios();
            var grid = new GridCliente(pessoas, new FormPessoa(), (Pessoa)lkp.Selecionado, "Funcionario", false);
            grid.Selecionando = true;
            grid.ShowDialog();
            if (grid.Selecionado != null)
                lkp.Localizar(grid.Selecionado.ID);
            lkp.Focus();
        }

        private void lkbMaquina_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<Ofd_Maquinas>(lkpMaquina, typeof(FormOfd_Maquinas));
        }

        private void txtInicioTrabalho_Leave(object sender, EventArgs e)
        {
            TelaProObjeto(tpPrincipal);
            AtualizarTempoTrabalhoEProdutividade();
        }

        private void AtualizarTempoTrabalhoEProdutividade()
        {
            Selecionado.CalcularTempoTrabalhoEProdutividade();
            txtTempoTrabalho.EditValue = Selecionado.TempoTrabalho;
            txtProdutividade.EditValue = Selecionado.Produtividade;
        }

        protected override void AcoesAntesSalvar()
        {
            
            if (Selecionado.InicioHorarioAlmoco.HasValue && Selecionado.InicioHorarioAlmoco.Value.Year < 1802)
                Selecionado.InicioHorarioAlmoco = Selecionado.InicioHorarioAlmoco.Value.AddYears(1802);

            if (Selecionado.TerminoHorarioAlmoco.HasValue && Selecionado.TerminoHorarioAlmoco.Value.Year < 1802)
                Selecionado.TerminoHorarioAlmoco = Selecionado.TerminoHorarioAlmoco.Value.AddYears(1802);
        }


        IList<Ofd_PropostaMedicaoOcorrencias> ListaRemoverOcorrencias = new List<Ofd_PropostaMedicaoOcorrencias>();
        private void btExcluirOcorrencias_Click(object sender, EventArgs e)
        {

            if (GetOcorrenciaSelecionada() != null)
            {
                if (MessageBox.Show("Deseja excluir este Registro ? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    IList<Ofd_PropostaMedicaoOcorrencias> lOcorrencias = new List<Ofd_PropostaMedicaoOcorrencias>();
                    lOcorrencias = (IList<Ofd_PropostaMedicaoOcorrencias>)gcOcorrencias.DataSource;
                    ListaRemoverOcorrencias.Add(GetOcorrenciaSelecionada());
                    lOcorrencias.Remove(GetOcorrenciaSelecionada());
                    gcOcorrencias.DataSource = lOcorrencias;
                    AtualizarGcOcorrencias();
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btAlterarOcorrencias_Click(object sender, EventArgs e)
        {
            if (GetOcorrenciaSelecionada() != null)
            {
                FormOfd_PropostaMedicaoOcorrencias form =
                    new FormOfd_PropostaMedicaoOcorrencias(GetOcorrenciaSelecionada(), Acao.Alterar);
                IList<Ofd_PropostaMedicaoOcorrencias> listaOcorrencias = (IList<Ofd_PropostaMedicaoOcorrencias>)gcOcorrencias.DataSource;
                
                form.ShowDialog();
                if (form.Selecionado != null)
                {
                    int i = listaOcorrencias.IndexOf(GetOcorrenciaSelecionada());
                    listaOcorrencias[i] = form.Selecionado;
                    gcOcorrencias.DataSource = listaOcorrencias;
                    AtualizarGcOcorrencias();
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void AtualizarGcOcorrencias()
        {
            gcOcorrencias.RefreshDataSource();
            gcOcorrencias.Refresh();
        }

        private void btConsultarPerfuracao_Click(object sender, EventArgs e)
        {
            if (GetOcorrenciaSelecionada() != null)
            {
                FormOfd_PropostaMedicaoOcorrencias form =
                    new FormOfd_PropostaMedicaoOcorrencias(GetOcorrenciaSelecionada(), Acao.Consultar);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um registro. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public Ofd_PropostaMedicaoOcorrencias GetOcorrenciaSelecionada()
        {
            try
            {
                Ofd_PropostaMedicaoOcorrencias retorno = new Ofd_PropostaMedicaoOcorrencias();
                retorno = (Ofd_PropostaMedicaoOcorrencias)gvOcorrencias.GetRow(gvOcorrencias.GetSelectedRows().First());
                return retorno;
            }
            catch (Exception)
            {
                return null;
            }

        }

        private void btIncluirOcorrencias_Click(object sender, EventArgs e)
        {
            FormOfd_PropostaMedicaoOcorrencias form =
            new FormOfd_PropostaMedicaoOcorrencias(null, Acao.Incluir);
            form.ShowDialog();
            if (form.Selecionado != null)
            {
                IList<Ofd_PropostaMedicaoOcorrencias> listaocorrencias = (IList<Ofd_PropostaMedicaoOcorrencias>)gcOcorrencias.DataSource == null 
                    ? new List<Ofd_PropostaMedicaoOcorrencias>() : (IList<Ofd_PropostaMedicaoOcorrencias>)gcOcorrencias.DataSource;
                form.Selecionado.PropostaMedicao = Selecionado;
                listaocorrencias.Add(form.Selecionado);
                gcOcorrencias.DataSource = listaocorrencias;
                AtualizarGcOcorrencias();
            }
        }
    }
}
