using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Linq;
using cwkGestao.Negocio.Contratos;
using System.Collections.Generic;
using Relatorio.Relatorios;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Modulos.Contratos
{
    public partial class FormImprimiOS : Form
    {
        public FormImprimiOS()
        {
            InitializeComponent();
            IniciaExemplos();
        }

        private bool CamposValidos()
        {
            dxErrorProvider.ClearErrors();
            if (txtDtInicial.DateTime == new DateTime())
            {
                dxErrorProvider.SetError(txtDtInicial, "Campo Obrigatório");
            }
            if (txtDtFinal.DateTime == new DateTime())
            {
                dxErrorProvider.SetError(txtDtFinal, "Campo Obrigatório");
            }
            if (txtDtFinal.DateTime < txtDtInicial.DateTime)
            {
                dxErrorProvider.SetError(txtDtInicial, "Deve ser menor que a data final");
            }
            if (lkpPessoa.Selecionado == null)
            {
                dxErrorProvider.SetError(lkpPessoa, "Campo obrigatório");
            }
            return !dxErrorProvider.HasErrors;    
        }

        private bool PodeImportar()
        {
            return MessageBox.Show("Deseja gerar os Documentos para o grupo selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sbAjuda_Click(object sender, EventArgs e)
        {
            this.ChamarHelp();
        }

        private void IniciaExemplos()
        {
            lkpPessoa.Exemplo = new cwkGestao.Modelo.Pessoa { BCliente = true };
            lkpPessoa.CamposRestricoesAND = new List<string>() { "BCliente" };
            lkpPessoa.Sessao = cwkGestao.Negocio.PessoaController.Instancia.getSession();
        }

        private void sbImprimir_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = PessoaController.Instancia.LoadObjectById(((Pessoa)lkpPessoa.Selecionado).ID);
            
            if (CamposValidos())
            {
                rptOrdemServicoRFC relatorio = new rptOrdemServicoRFC(pessoa.ID, (DateTime)txtDtInicial.EditValue, (DateTime)txtDtFinal.EditValue, pessoa.HorasContratadas);
                relatorio.ShowPreviewDialog();
            }
        }

        private void lkbPessoa_Click(object sender, EventArgs e)
        {
            try
            {
                GridGenerica<Pessoa> grid = new GridGenerica<Pessoa>(PessoaController.Instancia.GetAllClientes(), new FormPessoa(), (Pessoa)lkpPessoa.Selecionado, false);
                Pessoa cliente = new Pessoa() { BCliente = true };
                grid.Selecionando = true;

                if (cwkControleUsuario.Facade.ControleAcesso(grid))
                    grid.ShowDialog();

                if (grid.Selecionado == null)
                {
                    grid.Close();
                }
                else
                {
                    cliente = PessoaController.Instancia.LoadObjectById(grid.Selecionado.ID);
                    lkpPessoa.Localizar(cliente.ID);
                }
                lkpPessoa.Focus();
            }
            catch (Exception ex)
            {
                throw new Exception("", ex);
            }
        }
    }
}
