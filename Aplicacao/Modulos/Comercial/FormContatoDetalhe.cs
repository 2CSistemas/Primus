using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using Aplicacao.Base;
using System.Linq;
using DevExpress.XtraRichEdit.API;

namespace Aplicacao
{
    public partial class FormContatoDetalhe : Aplicacao.IntermediariasTela.FormManutContatoDetalheIntermediaria
    {
        private Cw_usuario AnalistaSelecionado;
        private Cw_usuario AnalistaLogado;
        private Contato contato = new Contato();
        private ContatoDetalhe contatoDet = new ContatoDetalhe();
        private int IDContatoDetalheSelecionado { get; set; }

        public FormContatoDetalhe()
        {
            AtribuiExemplosLkp();
            CarregarStatusContato();
            IDContatoDetalheSelecionado = Selecionado.ID;
        }

        public FormContatoDetalhe(IList<ContatoDetalhe> detalhes, int idSelecionado)
        {
            AtribuiExemplosLkp();
            CarregarStatusContato();
            Selecionado = detalhes.FirstOrDefault();
            IDContatoDetalheSelecionado = idSelecionado;
            SelecionadoParaTela();
            AtivaDesativaBotoesOcorrencia(true);
        }

        private void CarregarStatusContato()
        {
            lkpStatusContato.Properties.DataSource = StatusContatoController.Instancia.GetAll();
            lkpStatusContato.Properties.ValueMember = "Descricao";
            lkpStatusContato.Properties.DisplayMember = "Descricao";
        }

        private void AtribuiExemplosLkp()
        {
            lkpPessoa.Exemplo = new Pessoa { BCliente = true };
            lkpPessoa.CamposRestricoesAND = new List<string> { "BCliente" };
            lkpPessoa.Sessao = (object)cwkGestao.Negocio.PessoaController.Instancia.getSession();

            int id = cwkControleUsuario.Facade.getUsuarioLogado.Id;
            AnalistaSelecionado = Cw_usuarioController.Instancia.LoadObjectById(id);
            AnalistaLogado = Cw_usuarioController.Instancia.LoadObjectById(id);

            lkpAtendente.Exemplo = new Cw_usuario();
            lkpAtendente.CamposRestricoesAND = new List<string>();
            lkpAtendente.Sessao = (object)cwkGestao.Negocio.Cw_usuarioController.Instancia.getSession();
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
        }

