using cwkGestao.Negocio;
using cwkGestao.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Base;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormCusto : Aplicacao.IntermediariasTela.FormManutCustoIntermediaria
    {
        private Nota objNota;
        public FormCusto()
        {
            InitializeComponent();
        }

        public FormCusto(Nota pObjNota)
            : this()
        {
            objNota = pObjNota;
        }

        protected override void OK()
        {
            try
            {
                if (CustoValido())
                {
                    TelaProObjeto(tcPrincipal);
                    CustoController.Instancia.Salvar(Selecionado, Operacao);
                    RatearCustoNotaItem();
                    this.Close();
                }
            }
            catch (Exception e)
            {
                if (e.Message.Contains("Não é possível"))
                    MessageBox.Show(e.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    new FormErro(e).ShowDialog();
            }
        }

        private void RatearCustoNotaItem()
        {
            Nota nota = NotaController.Instancia.LoadObjectById(objNota.ID);
            IList<Custo> custos = CustoController.Instancia.GetAllByIDNota(nota.ID);
            Decimal ValorCusto = custos.Sum(s => s.Valor);

            if (custos.Count == 0) return;

            foreach (var item in nota.NotaItems)
            {
                item.RateioCusto = ValorCusto * Math.Round(item.Total / (nota.TotalNota == 0 ? 1 : nota.TotalNota), 4);
            }

            NotaController.Instancia.Salvar(nota, Acao.Alterar);
        }

        private bool CustoValido()
        {
            dxErroProvider.ClearErrors();


            if (String.IsNullOrEmpty(txtDescricao.Text))
            {
                dxErroProvider.SetError(txtDescricao, "Campo obrigatório");
            }

            Decimal valor = this.ParseMoney(txtValor.Text);
            if (valor <= 0)
            {
                dxErroProvider.SetError(txtValor, "O Valor deve ser maior que 0");
            }


            return !dxErroProvider.HasErrors;
        }


        protected override void TelaProObjeto(Control pai)
        {
            base.TelaProObjeto(pai);
            Selecionado.Nota = objNota;
        }

        public Decimal ParseMoney(string input)
        {
            Decimal valorConvertido = 0;
            try
            {
                Decimal.TryParse(input, NumberStyles.Currency,
                  CultureInfo.CurrentCulture.NumberFormat, out valorConvertido);
            }
            catch
            {
                valorConvertido = 0;
            }

            return valorConvertido;
        }
    }
}
