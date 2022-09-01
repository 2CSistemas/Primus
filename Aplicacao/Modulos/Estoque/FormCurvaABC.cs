using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Aplicacao
{
    public partial class FormCurvaABC : Form
    {
        private Modelo.ConsultaABC consulta;
        private string filial;
        private DateTime datai, dataf;

        public FormCurvaABC(Modelo.ConsultaABC pConsulta, string pFilial, DateTime pDatai, DateTime pDataf)
        {
            InitializeComponent();
            gcClasseA.DataSource = pConsulta.ClasseA;
            gcClasseB.DataSource = pConsulta.ClasseB;
            gcClasseC.DataSource = pConsulta.ClasseC;
            consulta = pConsulta;
            filial = pFilial;
            datai = pDatai;
            dataf = pDataf;
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            Relatorios.CurvaABC form = new Aplicacao.Relatorios.CurvaABC(consulta, filial, datai, dataf);
            if (this.MdiParent != null)
                form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void FormCurvaABC_Load(object sender, EventArgs e)
        {
            if (File.Exists("PadraoCorSistema.xml"))
            {
                gvClasseA.Appearance.RestoreLayoutFromXml("PadraoCorSistema.xml");
                gvClasseB.Appearance.RestoreLayoutFromXml("PadraoCorSistema.xml");
                gvClasseC.Appearance.RestoreLayoutFromXml("PadraoCorSistema.xml");
            }
        }
    }
}
