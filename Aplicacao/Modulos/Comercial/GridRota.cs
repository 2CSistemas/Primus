using System;
using cwkGestao.Negocio;
using Aplicacao.IntermediariasTela;
using System.Windows.Forms;
using cwkGestao.Modelo;
using System.Linq;
using System.Collections.Generic;
using Aplicacao.Base;

namespace Aplicacao.Modulos.Comercial
{
    public partial class GridRota : GridRotaIntermediaria
    {
        public GridRota() : base(RotaController.Instancia.GetAll(), null, false)
        {
            InitializeComponent();
            sbIncluir.Visible = sbIncluir.Enabled = true;
            sbAlterar.Visible = sbAlterar.Enabled = true;
            sbExcluir.Visible = sbExcluir.Enabled = true;
            FormManut = new FormRota(Selecionado);
            
        }

        private void gvPrincipal_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (GetRegistrosSelecionados().Count > 1)
            {
                HabilitaDesabilitaBotoes(false);
            }
            else
            {
                HabilitaDesabilitaBotoes(true);
            }
        }

        private void HabilitaDesabilitaBotoes(bool valor)
        {
            sbAlterar.Visible = sbAlterar.Enabled = valor;
            sbConsultar.Visible = sbConsultar.Enabled = valor;
            sbFuncao13.Visible = sbFuncao13.Enabled = valor;
            sbImprimirFiltro.Visible = sbImprimirFiltro.Enabled = valor;
        }

        protected override void GridGenerica_Shown(object sender, EventArgs e)
        {
            base.GridGenerica_Shown(sender, e);
            gvPrincipal.OptionsSelection.MultiSelect = true;
            gvPrincipal.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(gvPrincipal_SelectionChanged);
        }

        private void sbFuncao13_Click(object sender, EventArgs e)
        {
            IncluirClone();
        }

        private void IncluirClone()
        {
            Rota selecionado = GetRegistroSelecionado();
            if (selecionado != null)
            {
                Rota rotaClone = new Rota();
                rotaClone.Codigo = RotaController.Instancia.MaxCodigo();
                rotaClone.Data = selecionado.Data;
                rotaClone.Descricao = selecionado.Descricao;
                rotaClone.Filial = selecionado.Filial;
                rotaClone.Observacao = selecionado.Observacao;
                rotaClone.Responsavel = selecionado.Responsavel;
                rotaClone.RotaDetalhes = new List<RotaDetalhe>();

                int codigo = 0;
                foreach (RotaDetalhe rotadetalhe in selecionado.RotaDetalhes)
                {
                    codigo++;
                    RotaDetalhe rotaDetalheClone = new RotaDetalhe();
                    rotaDetalheClone.Codigo = codigo;
                    rotaDetalheClone.Sequencia = rotadetalhe.Sequencia;
                    rotaDetalheClone.Cliente = rotadetalhe.Cliente;
                    rotaDetalheClone.Rota = rotaClone;
                    rotaDetalheClone.Operador = rotadetalhe.Operador;
                    rotaClone.RotaDetalhes.Add(rotaDetalheClone);
                }

                FormManut.Selecionado = rotaClone;
                FormManut.Operacao = cwkGestao.Modelo.Acao.Incluir;
                FormManut.ShowDialog();
                if (FormManut.Selecionado != null)
                {
                    lista.Add(FormManut.Selecionado);
                    SelecionaRegistroNoGrid(gvPrincipal.GetRowHandle(lista.IndexOf(FormManut.Selecionado)));
                }
                AtualizarGrid();
                
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado. Somente consulta.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       

        private void sbFuncao12_Click(object sender, EventArgs e)
        {
            FormGeracaoRotas form = new FormGeracaoRotas();
            form.ShowDialog();
            if (form.rotasGeradas != null)
            {
                foreach (var item in form.rotasGeradas)
                    lista.Add(item);
                AtualizarGrid();
                MessageBox.Show("Rotas Geradas com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        protected override void Excluir()
        {
            try
            {
                IList<Rota> rotasSelecionadas = GetRegistrosSelecionados();
                if (rotasSelecionadas.Count > 0)
                {
                    if ((MessageBox.Show("Deseja excluir as Rotas Selecionadas?", "Atenção",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                    {
                        foreach (Rota rotaSelecionadas in rotasSelecionadas)
                        {                          
                            if (rotaSelecionadas.RotaDetalhes.Count == rotaSelecionadas.RotaDetalhes.Where(p => p.Situacao == 0).ToList().Count)
                            {
                                RotaController.Instancia.Salvar(rotaSelecionadas, Acao.Excluir);
                                lista.Remove(rotaSelecionadas);                                
                            }
                        }
                        AtualizarGrid();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione pelo menos um registro para exclusão", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                rotasSelecionadas = new List<Rota>();
            }
            catch (Exception ex)
            {
                FormErro form = new FormErro(ex);
                form.ShowDialog();
            }
            
        }
    }
}