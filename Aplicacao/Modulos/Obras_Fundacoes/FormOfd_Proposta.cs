using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using DevExpress.XtraEditors;
using Aplicacao.Util;
using Aplicacao.Base;

namespace Aplicacao
{
    public partial class FormOfd_Proposta : Aplicacao.IntermediariasTela.FormManutOfd_PropostaIntermediaria
    {
        private int IDOrcamento { get; set; }
        public FormOfd_Proposta()
        {
            Selecionado.CidadeClienteOrcamento = new Cidade();
            Selecionado.CidadeObraOrcamento = new Cidade();
            if (Ofd_PropostaController.Instancia.GetAll().Count <= 0)
                IDOrcamento = 1;
            else
                IDOrcamento = Ofd_PropostaController.Instancia.GetUltimoID_Ofd_Proposta() + 1; 
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            
            ConfgurarLookups();
            ConfigurarGridArquivos();
            ConfigurarGridRevisoes();
            SetarTags();
        }



        protected override void btSubRegistro_Click(object sender, EventArgs e)
        {
            int valorTipoSelecionado = (int)rgTipo.EditValue;
            switch (valorTipoSelecionado)
            {
                case 0:
                    TelaProObjeto(tpProposta);
                    base.btSubRegistro_Click(sender, e);
                    break;
                case 1:
                    TelaProObjeto(tpOrcamento);
                    break;
            }
            
        }

        protected override void OnShown(EventArgs e)
        {
            ConfigurarRadioGroupOperacao();
           
            base.OnShown(e);
            SetarTags();
            if (Selecionado.Obra != null)
                txtObraStr.Text = Selecionado.Obra.ToString();
            rgTipo.EditValue = Selecionado.TipoLancamento;
            rtxtObservacaoObraOrcamento.Text = Selecionado.ObservacaoObraOrcamento;
            rtxtObservacaoOrcamento.Text = Selecionado.ObservacaoOrcamento;
            txtACOrcamento.EditValue = Selecionado.ACContatoOrcamento;
            txtAOrcamento.EditValue = Selecionado.AContatoOrcamento;
            if (Selecionado.IDCidadeClienteOrcamento != 0)
            {
                lkpCidadeClienteOrcamento.Localizar((int)Selecionado.IDCidadeClienteOrcamento);
            }
            if (Selecionado.IDCidadeObraOrcamento != 0)
            {
                lkpCidadeObraOrcamento.Localizar((int)Selecionado.IDCidadeObraOrcamento);
            }

            SelecionarAbaCorreta();
            
        }

        private void ConfigurarRadioGroupOperacao()
        {
            if (Operacao != Acao.Incluir)
                rgTipo.Enabled = false;
            else
                rgTipo.Enabled = true;
        }

        private void SetarTags()
        {
            tpArquivos.Tag = Selecionado;
            tpRevisoes.Tag = Selecionado;
            tpProposta.Tag = Selecionado;
            tpOrcamento.Tag = Selecionado;
            tpObra.Tag = Selecionado;
            tpContato.Tag = Selecionado;
            tpServicos.Tag = Selecionado;
        }

        private void ConfgurarLookups()
        {
            lkpCliente.Exemplo = new Pessoa { BCliente = true };
            lkpCliente.CamposRestricoesAND = new List<string> { "BCliente" };
            lkpClienteFaturamento.Exemplo = new Pessoa { BCliente = true };
            lkpClienteFaturamento.CamposRestricoesAND = new List<string> { "BCliente" };
            lkpServico.Exemplo = new Servico();
            lkpCidadeClienteOrcamento.Exemplo = new Cidade();
            lkpCidadeObraOrcamento.Exemplo = new Cidade();
        }

        private void ConfigurarGridArquivos()
        {
            Type formType = typeof(FormOfd_PropostaArquivos);
            object[] parms = new[] { new Ofd_PropostaArquivos() { Proposta = Selecionado } };

            btIncluirArquivo.SubFormType = btAlterarArquivo.SubFormType = btExcluirArquivo.SubFormType = btConsultarArquivo.SubFormType = formType;
            btIncluirArquivo.SubFormTypeParams = btAlterarArquivo.SubFormTypeParams = btExcluirArquivo.SubFormTypeParams = btConsultarArquivo.SubFormTypeParams = parms;

            //FormOfd_PropostaArquivos formArquivo = new FormOfd_PropostaArquivos() { Selecionado = new Ofd_PropostaArquivos() { Proposta = Selecionado } };
            //btIncluirArquivo.SubForm = formArquivo;
            //btAlterarArquivo.SubForm = formArquivo;
            //btExcluirArquivo.SubForm = formArquivo;
            //btConsultarArquivo.SubForm = formArquivo;
        }

