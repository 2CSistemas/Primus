using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Modelo;
using Aplicacao.Util;
using Aplicacao.Modulos.Obras_Fundacoes;
using System.Reflection;

namespace Aplicacao
{
    public partial class FormOfd_Obra : Aplicacao.IntermediariasTela.FormManutOfd_ObraIntermediaria
    {
        public FormOfd_Obra()
        {
        }
        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            ConfigurarGridArquivos();
            lkpConstrutora.Exemplo = new Pessoa { BCliente = true };
            lkpConstrutora.CamposRestricoesAND = new List<string> { "BCliente" };
            SetarTags();
        }

        private void SetarTags()
        {
            tpArquivos.Tag = Selecionado;
        }

        protected override void btSubRegistro_Click(object sender, EventArgs e)
        {
            TelaProObjeto(tcPrincipal);
            base.btSubRegistro_Click(sender, e);
        }

        protected override void OnShown(EventArgs e)
        {
            if (Selecionado != null)
            {
                gcServicos.DataSource = Ofd_ObraController.Instancia.GetServicosPorObra(Selecionado.ID);
            }
            base.OnShown(e);
            SetarTags();
        }

        private void lkbConstrutora_Click(object sender, EventArgs e)
        {
            var pessoas = PessoaController.Instancia.GetAllClientes();
            var grid = new GridCliente(pessoas, new FormPessoa(), (Pessoa)lkpConstrutora.Selecionado, "Cliente", false);
            grid.Selecionando = true;
            grid.ShowDialog();
            if (grid.Selecionado != null)
                lkpConstrutora.Localizar(grid.Selecionado.ID);
            lkpConstrutora.Focus();
        }

        private void ConfigurarGridArquivos()
        {
            //FormOfd_ObraArquivos formArquivo = new FormOfd_ObraArquivos() { Selecionado = new Ofd_ObraArquivos() { Obra = Selecionado } };
            //btIncluir.SubForm = formArquivo;
            //btAlterar.SubForm = formArquivo;
            //btExcluir.SubForm = formArquivo;
            //btConsultar.SubForm = formArquivo;

            object[] parms = new[] { new Ofd_ObraArquivos() { Obra = Selecionado } };
            Type formType = typeof(FormOfd_ObraArquivos);

            btIncluir.SubFormType = btAlterar.SubFormType = btExcluir.SubFormType = btConsultar.SubFormType = formType;
            btIncluir.SubFormTypeParams = btAlterar.SubFormTypeParams = btExcluir.SubFormTypeParams = btConsultar.SubFormTypeParams = parms;
        }

        private void btAbrirArquivo_Click(object sender, EventArgs e)
        {
            object arquivo = gvArquivos.GetRegistroSelecionado();
            if (arquivo != null)
                Ofd_ObraArquivosController.Instancia.AbrirArquivo(((Ofd_ObraArquivos)arquivo).CaminhoArquivo);
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {

        }
    }
}
