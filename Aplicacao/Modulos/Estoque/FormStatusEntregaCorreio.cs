using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using cwkGestao.Modelo.Util;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormStatusEntregaCorreio : Aplicacao.IntermediariasTela.FormManutStatusEntEventoCorreioIntermediaria
    {
        StatusEntrega status;

        public FormStatusEntregaCorreio()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            Refresh();
        }

        private void FormStatusEntrega_Shown(object sender, EventArgs e)
        {
            tabStatusEntrega.SelectedTabPage = StatusEntrega;

            gcEventosCorreio.DataSource = EventosCorreioController.Instancia.GetAll();
            txtCodigo.Focus();
            if (Operacao == Acao.Incluir)
            {
                txtDescricaoHTML.ReadOnly = false;
                txtDescricaoHTML.RtfText = "";
                gvEventosCorreio.OptionsSelection.MultiSelect = true;
            }
            else
            {
                txtDescricaoHTML.ReadOnly = false;
                status = Selecionado.StatusEntrega;
                txtCodigo.Text = status.Codigo.ToString();
                txtDescricao.Text = status.Descricao;

                if (StringUtil.VerificaSeEHtml(status.Desc_HTML))
                   txtDescricaoHTML.Text = status.Desc_HTML;
                else
                    txtDescricaoHTML.RtfText = status.Desc_HTML;

                gvEventosCorreio.FocusedRowHandle = Selecionado.EventosCorreio.Codigo - 1;
                gvEventosCorreio.OptionsSelection.MultiSelect = false;
            }
        }

        protected override void OK()
        {
            if (Operacao == Acao.Excluir)
            {
                StatusEntEventoCorreioController.Instancia.Salvar(Selecionado, Acao.Excluir);
                Close();
                return;
            }

            if (ValidaCampos())
            {
                string desc_Html = "";

                try
                {
                    if (StringUtil.VerificaSeEHtml(txtDescricaoHTML.Text))
                        desc_Html = txtDescricaoHTML.Text;
                    else
                        desc_Html = txtDescricaoHTML.RtfText;

                    if (Operacao == Acao.Incluir)
                    {
                        status = new StatusEntrega()
                        {
                            Codigo = Convert.ToInt32(txtCodigo.Text),
                            Descricao = txtDescricao.Text,
                            Desc_HTML = desc_Html
                        };

                        StatusEntregaController.Instancia.Salvar(status, Acao.Incluir);

                        foreach (int item in gvEventosCorreio.GetSelectedRows())
                        {
                            Selecionado = new StatusEntEventoCorreio()
                            {
                                StatusEntrega = status,
                                EventosCorreio = (EventosCorreio)gvEventosCorreio.GetRow(item)
                            };

                            StatusEntEventoCorreioController.Instancia.Salvar(Selecionado, Acao.Incluir);
                        }

                        Close();
                        return;
                    }

                    if (Operacao == Acao.Alterar)
                    {
                        status.Codigo = Convert.ToInt32(txtCodigo.Text);
                        status.Descricao = txtDescricao.Text;
                        status.Desc_HTML = desc_Html;

                        StatusEntregaController.Instancia.Salvar(status, Acao.Alterar);

                        Selecionado.StatusEntrega = status;
                        Selecionado.EventosCorreio = (EventosCorreio)gvEventosCorreio.GetFocusedRow();

                        StatusEntEventoCorreioController.Instancia.Salvar(Selecionado, Acao.Alterar);

                        Close();
                        return;
                    }
                }
                catch
                {
                    throw new Exception("O evento selecionado já foi registrado em outro status dos Correios.");
                }
            }
            else
                MessageBox.Show("Adicione todos os campos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private bool ValidaCampos()
        {
            if (String.IsNullOrEmpty(txtCodigo.Text) ||
                String.IsNullOrEmpty(txtDescricao.Text) ||
                String.IsNullOrEmpty(txtDescricaoHTML.RtfText))
                return false;

            return true;
        }
    }
}