        private void ConfigurarGridRevisoes()
        {
            object[] parms = new[] { new FormOfd_PropostaRevisaoPerfuracoes() { Selecionado = new Ofd_PropostaRevisaoPerfuracoes() { Ofd_Proposta = Selecionado } } };
            Type formType = typeof(FormOfd_PropostaRevisaoPerfuracoes);

            btIncluirRevisao.SubFormType = btAlterarRevisao.SubFormType = btExcluirRevisao.SubFormType = btConsultarRevisao.SubFormType = formType;
            btIncluirRevisao.SubFormTypeParams = btAlterarRevisao.SubFormTypeParams = btExcluirRevisao.SubFormTypeParams = btConsultarRevisao.SubFormTypeParams = parms;

            //FormOfd_PropostaRevisaoPerfuracoes form = new FormOfd_PropostaRevisaoPerfuracoes() { Selecionado = new Ofd_PropostaRevisaoPerfuracoes() { Ofd_Proposta = Selecionado } };
            //btIncluirRevisao.SubForm = form;
            //btAlterarRevisao.SubForm = form;
            //btExcluirRevisao.SubForm = form;
            //btConsultarRevisao.SubForm = form;
        }

        private void BuscarPessoa(Cwork.Utilitarios.Componentes.Lookup lkp)
        {
            var pessoas = PessoaController.Instancia.GetAllClientes();
            var grid = new GridCliente(pessoas, new FormPessoa(), (Pessoa)lkp.Selecionado, "Cliente", false);
            grid.Selecionando = true;
            grid.ShowDialog();
            if (grid.Selecionado != null)
                lkp.Localizar(grid.Selecionado.ID);
            lkp.Focus();
        }

        private void sbAbrirArquivo_Click(object sender, EventArgs e)
        {
            object arquivo = gvArquivos.GetRegistroSelecionado();
            if (arquivo != null)
                Ofd_PropostaArquivosController.Instancia.AbrirArquivo(((Ofd_PropostaArquivos)arquivo).CaminhoArquivo);
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.SelectedIndex == (int)StatusPropostaObraFundacao.Aprovada)
            {
                if (Selecionado.Status == StatusPropostaObraFundacao.Aprovada)
                    txtObraStr.Text = Selecionado.Obra.ToString();
                else
                {
                    cbStatus.SelectedIndex = (int)Selecionado.Status;
                    MessageBox.Show("A aprovação de uma proposta deve ser feita por meio da opção \"Aprovar\" na tabela de propostas.");
                }
            }
            else if (cbStatus.SelectedIndex < (int)StatusPropostaObraFundacao.Aprovada)
                txtObraStr.Text = String.Empty;
        }

        protected override void AcoesAntesSalvar()
        {
            if (Selecionado.Status < StatusPropostaObraFundacao.Aprovada)
                Selecionado.Obra = null;
        }

