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
using DevExpress.Skins;

namespace Aplicacao
{
    public partial class FormManutPedido : Aplicacao.Base.ManutBase
    {
        private cwkGestao.Modelo.CwkPedido ObjCwkPedido;
        private CwkPedidoController CwkPedidoController = CwkPedidoController.Instancia;
        private PessoaController PessoaController = PessoaController.Instancia;
        private VersaoController VersaoController = VersaoController.Instancia;
        private SistemaController SistemaController = SistemaController.Instancia;
        private ClienteRevendaController ClienteRevendaController = ClienteRevendaController.Instancia;
        private List<cwkGestao.Modelo.CwkPedidoEmpresa> Lista = new List<cwkGestao.Modelo.CwkPedidoEmpresa>();
        CwkPedidoEmpresaController cwkPedidoEmpresaController = CwkPedidoEmpresaController.Instancia;

        public FormManutPedido()
        {
            InitializeComponent();
            CarregaClientes();
            cbIdSistema.Properties.DataSource = SistemaController.GetAll();
            string SkinElementName;
            DevExpress.Skins.Skin currentSkin;
            currentSkin = DevExpress.Skins.CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default);
            SkinElementName = DevExpress.Skins.CommonColors.DisabledControl;
            Color DisabledColor = currentSkin.Colors[SkinElementName];
            txtNumeroserie.Properties.AppearanceDisabled.BackColor = DisabledColor;
        }

        public override void CarregaObjeto()
        {
            switch (cwAcao)
            {
                case 1://incluir
                    ObjCwkPedido = new cwkGestao.Modelo.CwkPedido();
                    ObjCwkPedido.CwkPedidoEmpresas = new List<cwkGestao.Modelo.CwkPedidoEmpresa>();
                    txtCodigo.EditValue = CwkPedidoController.MaxCodigo();
                    txtData.DateTime = DateTime.Now.Date;
                    txtHora.DateTime = DateTime.Now;
                    txtLiberado.Text = Modelo.cwkGlobal.objUsuarioLogado.Login;
                    break;
                default:// alterar 2
                    ObjCwkPedido = CwkPedidoController.LoadObjectById(cwID);
                    txtCodigo.EditValue = ObjCwkPedido.Codigo;
                    txtHora.DateTime = Convert.ToDateTime(ObjCwkPedido.Hora);
                    txtObservacao.Text = ObjCwkPedido.Observacao;
                    txtData.DateTime = ObjCwkPedido.Data.Value;
                    txtSolicitante.Text = ObjCwkPedido.Solicitante;
                    txtLiberado.Text = ObjCwkPedido.Liberado;
                    cbIdSistema.EditValue = SistemaController.LoadObjectById(ObjCwkPedido.IDSistema);
                    cbIdPessoa.EditValue = ObjCwkPedido.IDPessoa;
                    chkBDemonstracao.Checked = ObjCwkPedido.BDemonstracao;
                    chkBloqueioUsuarios.Checked = ObjCwkPedido.BloqueioUsuarios;
                    chkExportacaoHorasAbonadas.Checked = ObjCwkPedido.ExportacaoHorasAbonadas;
                    chkRelatorioabsenteismo.Checked = ObjCwkPedido.Relatorioabsenteismo;
                    chkModuloRefeitorio.Checked = ObjCwkPedido.ModuloRefeitorio;
                    chkLicencaReservada.Checked = ObjCwkPedido.LicencaReservada;
                    cbStatus.SelectedIndex = Convert.ToInt32(ObjCwkPedido.Status);
                    txtMotivoCancelamento.Text = ObjCwkPedido.MotivoCancelamento;

                    if (ObjCwkPedido.HoraSite.HasValue)
                        txtHoraSite.DateTime = ObjCwkPedido.HoraSite.Value;

                    if (ObjCwkPedido.IDVersao.HasValue)
                        cbIdVersao.EditValue = VersaoController.LoadObjectById(ObjCwkPedido.IDVersao.Value);

                    if (ObjCwkPedido.DataSite.HasValue)
                        txtDataSite.DateTime = ObjCwkPedido.DataSite.Value;

                    if (ObjCwkPedido.NumeroSerie.HasValue)
                        txtNumeroserie.Value = ObjCwkPedido.NumeroSerie.Value;

                    AtualizaGridEmpresas();
                    if (ObjCwkPedido.Status == OrcamentoStatus.Faturado)
                    {
                        sbGravar.Visible = false;
                        sbCancelar.Text = "Cancelar";
                    }
                    break;
            }
        }