        private void sbSalvarOcorrencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    switch (this.Operacao)
                    {
                        case Acao.Incluir:
                            contato = IncluirContato();
                            contatoDet = IncluirContatoDetalhe(contato);
                            if (contato.ContatoDetalhes == null)
                            {
                                contato.ContatoDetalhes = new List<ContatoDetalhe>();
                                contato.ContatoDetalhes.Add(contatoDet);
                            }
                            else
                            {
                                if (contatoDet.ID == 0)
                                    contato.ContatoDetalhes.Add(contatoDet);
                                else
                                {
                                    contato.ContatoDetalhes.Remove(Selecionado);
                                    contato.ContatoDetalhes.Add(contatoDet);
                                }
                            }
                            AlterarContato();
                            break;
                        case Acao.Alterar:
                            AtualizarRegistroContato();
                            ContatoController.Instancia.Salvar(contato, this.Operacao);
                            break;
                    }
                    LimparCamposOcorrencia();
                    RecarregarOcorrencias(contato.ID);
                    dtContato.Focus();
                }
            }
            catch (Exception ex)
            {
                FormErro form = new FormErro(ex);
                form.ShowDialog();
            }
        }

        private void AtualizarRegistroContato()
        {
            contato = Selecionado.Contato;
            contato = IncluirContato();
            contatoDet = IncluirContatoDetalhe(contato);
            contato.ContatoDetalhes.Remove(Selecionado);
            contato.ContatoDetalhes.Add(contatoDet);
        }

        private void AlterarContato()
        {
            if (contato.ID == 0)
                ContatoController.Instancia.Salvar(contato, Acao.Incluir);
            else
                ContatoController.Instancia.Salvar(contato, Acao.Alterar);
        }

        private ContatoDetalhe IncluirContatoDetalhe(Contato contato)
        {
            ContatoDetalhe contatoDet = new ContatoDetalhe();
            if ((Selecionado != null) &&
                (Selecionado.ID != 0))
            {
                contatoDet.ID = Selecionado.ID;
            }
            contatoDet.Assunto = Convert.ToString(txtAssunto.EditValue);
            contatoDet.Contato = contato;
            contatoDet.Data = dtContato.DateTime;
            contatoDet.HoraInicial = TimeSpan.Parse(teInicioContato.EditValue.ToString());
            contatoDet.HoraFinal = TimeSpan.Parse(teFinalContato.EditValue.ToString());
            contatoDet.Observacao = Convert.ToString(txtObservacao.EditValue);
            contatoDet.StatusContato = StatusContatoController.Instancia.LoadObjectById(Convert.ToInt32(lkpStatusContato.GetColumnValue("ID")));
            return contatoDet;
        }

        private void RecarregarOcorrencias(int IDContato)
        {
            gcContatoDetalhe.DataSource = ContatoDetalheController.Instancia.GetPorIDContato(IDContato);
        }

        private void sbCancelarOcorrencia_Click(object sender, EventArgs e)
        {
            try
            {
                LimparCamposOcorrencia();
                Contato contato;
                if (Selecionado == null)
                {
                    contato = null;
                }
                else
                {
                    contato = Selecionado.Contato;
                    Selecionado = new ContatoDetalhe();
                    Selecionado.Contato = contato;
                }
                IDContatoDetalheSelecionado = 0;
                dxErroProvider.ClearErrors();
            }
            catch (Exception ex)
            {
                FormErro form = new FormErro(ex);
                form.ShowDialog();
            }
        }

        private void sbExcluirOcorrencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (Selecionado != null)
                {
                    contato = Selecionado.Contato;
                    ContatoDetalheController.Instancia.Salvar(Selecionado, Acao.Excluir);
                    LimparCamposOcorrencia();
                    RecarregarOcorrencias(contato.ID);
                }
                else
                {
                    MessageBox.Show("Nenhum Aviso Selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                FormErro form = new FormErro(ex);
                form.ShowDialog();
            }
        }

        private Contato IncluirContato()
        {
            contato.NomeContato = Convert.ToString(txtContato.EditValue);
            contato.Pessoa = (Pessoa)lkpPessoa.Selecionado;
            contato.Atendente = (Cw_usuario)lkpAtendente.Selecionado;
            contato.FoneContato = txtFoneContato.Text;
            return contato;
        }

        private void LimparCamposOcorrencia()
        {
            dtContato.EditValue = DBNull.Value;
            teInicioContato.EditValue = DBNull.Value;
            teFinalContato.EditValue = DBNull.Value;
            lkpStatusContato.EditValue = null;
            txtAssunto.Text = String.Empty;
            txtObservacao.Text = String.Empty;
            contatoDet = new ContatoDetalhe();
        }

        private void CarregaOcorrencias()
        {
            ContatoDetalhe linhaSelecionada = new ContatoDetalhe();
            if (((gvContatoDetalhe.GetSelectedRows() != null) &&
                (gvContatoDetalhe.GetSelectedRows().Length > 0)) &&
                ((ContatoDetalhe)gvContatoDetalhe.GetRow(gvContatoDetalhe.GetSelectedRows()[0])) != null)
            {
                int idContDetalhe = (((ContatoDetalhe)gvContatoDetalhe.GetRow(gvContatoDetalhe.GetSelectedRows()[0])).ID);
                linhaSelecionada = ContatoDetalheController.Instancia.LoadObjectById(idContDetalhe);
                if (linhaSelecionada != null)
                {
                    dtContato.DateTime = linhaSelecionada.Data;
                    teInicioContato.EditValue = linhaSelecionada.HoraInicial;
                    teFinalContato.EditValue = linhaSelecionada.HoraFinal;
                    lkpStatusContato.EditValue = linhaSelecionada.StatusContato.Descricao;
                    txtAssunto.Text = linhaSelecionada.Assunto;
                    txtObservacao.Text = linhaSelecionada.Observacao;
                }
            }
            Selecionado = linhaSelecionada;
            IDContatoDetalheSelecionado = Selecionado.ID;
        }

        private void CarregaObjeto(ContatoDetalhe linhaSelecionada)
        {
            linhaSelecionada.Data = dtContato.DateTime;
            linhaSelecionada.HoraInicial = (TimeSpan)teInicioContato.EditValue;
            linhaSelecionada.HoraFinal = (TimeSpan)teFinalContato.EditValue;
            linhaSelecionada.StatusContato = (StatusContato)lkpStatusContato.EditValue;
            linhaSelecionada.Assunto = txtAssunto.Text;
            linhaSelecionada.Observacao = txtObservacao.Text;
        }

        private void lkbAtendente_Click(object sender, EventArgs e)
        {
            GridGenerica<Cw_usuario> grid = new GridGenerica<Cw_usuario>(Cw_usuarioController.Instancia.GetAll(), null, AnalistaLogado, false);
            grid.Selecionando = true;
            grid.DesabilitarBotoes(GridGenerica<Cw_usuario>.Botao.Incluir);
            grid.DesabilitarBotoes(GridGenerica<Cw_usuario>.Botao.Alterar);
            grid.DesabilitarBotoes(GridGenerica<Cw_usuario>.Botao.Excluir);
            grid.DesabilitarBotoes(GridGenerica<Cw_usuario>.Botao.Consultar);
            grid.EsconderBotoes(GridGenerica<Cw_usuario>.Botao.Incluir);
            grid.EsconderBotoes(GridGenerica<Cw_usuario>.Botao.Alterar);
            grid.EsconderBotoes(GridGenerica<Cw_usuario>.Botao.Excluir);
            grid.EsconderBotoes(GridGenerica<Cw_usuario>.Botao.Consultar);
            grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpAtendente.EditValue = AnalistaSelecionado = Cw_usuarioController.Instancia.LoadObjectById(grid.Selecionado.ID);
                lkpAtendente.Focus();
            }
        }

        private void lkbPessoa_Click(object sender, EventArgs e)
        {
            IList<Pessoa> pessoas;
            GridCliente grid;
            pessoas = PessoaController.Instancia.GetAll();
            grid = new GridCliente(pessoas, new FormPessoa(), (Pessoa)lkpPessoa.Selecionado, "Cliente", false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();
            if (grid.Selecionado != null)
                lkpPessoa.Localizar(grid.Selecionado.ID);
            lkpPessoa.Focus();
        }

        private void gcContatoDetalhe_MouseClick(object sender, MouseEventArgs e)
        {
            CarregaOcorrencias();
        }

        private void FormContatoDetalhe_Load(object sender, EventArgs e)
        {
            sbGravar.Visible = false;
            sbGravar.Enabled = false;
            switch (this.Operacao)
            {
                case Acao.Incluir:
                    AtivaDesativaBotoesOcorrencia(true);
                    Selecionado = null;
                    break;
                case Acao.Alterar:
                    AtivaDesativaBotoesOcorrencia(true);
                    SelecionadoParaTela();
                    break;
                case Acao.Excluir:
                    AtivaDesativaBotoesOcorrencia(true);
                    SelecionadoParaTela();
                    break;
                case Acao.Consultar:
                    AtivaDesativaBotoesOcorrencia(false);
                    SelecionadoParaTela();
                    break;
            }
        }

        private void SelecionadoParaTela()
        {
            if (Selecionado != null)
            {
                lkpAtendente.EditValue = Selecionado.Contato.Atendente;
                lkpPessoa.EditValue = Selecionado.Contato.Pessoa;
                txtContato.EditValue = Selecionado.ContatoVisivel;
                txtFoneContato.Text = Selecionado.Contato.FoneContato;
                IDContatoDetalheSelecionado = Selecionado.ID;
                if (IDContatoDetalheSelecionado != 0)
                {
                    IList<ContatoDetalhe> contatoSelecionado = new List<ContatoDetalhe>();
                    contatoSelecionado.Add(ContatoDetalheController.Instancia.LoadObjectById(IDContatoDetalheSelecionado));
                    gcContatoDetalhe.DataSource = contatoSelecionado;
                }
                else
                    gcContatoDetalhe.DataSource = ContatoDetalheController.Instancia.GetPorIDContato(Selecionado.Contato.ID);

                CarregaOcorrencias();
            }
        }

        private void LimparTela()
        {
            lkpAtendente.EditValue = null;
            lkpPessoa.EditValue = null;
            txtContato.EditValue = null;
            gcContatoDetalhe.DataSource = null;
            gcTelefones.DataSource = null;
            contatoDet = new ContatoDetalhe();
            contato = new Contato();
            IDContatoDetalheSelecionado = 0;
        }

        private void AtivaDesativaBotoesOcorrencia(bool p)
        {
            this.sbSalvarOcorrencia.Visible = p;
            this.sbExcluirOcorrencia.Visible = p;
            this.sbCancelarOcorrencia.Visible = p;
        }

        private void gcContatoDetalhe_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    CarregaOcorrencias();
                    break;
                case Keys.Up:
                    CarregaOcorrencias();
                    break;
            }
        }

        private bool ValidarCampos()
        {
            TimeSpan horaInicial, horaFinal;
            dxErroProvider.ClearErrors();
            if (lkpPessoa.Selecionado == null)
                dxErroProvider.SetError(lkpPessoa, "Campo obrigatório");
            if (lkpAtendente.Selecionado == null)
                dxErroProvider.SetError(lkpAtendente, "Campo obrigatório");
            if (String.IsNullOrEmpty(Convert.ToString(txtContato.EditValue)))
                dxErroProvider.SetError(txtContato, "Campo obrigatório");
            if ((dtContato.EditValue == null) || (dtContato.EditValue == DBNull.Value))
                dxErroProvider.SetError(dtContato, "Campo obrigatório");
            if ((teInicioContato.EditValue == null) || (teInicioContato.EditValue == DBNull.Value))
                dxErroProvider.SetError(teInicioContato, "Campo obrigatório");
            if ((teFinalContato.EditValue == null) || (teFinalContato.EditValue == DBNull.Value))
                dxErroProvider.SetError(teFinalContato, "Campo obrigatório");
            if (lkpStatusContato.EditValue == null)
                dxErroProvider.SetError(lkpStatusContato, "Campo obrigatório");
            if ((teInicioContato.EditValue != null) && (teFinalContato.EditValue != null) &&
                (teInicioContato.EditValue != DBNull.Value) && (teFinalContato.EditValue != DBNull.Value))
            {
                horaInicial = TimeSpan.Parse(teInicioContato.EditValue.ToString());
                horaFinal = TimeSpan.Parse(teFinalContato.EditValue.ToString());
                if (horaInicial > horaFinal)
                    dxErroProvider.SetError(teInicioContato, "A data inicial não pode setr");

            }

            return !dxErroProvider.HasErrors;
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lkpPessoa_EditValueChanged(object sender, EventArgs e)
        {
            if (lkpPessoa.Selecionado != null)
            {
                gcTelefones.DataSource = ((Pessoa)lkpPessoa.Selecionado).PessoaTelefones;
            }
        }

        private void FormContatoDetalhe_FormClosed(object sender, FormClosedEventArgs e)
        {
            LimparTela();
        }

        private void lkbAtendente_Click_1(object sender, EventArgs e)
        {

        }

        private void gvContatoDetalhe_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            Bitmap groupPanelImage;
            groupPanelImage = (Bitmap)Aplicacao.Properties.Resources.HeaderGrid;
            groupPanelImage.MakeTransparent();
            Brush brush = e.Cache.GetGradientBrush(e.Bounds, Color.White, Color.WhiteSmoke,
              System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(brush, e.Bounds);
            Image img = groupPanelImage;
            Rectangle r = new Rectangle(e.Bounds.X + e.Bounds.Width - img.Size.Width - 5,
              e.Bounds.Y + (e.Bounds.Height - img.Size.Height) / 2, img.Width, img.Height);
            e.Graphics.DrawImageUnscaled(img, r);
            e.Handled = true;
        }
    }
}
