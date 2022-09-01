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
    public partial class FormStatusMercadoria : Aplicacao.Relatorios.Base.FormBaseEmpresa
    {
        string tipoFormulario = "";

        public FormStatusMercadoria(string tipoForm)
        {
            InitializeComponent();
            tipoFormulario = tipoForm;
            if (tipoFormulario == "Cliente")
            {
                this.Text = "Relatório de Status Mercadoria por Cliente";

                lkpTransportadora.Visible = false;
                lkbTransportadora.Visible = false;
                labelControl6.Visible = false;

                lkpCliente.Visible = true;
                lkbCliente.Visible = true;

                cbTransportadoraTodos.Visible = false;                
            }
            else
            {
                this.Text = "Relatório de Status Mercadoria por Transportadora";

                lkpCliente.Visible = false;
                lkbCliente.Visible = false;

                lkpTransportadora.Visible = true;
                lkpTransportadora.Visible = true;

                labelControl2.Visible = false;
                cbClienteTodos.Visible = false;

                labelControl6.Location = new Point(6, 184);


                lkpTransportadora.Location = lkpCliente.Location;
                lkbTransportadora.Location = lkbCliente.Location;
                lkbCliente.Location = lkbCliente.Location;

                cbTransportadoraTodos.Location = cbClienteTodos.Location;
            }

            labelControl3.Location = new Point(22, 211);
            cbTipo.Location = new Point(94, 207);

            txtInicio.Location = new Point(331, 206);
            txtFim.Location = new Point(454, 206);
            labelControl4.Location = new Point(290, 207);
            labelControl5.Location = new Point(442, 207);

            this.Size = new Size(753, 325);

            lkpCliente.Sessao = PessoaController.Instancia.getSession();
            lkpCliente.Exemplo = new Pessoa { BCliente = true };

            lkpTransportadora.Sessao = PessoaController.Instancia.getSession();
            lkpTransportadora.Exemplo = new Pessoa { BTransportadora = true };

            HabilitaCampos();

            cbGrupo.Refresh();
            Carrega();
        }

        private bool ValidaCampos()
        {
            StringBuilder erros = new StringBuilder();

            if (cbGrupo.EditValue == null)
                erros.AppendLine("Selecione um Grupo.");

            if (gvEmpresas.SelectedRowsCount == 0)
                erros.AppendLine("Selecione uma Empresa.");

            if (lkpCliente.EditValue == null && !cbClienteTodos.Checked && tipoFormulario == "Cliente")
                erros.AppendLine("Selecione um Cliente.");

            if (lkpTransportadora.EditValue == null && !cbTransportadoraTodos.Checked && tipoFormulario == "Transportadora")
                erros.AppendLine("Selecione uma Transportadora.");

            String msg = erros.ToString();

            if (msg.Length > 0)
            {
                MessageBox.Show(msg);
            }

            return msg.Length == 0;
        }

        private void lkbCliente_Click(object sender, EventArgs e)
        {
            IList<Pessoa> pessoas = PessoaController.Instancia.GetAllClientes();
            GridGenerica<Pessoa> grid = new GridGenerica<Pessoa>(pessoas, new FormPessoa(), (Pessoa)lkpCliente.Selecionado, false);

            grid.Selecionando = true;

            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
                lkpCliente.Localizar(grid.Selecionado.ID);

            lkpCliente.Focus();
        }

        private void lkbTransportadora_Click(object sender, EventArgs e)
        {
            IList<Pessoa> pessoas = PessoaController.Instancia.GetAllTransportadoras();
            GridGenerica<Pessoa> grid = new GridGenerica<Pessoa>(pessoas, new FormPessoa(), (Pessoa)lkpTransportadora.Selecionado, false);

            grid.Selecionando = true;

            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
                lkpTransportadora.Localizar(grid.Selecionado.ID);

            lkpTransportadora.Focus();
        }

        private void cbClienteTodos_CheckedChanged(object sender, EventArgs e)
        {
            lkpCliente.Enabled = !cbClienteTodos.Checked;
            lkbCliente.Enabled = !cbClienteTodos.Checked;
        }

        private void cbTransportadoraTodos_CheckedChanged(object sender, EventArgs e)
        {
            lkpTransportadora.Enabled = !cbTransportadoraTodos.Checked;
            lkbTransportadora.Enabled = !cbTransportadoraTodos.Checked;
        }

        protected override void btOk_Click(object sender, EventArgs e)
        {
            if (!ValidaCampos())
                return;

            DateTime dtInicio = new DateTime();
            DateTime dtFinal = DateTime.Now.Date;

            switch ((string)cbTipo.EditValue)
            {
                case "Última Semana":
                    dtInicio = dtFinal.AddDays(-7);
                    break;
                case "Últimos 15 dias":
                    dtInicio = dtFinal.AddDays(-15);
                    break;
                case "Últimos 30 dias":
                    dtInicio = dtFinal.AddDays(-30);
                    break;
                case "Últimos 45 dias":
                    dtInicio = dtFinal.AddDays(-45);
                    break;
                case "Específico":
                    dtInicio = (DateTime)txtInicio.EditValue;
                    dtFinal = (DateTime)txtFim.EditValue;
                    break;
                default:
                    break;
            }

            var empresa = gvEmpresas.GetSelectedRows();
            IList<ExpedicaoHistorico> expedicaoHistorico;
            if ((cbClienteTodos.Checked && tipoFormulario == "Cliente") ||(cbTransportadoraTodos.Checked && tipoFormulario == "Transportadora"))
                expedicaoHistorico = ExpedicaoHistoricoController.Instancia.GetHistoricos(dtInicio.Date, dtFinal.Date, (int)gvEmpresas.GetRowCellValue(empresa[0], "ID"));                
            else if (tipoFormulario == "Transportadora")
                expedicaoHistorico = ExpedicaoHistoricoController.Instancia.GetHistoricosPorCliente(dtInicio.Date, dtFinal.Date, ((Pessoa)lkpTransportadora.Selecionado).ID);
            else
                expedicaoHistorico = ExpedicaoHistoricoController.Instancia.GetHistoricosPorCliente(dtInicio.Date, dtFinal.Date, ((Pessoa)lkpCliente.Selecionado).ID);

            List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", dtInicio.Date.ToString());
            Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", dtFinal.Date.ToString());
            Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", gvEmpresas.GetRowCellValue(empresa[0], "Nome").ToString());
            
            string tipo = "";

            if (tipoFormulario == "Transportadora")
                tipo = "Status mercadoria por Transportadora";
            else
                tipo = "Status mercadoria por Cliente";
            
            Microsoft.Reporting.WinForms.ReportParameter p4 = new Microsoft.Reporting.WinForms.ReportParameter("Tipo", tipo);
            
            parametros.Add(p1);
            parametros.Add(p2);
            parametros.Add(p3);
            parametros.Add(p4);

            Relatorio.dsStatusMercadoria dt = new Relatorio.dsStatusMercadoria();

            Dictionary<int, string> pedidos = new Dictionary<int,string>();
            if (tipoFormulario == "Transportadora")
            {
                using (Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext())
                {
                    foreach (var item in expedicaoHistorico)
                    {
                        if (pedidos.ContainsKey(item.ExpedicaoRastreamento.Pedido.Numero))
                            item.ExpedicaoRastreamento.Pedido.TotalPedido = 0;
                        else
                            pedidos.Add(item.ExpedicaoRastreamento.Pedido.Numero, "");   

                        dt.Mercadorias.AddMercadoriasRow(item.ExpedicaoRastreamento.IDRastreamento.Codigo,
                            item.ExpedicaoRastreamento.Pedido.PessoaFantasia,
                            item.StatusEntEventoCorreio.EventosCorreio.Descricao,
                            item.DataEvento.ToString().Remove(10),
                            item.ExpedicaoRastreamento.Pedido.DtPrazoEntrega.ToString().Remove(10),
                            item.ExpedicaoRastreamento.Pedido.Numero.ToString(),
                            item.ExpedicaoRastreamento.Pedido.TotalPedido.ToString(),
                            item.ExpedicaoRastreamento.Pedido.Filial.Nome,
                            item.ExpedicaoRastreamento.Pedido.TransNome);                
                    }
                }

                Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase("rptMercadoriasEncaminhadas.rdlc", "dsStatusMercadoria_Mercadorias", dt.Mercadorias, parametros);
                form.ShowDialog();
            }
            else
            {
                using (Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext())
                {
                    foreach (var item in expedicaoHistorico)
                    {
                        dt.Status.AddStatusRow(item.ExpedicaoRastreamento.IDRastreamento.Codigo,
                             item.ExpedicaoRastreamento.Pedido.DtPrazoEntrega.ToString().Remove(10),
                             item.StatusEntEventoCorreio.StatusEntregaVisual,
                             item.DataEvento.ToString().Remove(10),
                             item.StatusEntEventoCorreio.EventosCorreio.Descricao,
                             item.ExpedicaoRastreamento.Pedido.Numero.ToString(),
                             item.ExpedicaoRastreamento.Pedido.Filial.Nome,
                             item.ExpedicaoRastreamento.Pedido.PessoaFantasia);
                    }
                }

                Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase("rptStatusMercadoria.rdlc", "dsStatusMercadoria_Status", dt.Status, parametros);
                form.ShowDialog();
            }

            base.btOk_Click(sender, e);
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitaCampos();
        }

        private void HabilitaCampos()
        {
            if (cbTipo.EditValue == "Específico")
            {
                txtInicio.Enabled = true;
                txtFim.Enabled = true;
            }
            else
            {
                txtInicio.Enabled = false;
                txtFim.Enabled = false;
            }
        }
    }
}