        private void rgTipo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SelecionarAbaCorreta();
        }

        private void SelecionarAbaCorreta()
        {
            int valorTipoSelecionado = (int)rgTipo.EditValue;
            switch (valorTipoSelecionado)
            {
                case 0:
                    xtraTabControl.SelectedTabPage = tpProposta;
                    ObjetoPraTela(tpProposta);
                    ZerarValuesControles(tpOrcamento);
                    ZerarValuesControles(tpObra, rtxtObservacaoObraOrcamento);
                    ZerarValuesControles(tpContato, rtxtObservacaoOrcamento);
                    gcServicos.DataSource = new List<Servico>();
                    break;
                case 1:
                    xtraTabControl.SelectedTabPage = tpOrcamento;
                    ObjetoPraTela(tpOrcamento);
                    if (Selecionado.CodigoOrcamento == 0)
                    {
                        txtCodigoOrcamento.EditValue = IDOrcamento.ToString();
                    }
                    else
                    {
                        txtCodigoOrcamento.EditValue = Selecionado.CodigoOrcamento;
                    }
                    
                    gcServicos.DataSource = ServicoController.Instancia.GetServicosPorIDOfd_Proposta(Selecionado.ID);
                    ZerarValuesControles(tpProposta);
                    break;
            }
        }

        private void ZerarValuesControles(DevExpress.XtraTab.XtraTabPage tabNaoSelecionada, RichTextBox txtObservacao)
        {
            tabNaoSelecionada.LimparControles();
            txtObservacao.Text = "";
        }

        private void ZerarValuesControles(DevExpress.XtraTab.XtraTabPage tabNaoSelecionada)
        {
            tabNaoSelecionada.LimparControles();
        }

        private void lkbCidadeClienteOrcamento_Click(object sender, EventArgs e)
        {
            var cidades = CidadeController.Instancia.GetAll();
            GridGenerica<Cidade> grid = new GridGenerica<Cidade>(cidades, new FormCidade(), false);
            grid.Selecionando = true;
            grid.ShowDialog();
            if (grid.Selecionado != null)
            {
                lkpCidadeClienteOrcamento.Localizar(grid.Selecionado.ID);
                Selecionado.CidadeClienteOrcamento = grid.Selecionado;
            }
            lkpCidadeClienteOrcamento.Focus();
            
        }

        private void lkbCidadeObraOrcamento_Click(object sender, EventArgs e)
        {
            var cidades = CidadeController.Instancia.GetAll();
            GridGenerica<Cidade> grid = new GridGenerica<Cidade>(cidades, new FormCidade(), false);
            grid.Selecionando = true;
            grid.ShowDialog();
            if (grid.Selecionado != null)
            {
                lkpCidadeObraOrcamento.Localizar(grid.Selecionado.ID);
                Selecionado.CidadeObraOrcamento = grid.Selecionado;
            }
            lkpCidadeObraOrcamento.Focus();
            
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            int valorTipoSelecionado = (int)rgTipo.EditValue;           
            switch (valorTipoSelecionado)
            {
                case 0:
                    LimparObjeto(Selecionado, valorTipoSelecionado);
                    SalvarProposta();                  
                    break;
                case 1:
                    LimparObjeto(Selecionado, valorTipoSelecionado);
                    SalvarOrcamento();
                    break;
            }                 
        }

        private void LimparObjeto(Ofd_Proposta Selecionado, int valorTipoSelecionado)
        {
            switch (valorTipoSelecionado)
            {
                case 0:
                    Selecionado.ACContatoOrcamento = null;
                    Selecionado.AContatoOrcamento = null;
                    Selecionado.CodigoOrcamento = 0;
                    Selecionado.EmailClienteOrcamento = null;
                    Selecionado.EmailContatoOrcamento = null;
                    Selecionado.EnderecoObraOrcamento = null;
                    Selecionado.CidadeClienteOrcamento = null;
                    Selecionado.CidadeObraOrcamento = null;
                    Selecionado.NomeClienteOrcamento = null;
                    Selecionado.NomeConstrutoraOrcamento = null;
                    Selecionado.NomeObraOrcamento = null;
                    Selecionado.ObservacaoObraOrcamento = null;
                    Selecionado.ObservacaoOrcamento = null;
                    Selecionado.StatusOrcamento = StatusOrcamentoObraFundacao.EmBranco;
                    Selecionado.TelefoneClienteOrcamento = null;
                    Selecionado.TelefoneConstrutoraOrcamento = null;
                    Selecionado.TelefoneContatoOrcamento = null;
                    break;
                case 1:
                    Selecionado.Codigo = 0;
                    Selecionado.NumeroProposta = null;
                    Selecionado.Status = StatusPropostaObraFundacao.EmBranco;
                    Selecionado.Cliente = null;
                    Selecionado.ClienteFaturamento = null;
                    Selecionado.NomeObra = null;
                    Selecionado.TipoPreco = TipoPrecoObraFundacao.EmBranco;
                    Selecionado.ValorTaxaMobilizacao = 0;
                    Selecionado.ValorHoraMaquinaParada = 0;
                    Selecionado.Servico = null;
                    Selecionado.Obra = null;
                    Selecionado.PrevisaoProjeto = 0;
                    Selecionado.QuantidadeTotal = 0;
                    Selecionado.Arquivos = null;
                    Selecionado.Revisoes = null;
                    Selecionado.Medicoes = null;
                    Selecionado.Ofd_Servicos = null;
                    break;
            }      
        }

        private void SalvarOrcamento()
        {
            Ofd_PropostaOrcamentoServicos item;
            try
            {
                if (Operacao == Acao.Excluir)
                {
                    IList<Ofd_PropostaOrcamentoServicos> listaServicos = Ofd_PropostaOrcamentoServicosController.Instancia.GetOfdServicosPorIDOfd_Proposta(Selecionado.ID);
                    ExcluirOfdOrcamentoServicos(listaServicos);
                    Ofd_PropostaController.Instancia.Salvar(Selecionado, Operacao);
                    this.Close();
                }
                else
                {
                    int tipoLancamento = (int)rgTipo.EditValue;
                    if (ValidaFormulario(tipoLancamento))
                    {
                        TelaProObjeto(tpOrcamento);
                        if (Operacao < Acao.Consultar)
                        {
                            Selecionado.TipoLancamento = 1;
                            Selecionado.Ofd_Servicos = new List<Ofd_PropostaOrcamentoServicos>();
                            Selecionado.ObservacaoObraOrcamento = rtxtObservacaoObraOrcamento.Text;
                            Selecionado.ObservacaoOrcamento = rtxtObservacaoOrcamento.Text;
                            if (txtACOrcamento.EditValue != null)
                                Selecionado.ACContatoOrcamento = txtACOrcamento.EditValue.ToString();
                            else
                                Selecionado.ACContatoOrcamento = "";
                            if (txtAOrcamento.EditValue != null)
                                Selecionado.AContatoOrcamento = txtAOrcamento.EditValue.ToString();
                            else
                                Selecionado.AContatoOrcamento = "";
                            Selecionado.CidadeClienteOrcamento = (Cidade)lkpCidadeClienteOrcamento.Selecionado;
                            Selecionado.CidadeObraOrcamento = (Cidade)lkpCidadeObraOrcamento.Selecionado;
                            if (Selecionado.CidadeClienteOrcamento != null)
                                Selecionado.IDCidadeClienteOrcamento = Selecionado.CidadeClienteOrcamento.ID;
                            else
                                Selecionado.IDCidadeClienteOrcamento = 0;
                            if (Selecionado.CidadeObraOrcamento != null)
                                Selecionado.IDCidadeObraOrcamento = Selecionado.CidadeObraOrcamento.ID;
                            else
                                Selecionado.IDCidadeObraOrcamento = 0;
                          
                            Ofd_PropostaController.Instancia.Salvar(Selecionado, Operacao);

                            IList<Ofd_PropostaOrcamentoServicos> listaServicos = Ofd_PropostaOrcamentoServicosController.Instancia.GetOfdServicosPorIDOfd_Proposta(Selecionado.ID);
                            foreach (Ofd_PropostaOrcamentoServicos ofdServico in listaServicos)
                            {
                                Ofd_PropostaOrcamentoServicosController.Instancia.Salvar(ofdServico, Acao.Excluir);
                            }
                            foreach (Servico servico in (List<Servico>)gcServicos.DataSource)
                            {
                                item = new Ofd_PropostaOrcamentoServicos() { Ofd_Proposta = Selecionado, Servico = servico };
                                Selecionado.Ofd_Servicos.Add(item); 
                                Ofd_PropostaOrcamentoServicosController.Instancia.Salvar(item, Acao.Incluir);
                            }
                            Ofd_PropostaController.Instancia.Salvar(Selecionado, Acao.Alterar);
                            this.Close();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Não é possível alterar o movimento"))
                    MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    new FormErro(ex).ShowDialog();
            }
        }

        private void ExcluirOfdOrcamentoServicos(IList<Ofd_PropostaOrcamentoServicos> listaServicos)
        {
            foreach (Ofd_PropostaOrcamentoServicos ofdServico in listaServicos)
            {
                Ofd_PropostaOrcamentoServicosController.Instancia.Salvar(ofdServico, Acao.Excluir);
            }
        }

        private void SalvarProposta()
        {
            try
            {
                int tipoLancamento = (int)rgTipo.EditValue;
                if (ValidaFormulario(tipoLancamento))
                {
                    TelaProObjeto(tpProposta);
                    if (Operacao < Acao.Consultar)
                    {
                        if (Operacao < Acao.Consultar)
                        {
                            Selecionado.TipoLancamento = 0;
                            Ofd_PropostaController.Instancia.Salvar(Selecionado, Operacao);
                        }
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("constraint \"FK_Ofd_PropostaMedicao_Ofd_Proposta\""))
                    MessageBox.Show("Não é possivel excluir esta Proposta pois já existem revisões relacionadas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (ex.Message.Contains("Não é possível alterar o movimento"))
                        MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        new FormErro(ex).ShowDialog();
                }
            }
        }

        private bool ValidaFormulario(int tipo)
        {
            if (tipo == 0)
            {
                return ValidaFormularioProposta();
            }
            else
            {
                return ValidaFormularioOrcamento();
            } 
        }

        private bool ValidaFormularioProposta()
        {
            dxErroProvider.ClearErrors();
            if ((int)txtCodigo.EditValue <= 0)
            {
                dxErroProvider.SetError(txtCodigo, "Campo não pode ser menor ou igual a zero");
            }
            if (lkpCliente.Selecionado == null)
            {
                dxErroProvider.SetError(lkpCliente, "Campo Obrigatório");
            }
            if (lkpClienteFaturamento.Selecionado == null)
            {
                dxErroProvider.SetError(lkpClienteFaturamento, "Campo Obrigatório");
            }
            if (lkpServico.Selecionado == null)
            {
                dxErroProvider.SetError(lkpServico, "Campo Obrigatório");
            }
            if (string.IsNullOrEmpty(txtNomeObra.Text))
            {
                dxErroProvider.SetError(txtNomeObra, "Campo Obrigatório");
            }
            if (string.IsNullOrEmpty(txtValorTaxaMobilizacao.Text))
            {
                dxErroProvider.SetError(txtValorTaxaMobilizacao, "Campo Obrigatório");
            }
            if (string.IsNullOrEmpty(txtValorHoraMaquinaParada.Text))
            {
                dxErroProvider.SetError(txtValorHoraMaquinaParada, "Campo Obrigatório");
            }
            if (string.IsNullOrEmpty(txtPrevisaoProjeto.Text))
            {
                dxErroProvider.SetError(txtPrevisaoProjeto, "Campo Obrigatório");
            }
            if (string.IsNullOrEmpty(txtQuantidadeTotal.Text))
            {
                dxErroProvider.SetError(txtQuantidadeTotal, "Campo Obrigatório");
            }
            return !dxErroProvider.HasErrors;
        }

        private bool ValidaFormularioOrcamento()
        {
            dxErroProvider.ClearErrors();
            if (string.IsNullOrEmpty(txtNomeClienteOrcamento.Text))
            {
                dxErroProvider.SetError(txtNomeClienteOrcamento, "Campo Obrigatório");
            }
            if (string.IsNullOrEmpty(txtAOrcamento.Text))
            {
                dxErroProvider.SetError(txtAOrcamento, "Campo Obrigatório");
            }
            if (string.IsNullOrEmpty(txtNomeObraOrcamento.Text))
            {
                dxErroProvider.SetError(txtNomeObraOrcamento, "Campo Obrigatório");
            }
            if (((List<Servico>)gcServicos.DataSource).Count < 1)
            {
                MessageBox.Show("Deve haver pelo menos 1 serviço vinculado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            return !dxErroProvider.HasErrors;
        }

        private void lkpCidadeClienteOrcamento_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (lkpCidadeClienteOrcamento.Selecionado != null)
                {
                    Cidade cidade = CidadeController.Instancia.LoadObjectById(((Cidade)lkpCidadeClienteOrcamento.Selecionado).ID);
                    Selecionado.CidadeClienteOrcamento = cidade;
                }
            }
            catch (Exception ex)
            {
                FormErro form = new FormErro(ex);
                form.ShowDialog();
            }
        }

        private void lkpCidadeObraOrcamento_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (lkpCidadeObraOrcamento.Selecionado != null)
                {
                    Cidade cidade = CidadeController.Instancia.LoadObjectById(((Cidade)lkpCidadeObraOrcamento.Selecionado).ID);
                    Selecionado.CidadeObraOrcamento = cidade;
                }
               
            }
            catch (Exception ex)
            {
                FormErro form = new FormErro(ex);
                form.ShowDialog();
            }
        }

        private void lkbCliente_Click_1(object sender, EventArgs e)
        {
            BuscarPessoa(lkpCliente);
        }

        private void lkbClienteFaturamento_Click_1(object sender, EventArgs e)
        {
            BuscarPessoa(lkpClienteFaturamento);
        }

        private void btnlkpServico_Click_1(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<Servico>(lkpServico, typeof(FormServico));
        }

        private void sbIncluirServicoOrcamento_Click(object sender, EventArgs e)
        {
            GridGenerica<Servico> grid = 
                new GridGenerica<Servico>(
                    null, null, ServicoController.Instancia.GetAll, 
                    false, null, null, null, typeof(FormServico)
                    );
            grid.Selecionando = true;
            grid.ShowDialog();
            IList<Servico> lista = ((IList<Servico>)gcServicos.DataSource);

            if (grid.Selecionado != null)
            {
                lista.Add(grid.Selecionado);
                gcServicos.DataSource = lista;
                gvServicos.RefreshData();
            }
        }

        private void sbExcluirServicoOrcamento_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Deseja excluir o serviço do Orçamento", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                Servico servicoSelecionado = (Servico)gvServicos.GetRegistroSelecionado();
                IList<Servico> listaNova = ((IList<Servico>)gcServicos.DataSource);
                listaNova.Remove(servicoSelecionado);
                gcServicos.DataSource = listaNova;
                gcServicos.Refresh();
                gvServicos.RefreshData();
                gcServicos.RefreshDataSource();
            }
        }

    }
}
