using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using Aplicacao.Interfaces;
using Aplicacao.Util;

namespace Aplicacao.Relatorios.Base
{
    public partial class UcGrupoEmpresas : UserControl, IFormGrid
    {
        private EmpresaController empresaController;
        private FilialController filialController;
        private IList<Filial> todasFiliais;
        private IList<Empresa> todasEmpresas;
        private readonly IList<TupleIFormGrid> grids = new List<TupleIFormGrid>();

        private readonly List<Filial> filiaisGrid = new List<Filial>();

        public Empresa EmpresaSelecionada
        {
            get
            {
                return (Empresa)cbGrupo.EditValue;
            }
        }

        public IEnumerable<Filial> FiliaisSelecionadas
        {
            get
            {
                foreach (var item in gvEmpresas.GetSelectedRows())
                {
                    yield return (Filial)gvEmpresas.GetRow(item);
                }
            }
        }

        public IEnumerable<int> IdsFiliaisSelecionadas
        {
            get
            {
                foreach (var item in gvEmpresas.GetSelectedRows())
                {
                    yield return ((Filial)gvEmpresas.GetRow(item)).ID;
                }
            }
        }

        public string EmpresaRelatorio
        {
            get
            {
                if (gvEmpresas.SelectedRowsCount > 1)
                    return EmpresaSelecionada.Nome;
                else if (gvEmpresas.SelectedRowsCount == 1)
                    return FiliaisSelecionadas.First().Nome;
                else
                    return "";
            }
        }

        public bool TemEmpresasSelecionadas
        {
            get
            {
                return gvEmpresas.SelectedRowsCount > 0;
            }
        }

        public IList<TupleIFormGrid> Grids { get { return grids; } }

        public DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler CustomSort { get; set; }

        public UcGrupoEmpresas()
        {
            InitializeComponent();
            grids.Add(new TupleIFormGrid { View = gvEmpresas, Control = gcEmpresas, Tipo = typeof(Empresa), ColunasEscondidas = new List<string>() });
        }

        private void cbGrupo_EditValueChanged(object sender, EventArgs e)
        {
            if (cbGrupo.EditValue != null)
            {
                var grupo = (Empresa)cbGrupo.EditValue;
                filiaisGrid.Clear();
                filiaisGrid.AddRange((from f in todasFiliais
                                      where f.Empresa.ID == grupo.ID
                                      select f).ToList());
                gcEmpresas.RefreshDataSource();
                gvEmpresas.MoveFirst();
            }
        }

        private void ucGrupoEmpresas_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                empresaController = EmpresaController.Instancia;
                filialController = FilialController.Instancia;

                todasEmpresas = empresaController.GetAll();
                todasFiliais = filialController.GetAll();

                cbGrupo.Properties.DataSource = todasEmpresas;
                gcEmpresas.DataSource = filiaisGrid;

                this.CarregarPadraoCorSistema();
            }
        }
    }
}
