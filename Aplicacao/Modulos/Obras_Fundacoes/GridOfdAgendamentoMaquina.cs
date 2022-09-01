using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid.Localization;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using DevExpress.XtraPivotGrid;
using System.Reflection;
using Aplicacao.Util;
using System.Linq;
using DevExpress.XtraPrinting;

namespace Aplicacao.Modulos.Obras_Fundacoes
{
    public partial class GridOfdAgendamentoMaquina : DevExpress.XtraEditors.XtraForm
    {
        string textoFiltroCabecalhoRel;
        Ofd_AgendamentoMaquina Selecionado;
        public GridOfdAgendamentoMaquina()
        {
            InitializeComponent();
            PivotGridLocalizer.Active = new GridPivotLocalizer();
            ucFiltroGrid1.sbFiltrar.Click += new EventHandler(sbFiltrar_Click);
            AtualizarGrid();
            this.Focus();
        }

        #region Métodos Auxiliares

        private void AtualizarGrid()
        {
            IList<Ofd_AgendamentoMaquina> ds = Ofd_AgendamentoMaquinaController.Instancia
                .GetAllByPeriod(ucFiltroGrid1.deDataInicial.DateTime, ucFiltroGrid1.deDataFinal.DateTime, null);
            foreach (var item in ds)
            {
                if (!item.HoraEntrada.HasValue)
                {
                    item.HoraEntrada = item.Data;
                }
            }
            pgcAgendamentoMaquinas.DataSource = ds;
            pgcAgendamentoMaquinas.Refresh();
            pgcAgendamentoMaquinas.RefreshData();
        }

        public void GetCelulaSelecionada()
        {
            IList<Ofd_AgendamentoMaquina> ds = GridUtil
                .ConvertPivotDrillDownDataSourceToList<Ofd_AgendamentoMaquina>(
                pgcAgendamentoMaquinas.Cells.GetFocusedCellInfo().CreateDrillDownDataSource());
            Selecionado = ds.FirstOrDefault();
        }

        #endregion

        #region Eventos

        void sbFiltrar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }
        
        private void pgcAgendamentoMaquinas_CustomCellDisplayText(object sender, DevExpress.XtraPivotGrid.PivotCellDisplayTextEventArgs e)
        {
            if (e.ColumnValueType == PivotGridValueType.Value && e.RowValueType == PivotGridValueType.Value)
            {
                IList<Ofd_AgendamentoMaquina> ds = GridUtil.ConvertPivotDrillDownDataSourceToList<Ofd_AgendamentoMaquina>(e.CreateDrillDownDataSource());
                if (ds.Count > 0)
                {
                    if (ds.Count > 1)
                    {
                        e.DisplayText = "Quantidade de agendamentos: " + ds.Count;
                    }
                    else
                    {
                        e.DisplayText = ds[0].Informacao;
                    }
                }
            }

        }

        private void pgcAgendamentoMaquinas_CellDoubleClick(object sender, DevExpress.XtraPivotGrid.PivotCellEventArgs e)
        {
            if (e.ColumnValueType == PivotGridValueType.Value && e.RowValueType == PivotGridValueType.Value)
            {
                IList<Ofd_AgendamentoMaquina> dsGeral = (List<Ofd_AgendamentoMaquina>)pgcAgendamentoMaquinas.DataSource;
                IList<Ofd_AgendamentoMaquina> ds = GridUtil.ConvertPivotDrillDownDataSourceToList<Ofd_AgendamentoMaquina>(e.CreateDrillDownDataSource());

                Ofd_AgendamentoMaquina agendamento = new Ofd_AgendamentoMaquina();
                FormOfd_AgendamentoMaquina form;
                
                if (ds.Count > 0)
                {
                    agendamento = ds[0];
                    form = new FormOfd_AgendamentoMaquina(dsGeral) { Operacao = Acao.Alterar, Selecionado = agendamento };
                }
                else
                {
                    form = new FormOfd_AgendamentoMaquina(dsGeral) { Operacao = Acao.Incluir };
                }
                form.TratarTela();
                if (!cwkControleUsuario.Facade.ControleAcesso(form))
                {
                    return;
                }
                form.ShowDialog();
                AtualizarGrid();
            }
        }

