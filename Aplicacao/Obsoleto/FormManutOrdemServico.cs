using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Util;
using cwkGestao.Negocio;
using System.Linq;
using cwkGestao.Modelo;

namespace Aplicacao
{
    public partial class FormManutOrdemServico : Aplicacao.Base.ManutBase
    {
        cwkGestao.Modelo.OrdemServico objOrdemServico;
        StatusOrdemServicoController statusOrdemServicoController = StatusOrdemServicoController.Instancia;
        TipoAtendimentoController tipoAtendimentoController = TipoAtendimentoController.Instancia;
        OrdemServicoController ordemServicoController = OrdemServicoController.Instancia;
        AcompanhamentoOSController acompanhamentoOSController = AcompanhamentoOSController.Instancia;
        ClienteRevendaController clienteRevendaController = ClienteRevendaController.Instancia;
        SistemaController sistemaController = SistemaController.Instancia;
        VersaoController versaoController = VersaoController.Instancia;

        public FormManutOrdemServico()
        {
            InitializeComponent();
            CarregaComboCliente();
            CarregaComboSistema();
            CarregaComboTipoAtendimento();
            CarregaComboStatusOrdemServico();
            CarregaComboResponsavel();
        }

        public override void CarregaObjeto()
        {
            switch (cwAcao)
            {
                case 1:
                    objOrdemServico = new cwkGestao.Modelo.OrdemServico();
                    objOrdemServico.ServicoOS = new List<cwkGestao.Modelo.ServicoOS>();
                    txtCodigo.EditValue = ordemServicoController.MaxCodigo();
                    txtDataStatus.DateTime = DateTime.Now;
                    break;
                default:
                    objOrdemServico = ordemServicoController.LoadObjectById(cwID);
                    txtCodigo.EditValue = objOrdemServico.Codigo;
                    cbIDStatus.EditValue = objOrdemServico.IDStatus;
                    txtResumo.EditValue = objOrdemServico.Resumo;
                    cbIdCliente.EditValue = objOrdemServico.IDCliente;
                    cbIdClienteRevenda.EditValue = objOrdemServico.IDClienteRevenda;
                    txtContato.EditValue = objOrdemServico.Contato;
                    cbIdTipoAtendimento.EditValue = objOrdemServico.IDTipoAtendimento;
                    cbIdSistema.EditValue = objOrdemServico.IDSistema;
                    cbIdVersao.EditValue = objOrdemServico.IDVersao;
                    txtDataPrevisao.EditValue = objOrdemServico.DataPrevisao;
                    txtDataPrevisaoFinal.EditValue = objOrdemServico.DataPrevisaoFinal;
                    cbIdResponsavel.EditValue = objOrdemServico.IDResponsavel;
                    txtDescricao.EditValue = objOrdemServico.Descricao;
                    txtDataStatus.EditValue = objOrdemServico.AcompanhamentoOS.OrderByDescending(a => a.Codigo).First().Incdata;

                   // mObservacao1.EditValue = objOrdemServico.mObservacao1;
                    

                    AtualizaGridServicos();
                    gcAcompanhamento.DataSource = acompanhamentoOSController.GetAcompanhamentoOS(objOrdemServico.ID);
                    break;
            }
        }

        public override Dictionary<string, string> Salvar()
        {
            objOrdemServico.Codigo = Convert.ToInt32(txtCodigo.Value);
            objOrdemServico.Resumo = txtResumo.Text;
            objOrdemServico.IDStatus = (int)cbIDStatus.EditValue;
            objOrdemServico.IDCliente = (int)cbIdCliente.EditValue;
            objOrdemServico.Contato = txtContato.Text;
            objOrdemServico.IDClienteRevenda = (int?)cbIdClienteRevenda.EditValue;
            objOrdemServico.IDTipoAtendimento = (int?)cbIdTipoAtendimento.EditValue;
            objOrdemServico.IDSistema = (int?)cbIdSistema.EditValue;
            objOrdemServico.IDVersao = (int?)cbIdVersao.EditValue;
            objOrdemServico.IDResponsavel = (int)cbIdResponsavel.EditValue;
            objOrdemServico.DataPrevisao = (DateTime?)txtDataPrevisao.EditValue;
            objOrdemServico.DataPrevisaoFinal = (DateTime?)txtDataPrevisaoFinal.EditValue;
            objOrdemServico.Descricao = txtDescricao.Text;
            //objOrdemServico.Observacao = txtObservacao.Text;

            objOrdemServico.DataStatus = txtDataStatus.DateTime;

            return ordemServicoController.Salvar(objOrdemServico, (cwkGestao.Modelo.Acao)cwAcao);
        }

