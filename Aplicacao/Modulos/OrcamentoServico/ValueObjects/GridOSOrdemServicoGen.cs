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
using System.IO;
using cwkGestao.Negocio.Utils;
using System.Text.RegularExpressions;
using Aplicacao.Util.Telas;

namespace Aplicacao
{
    public partial class GridOSOrdemServicoGen : Aplicacao.IntermediariasTela.GridOrdemServicoIntermediaria
    {
        public Dictionary<string, string> ListaTags { get; set; }

        public GridOSOrdemServicoGen(IList<OSOrdemServico> lista, OSOrdemServico ordemServico, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, ordemServico, adicionarFiltro, formManut, parametros)
        {
            ConfiguraBotaoImprimir();
            ConfiguraBotaoFaturar();
            ConfiguraBotaoEmail();
            ImprimiContrato();
        }

        public GridOSOrdemServicoGen(IList<OSOrdemServico> lista, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, null, adicionarFiltro, formManut, parametros)
        {
            ConfiguraBotaoImprimir();
            ConfiguraBotaoFaturar();
            ConfigurarBotaoDuplicar();
            ConfiguraBotaoEmail();
            ImprimiContrato();
        }


        public GridOSOrdemServicoGen()
        {
            InitializeComponent();
            ConfiguraBotaoImprimir();
            ConfiguraBotaoFaturar();
            ConfiguraBotaoEmail();
            ImprimiContrato();
        }

        private void ConfigurarBotaoDuplicar()
        {
            sbFuncao12.Click += new EventHandler(btDuplicar_Click);
            sbFuncao12.Text = "Duplicar";
            sbFuncao12.Image = global::Aplicacao.Properties.Resources.Gerar_Jornada_com_folga_copy;
            sbFuncao12.Visible = true;
            sbFuncao12.Enabled = true;
            sbFuncao12.Refresh();
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

        private void ConfiguraBotaoEmail()
        {
            sbFuncao25.Click += new EventHandler(btEmail_Click);
            sbFuncao25.Text = "&E-mail";
            sbFuncao25.Image = global::Aplicacao.Properties.Resources._1371664476_14028;
            sbFuncao25.Visible = true;
            sbFuncao25.Enabled = true;
            sbFuncao25.Refresh();
        }

        private void ImprimiContrato()
        {
            sbFuncao13.Click += new EventHandler(btnImprimirContrato_Click);
            sbFuncao13.Text = "&Imprimir Contrato";
            sbFuncao13.Image = global::Aplicacao.Properties.Resources.Imprimir_Cartão_Ponto_copy;
            sbFuncao13.Visible = true;
            sbFuncao13.Enabled = true;
            sbFuncao13.Refresh();
        }

        private void btDuplicar_Click(object sender, EventArgs e)
        {
            if (GetRegistroSelecionado() != null)
            {
                Duplicar();
            }
            else
            {
                MessageBox.Show("Não existe registro Selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            if (GetRegistroSelecionado() != null)
            {
                PerguntarPorImpressao();
            }
            else
            {
                MessageBox.Show("Não existe registro Selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btFaturar_Click(object sender, EventArgs e)
        {
            var osSelecionada = GetRegistroSelecionado();

            if (osSelecionada != null)
            {
                //if (osSelecionada.Status.Valor != (int)OSOrdemServico.StatusOS.AguardandoFaturamento)
                if ((osSelecionada.Status != null) && (osSelecionada.Status.BFaturar))
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
                else
                {
                    //MessageBox.Show("Somente orçamentos com Status \'Aguardando Faturamento\'  podem ser faturados.");
                    MessageBox.Show("Somente orçamentos com Status faturar marcado, podem ser faturados.");
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado.");
            }
        }
        private void btEmail_Click(object sender, EventArgs e)
        {
            if (GetRegistroSelecionado() != null)
            {
                var selecionado = GetRegistroSelecionado();
                FormEnviaEmailOS form = new FormEnviaEmailOS(selecionado);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não existe registro Selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    case OSOrdemServico.ImprimirOS.Etiqueta:
                        try
                        {
                            FormEscolheImpressorasPRN form = new FormEscolheImpressorasPRN(GetRegistroSelecionado());
                            form.ShowDialog();
                        }
                        catch (Exception ex)
                        {
                            FormErro formErro = new FormErro("Erro ao imprimir a etiqueta", ex.Message);
                            formErro.ShowDialog();
                        }
                        break;
                    case OSOrdemServico.ImprimirOS.Recibo:
                        try
                        {
                            OSOrdemServico osSelecionada = OSOrdemServicoController.Instancia.LoadObjectById(GetRegistroSelecionado().ID);
                            var ParametrosRecibo = OSOrdemServicoController.Instancia.recibo(osSelecionada, osSelecionada.Total);

                            Aplicacao.Base.FormRelatorioBase form = 
                                new Aplicacao.Base.FormRelatorioBase(ParametrosRecibo[0].ToString(), 
                                ParametrosRecibo[1].ToString(), 
                                ParametrosRecibo[2], 
                                (List<Microsoft.Reporting.WinForms.ReportParameter>)ParametrosRecibo[3]);

                            form.Text = "Impressão Recibo";
                            form.Show();
                        }
                        catch (Exception ex)
                        {
                            FormErro formErro = new FormErro("Erro ao imprimir o cupom", ex.Message);
                            formErro.ShowDialog();
                        }
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
            if (!((OSOrdemServico)gvPrincipal.GetFocusedRow()).Status.BFechado)
            {
                Configuracao conf = ConfiguracaoController.Instancia.GetAll().FirstOrDefault();
                if (!((OSOrdemServico)gvPrincipal.GetFocusedRow()).Status.BPermissaoGerente)
                {
                    base.Alterar();
                }
                else
                {
                    Modelo.Cw_Usuario usuarioLogado = Modelo.cwkGlobal.objUsuarioLogado;
                    if ((cwkControleUsuario.Facade.getUsuarioLogado.Tipo == 2 || cwkControleUsuario.Facade.LoginGerente()))
                    {
                        base.Alterar();
                        Modelo.cwkGlobal.objUsuarioLogado = usuarioLogado;
                    }
                }
            }
            else
            {
                MessageBox.Show("Não se pode alterar um Orçamento de Serviço com o status fechado.\n\nAbrindo como consulta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                base.Consultar();
            }
        }
        private static int TamanhoTag(Match match, string key)
        {
            int tamanho = 0;
            string m = match.ToString();
            m = m.Replace(key, "");
            m = m.Replace("{", "").Replace("}", "");
            try
            {
                tamanho = Convert.ToInt32(m);
            }
            catch
            {
                tamanho = 0;
            }
            return tamanho;
        }

        private void btnImprimirContrato_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imprimir Contrato");
        }

        private void Teste_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teste");
        }

    }
}
