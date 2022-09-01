using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Modelo;
using Aplicacao.Util;
using cwkGestao.Modelo.Proxy;

namespace Aplicacao
{
    public partial class FormConsultaMovimentosEstoque : Form
    {
        public FormConsultaMovimentosEstoque(Produto produto, LocalEstoque localEstoque)
        {
            InitializeComponent();

            if (localEstoque == null)
                gcMovimentos.DataSource = NotaItemController.Instancia.GetMovimentosEstoque(produto.ID, 0);
            else
                gcMovimentos.DataSource = NotaItemController.Instancia.GetMovimentosEstoque(produto.ID, localEstoque.ID);
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormConsultaEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void sbConsultarNota_Click(object sender, EventArgs e)
        {
            try
            {
                var nota = NotaController.Instancia.GetByCodigo(GetRegistroSelecionado().CodNota);
                if (nota != null)
                {
                    using (var formNota = new FormNota(nota.Ent_Sai))
                    {
                        formNota.Selecionado = nota;
                        formNota.Operacao = Acao.Consultar;
                        formNota.ShowDialog();
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Não existem notas selecionadas, ou não existem notas à serem exibidas");
                new Aplicacao.Base.FormErro("Erro na seleção de notas"+System.Environment.NewLine+
                "\r\n\r\n"+" Favor verificar se existem notas selecionadas.", "Não existem notas selecionadas, ou não existem notas à serem exibidas").Show();
                return;
            }
        }

        protected virtual pxyMovimentoEstoqueProduto GetRegistroSelecionado()
        {
            try
            {
                return (pxyMovimentoEstoqueProduto)gvMovimentos.GetRow(gvMovimentos.GetSelectedRows()[0]);
            }
            catch (IndexOutOfRangeException)
            {
                return null;
            }
        }
    }
}