        #region Serviços
        private void AtualizaGridServicos()
        {
            gcServico.DataSource = (from o in objOrdemServico.ServicoOS
                                   select new
                                   {
                                       o.Codigo,
                                       o.Resumo,
                                       o.DataInicio,
                                       o.DataTermino,
                                       o.TempoHoras
                                   }).ToList();
            gcServico.RefreshDataSource();
        }

        private void CarregaFormularioServico(int pAcao, int pIndice)
        {
            if (pAcao != 1 && pIndice == 0)
            {
                MessageBox.Show("Nenhum registro selecionado.");
            }
            else
            {
                FormManutServicoOS form = new FormManutServicoOS(objOrdemServico);
                form.cwAcao = pAcao;
                form.cwID = pIndice;
                form.cwTabela = "Serviço";
                form.ShowDialog();

                if (pAcao == 3)
                {
                    ordemServicoController.ReordenaServicos(objOrdemServico.ServicoOS);
                }

                if (pAcao != 4)
                {
                    AtualizaGridServicos();
                }
            }
        }

        private Int32 ServicoSelecionado()
        {
            Int32 parc;
            try
            {
                parc = (int)gvServico.GetFocusedRowCellValue("Codigo");
            }
            catch (Exception)
            {
                parc = 0;
            }
            return parc;
        }

        private void sbConsultarServico_Click(object sender, EventArgs e)
        {
            CarregaFormularioServico(4, ServicoSelecionado());
        }

        private void sbIncluirServico_Click(object sender, EventArgs e)
        {
            CarregaFormularioServico(1, 0);
        }

        private void sbAlterarServico_Click(object sender, EventArgs e)
        {
            CarregaFormularioServico(2, ServicoSelecionado());
        }

        private void sbExcluirServico_Click(object sender, EventArgs e)
        {
            CarregaFormularioServico(3, ServicoSelecionado());
        }
        #endregion

        #region Combos

        private void CarregaComboCliente()
        {
            using (Modelo.DataClassesDataContext dc = new Modelo.DataClassesDataContext())
            {
                Modelo.Cliente bllCliente = new Modelo.Cliente();
                cbIdCliente.Properties.DataSource = bllCliente.getListaCombo(dc);
            }
        }

        private void CarregaComboResponsavel()
        {
            cbIdResponsavel.Properties.DataSource = cwkControleUsuario.Facade.GetAllUsuarios();
        }

        private void CarregaComboStatusOrdemServico()
        {
            cbIDStatus.Properties.DataSource = (from c in statusOrdemServicoController.GetAll()
                                                select new
                                                {
                                                    id = c.ID,
                                                    codigo = c.Codigo,
                                                    descricao = c.Descricao,
                                                }).ToList();
        }

        private void CarregaComboTipoAtendimento()
        {
            cbIdTipoAtendimento.Properties.DataSource = (from c in tipoAtendimentoController.GetAll()
                                                         select new
                                                         {
                                                             id = c.ID,
                                                             codigo = c.Codigo,
                                                             descricao = c.Descricao,
                                                         }).ToList();
        }

        private void CarregaComboSistema()
        {
            cbIdSistema.Properties.DataSource = (from c in sistemaController.GetAll()
                                                 select new
                                                 {
                                                     id = c.ID,
                                                     codigo = c.Codigo,
                                                     nome = c.Nome,
                                                 }).ToList();
        }

        private void AtualizaComboVersao()
        {
            int id = (int)cbIdSistema.EditValue;
            if (id > 0)
            {
                cbIdVersao.Enabled = true;
                cbIdVersao.Properties.DataSource = (from c in versaoController.GetAllBySistema(id)
                                                    select new
                                                    {
                                                        id = c.ID,
                                                        codigo = c.Codigo,
                                                        numero = c.Numero,
                                                    }).ToList();
            }
        }

        private void AtualizaComboClienteRevenda()
        {
            int id = (int)cbIdCliente.EditValue;
            if (id > 0)
            {
                cbIdClienteRevenda.Enabled = true;
                sbAdClienteRevenda.Enabled = true;
                cbIdClienteRevenda.Properties.DataSource = clienteRevendaController.GetAllByPessoa(id);
                //cbIdClienteRevenda.Properties.DataSource = (from c in clienteRevendaController.GetAllByPessoa(id)
                //                                            select new
                //                                            {
                //                                                id = c.ID,
                //                                                codigo = c.Codigo,
                //                                                nome = c.Nome,
                //                                            }).ToList();
            }
        }

