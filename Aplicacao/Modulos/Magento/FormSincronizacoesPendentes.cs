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
using cwkGestao.Integracao.Magento.Exportacao;
using Aplicacao.Base;

namespace Aplicacao.Modulos.Utilitarios
{
    public partial class FormSincronizacoesPendentes : Form
    {
        private IList<SincronismoPendente> sincronismos;

        public FormSincronizacoesPendentes()
        {
            InitializeComponent();
            AtualizarSincronizacoesPendentes();
        }

        private void AtualizarSincronizacoesPendentes()
        {
            gcSincronizacoes.DataSource = sincronismos = SincronismoPendenteController.Instancia.GetAll();
            gcSincronizacoes.RefreshDataSource();
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sbSincronizar_Click(object sender, EventArgs e)
        {
            
            var selecionados = sincronismos.Where(s => s.Selecionado);
            if (selecionados.Count() > 0)
                Sincronizar(selecionados);
        }

        private void Sincronizar(IEnumerable<SincronismoPendente> selecionados)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                using (var exportador = new MegaExportador())
                {
                    foreach (var item in selecionados)
                    {
                        object entidade = null;
                        if (item.NomeCadastro == typeof(GrupoEstoque).Name)
                            entidade = GrupoEstoqueController.Instancia.LoadObjectById(item.IDCadastro);
                        else if (item.NomeCadastro == typeof(Produto).Name)
                            entidade = ProdutoController.Instancia.LoadObjectById(item.IDCadastro);
                        else if (item.NomeCadastro == typeof(Pessoa).Name)
                            entidade = PessoaController.Instancia.LoadObjectById(item.IDCadastro);
                        else if (item.NomeCadastro == typeof(Nota).Name)
                            entidade = NotaController.Instancia.LoadObjectById(item.IDCadastro);

                        exportador.Exportar(entidade);
                        SincronismoPendenteController.Instancia.Salvar(item, Acao.Excluir);
                    }
                }
                AtualizarSincronizacoesPendentes();
            }
            catch (Exception ex)
            {
                FormErro.ShowDialog(ex);
            }
            Cursor = Cursors.Default;
        }

        private void sbSelecionarTodos_Click(object sender, EventArgs e)
        {
            AlterarSelecaoGrid(true);
        }

        private void sbLimparSelecao_Click(object sender, EventArgs e)
        {
            AlterarSelecaoGrid(false);
        }

        private void AlterarSelecaoGrid(bool selecionado)
        {
            sincronismos.ToList().ForEach(f => f.Selecionado = selecionado);
            gcSincronizacoes.RefreshDataSource();
        }

    }
}
