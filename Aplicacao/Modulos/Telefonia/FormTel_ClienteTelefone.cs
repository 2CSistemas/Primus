using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Telefonia
{
    public partial class FormTel_ClienteTelefone : Aplicacao.IntermediariasTela.FormManutTel_ClienteTelefone
    {
        private Tel_GrupoClienteTelefone telefoneSelecionado = null;
        private Tel_GrupoClienteTelefone TelefoneSelecionado
        {
            get { return telefoneSelecionado; }
            set
            {
                telefoneSelecionado = value;
                if (telefoneSelecionado == null)
                    txtBuscaTelefone.Text = String.Empty;
                else
                    txtBuscaTelefone.Text = telefoneSelecionado.Telefone;
            }
        }

        public FormTel_ClienteTelefone() { }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
        }

        private void FormTel_ClienteTelefone_Load(object sender, EventArgs e)
        {
            //Se for inclusão vem desabilitado por padrão
            if (Operacao == (cwkGestao.Modelo.Acao)31)
                HabilitarGrupoClienteTelefone(false);
        }

        protected override List<Exception> ObjetoPraTela(Control pai)
        {
            TelefoneSelecionado = Selecionado.GrupoClienteTelefone;
            return base.ObjetoPraTela(pai);
        }

        protected override void TelaProObjeto(Control pai)
        {
            Selecionado.GrupoClienteTelefone = TelefoneSelecionado;
            base.TelaProObjeto(pai);

            if (Selecionado.BAgrupador)
                Selecionado.Cliente.NumeroPiloto = Selecionado.GrupoClienteTelefone.Telefone;
        }

        protected override bool ValidacoesAdicionais()
        {
            if (TelefoneSelecionado == null)
                dxErroProvider.SetError(txtBuscaTelefone, "Selecione um telefone");

            if (chbBAgrupador.Checked && Selecionado.Cliente.Telefones.Where(t => t != Selecionado && t.BAgrupador).Count() > 0)
                dxErroProvider.SetError(chbBAgrupador, "Já existe um telefone agrupador cadastrado.");

            return !dxErroProvider.HasErrors;
        }

        private void HabilitarGrupoClienteTelefone(bool habilitar)
        {
            txtBuscaTelefone.Enabled = habilitar;
            btBuscarGrupoClienteTelefone.Enabled = habilitar;
        }

        private void txtDataAtivacao_Leave(object sender, EventArgs e)
        {
            HabilitarGrupoClienteTelefone(txtDataAtivacao.EditValue != null);
        }

        private void btBuscarGrupoClienteTelefone_Click(object sender, EventArgs e)
        {
            SelecionarTelefoneGrid(String.Empty);
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBuscaTelefone.Text))
                TelefoneSelecionado = null;
            else if (telefoneSelecionado == null || txtBuscaTelefone.Text != telefoneSelecionado.Telefone)
                SelecionarTelefoneGrid(txtBuscaTelefone.Text);
        }

        private void SelecionarTelefoneGrid(string telefone)
        {
            var dados = Tel_GrupoClienteTelefoneController.Instancia.GetDisponiveisPorGrupo(Selecionado.Cliente.GrupoCliente, txtDataAtivacao.DateTime, telefone);
            if (dados.Count == 1)
                TelefoneSelecionado = dados.First();
            else
            {
                var grid = new GridGenerica<Tel_GrupoClienteTelefone>(dados, null, TelefoneSelecionado, false);
                grid.Selecionando = true;
                grid.EsconderBotoes(GridGenerica<Tel_GrupoClienteTelefone>.Botao.Incluir | GridGenerica<Tel_GrupoClienteTelefone>.Botao.Alterar | GridGenerica<Tel_GrupoClienteTelefone>.Botao.Consultar | GridGenerica<Tel_GrupoClienteTelefone>.Botao.Excluir);
                grid.ShowDialog();
                if (grid.Selecionado != null)
                    TelefoneSelecionado = grid.Selecionado;
                txtBuscaTelefone.Focus();
            }
        }
    }
}
