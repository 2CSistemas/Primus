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
using System.Threading;
using Aplicacao.Interfaces;

namespace Aplicacao.Modulos.Financeiro
{
    public partial class GridDocumentoRateio : Aplicacao.IntermediariasTela.GridDocumentoIntermediaria
    {
        public GridDocumentoRateio()
            : base(null, null, null, null, true)
        {
            InitializeComponent();
            gcPrincipal.Size = new Size(931, 364);
            ConfiguraBotoes();
            Thread threadSubForm = new Thread(x => CreateFormDocumento(this));
            threadSubForm.Start(this);
        }

        private static void CreateFormDocumento(GridGenerica<Documento> grid)
        {
            grid.FormManut = new FormDocumentoRateio();
        }

        private void ConfiguraBotoes()
        {//Ratear, Consultar, alterar, imprimir filtro, ajuda, fechar.
            sbAlterar.Text = "&Ratear";
            sbIncluir.Enabled = false;
            sbIncluir.Visible = false;
            sbExcluir.Enabled = false;
            sbExcluir.Visible = false;
            sbFuncao10.Enabled = false;
            sbFuncao10.Visible = false;
            sbFuncao11.Enabled = false;
            sbFuncao11.Visible = false;
            sbFuncao12.Enabled = false;
            sbFuncao12.Visible = false;
            sbFuncao13.Enabled = false;
            sbFuncao13.Visible = false;
            sbSelecionar.Enabled = false;
            sbSelecionar.Visible = false;
            sbFuncao22.Enabled = false;
            sbFuncao22.Visible = false;
            sbFuncao23.Enabled = false;
            sbFuncao23.Visible = false;
        }

        protected override void Incluir()
        {
            return;
        }

        protected override void Consultar()
        {
            base.Consultar();
        }

        
    }
}