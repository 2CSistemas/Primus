using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Interfaces;
using Aplicacao.IntermediariasTela;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using cwkGestao.Negocio.RelatoriosMatriciais;
using DevExpress.XtraGrid;
using Aplicacao.Base;

namespace Aplicacao
{
    public partial class GridNotaComplementarGen : Aplicacao.IntermediariasTela.GridNotaIntermediaria
    {
        private InOutType inOut;

        public static GridNotaComplementarGen Get(InOutType inOut)
        {
            return new GridNotaComplementarGen(NotaController.Instancia.GetAllComplementares(inOut), inOut, null, false, typeof(FormNotaComplementar));
        }

        private GridNotaComplementarGen(IList<Nota> lista, InOutType inOut, Nota selecionado, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, selecionado, adicionarFiltro, formManut, parametros)
        {
            this.inOut = inOut;
            ConfiguraBotaoNFe();
            this.Text += String.Format(" de {0} [Complementar]", inOut);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            //this.Text += String.Format(" de {0} [Complementar]", inOut);
        }

        private void ConfiguraBotaoNFe()
        {
            sbFuncao10.Click += new EventHandler(btNFe_Click);
            sbFuncao10.Text = "NF&e";
            sbFuncao10.Image = global::Aplicacao.Properties.Resources.ImprimirCartaoPonto;
            sbFuncao10.Visible = true;
            sbFuncao10.Enabled = true;
        }

        private void btNFe_Click(object sender, EventArgs e)
        {
            var registroSelecionado = GetRegistroSelecionado();
            if (registroSelecionado != null)
            {
                if (registroSelecionado.ModeloDocto != 55 && registroSelecionado.ModeloDocto != 65)
                {
                    MessageBox.Show("O registro selecionado não é uma NFe.", "Operação não Permitida", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    try
                    {
                        FormNFe frmNFe = new FormNFe();
                        frmNFe.IDNota = registroSelecionado.ID;
                        frmNFe.ShowDialog();
                        frmNFe.Dispose();

                        RecarregarGrid();
                    }
                    catch (Exception ex)
                    {
                        new FormErro(ex).ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado.");
            }
        }

        protected override void GridGenerica_Shown(object sender, EventArgs e)
        {
            base.GridGenerica_Shown(sender, e);
            FormatarColunaStatus();
        }

        private void FormatarColunaStatus()
        {
            StyleFormatCondition estilo = new StyleFormatCondition();
            estilo.Appearance.ForeColor = Color.Green;
            estilo.Appearance.Options.UseForeColor = true;
            estilo.ApplyToRow = false;
            estilo.Column = gvPrincipal.Columns["StatusLegivel"];
            estilo.Condition = FormatConditionEnum.Equal;
            estilo.Value1 = "Autorizada";

            StyleFormatCondition estilo2 = new StyleFormatCondition();
            estilo2.Appearance.ForeColor = Color.Red;
            estilo2.Appearance.Options.UseForeColor = true;
            estilo2.ApplyToRow = false;
            estilo2.Column = gvPrincipal.Columns["StatusLegivel"];
            estilo2.Condition = FormatConditionEnum.Equal;
            estilo2.Value1 = "Negada";

            StyleFormatCondition estilo3 = new StyleFormatCondition();
            estilo3.Appearance.ForeColor = Color.Blue;
            estilo3.Appearance.Options.UseForeColor = true;
            estilo3.ApplyToRow = false;
            estilo3.Column = gvPrincipal.Columns["StatusLegivel"];
            estilo3.Condition = FormatConditionEnum.Equal;
            estilo3.Value1 = "Não enviada";
            estilo3.Value2 = "Aguardando";

            StyleFormatCondition estilo4 = new StyleFormatCondition();
            estilo4.Appearance.ForeColor = Color.Brown;
            estilo4.Appearance.Options.UseForeColor = true;
            estilo4.ApplyToRow = false;
            estilo4.Column = gvPrincipal.Columns["StatusLegivel"];
            estilo4.Condition = FormatConditionEnum.Equal;
            estilo4.Value1 = "Cancelada";

            gvPrincipal.FormatConditions.Add(estilo);
            gvPrincipal.FormatConditions.Add(estilo2);
            gvPrincipal.FormatConditions.Add(estilo3);
            gvPrincipal.FormatConditions.Add(estilo4);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            switch (e.KeyCode)
            {
                case Keys.F5:
                    RecarregarGrid();
                    break;
            }
        }

        private void RecarregarGrid()
        {
            gcPrincipal.DataSource = NotaController.Instancia.GetAllComplementares(inOut);
            gvPrincipal.MoveLastVisible();
        }

        protected override void Incluir()
        {
            var grid = GridNotaGen.Get(inOut, ProdutoServicoType.Produtos, false);  



            grid.SelecionandoComplementada = true;
            grid.ShowDialog();
            if (grid.Selecionado != null)
            {
                if (grid.Selecionado.ModeloDocto == 55 && grid.Selecionado.Status == "2")
                {
                    var form = new FormNotaComplementar();                    
                    form.Selecionado = NotaController.Instancia.GetNotaComplementar(grid.Selecionado);
                    form.Operacao = form.Selecionado.ID == 0 ? Acao.Incluir : Acao.Alterar;
                    form.ShowDialog();
                    RecarregarGrid();
                }
                else
                    MessageBox.Show("Só é possível complementar NFe Autorizada.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
