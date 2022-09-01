using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Interfaces;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using cwkGestao.Modelo.Proxy;
using System.Linq;
using Aplicacao.Modulos.Comercial.Impressao;
using Aplicacao.Base;

namespace Aplicacao
{
    public partial class GridOSOrdemServicoGen : Aplicacao.IntermediariasTela.GridOrdemServicoIntermediaria
    {

        public GridOSOrdemServicoGen(IList<OSOrdemServico> lista, IFormManut<OSOrdemServico> formManut, OSOrdemServico ordemServico, bool adicionarFiltro)
            : base(lista, formManut, ordemServico, adicionarFiltro)
        {
            ConfiguraBotaoImprimir();
            ConfiguraBotaoFaturar();
        }

        public GridOSOrdemServicoGen(IList<OSOrdemServico> lista, IFormManut<OSOrdemServico> formManut, bool adicionarFiltro)
            : base(lista, formManut, null, adicionarFiltro)
        {
            ConfiguraBotaoImprimir();
            ConfiguraBotaoFaturar();
        }
        public GridOSOrdemServicoGen()
        {
            InitializeComponent();
            ConfiguraBotaoImprimir();
            ConfiguraBotaoFaturar();
        }

        private void ConfiguraBotaoFaturar()
        {
            sbFuncao11.Click += new EventHandler(btFaturar_Click);
            sbFuncao11.Text = "Fa&turar";
            sbFuncao11.Image = global::Aplicacao.Properties.Resources.Gerar_Jornada_com_folga_copy;
            sbFuncao11.Visible = true;
            sbFuncao11.Enabled = true;
            sbFuncao11.Refresh();
        }

        private void ConfiguraBotaoImprimir()
        {
            sbFuncao10.Click += new EventHandler(btImprimir_Click);
            sbFuncao10.Text = "&Imprimir";
            sbFuncao10.Image = global::Aplicacao.Properties.Resources.Imprimir_Cartão_Ponto_copy;
            sbFuncao10.Visible = true;
            sbFuncao10.Enabled = true;
            sbFuncao10.Refresh();
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            PerguntarPorImpressao();
        }

        private void btFaturar_Click(object sender, EventArgs e)
        {
            var osSelecionada = GetRegistroSelecionado();

            if (osSelecionada != null)
            {
                if (osSelecionada.Status != OSOrdemServico.StatusOS.AguardandoFaturamento)
                {
                    MessageBox.Show("Somente orçamentos com Status \'Aguardando Faturamento\' podem ser faturados.");
                }
                else
                {
                    string mensagem;
                    if (!cwkGestao.Negocio.NotaController.Instancia.DadosPedidoFaturarValidos(osSelecionada.Cliente, out mensagem))
                    {
                        MessageBox.Show("Antes de efetuar a fatura é necessário corrigir o cadastro do cliente:"
                            + Environment.NewLine + mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        FormFaturamentoOSLote form = new FormFaturamentoOSLote(osSelecionada);
                        form.ShowDialog();
                        lista = OSOrdemServicoController.Instancia.GetAll();
                        gcPrincipal.RefreshDataSource();
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado.");
            }
        }

        private void PerguntarPorImpressao()
        {
            try
            {
                var x = new CwkMessageBox<OSOrdemServico.ImprimirOS>("Imprimir", "Deseja imprimir a Ordem de Serviço criada?").ShowDialog();
                switch (x)
                {
                    case OSOrdemServico.ImprimirOS.Laser:
                        var selecionado = GetRegistroSelecionado();
                        string Err = String.Empty;
                        if (selecionado != null)
                        {
                            Err = ImpressaoOSOrdemServico.ImprimeOS(selecionado.ID);    
                        }
                        else
                        {
                            Err = ImpressaoOSOrdemServico.ImprimeOS(null);
                        }
                        
                        if (Err != String.Empty)
                            MessageBox.Show(Err);
                        break;
                    case OSOrdemServico.ImprimirOS.Fechar:
                        break;
                }
            }
            catch (Exception e)
            {
                new FormErro(e).ShowDialog();
            }
        }

        protected override void Alterar()
        {
            if (((OSOrdemServico)gvPrincipal.GetFocusedRow()).Status != OSOrdemServico.StatusOS.Fechada)
                base.Alterar();
            else
            {
                MessageBox.Show("Não se pode alterar um Orçamento de Serviço com o status fechado.\n\nAbrindo como consulta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                base.Consultar();
            }
        }
    }
}
