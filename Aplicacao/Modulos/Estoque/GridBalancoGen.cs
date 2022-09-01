using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Aplicacao.Interfaces;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using Aplicacao.Base;
using Aplicacao.Modulos.Estoque.Impressao;
using cwkGestao.Integracao.Magento.Exportacao;
using cwkGestao.Integracao.Magento.Utils;
using Aplicacao.Util;

namespace Aplicacao
{
    public partial class GridBalancoGen : Aplicacao.IntermediariasTela.GridBalancoIntermediaria
    {
        public GridBalancoGen(IList<Balanco> list, IFormManut<Balanco> formManut, bool adicionarFiltro)
            : this(list, formManut, null, adicionarFiltro)
        {
        }

        public GridBalancoGen(IList<Balanco> list, IFormManut<Balanco> formManut, Balanco selecionado, bool adicionarFiltro)
            : base(list, formManut, selecionado, adicionarFiltro)
        {
            InitializeComponent();

            sbFuncao10.Image = global::Aplicacao.Properties.Resources.Muda_turno_de_trabalho_copy;
            sbFuncao10.Click += new EventHandler(btFecharBalanco_Click);
            sbFuncao10.Text = "&Fechar Balanço";
            sbFuncao10.Size = new Size(150,23);
            sbFuncao10.Image = global::Aplicacao.Properties.Resources.Recalcula_Marcacaes_copy;
            sbFuncao10.Visible = true;
            sbFuncao10.Enabled = true;

            sbFuncao11.Image = global::Aplicacao.Properties.Resources.ImprimirCartaoPonto;
            sbFuncao11.Click += new EventHandler(btImprimir_Click);
            sbFuncao11.Text = "&Imprimir";
            sbFuncao11.Location = new Point(167, 392);
            sbFuncao11.Size = new Size(86, 23);
            sbFuncao11.Image = global::Aplicacao.Properties.Resources.ImprimirCartaoPonto;
            sbFuncao11.Visible = true;
            sbFuncao11.Enabled = true;
        }

        private void btFecharBalanco_Click(object sender, EventArgs e)
        {
            try
            {
                if (GetRegistroSelecionado().FechadoEm.Equals(""))
                {
                    if (MessageBox.Show("Deseja efetuar o fechamento do balanço?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var form = new FormFecharBalanco();
                        form.Selecionado = BalancoController.Instancia.LoadObjectById(GetRegistroSelecionado().ID);
                        form.ShowDialog();
                        RefreshGrid();
                    }

                    //Atualiza estoque com a loja virtual.
                    MagentoConfiguracao MagentoConfig = MagentoConfiguracaoController.Instancia.GetConfiguracao();
                    if (MagentoConfig != null)
                    {
                        if (MagentoConfig.BEnviaEstoqueMagento)
                        {
                            try
                            {
                                if (MessageBox.Show("Deseja atualizar o estoque com a loja virtual ? ", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                                {
                                    var itemsBalanco = BalancoController.Instancia.LoadObjectById(GetRegistroSelecionado().ID);

                                    SincronizacoesMagentoUtil exportador = new SincronizacoesMagentoUtil();
                                    exportador.Exportador(itemsBalanco);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                    }
                   
                }
                else
                {
                    MessageBox.Show("Não é possivel fechar um balanço já fechado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                gcPrincipal.DataSource = lista = cwkGestao.Negocio.BalancoController.Instancia.GetAll();
                gvPrincipal.MoveLastVisible();
            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
        }

        protected override void Incluir()
        {
            if (this.lista.Count(i => i.Data.Year == 1800) > 0)
            {
                MessageBox.Show("Antes de iniciar um novo balanço é necessário realizar o fechamento de todos os balanços já iniciados.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                base.Incluir();
            }
        }

        protected override void Alterar()
        {
            if (PermiteAlterarOuExcluir())
            {
                base.Alterar();
            }
        }

        private bool PermiteAlterarOuExcluir()
        {
            if (GetRegistroSelecionado().Data.Year != 1800)
            {
                MessageBox.Show("Não é possível alterar/excluir um balanço fechado.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        protected override void Excluir()
        {
            if (PermiteAlterarOuExcluir())
            {
                base.Excluir();
            }
        }

        protected override void GridGenerica_KeyDown(object sender, KeyEventArgs e)
        {
            base.GridGenerica_KeyDown(sender, e);
            switch (e.KeyCode)
            {
                case Keys.F5:
                    gcPrincipal.DataSource = cwkGestao.Negocio.BalancoController.Instancia.GetAll();
                    break;
            }
        }

        private void btImprimir_Click(object sender, EventArgs e) 
        {
            var selecionado = GetRegistroSelecionado();
            if (!String.IsNullOrEmpty(selecionado.FechadoEm))
            {
                ImpressaoLogBalanco impressao = new ImpressaoLogBalanco(BalancoController.Instancia.LoadBalancoComNotas(selecionado.ID));
                impressao.Imprimir();
            }
            else
            {
                MessageBox.Show("Não é possivel imprimir um relatório de balanço que não esta fechado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
