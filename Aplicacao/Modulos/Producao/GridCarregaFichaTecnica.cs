using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Producao
{
    public partial class GridCarregaFichaTecnica : Aplicacao.IntermediariasTela.GridCarregaFichaTecnicaIntermediaria
    {
        public FichaTecnicaPCP FichaSelecionada { get; set; }

        public GridCarregaFichaTecnica()
        {
            InitializeComponent();
            gcPrincipal.DataSource = FichaTecnicaPCPController.Instancia.GetAll();
        }

        public FichaTecnicaPCP ShowForm()
        {
            this.ShowDialog();
            return FichaSelecionada;
        }

        protected override void sbSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.GetRegistroSelecionado() == null)
                {
                    new Aplicacao.Base.FormErro("Não há Ficha Técnica selecionada", 
                        "Favor selecionar uma Ficha Técnica para ser carregada").ShowDialog();
                    return;
                }
                FichaSelecionada = FichaTecnicaPCPController.Instancia.LoadObjectById(GetRegistroSelecionado().ID);
                this.Close();
            }
            catch (Exception z)
            {
                
                new Aplicacao.Base.FormErro(z).ShowDialog();
                return;
            }
            
        }
    }
}