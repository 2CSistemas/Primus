using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Modulos.Comercial.Impressao;
using Aplicacao.Base;
using cwkGestao.Modelo.Exceptions;

namespace Aplicacao
{
    public partial class FormDialogo : Form
    {
        private List<int> listPedido;
        private List<Modelo.Objeto.FinanceiroParcela> listParcelas;
        private int TipoMovto;
        private int Condicao;
        private DateTime? DataFat;
        private bool orcamento;
        private string Obs1;
        private string Obs2;
        private string Obs3;
        private bool FatLote;
        private decimal desconto;

        private Modelo.DataClassesDataContext db;

        private cwkGestao.Modelo.Pedido pedido;

        public FormDialogo(bool pOrcamento, List<int> pPedido, List<Modelo.Objeto.FinanceiroParcela> pParcelas, int pTipoMovto, int pCondicao, DateTime? pDataFat, string pObs1, string pObs2, string pObs3, bool pFatLote)
        {
            InitializeComponent();

            db = new Modelo.DataClassesDataContext();
            listPedido = pPedido;
            listParcelas = pParcelas;
            TipoMovto = pTipoMovto;
            Condicao = pCondicao;
            DataFat = pDataFat;
            orcamento = pOrcamento;
            Obs1 = pObs1;
            Obs2 = pObs2;
            Obs3 = pObs3;
            FatLote = pFatLote;
        }

        public FormDialogo(cwkGestao.Modelo.Pedido _pedido)
        {
            InitializeComponent();
            pedido = _pedido;

            listPedido = new List<int>() { pedido.ID };

            orcamento = true;
            
        }

        public FormDialogo(cwkGestao.Modelo.Pedido _pedido, bool podeimprimir)
        {
            InitializeComponent();
            pedido = _pedido;

            listPedido = new List<int>() { pedido.ID };
            bt1.Visible = false;
            orcamento = true;

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            foreach (int idPedido in listPedido)
            {
                cwkGestao.Modelo.Pedido pedido = cwkGestao.Negocio.PedidoController.Instancia.LoadObjectById(idPedido);
                try
                {
                    ImpressaoOrcamento impressao = ImpressaoOrcamento.GetImpressaoOrcamento(pedido);
                    if (impressao.GetType() == typeof(ImpressaoOrcamentoMulti))
                        impressao.Imprimir(true);
                    else
                    impressao.Imprimir();
                }
                catch (PrinterNotFoundException printerNotFoundException)
                {
                    new FormErro(printerNotFoundException).ShowDialog();
                }
                
            }
            this.Close();
        }

        private void sbArquivar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDialogo_Load(object sender, EventArgs e)
        {
            bt1.Enabled = orcamento;
            sbArquivar.Enabled = orcamento;

            if (listPedido.Count > 1)
                lbPedido.Text = "";
            else
            {
                if (pedido != null)
                {
                    lbPedido.Text = "ORÇAMENTO: " + pedido.Numero;
                }
                else
                {

                    Modelo.Pedido objPedido = new Modelo.Pedido();
                    objPedido = (Modelo.Pedido)objPedido.getObjeto(db, listPedido[0]);

                    lbPedido.Text = "ORÇAMENTO: " + objPedido.Numero;
                }
            }
        }

    }
}