        public override Dictionary<string, string> Salvar()
        {
            chkBDemonstracao_CheckedChanged(null, null);
            ObjCwkPedido.Codigo = (int)txtCodigo.Value;
            ObjCwkPedido.Hora = txtHora.EditValue == null ? null : (DateTime?)txtHora.DateTime;
            ObjCwkPedido.HoraSite = txtHoraSite.EditValue == null ? null : (DateTime?)txtHoraSite.DateTime;
            ObjCwkPedido.Data = txtData.EditValue == null ? null : (DateTime?)txtData.DateTime;
            ObjCwkPedido.Solicitante = txtSolicitante.Text;
            ObjCwkPedido.DataSite = txtDataSite.EditValue == null ? null : (DateTime?)txtDataSite.DateTime;
            ObjCwkPedido.Liberado = txtLiberado.Text;
            ObjCwkPedido.NumeroSerie = (int)txtNumeroserie.Value;
            ObjCwkPedido.Observacao = txtObservacao.Text;
            ObjCwkPedido.Status = (OrcamentoStatus)cbStatus.SelectedIndex;
            ObjCwkPedido.BDemonstracao = chkBDemonstracao.Checked;
            ObjCwkPedido.BloqueioUsuarios = chkBloqueioUsuarios.Checked;
            ObjCwkPedido.ExportacaoHorasAbonadas = chkExportacaoHorasAbonadas.Checked;
            ObjCwkPedido.Relatorioabsenteismo = chkRelatorioabsenteismo.Checked;
            ObjCwkPedido.ModuloRefeitorio = chkModuloRefeitorio.Checked;
            ObjCwkPedido.LicencaReservada = chkLicencaReservada.Checked;
            ObjCwkPedido.Idrevenda = ((int)cbIdPessoa.EditValue);
            if (cbIdPessoa.EditValue != null && (int)cbIdPessoa.EditValue != 0)
                ObjCwkPedido.Pessoa = PessoaController.LoadObjectById((int)cbIdPessoa.EditValue);
            ObjCwkPedido.Sistema = (cwkGestao.Modelo.Sistema)cbIdSistema.EditValue;
            ObjCwkPedido.Versao = cbIdVersao.EditValue != null ? (cwkGestao.Modelo.Versao)cbIdVersao.EditValue : null;

            switch (cwAcao)
            {
                case 1:
                    ObjCwkPedido.IncData = DateTime.Now;
                    ObjCwkPedido.IncUsuario = Modelo.cwkGlobal.objUsuarioLogado.Login;
                    break;
                case 2:
                    ObjCwkPedido.AltData = DateTime.Now;
                    ObjCwkPedido.AltUsuario = Modelo.cwkGlobal.objUsuarioLogado.Login;
                    break;
            }
            try
            {
                ObjCwkPedido.MotivoCancelamento = "";
                if (ObjCwkPedido.Status == OrcamentoStatus.Faturado)
                {
                    return new Dictionary<string, string>() { { "cbStatus", "Não é permitido faturar um orçamento desta forma." } };

                }
                else if (ObjCwkPedido.Status == OrcamentoStatus.Cancelado)
                {
                    if (!txtMotivoCancelamento.Text.Contains(DateTime.Now.ToShortDateString()))
                        txtMotivoCancelamento.Text = DateTime.Now.ToShortDateString() + " : " + txtMotivoCancelamento.Text;
                    ObjCwkPedido.MotivoCancelamento = txtMotivoCancelamento.Text;
                }

                return CwkPedidoController.Salvar(ObjCwkPedido, (cwkGestao.Modelo.Acao)cwAcao);
            }
            catch (Exception e)
            {
                String msg = e.Message;
                Exception inn = e;
                while (inn.InnerException != null)
                {
                    inn = e.InnerException;
                    msg += inn.Message;
                }
                MessageBox.Show(msg);
                return new Dictionary<string, string>() { { "?", "?" } };
            }
        }

