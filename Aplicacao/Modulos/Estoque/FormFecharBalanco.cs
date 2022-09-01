using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using Aplicacao.Base;
using cwkGestao.Negocio.ControleEstoque;
using Aplicacao.Modulos.Estoque.Impressao;

namespace Aplicacao
{
    public partial class FormFecharBalanco : Aplicacao.IntermediariasTela.FormManutBalancoIntermediaria
    {
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            txtFechadoEm.DateTime = DateTime.Now;
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            this.Text = "Fechamento de Balanço";
        }

        protected override void OK()
        {
            if (!ValidarFormulario()) return;

            if (FecharBalanco())
                GerarRelatorio();
        }

        private bool FecharBalanco()
        {
            try
            {
                //Data do fechamento não pode ser maior que a data atual e nem menor que a data de início do balanço
                if (txtFechadoEm.DateTime.Date > System.DateTime.Today)
                    throw new Exception("Data de fechamento do balanço não pode ser maior que a data atual.");
                if (txtFechadoEm.DateTime.Date < txtIniciadoEm.DateTime.Date)
                    throw new Exception("Data de fechamento do balanço não pode ser menor que a data do início do balanço.");

                FechaBalanco fechaBalanco = new FechaBalanco(Selecionado);
                fechaBalanco.Fechar(txtFechadoEm.DateTime);
                return true;
            }
            catch (Exception ex)
            {
                new FormErro(new Exception("Erro ao fechar balanço.", ex)).ShowDialog();
                return false;
            }
        }

        private void GerarRelatorio()
        {
            ImpressaoLogBalanco impressao = new ImpressaoLogBalanco(Selecionado);
            impressao.Imprimir();
            this.Close();
        }
    }
}
