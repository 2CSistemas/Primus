using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Modelo;

namespace Aplicacao.Relatorios
{
    public partial class ApontamentoDeHoras : Aplicacao.Relatorios.Base.FormBase
    {
        OrdemProducaoExecucaoController ordemProducaoExecucaoController = OrdemProducaoExecucaoController.Instancia;

        public ApontamentoDeHoras()
        {
            InitializeComponent();
            this.Text = "Relatório de Apontamento de Horas";

            object sessao = ordemProducaoExecucaoController.getSession();

            lkpFuncionario.Sessao = sessao;
            lkpFuncionario.Exemplo = new cwkGestao.Modelo.Pessoa() { BFuncionario = true };
            lkpFuncionario.CamposRestricoesAND = new List<string> { "BFuncionario" };

            lkpOP.Sessao = sessao;
            lkpOP.Exemplo = new cwkGestao.Modelo.OrdemProducao();

            lkpServico.Sessao = sessao;
            lkpServico.Exemplo = new cwkGestao.Modelo.Servico();
        }

        protected override bool GerarRelatorio()
        {
            if (!ucGrupoEmpresas1.TemEmpresasSelecionadas)
            {
                MessageBox.Show("Selecione pelo menos uma empresa.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!CamposValidos())
                return false;

            string nomerel;
            string tipo;

            if (rgAgrupamento.SelectedIndex == 0)
            {
                nomerel = @"Producao/rptApontamentoHorasPorOP.rdlc";
                tipo = "";
            }
            else if (rgAgrupamento.SelectedIndex == 1)
            {
                nomerel = @"Producao/rptApontamentoHorasPorFuncServico.rdlc";
                tipo = "Funcionário";
            }
            else
            {
                nomerel = @"Producao/rptApontamentoHorasPorFuncServico.rdlc";
                tipo = "Serviço";
            }

            string nome = ucGrupoEmpresas1.EmpresaRelatorio;
            string ds = "dsProducao_ApontamentoHoras";
            var parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            var p1 = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", nome.ToUpper());
            var p2 = new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", txtDataI.DateTime.ToString());
            var p3 = new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", txtDataF.DateTime.ToString());
            var p4 = new Microsoft.Reporting.WinForms.ReportParameter("Tipo", tipo);
            parametros.Add(p1);
            parametros.Add(p2);
            parametros.Add(p3);
            parametros.Add(p4);

            IList<object> dados = ordemProducaoExecucaoController.GetRelatorioApontamento(txtDataI.DateTime, txtDataF.DateTime
                , (OrdemProducao)lkpOP.Selecionado, (Pessoa)lkpFuncionario.Selecionado, (Servico)lkpServico.Selecionado);
            Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase(nomerel, ds, dados, parametros);
            form.Show();
            return true;
        }

        private bool CamposValidos()
        {
            dxErroProvider.ClearErrors();

            if (!chbOP.Checked && lkpOP.Selecionado == null)
                dxErroProvider.SetError(lkpOP, "Selecione a OP.");

            if (!chbFuncionario.Checked && lkpFuncionario.Selecionado == null)
                dxErroProvider.SetError(lkpFuncionario, "Selecione o funcionário.");

            if (!chbServico.Checked && lkpServico.Selecionado == null)
                dxErroProvider.SetError(lkpServico, "Selecione o serviço.");

            if (txtDataI.DateTime < Convert.ToDateTime("01/01/1800"))
                dxErroProvider.SetError(txtDataI, "A data não pode ser menor do que 01/01/1800.");

            if (txtDataF.DateTime < Convert.ToDateTime("01/01/1800"))
                dxErroProvider.SetError(txtDataF, "A data não pode ser menor do que 01/01/1800.");

            if (txtDataI.DateTime > txtDataF.DateTime)
                dxErroProvider.SetError(txtDataI, "A data inicial não pode ser maior do que a data final.");

            if (dxErroProvider.HasErrors)
                return false;
            return true;
        }

        private void chbOP_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaOP(!chbOP.Checked);
        }

        private void chbFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaFuncionario(!chbFuncionario.Checked);
        }

        private void chbServico_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaServico(!chbServico.Checked);
        }

        private void HabilitaOP(bool habilita)
        {
            lkpOP.Enabled = habilita;
            btnlkpOP.Enabled = habilita;

            if (!habilita)
                lkpOP.EditValue = null;
        }

        private void HabilitaFuncionario(bool habilita)
        {
            lkpFuncionario.Enabled = habilita;
            btnlkpFuncionario.Enabled = habilita;

            if (!habilita)
                lkpFuncionario.EditValue = null;
        }

        private void HabilitaServico(bool habilita)
        {
            lkpServico.Enabled = habilita;
            btnlkpServico.Enabled = habilita;

            if (!habilita)
                lkpServico.EditValue = null;
        }

        private void btnlkpOP_Click(object sender, EventArgs e)
        {
            using (global::Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext())
            {
                int? id = null;
                if (lkpOP.Selecionado != null)
                    id = ((OrdemProducao)lkpOP.Selecionado).ID;
                GridOrdemProducao grid = new GridOrdemProducao(db, "Ordem de Produção", true, id);
                grid.ShowDialog();
                if (!String.IsNullOrEmpty(grid.Retorno))
                    lkpOP.Localizar(Convert.ToInt32(grid.Retorno));
            }
        }

        private void btnlkpFuncionario_Click(object sender, EventArgs e)
        {
            var grid = new GridGenerica<Pessoa>(PessoaController.Instancia.GetAllFuncionarios(), new FormPessoa(), (Pessoa)lkpFuncionario.Selecionado, false);
            grid.Selecionando = true;
            grid.ShowDialog();
            lkpFuncionario.EditValue = grid.Selecionado;
        }

        private void btnlkpServico_Click(object sender, EventArgs e)
        {
            var grid = new GridGenerica<Servico>(ServicoController.Instancia.GetAll(), new FormServico(), (Servico)lkpServico.Selecionado, false);
            grid.Selecionando = true;
            grid.ShowDialog();
            lkpServico.EditValue = grid.Selecionado;
        }
    }
}
