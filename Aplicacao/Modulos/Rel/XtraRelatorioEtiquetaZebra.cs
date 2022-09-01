using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Rel
{
    public partial class XtraRelatorioEtiquetaZebra : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraRelatorioEtiquetaZebra(Produto produto)
        {
            InitializeComponent();

            Configuracao objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();

            ovTXT_NomeEmpresa.Text = objConfiguracao.FilialFrenteCaixa.Nome.ToUpper();
            ovTXT_CodigodeBarras.Text = produto.Barra;
            ovTXT_CodigoProduto.Text = produto.Codigo;
            ovTXT_DescricaoProduto.Text = produto.DescLonga1;
            //ovTXT_NomeEmpresa.Text = produto.Codigo;
           // ovTXT_Valor.Text = produto.PrecoBase;
           

        }

    }
}
