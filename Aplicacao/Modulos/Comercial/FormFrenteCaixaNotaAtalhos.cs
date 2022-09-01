using MetroFramework.Forms;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormFrenteCaixaNotaAtalhos : MetroForm
    {
        public enum AtalhosPDV
        {
            QUANTIDADE = 1,
            PESARBALANCA = 2,
            DESCARTARITEM = 3,
            CONSULTARPRECO = 4,
            PRODUTOS = 5,
            INFORMARCPF = 6,
            CLIENTE = 7,
            VENDEDOR = 8,
            CANCELARVENDA = 9,
            ABRIRCAIXA = 10,
            CONDICAODEPAGAMENTO = 11,
            SANGRIA = 12,
            SUPRIMENTO = 13,
            FECHARCAIXA = 14,
            FINALIZARVENDA = 15,
            //ABRIRDELIVERY = 16,
            CARREGARPEDIDO = 17,
            DESCONTO = 18,
            REIMPRIMIRPEDIDO = 19,
            SALVARRESERVA = 20,
            CARREGARRESERVA = 21,
            ABRIRGAVETA = 22
        }

        public AtalhosPDV AtalhoSelecionado { get; set; }
        public bool FechouTela { get; set; } = false;

        private Dictionary<string, Keys> AtalhosStartIni = null;
        private Dictionary<string, string> AtalhosStartIniString = null;

        public FormFrenteCaixaNotaAtalhos(Dictionary<string, Keys> AtalhosStartIni, Dictionary<string, string> AtalhosStartIniString)
        {
            InitializeComponent();
            this.AtalhosStartIni = AtalhosStartIni;
            this.AtalhosStartIniString = AtalhosStartIniString;
            AjustarNomenclaturas();
        }

        private void AjustarNomenclaturas()
        {
            string AjustarText(string Texto)
            {
                return $"[{Texto.Replace(",", " + ").Replace("Control", "CTRL")}]";
            }

            LBL_QUANTIDADE.Text = AjustarText(AtalhosStartIniString["QUANTIDADE"]);
            LBL_BALANCA.Text = AjustarText(AtalhosStartIniString["PESARBALANCA"]);
            LBL_DESCARTARITEM.Text = AjustarText(AtalhosStartIniString["DESCARTARITEM"]);
            LBL_CONSULTAPRECO.Text = AjustarText(AtalhosStartIniString["CONSULTARPRECO"]);
            LBL_PRODUTOS.Text = AjustarText(AtalhosStartIniString["PRODUTOS"]);
            LBL_INFORMARCPF.Text = AjustarText(AtalhosStartIniString["INFORMARCPF"]);
            LBL_CLIENTE.Text = AjustarText(AtalhosStartIniString["CLIENTE"]);
            LBL_VENDEDOR.Text = AjustarText(AtalhosStartIniString["VENDEDOR"]);
            LBL_CANCELARVENDA.Text = AjustarText(AtalhosStartIniString["CANCELARVENDA"]);
            LBL_ABRIRCAIXA.Text = AjustarText(AtalhosStartIniString["ABRIRCAIXA"]);
            LBL_CONDICAO.Text = AjustarText(AtalhosStartIniString["CONDICAODEPAGAMENTO"]);
            LBL_SANGRIA.Text = AjustarText(AtalhosStartIniString["SANGRIA"]);
            LBL_SUPRIMENTO.Text = AjustarText(AtalhosStartIniString["SUPRIMENTO"]);
            LBL_FECHARCAIXA.Text = AjustarText(AtalhosStartIniString["FECHARCAIXA"]);
            LBL_FINALIZARVENDA.Text = AjustarText(AtalhosStartIniString["FINALIZARVENDA"]);
            LBL_CARREGARPEDIDO.Text = AjustarText(AtalhosStartIniString["CARREGARPEDIDO"]);
            LBL_DESCONTO.Text = AjustarText(AtalhosStartIniString["DESCONTO"]);
            LBL_IMPRIMIRPEDIDO.Text = AjustarText(AtalhosStartIniString["REIMPRIMIRPEDIDO"]);
            LBL_SALVARRESERVA.Text = AjustarText(AtalhosStartIniString["SALVARRESERVA"]);
            LBL_CARREGARRESERVA.Text = AjustarText(AtalhosStartIniString["CARREGARRESERVA"]);
            LBL_ABRIRGAVETA.Text = AjustarText(AtalhosStartIniString["ABRIRGAVETA"]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                FechouTela = true;
                Close();
            }
            else
            {
                var AtalhoEncontrado = AtalhosStartIni.FirstOrDefault(o => o.Value == keyData);
                switch (AtalhoEncontrado.Key)
                {
                    case "QUANTIDADE":
                        AtalhoSelecionado = AtalhosPDV.QUANTIDADE;
                        Close();
                        break;
                    case "PESARBALANCA":
                        AtalhoSelecionado = AtalhosPDV.PESARBALANCA;
                        Close();
                        break;
                    case "DESCARTARITEM":
                        AtalhoSelecionado = AtalhosPDV.DESCARTARITEM;
                        Close();
                        break;
                    case "CONSULTARPRECO":
                        AtalhoSelecionado = AtalhosPDV.CONSULTARPRECO;
                        Close();
                        break;
                    case "PRODUTOS":
                        AtalhoSelecionado = AtalhosPDV.PRODUTOS;
                        Close();
                        break;
                    case "INFORMARCPF":
                        AtalhoSelecionado = AtalhosPDV.INFORMARCPF;
                        Close();
                        break;
                    case "CLIENTE":
                        AtalhoSelecionado = AtalhosPDV.CLIENTE;
                        Close();
                        break;
                    case "VENDEDOR":
                        AtalhoSelecionado = AtalhosPDV.VENDEDOR;
                        Close();
                        break;
                    case "CANCELARVENDA":
                        AtalhoSelecionado = AtalhosPDV.CANCELARVENDA;
                        Close();
                        break;
                    case "ABRIRCAIXA":
                        AtalhoSelecionado = AtalhosPDV.ABRIRCAIXA;
                        Close();
                        break;
                    case "FECHARCAIXA":
                        AtalhoSelecionado = AtalhosPDV.FECHARCAIXA;
                        Close();
                        break;
                    case "SANGRIA":
                        AtalhoSelecionado = AtalhosPDV.SANGRIA;
                        Close();
                        break;
                    case "SUPRIMENTO":
                        AtalhoSelecionado = AtalhosPDV.SUPRIMENTO;
                        Close();
                        break;
                    case "FINALIZARVENDA":
                        AtalhoSelecionado = AtalhosPDV.FINALIZARVENDA;
                        Close();
                        break;
                    case "DESCONTO":
                        AtalhoSelecionado = AtalhosPDV.DESCONTO;
                        //AtalhoSelcionado = AtalhosPDV.ABRIRDELIVERY;
                        Close();
                        break;
                    case "CONDICAODEPAGAMENTO":
                        AtalhoSelecionado = AtalhosPDV.CONDICAODEPAGAMENTO;
                        Close();
                        break;
                    case "CARREGARPEDIDO":
                        AtalhoSelecionado = AtalhosPDV.CARREGARPEDIDO;
                        Close();
                        break;
                    case "REIMPRIMIRPEDIDO":
                        AtalhoSelecionado = AtalhosPDV.REIMPRIMIRPEDIDO;
                        Close();
                        break;
                    case "SALVARRESERVA":
                        AtalhoSelecionado = AtalhosPDV.SALVARRESERVA;
                        Close();
                        break;
                    case "CARREGARRESERVA":
                        AtalhoSelecionado = AtalhosPDV.CARREGARRESERVA;
                        Close();
                        break;
                    case "ABRIRGAVETA":
                        AtalhoSelecionado = AtalhosPDV.ABRIRGAVETA;
                        Close();
                        break;
                }
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