        private void sbConsultar_Click(object sender, EventArgs e)
        {
            GetCelulaSelecionada();
            IList<Ofd_AgendamentoMaquina> ds = (List<Ofd_AgendamentoMaquina>)pgcAgendamentoMaquinas.DataSource;
            FormOfd_AgendamentoMaquina form = new FormOfd_AgendamentoMaquina(ds) { Operacao = Acao.Consultar };
            form.TratarTela();
            if (!cwkControleUsuario.Facade.ControleAcesso(form))
            {
                return;
            }
            if (Selecionado != null)
            {
                form.Selecionado = this.Selecionado;
                form.ShowDialog();
                AtualizarGrid();
            }
            else
            {
                MessageBox.Show("Selecione um Agendamento para Consultar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void sbIncluir_Click(object sender, EventArgs e)
        {
            IList<Ofd_AgendamentoMaquina> ds = (List<Ofd_AgendamentoMaquina>)pgcAgendamentoMaquinas.DataSource;
            FormOfd_AgendamentoMaquina form = new FormOfd_AgendamentoMaquina(ds) { Operacao = Acao.Incluir };
            form.TratarTela();
            if (!cwkControleUsuario.Facade.ControleAcesso(form))
            {
                return;
            }
            form.ShowDialog();
            AtualizarGrid();
        }

        private void sbAlterar_Click(object sender, EventArgs e)
        {
            GetCelulaSelecionada();
            IList<Ofd_AgendamentoMaquina> ds = (List<Ofd_AgendamentoMaquina>)pgcAgendamentoMaquinas.DataSource;
            FormOfd_AgendamentoMaquina form = new FormOfd_AgendamentoMaquina(ds) { Operacao = Acao.Alterar };
            form.TratarTela();
            if (!cwkControleUsuario.Facade.ControleAcesso(form))
            {
                return;
            }
            if (Selecionado != null)
            {
                form.Selecionado = this.Selecionado;
                form.ShowDialog();
                AtualizarGrid();
            }
            else
            {
                MessageBox.Show("Selecione um Agendamento para Alterar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void sbExcluir_Click(object sender, EventArgs e)
        {
            GetCelulaSelecionada();
            IList<Ofd_AgendamentoMaquina> ds = (List<Ofd_AgendamentoMaquina>)pgcAgendamentoMaquinas.DataSource;
            FormOfd_AgendamentoMaquina form = new FormOfd_AgendamentoMaquina(ds) { Operacao = Acao.Excluir };
            form.TratarTela();
            if (!cwkControleUsuario.Facade.ControleAcesso(form))
            {
                return;
            }
            if (Selecionado != null)
            {
                form.Selecionado = this.Selecionado;
                form.ShowDialog();
                AtualizarGrid();
            }
            else
            {
                MessageBox.Show("Selecione um Agendamento para Excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pgcAgendamentoMaquinas_CellClick(object sender, PivotCellEventArgs e)
        {
            GetCelulaSelecionada();
        }

        #endregion

        #region Impressão da Pivot Grid

        private void sbImprimirFiltro_Click(object sender, EventArgs e)
        {
            printableComponentLink1.CreateDocument();
            printableComponentLink1.ShowPreview();
        }

        private void printableComponentLink1_CreateMarginalHeaderArea(object sender, CreateAreaEventArgs e)
        {
            DevExpress.XtraPrinting.TextBrick brick = new TextBrick();

            string dataAtualStr = DateTime.Today.ToLongDateString();
            textoFiltroCabecalhoRel = " por Período ("
                + ucFiltroGrid1.deDataInicial.DateTime.Date.ToString() + " à "
                + ucFiltroGrid1.deDataFinal.DateTime.Date.ToString() + ").";
            string[] rows = { this.Text, textoFiltroCabecalhoRel, dataAtualStr };

            for (int i = 0; i < rows.Count(); i++)
            {
                if (i == 0)
                {
                    brick = e.Graph.DrawString(rows[i], Color.Black, new RectangleF(0, 0, 500, 40),
                                               DevExpress.XtraPrinting.BorderSide.None);
                    brick.Font = new Font("Arial", 16);
                    brick.StringFormat = brick.StringFormat.ChangeAlignment(StringAlignment.Center);
                }
                else if (i == 1)
                {
                    string filtro = rows[i];
                    brick = e.Graph.DrawString("Filtro: " + filtro, Color.Black, new RectangleF(0, 32, 800, 40),
                                               DevExpress.XtraPrinting.BorderSide.None);
                    brick.Font = new Font("Arial", 9);
                    brick.StringFormat = brick.StringFormat.ChangeAlignment(StringAlignment.Near);
                }
                else if (i == 2)
                {
                    brick = e.Graph.DrawString(rows[i], Color.Black, new RectangleF(750, 32, 230, 40),
                       DevExpress.XtraPrinting.BorderSide.None);
                    brick.Font = new Font("Arial", 9);
                    brick.StringFormat = brick.StringFormat.ChangeAlignment(StringAlignment.Far);
                }
            }
        }

        #endregion

        private void GridOfdAgendamentoMaquina_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    sbFechar_Click(new object(), new EventArgs());
                    break;
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Agendamento Máquina");
                    break;
                case Keys.F5:
                    AtualizarGrid();
                    break;
            }
        }

        private void pgcAgendamentoMaquinas_CustomDrawFieldHeaderArea(object sender, PivotCustomDrawHeaderAreaEventArgs e)
        {

        }
    }
}