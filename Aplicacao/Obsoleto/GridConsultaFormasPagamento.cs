using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class GridConsultaFormasPagamento : Form
    {
        private List<Modelo.FormaPgtoMovimento> listaFormasPgtoMovimento;
        //private List<Modelo.Objeto.pxyFormaPagamento> ProxyFormaPagamento;
        public GridConsultaFormasPagamento(Modelo.Movimento pObjMovimento)
        {
            InitializeComponent();
            //ProxyFormaPagamento = new List<Modelo.Objeto.pxyFormaPagamento>();
            //foreach (Modelo.FormaPgtoMovimento item in pObjMovimento.FormaPgtoMovimentos)
            //{
            //    ProxyFormaPagamento.Add(new Modelo.Objeto.pxyFormaPagamento()
            //    {                    
            //        Descricao = item.FormaPagamento.Nome,
            //        Valor = item.Valor
            //    }
            //    );
            //}
            //GridFormasPagamento.DataSource = ProxyFormaPagamento.ToList();
            listaFormasPgtoMovimento = pObjMovimento.FormaPgtoMovimentos.ToList();
            GridFormasPagamento.DataSource = listaFormasPgtoMovimento;
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