        private cwkGestao.Modelo.Pessoa GetPessoa(int pID)
        {
            return PessoaController.GetPessoa(pID);
        }

        private void sbConsultarEmpresa_Click(object sender, EventArgs e)
        {
            if (gvPedidoempresa.GetFocusedRow() == null)
                MessageBox.Show("Por favor selecione um registro para consultar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                ChamaPedidoEmpresa(4, EmpresaSelecionada());
        }

        private void sbIncluirEmpresa_Click(object sender, EventArgs e)
        {
            ChamaPedidoEmpresa(1, 0);
        }

        private void sbAlterarEmpresa_Click(object sender, EventArgs e)
        {
            if (gvPedidoempresa.GetFocusedRow() == null)
                MessageBox.Show("Por favor selecione um registro para alterar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                ChamaPedidoEmpresa(2, EmpresaSelecionada());
        }

        private void sbExcluirEmpresa_Click(object sender, EventArgs e)
        {
            if (gvPedidoempresa.GetFocusedRow() == null)
                MessageBox.Show("Por favor selecione um registro para excluir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                ChamaPedidoEmpresa(3, EmpresaSelecionada());
        }

        private void CarregaClientes()
        {
            using (Modelo.DataClassesDataContext dc = new Modelo.DataClassesDataContext())
            {
                Modelo.Cliente bllCliente = new Modelo.Cliente();
                cbIdPessoa.Properties.DataSource = bllCliente.getListaCombo(dc);
            }
        }

        private void sbAdPessoa_Click(object sender, EventArgs e)
        {
            LookupUtil.GridComboLookupPessoa(cbIdPessoa, new FormPessoa(), cwkGestao.Negocio.PessoaController.Instancia.GetAllClientes(), "Cliente");
            CarregaClientes();

        }

        private void sbAdSistema_Click(object sender, EventArgs e)
        {
            Sistema selecionado = (Sistema)cbIdSistema.EditValue;
            GridGenerica<Sistema> pGp = new GridGenerica<Sistema>(SistemaController.GetAll(), new FormSistema(), selecionado, false) { Selecionando = true };

            if (cwkControleUsuario.Facade.ControleAcesso(pGp))
            {
                pGp.ShowDialog();
                if (pGp.Selecionado != null)
                {
                    cbIdSistema.Properties.DataSource = SistemaController.GetAll();
                    cbIdSistema.EditValue = pGp.Selecionado;
                }
                AtualizaVersoes();
            }
            cbIdSistema.Focus();
        }

        private void cbIdSistema_EditValueChanged(object sender, EventArgs e)
        {
            if (cbIdSistema.EditValue == null)
            {
                cbIdVersao.Enabled = false;
            }
            else
            {
                cbIdVersao.Enabled = true;
                AtualizaVersoes();
                cbIdVersao.EditValue = null;
                if (ObjCwkPedido != null && ObjCwkPedido.Sistema != null && ObjCwkPedido.Sistema.Codigo != ((Sistema)cbIdSistema.EditValue).Codigo)
                {
                    ObjCwkPedido.Sistema = (Sistema)cbIdSistema.EditValue;
                    cwkPedidoEmpresaController.RegerarNumeroSerie(ObjCwkPedido);
                } 
            }
        }

        private void AtualizaVersoes()
        {
            cbIdVersao.Properties.DataSource = VersaoController.GetVersaoSistema(((cwkGestao.Modelo.Sistema)cbIdSistema.EditValue).ID);
        }

        private void ChamaPedidoEmpresa(int pAcao, int pIndice) // 1 inclui, 2 altera, 3 exclui, 4 consulta 
        {
            if (pAcao == 1)
            {
                if ((int)cbIdPessoa.EditValue == 0)
                {
                    MessageBox.Show("Selecione o cliente antes de incluir uma empresa.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (pAcao != 1 && pIndice == 0)
            {
                MessageBox.Show("Nenhum registro selecionado.");
            }
            else
            {
                ObjCwkPedido.IDPessoa = (int)cbIdPessoa.EditValue;
                ObjCwkPedido.Sistema = (Sistema)cbIdSistema.EditValue;
                ObjCwkPedido.Versao = (Versao)cbIdVersao.EditValue;
                if (!String.IsNullOrEmpty(txtNumeroserie.Text))
                {
                    ObjCwkPedido.NumeroSerie = Convert.ToInt32(txtNumeroserie.Text);
                }
                else
                {
                    ObjCwkPedido.NumeroSerie = null;
                }

                try
                {
                    FormManutPedidoEmpresa form = new FormManutPedidoEmpresa(ObjCwkPedido);
                    form.cwAcao = pAcao;
                    form.cwID = pIndice;
                    form.cwTabela = "Serviço";
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    
                    throw ex;
                }
               
                if (pAcao == 3)
                {
                    CwkPedidoController.ReordenaPedidosEmpresa(ObjCwkPedido.CwkPedidoEmpresas);
                }

                if (pAcao != 4)
                {
                    AtualizaGridEmpresas();
                }
            }
        }

        private void AtualizaGridEmpresas()
        {
            gcPedidoempresa.DataSource = (from p in ObjCwkPedido.CwkPedidoEmpresas
                                          select new
                                              {
                                                  Seq = p.Seq,
                                                  Produto = p.TipoServico == 1 ?
                                                                p.Produto.Nome :
                                                                (p.TipoServico == 2 ?
                                                                    p.Servico.Nome : String.Empty),
                                                  Matriz = p.ClienteRevenda.Matriz == null ?
                                                                p.ClienteRevenda.Nome :
                                                                p.ClienteRevenda.Matriz.Nome,
                                                  Filial = p.ClienteRevenda.Matriz != null ?
                                                                p.ClienteRevenda.Nome : String.Empty
                                              }).ToList();
            gcPedidoempresa.RefreshDataSource();
        }

        private Int32 EmpresaSelecionada()
        {
            Int32 parc;
            try
            {
                parc = (int)gvPedidoempresa.GetFocusedRowCellValue("Seq");
            }
            catch (Exception)
            {
                parc = 0;
            }
            return parc;
        }

        private void gcPedidoempresa_DoubleClick(object sender, EventArgs e)
        {
            ChamaPedidoEmpresa(2, EmpresaSelecionada());
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.SelectedIndex == 3)
            {
                txtMotivoCancelamento.Visible = true;
                labelControl13.Visible = true;
            }
            else
            {
                txtMotivoCancelamento.Visible = false;
                labelControl13.Visible = false;
                txtMotivoCancelamento.Text = "";
            }
        }

        private void chkBDemonstracao_CheckedChanged(object sender, EventArgs e)
        {
            if (ObjCwkPedido != null && chkBDemonstracao.Checked != ObjCwkPedido.BDemonstracao)
            {
                ObjCwkPedido.BDemonstracao = chkBDemonstracao.Checked;
                cwkPedidoEmpresaController.RegerarNumeroSerie(ObjCwkPedido);
            }
            else
            {
                ObjCwkPedido.BDemonstracao = chkBDemonstracao.Checked;
            }

            if (chkBDemonstracao.Checked)
            {
                txtNumeroserie.Value = 0;
                foreach (CwkPedidoEmpresa pedidoEmpresa in ObjCwkPedido.CwkPedidoEmpresas)
                {
                    pedidoEmpresa.ValorProduto = 0;
                }
            }
            else
            {
                foreach (CwkPedidoEmpresa pedidoEmpresa in ObjCwkPedido.CwkPedidoEmpresas)
                {

                    if (pedidoEmpresa.Produto != null && pedidoEmpresa.ValorProduto == 0)
                        pedidoEmpresa.ValorProduto = pedidoEmpresa.Produto.PrecoBase;
                    else if (pedidoEmpresa.Servico != null && pedidoEmpresa.ValorProduto == 0)
                        pedidoEmpresa.ValorProduto = Convert.ToDecimal(pedidoEmpresa.Servico.Valor);
                }
            }
        }

        private void cbIdVersao_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
