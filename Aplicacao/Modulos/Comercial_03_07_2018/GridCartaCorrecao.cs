using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;
using Aplicacao.Base;
using cwkGestao.Negocio;

namespace Aplicacao
{
    public partial class GridCartaCorrecao : Aplicacao.IntermediariasTela.Grid_CartaCorrecaoIntermediaria
    {
        private Nota nota;

        public GridCartaCorrecao(Nota nota, IFormManut<CartaCorrecao> formManut)
            : base(nota.Cartas.ToList(), formManut, false)
        {
            InitializeComponent();
            this.nota = nota;
            this.Text = "Carta de Correção " + String.Format(" [Nota {0} - {1}]", nota.Numero, nota.PessoaNome);
            gvPrincipal.OptionsView.ColumnAutoWidth = false;

            ConfiguraBotaoCCe();
        }

        protected override CartaCorrecao InstanciarNovoSelecionado()
        {
            var cartacorrecao = new CartaCorrecao { Nota = nota };
            if (nota.Cartas.Count > 0)
                cartacorrecao.Sequencia = nota.Cartas.Max(d => d.Sequencia) + 1;
            else
                cartacorrecao.Sequencia = 1;
            return cartacorrecao;
        }

        private void ConfiguraBotaoCCe()
        {
            sbFuncao10.Click += new EventHandler(btCCe_Click);
            sbFuncao10.Text = "En&viar";
            sbFuncao10.Image = global::Aplicacao.Properties.Resources.ImprimirCartaoPonto;
            sbFuncao10.Visible = true;
            sbFuncao10.Enabled = true;
            sbFuncao10.Location = new Point(12, 392);
            sbFuncao10.Size = new Size(83, 23);
        }

        private void btCCe_Click(object sender, EventArgs e)
        {
            var registroSelecionado = GetRegistroSelecionado();
            if (registroSelecionado != null)
            {
                try
                {
                    CartaCorrecaoController.Instancia.EnviarCartaCorrecao(registroSelecionado);
                }
                catch (Exception ex)
                {
                    new FormErro(ex).ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado.");
            }
        }
    }
}