        private void sbAdStatusOS_Click(object sender, EventArgs e)
        {
            cwkGestao.Modelo.StatusOrdemServico selecionado = cbIDStatus.EditValue != null ? statusOrdemServicoController.LoadObjectById((int)cbIDStatus.EditValue) : null;
            GridGenerica<cwkGestao.Modelo.StatusOrdemServico> pGp = new GridGenerica<cwkGestao.Modelo.StatusOrdemServico>(statusOrdemServicoController.GetAll(), new FormStatusOrdemServico(), selecionado, false) { Selecionando = true };
            if (cwkControleUsuario.Facade.ControleAcesso(pGp))
            {
                pGp.ShowDialog();
                if (pGp.Selecionado != null)
                {
                    CarregaComboStatusOrdemServico();
                    cbIDStatus.EditValue = pGp.Selecionado.ID;
                    
                }
            }
            cbIDStatus.Focus();
        }

        private void sbAdCliente_Click(object sender, EventArgs e)
        {
            LookupUtil.GridComboLookupPessoa(cbIdCliente, new FormPessoa(), cwkGestao.Negocio.PessoaController.Instancia.GetAll(), "Pessoa");

            CarregaComboCliente();
            cbIdCliente.Focus();
        }

        private void sbAdClienteRevenda_Click(object sender, EventArgs e)
        {
            FormGridClienteRevenda pGp = new FormGridClienteRevenda("Tabela de Cliente da Revenda", (int)cbIdCliente.EditValue, null, (int?)cbIdClienteRevenda.EditValue, true);
            if (cwkControleUsuario.Facade.ControleAcesso(pGp))
            {
                pGp.ShowDialog();
                if (pGp.Retorno.Length != 0)
                {
                    cbIdClienteRevenda.EditValue = int.Parse(pGp.Retorno);
                    AtualizaComboClienteRevenda();
                }
            }
            cbIdClienteRevenda.Focus();
        }

        private void sbAdTipoAtendimento_Click(object sender, EventArgs e)
        {
            cwkGestao.Modelo.TipoAtendimento selecionado = cbIdTipoAtendimento.EditValue != null ? tipoAtendimentoController.LoadObjectById((int)cbIdTipoAtendimento.EditValue): null;
            GridGenerica<cwkGestao.Modelo.TipoAtendimento> pGp = new GridGenerica<cwkGestao.Modelo.TipoAtendimento>(tipoAtendimentoController.GetAll(), new FormTipoAtendimento(), selecionado, false) { Selecionando = true };
            if (cwkControleUsuario.Facade.ControleAcesso(pGp))
            {
                pGp.ShowDialog();
                if (pGp.Selecionado != null)
                {
                    CarregaComboTipoAtendimento();
                    cbIdTipoAtendimento.EditValue = pGp.Selecionado.ID;
                }
            }
            cbIdTipoAtendimento.Focus();
        }

        private void sbAdSistema_Click(object sender, EventArgs e)
        {
            Sistema selecionado = cbIdSistema.EditValue != null ? sistemaController.LoadObjectById((int)cbIdSistema.EditValue) : null;
            GridGenerica<Sistema> pGp = new GridGenerica<Sistema>(sistemaController.GetAll(), new FormSistema(), selecionado, false) { Selecionando = true };

            if (cwkControleUsuario.Facade.ControleAcesso(pGp))
            {
                pGp.ShowDialog();
                if (pGp.Selecionado != null)
                {
                    CarregaComboSistema();
                    cbIdSistema.EditValue = pGp.Selecionado.ID;
                }
                AtualizaComboVersao();
            }
            cbIdSistema.Focus();
        }

        private void cbIdSistema_EditValueChanged(object sender, EventArgs e)
        {
            AtualizaComboVersao();
        }

        private void cbIdCliente_EditValueChanged(object sender, EventArgs e)
        {
            AtualizaComboClienteRevenda();
        }

        #endregion

        private void gcServico_DoubleClick(object sender, EventArgs e)
        {
            if (sbAlterarServico.Enabled)
                CarregaFormularioServico(2, ServicoSelecionado());
            else
                CarregaFormularioServico(4, ServicoSelecionado());
        }

        private void cbIDStatus_EditValueChanged(object sender, EventArgs e)
        {
            txtDataStatus.DateTime = DateTime.Now;
        }
    }
}
