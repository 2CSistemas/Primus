using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Modulos.Financeiro;
using System.Linq;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Negocio.Telefonia;
using System.Collections.Generic;
using cwkGestao.Negocio;
using cwkGestao.Modelo.Proxy;
using System.Net;
using System.IO;
using System.Xml;
using Aplicacao.Util.Telas;
using cwkGestao.Integracao.Magento.Exportacao;
using cwkGestao.Integracao.Correios;
using Aplicacao.Modulos.Correios;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormExpedicaoEmbalagem : Form
    {
        private Pedido pedido;
        private Pessoa pessoaTransportadora;
        private TipoServicoTransporte tipoServico;
        private IList<TipoServicoTransporte> ListaTipoServico;
        private CorreiosPrecoPrazoTotalHolder Holder;
        private IList<CorreiosPrecoPrazo> ListaExclusoes = new List<CorreiosPrecoPrazo>();
        private IList<CorreiosPrecoPrazo> ListaCPP = new List<CorreiosPrecoPrazo>();
        private IList<RastreamentoCorreio> rastreamentos { get; set; }

        public FormExpedicaoEmbalagem(Pedido p)
        {
            pedido = p;

            ListaTipoServico = TipoServicoTransporteController.Instancia.GetAll();
            if (ListaTipoServico.Count > 0)
            {
                ListaTipoServico = ListaTipoServico.Where(w => w.IDServicoEnvioCorreio != null).ToList();
            }
            InitializeComponent();

            lkpPessoaTransportadora.Exemplo = new Pessoa();
            lkpPessoaTransportadora.Sessao = cwkGestao.Negocio.PessoaController.Instancia.getSession();

            lkpTipoServico.Properties.DataSource = ListaTipoServico;

            ListaCPP = CorreiosPrecoPrazoController.Instancia.GetPorIdPedido(pedido.ID);
            if (ListaCPP.Count > 0)
            {
                ListaCPP = ListaCPP.Where(w => w.bSelecionado == true).ToList();
            }
            if (ListaCPP.Count > 0)
	        {
	            tipoServico = ListaCPP.FirstOrDefault().TipoServicoTransporte;
                rastreamentos = RastreamentoCorreioController.Instancia.GetCodigosDisponiveisPorTipoServico(tipoServico);
                if (rastreamentos.Count > 0 && rastreamentos.Count >= ListaCPP.Count && ListaCPP.FirstOrDefault().IDRastreamento == null)
                {
                    for (int i = 0; i < ListaCPP.Count; i++)
                    {
                        ListaCPP[i].IDRastreamento = rastreamentos[i];
                    }
                }

                Holder = new CorreiosPrecoPrazoTotalHolder(ListaCPP);
            }
            else
            {
                Holder = new CorreiosPrecoPrazoTotalHolder();
            }
            gcCorreiosPrecoPrazo.DataSource = Holder.RequisicoesCorreios;

        }

        private void FormExpedicaoEmbalagem_Shown(object sender, EventArgs e)
        {
            txtPedido.EditValue = pedido.Codigo;
            if (pedido.PessoaTransportadora != null)
            {
                SetaCamposTransportadora(pedido.PessoaTransportadora);
            }
            if (Holder.RequisicoesCorreios.Count > 0)
            {
                lkpTipoServico.EditValue = Holder.RequisicoesCorreios.FirstOrDefault().TipoServicoTransporte;
            }
            gcCorreiosPrecoPrazo.RefreshDataSource();

            if (Holder.RequisicoesCorreios.Count > 0)
            {
                if (Holder.RequisicoesCorreios.FirstOrDefault().IDRastreamento == null)
                {
                    MessageBox.Show("Não existem códigos de rastreamento suficientes para o tipo de serviço "+ tipoServico.ToString() +".",
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (pedido.Status == StatusOrcamento.Faturado)
            {
                MessageBox.Show("Este pedido já foi faturado. Exibição somente para consulta.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lkpPessoaTransportadora.Properties.ReadOnly = true;
                lkbPessoaTransportadora.Enabled = false;
                sbExcluiOrcamentos.Enabled = false;
                sbVolumes.Enabled = false;
                lkpTipoServico.Enabled = false;
                cbTipoFrete.Enabled = false;
                txtTransPlaca.Properties.ReadOnly = true;
                txtTransPlacaUf.Properties.ReadOnly = true;
                sbGravar.Enabled = false;
            }
        }

        private void sbGerar_Click(object sender, EventArgs e)
        {
            #region lógica velha
            if (!CamposValidos())
            {
                MessageBox.Show("Todos os campos devem ser preenchidos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!VerificaPresencaCodsRastreamento(Holder.RequisicoesCorreios))
            {
                MessageBox.Show("Não existem códigos de rastreamento solicitados para todos os volumes." + 
                    " Solicite a quantidade necessária de códigos de rastreamento do serviço " + tipoServico.ToString() + 
                    " antes de concluir esta operação.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Configuracao config = ConfiguracaoController.Instancia.GetAll().FirstOrDefault();
            pedido.PessoaTransportadora = pessoaTransportadora;
            pedido.TransCidade = txtTransCidade.Text;
            pedido.TransUF = txtTransUF.Text;
            pedido.TransCNPJCPF = txtTransCnpj.Text;
            pedido.TransEndereco = txtTransEndereco.Text;
            pedido.TransNome = pessoaTransportadora.Nome;
            pedido.TransPlaca = txtTransPlaca.Text;
            pedido.TransPlacaUF = txtTransPlacaUf.Text;
            pedido.TipoFrete = (TipoFrete)cbTipoFrete.SelectedIndex;
            IList<ExpedicaoRastreamento> ListaRastreamentos = new List<ExpedicaoRastreamento>();
            try
            {
                foreach (CorreiosPrecoPrazo item in ListaExclusoes)
                {
                    CorreiosPrecoPrazoController.Instancia.Salvar(item, Acao.Excluir);
                }
                if (Holder.RequisicoesCorreios.Count == 0)
                {
                    MessageBox.Show("Não existem volumes para expedir. Verifique.",
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                ExcluiOrcamentosCorreiosSelecionados(Holder.RequisicoesCorreios);
                foreach (CorreiosPrecoPrazo item in Holder.RequisicoesCorreios)
                {
                    item.bSelecionado = true;
                    if (item.ID != 0)
                    {
                        CorreiosPrecoPrazoController.Instancia.Salvar(item, Acao.Alterar);
                    }
                    else
                    {
                        CorreiosPrecoPrazoController.Instancia.Salvar(item, Acao.Incluir);
                    }
                    ListaRastreamentos = SetaExpedicaoRastreamento();
                }

                pedido.bRealizouRotinaCorreios = true;
                pedido.CorreiosPrecoPrazo = Holder.RequisicoesCorreios;
                pedido.CalculaTotalPedido(config.NaoSomarFrete, config.NaoSomarIpiTotalNota);
                PedidoController.Instancia.Salvar(pedido, Acao.Alterar);

                string codigoPedidoMagento;

                if (config.ExportarCodigoDeRastreamento)
                {
                    if (pedido.CodigoPedidoMagento == 0)
                    {
                        if (new Aplicacao.InputBox().Show("", "Código Pedido Magento", out codigoPedidoMagento))
                        {
                            pedido.CodigoPedidoMagento = Convert.ToInt32(codigoPedidoMagento);
                            PedidoController.Instancia.Salvar(pedido, Acao.Alterar);
                        }
                    }

                    foreach (var item in ListaRastreamentos)
                    {
                        MegaExportador.ExportarUnicoObjeto(item);
                    }
                }

                this.Close();
                this.Dispose();
            }
            catch (Exception ex)
            {
                FormErro.ShowDialog(ex);
            }
            #endregion
        }

        #region métodos prontos

        private bool CamposValidos()
        {
            dxErrorProvider.ClearErrors();

            if (lkpTipoServico.EditValue == null)
            {
                dxErrorProvider.SetError(lkpTipoServico, "Campo Obrigatório");
            }
            if (lkpPessoaTransportadora.Selecionado == null)
            {
                dxErrorProvider.SetError(lkpPessoaTransportadora, "Campo Obrigatório");
            }
            if (txtTransPlaca.Text == "")
            {
                dxErrorProvider.SetError(txtTransPlaca, "Campo Obrigatório");
            }
            if (txtTransPlacaUf.Text == "")
            {
                dxErrorProvider.SetError(txtTransPlacaUf, "Campo Obrigatório");
            }
            return !dxErrorProvider.HasErrors;
        }

        private void FormExpedicaoEmbalagem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
                Dispose();
            }
        }

        private void lkpPessoaTransportadora_Leave(object sender, EventArgs e)
        {
            if (pedido.Status == StatusOrcamento.Faturado)
            {
                return;
            }
            if (lkpPessoaTransportadora.Selecionado != null)
            {
                SetaCamposTransportadora((Pessoa)lkpPessoaTransportadora.Selecionado);
            }
            this.Refresh();
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void sbAjuda_Click(object sender, EventArgs e)
        {
            this.ChamarHelp();
        }

        private void lkbPessoaTransportadora_Click(object sender, EventArgs e)
        {
            IList<Pessoa> pessoas = PessoaController.Instancia.GetAllTransportadoras();
            GridCliente grid = new GridCliente(pessoas, new FormPessoa(), pessoaTransportadora, "Transportadora", false);

            grid.Selecionando = true;
            grid.ShowDialog();

            if (grid.Selecionado != null && grid.Selecionado.ID > 0)
            {
                lkpPessoaTransportadora.Localizar(grid.Selecionado.ID);
                pessoaTransportadora = PessoaController.Instancia.LoadObjectById(grid.Selecionado.ID);
                SetaCamposTransportadora(pessoaTransportadora);
            }
            this.Refresh();
        }

        private void sbVolumes_Click(object sender, EventArgs e)
        {
            RotinaVolumes();
        }

        private void lkpTipoServico_Leave(object sender, EventArgs e)
        {
            if (pedido.Status == StatusOrcamento.Faturado)
            {
                return;
            }
            TipoServicoTransporte svcBackup = null;
            if (tipoServico != null)
            {
                svcBackup = (TipoServicoTransporte)tipoServico.Clone();
            }
            if (lkpTipoServico.EditValue == null)
            {
                if (tipoServico == null)
                {
                    return;
                }
                lkpTipoServico.EditValue = tipoServico;
            }
            if (tipoServico != null)
            {
                if (((TipoServicoTransporte)lkpTipoServico.EditValue).ID == tipoServico.ID)
                {
                    return;
                }
            }

            tipoServico = (TipoServicoTransporte)((TipoServicoTransporte)lkpTipoServico.EditValue).Clone();
            if (Holder.RequisicoesCorreios.Count == 0)
            {
                return;
            }
            IList<RastreamentoCorreio> rastreamento = RastreamentoCorreioController.Instancia.GetCodigosDisponiveisPorTipoServico(tipoServico);
            if (rastreamento.Count < Holder.RequisicoesCorreios.Count)
            {
                MessageBox.Show("Não há códigos de rastreamento do serviço " + tipoServico.IDServicoEnvioCorreio.ToString() +
                    " suficientes para os volumes informados." + "\r\n\r\n" + "Códigos sem rastreamento restantes: " + Holder.RequisicoesCorreios.Count.ToString() +
                    "\r\n" + "Códigos restantes: " + rastreamento.Count.ToString(), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lkpTipoServico.EditValue = (TipoServicoTransporte)svcBackup.Clone();
                tipoServico = (TipoServicoTransporte)svcBackup.Clone();
                return;
            }
            if (MessageBox.Show("O Tipo de Serviço de Correios foi alterado. Deseja calcular novamente os preços e prazos para este(s) volumes?",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CorreiosPrecoPrazoTotalHolder clone = (CorreiosPrecoPrazoTotalHolder)Holder.Clone();
                try
                {
                    clone = clone.CalculaPrecosPrazosIndividual((TipoServicoTransporte)lkpTipoServico.EditValue);
                    clone.SetTotais();
                    Holder = (CorreiosPrecoPrazoTotalHolder)clone.Clone();
                    if (Holder.PrecoTotal != pedido.ValorFrete)
                    {
                        if (MessageBox.Show("O valor total do frete foi alterado. Deseja alterar este valor no pedido?" +
                            "\r\n\r\n" + "Frete anterior: R$" + pedido.ValorFrete.ToString() + "\r\n\r\n" + "Frete atual: R$" + 
                            Holder.PrecoTotal.ToString(),
                            "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            pedido.ValorFrete = Holder.PrecoTotal;
                        }

                    }
                }
                catch (Exception b)
                {

                    new Aplicacao.Base.FormErro(b).ShowDialog();
                }
            }
            try
            {
                CorreiosPrecoPrazoTotalHolder clone = (CorreiosPrecoPrazoTotalHolder)Holder.Clone();
                clone = CorreiosPrecoPrazoTotalHolder.SetCodigosRastreamento(Holder, tipoServico);
                Holder = (CorreiosPrecoPrazoTotalHolder)clone.Clone();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (svcBackup != null)
                {
                    rastreamentos = RastreamentoCorreioController.Instancia.GetCodigosDisponiveisPorTipoServico(svcBackup);
                    if (rastreamentos.Count >= Holder.RequisicoesCorreios.Count)
                    {
                        Holder = CorreiosPrecoPrazoTotalHolder.SetCodigosRastreamento(Holder, svcBackup);
                        lkpTipoServico.EditValue = (TipoServicoTransporte)svcBackup.Clone();
                        tipoServico = (TipoServicoTransporte)svcBackup.Clone();
                    }
                }
            }
            gcCorreiosPrecoPrazo.DataSource = Holder.RequisicoesCorreios;
            gcCorreiosPrecoPrazo.RefreshDataSource();
        }

        private void SetaCamposTransportadora(Pessoa p)
        {
            lkpPessoaTransportadora.EditValue = p;
            txtTransCnpj.EditValue = p.CNPJ_CPF;
            txtTransEndereco.EditValue = p.EnderecoPrincipal().Endereco;
            txtTransCidade.EditValue = p.Cidade;
            txtTransUF.EditValue = p.Estado;
            txtTransPlaca.EditValue = p.Placa == null ? pedido.TransPlaca : p.Placa;
            txtTransPlacaUf.EditValue = p.PlacaUF == null ? pedido.TransPlacaUF : p.PlacaUF;
            pessoaTransportadora = p;
        }

        private void sbExcluiOrcamentos_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir permanentemente todos os orçamentos de Correio relacionados à este pedido?",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ExcluiOrcamentosCorreios();
            }

        }

        private bool VerificaPresencaCodsRastreamento(IList<CorreiosPrecoPrazo> lista)
        {
            bool presente = true;

            foreach (CorreiosPrecoPrazo item in lista)
            {
                if (item.IDRastreamento == null)
                {
                    presente = false;
                }
            }

            return presente;
        }

        private void gvCorreiosPrecoPrazo_DoubleClick(object sender, EventArgs e)
        {
            RotinaVolumes();
        }

        private void RotinaVolumes()
        {
            if (pedido.Status == StatusOrcamento.Faturado)
            {
                return;
            }
            if (lkpTipoServico.EditValue == null)
            {
                MessageBox.Show("Selecione um tipo de serviço antes de prosseguir com a operação.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            FormCorreiosPrecoPrazo form = new FormCorreiosPrecoPrazo(Holder.RequisicoesCorreios.Count > 0 ? Holder.RequisicoesCorreios : null);
            form.ShowDialog();
            if (form.Result == DialogResult.Cancel || form.ListaVolumesServicosCorreios.Count == 0)
            {
                return;
            }
            CorreiosPrecoPrazoTotalHolder clone = new CorreiosPrecoPrazoTotalHolder();
            foreach (CorreiosPrecoPrazo item in form.ListaVolumesServicosCorreios)
            {
                item.IDPedido = pedido;
                item.CepOrigem = pedido.Filial.CEP.Replace("-", "").Replace(".", "");
                item.CepDestino = pedido.Pessoa.EnderecoPrincipal().CEP == null ? "" :
                    pedido.Pessoa.EnderecoPrincipal().CEP.Replace("-", "").Replace(".", "");
                item.TipoServicoTransporte = (TipoServicoTransporte)lkpTipoServico.EditValue;
                clone.RequisicoesCorreios.Add(item);
            }
            if (form.ListaVolumesExcluidos != null)
            {
                foreach (CorreiosPrecoPrazo item in form.ListaVolumesExcluidos)
                {
                    ListaExclusoes.Add(item);
                }
            }
            if (MessageBox.Show("Deseja calcular os preços e prazos para os volumes informados?",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    CorreiosPrecoPrazoTotalHolder clone2 = ((CorreiosPrecoPrazoTotalHolder)clone.Clone()).
                        CalculaPrecosPrazosIndividual((TipoServicoTransporte)lkpTipoServico.EditValue);
                    Holder = clone2;
                    Holder.SetTotais();
                    if (Holder.PrecoTotal != pedido.ValorFrete)
                    {
                        if (MessageBox.Show("O valor total do frete foi alterado. Deseja alterar este valor no pedido?" +
                            "\r\n\r\n" + "Frete anterior: R$" + pedido.ValorFrete.ToString() + "\r\n\r\n" + "Frete atual: R$" +
                            Holder.PrecoTotal.ToString(),
                            "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            pedido.ValorFrete = Holder.PrecoTotal;
                        }

                    }
                }
                catch (Exception q)
                {
                    new Aplicacao.Base.FormErro("Ocorreram erros na comunicação com o Webservice dos Correios \n\n Tente novamente mais tarde",
                        q.Message + "\r\n\r\n" + q.StackTrace).ShowDialog();
                    Holder = clone;
                }

            }
            else
            {
                Holder = clone;
            }
            if (MessageBox.Show("Deseja atribuir códigos de rastreamento para os volumes informados",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    CorreiosPrecoPrazoTotalHolder clone3 = (CorreiosPrecoPrazoTotalHolder)Holder.Clone();
                    clone3 = CorreiosPrecoPrazoTotalHolder.SetCodigosRastreamento(Holder, tipoServico);
                    Holder = (CorreiosPrecoPrazoTotalHolder)clone3.Clone();
                }
                catch (Exception c)
                {
                    MessageBox.Show(c.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    rastreamentos = RastreamentoCorreioController.Instancia.GetCodigosDisponiveisPorTipoServico(tipoServico);
                    if (rastreamentos.Count >= Holder.RequisicoesCorreios.Count)
                    {
                        Holder = CorreiosPrecoPrazoTotalHolder.SetCodigosRastreamento(Holder, (TipoServicoTransporte)lkpTipoServico.EditValue);
                    }
                    else
                    {
                        Holder = clone;
                    }
                }
            }
            gcCorreiosPrecoPrazo.DataSource = Holder.RequisicoesCorreios;
            gcCorreiosPrecoPrazo.RefreshDataSource();
        }

        private void ExcluiOrcamentosCorreios()
        {
            IList<CorreiosPrecoPrazo> Exclusoes = CorreiosPrecoPrazoController.Instancia.GetPorIdPedido(pedido.ID);
            if (Exclusoes.Count > 0)
            {
                foreach (CorreiosPrecoPrazo item in Exclusoes)
                {
                    if (item.IDRastreamento != null)
                    {
                        ExpedicaoRastreamento er = ExpedicaoRastreamentoController.Instancia.GetExpedicaoRastreamentoPorRastreamento(item.IDRastreamento.ID);
                        if (er != null)
                        {
                            ExpedicaoRastreamentoController.Instancia.Salvar(er, Acao.Excluir);
                        }
                    }
                    CorreiosPrecoPrazoController.Instancia.Salvar(item, Acao.Excluir);
                }
            }
            this.Close();
            this.Dispose();
        }

        private void ExcluiOrcamentosCorreiosSelecionados(IList<CorreiosPrecoPrazo> listaAtual)
        {
            IList<CorreiosPrecoPrazo> Exclusoes = CorreiosPrecoPrazoController.Instancia.GetPorIdPedido(pedido.ID);
            IList<int> selecionados = new List<int>();

            foreach (CorreiosPrecoPrazo item in listaAtual)
            {
                if (item.ID != 0)
                {
                    selecionados.Add(item.ID);
                }
            }
            Exclusoes = Exclusoes.Where(w => !selecionados.Contains(w.ID) ).ToList();
            if (Exclusoes.Count > 0)
            {
                foreach (CorreiosPrecoPrazo item in Exclusoes)
                {
                    CorreiosPrecoPrazoController.Instancia.Salvar(item, Acao.Excluir);
                }
            }
        }

        private IList<ExpedicaoRastreamento> SetaExpedicaoRastreamento()
        {
            IList<ExpedicaoRastreamento> ListaRastreamentos = new List<ExpedicaoRastreamento>();
            var listaExclusao = ExpedicaoRastreamentoController.Instancia.GetExpedicaoRastreamentoPorPedido(pedido.ID);
            IList<ExpedicaoRastreamento> listaIguais = new List<ExpedicaoRastreamento>();

            foreach (var obj in listaExclusao)
            {
                ExpedicaoRastreamentoController.Instancia.Salvar(obj, Acao.Excluir);
            }

            foreach (CorreiosPrecoPrazo item in Holder.RequisicoesCorreios)
            {
                ExpedicaoRastreamento exp = new ExpedicaoRastreamento();
                exp.Pedido = item.IDPedido;
                exp.IDRastreamento = item.IDRastreamento;
                exp.ServicoEnvioCorreio = item.TipoServicoTransporte.IDServicoEnvioCorreio;
                exp.PesoBruto = item.NVlPeso;
                exp.PesoLiquido = item.NVlPeso;
                exp.bRastroCompleto = false;

                ExpedicaoRastreamentoController.Instancia.Salvar(exp, Acao.Incluir);

                ListaRastreamentos.Add(exp);
            }
            return ListaRastreamentos;
        }
        #endregion

        private void sbImprimirEtiqueta_Click(object sender, EventArgs e)
        {
            try
            {
                var tela = new FormImprimeEtiquetaCorreios(pedido.ID);
                tela.ShowDialog();
            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
            
        }

    }
}