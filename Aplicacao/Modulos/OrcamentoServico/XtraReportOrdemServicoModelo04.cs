using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using cwkGestao.Negocio;
using System.Data;
using System.Linq;
using DevExpress.XtraReports.UI;
using Modelo;

namespace Aplicacao.Modulos.OrcamentoServico
{
    public partial class XtraReportOrdemServicoModelo04 : DevExpress.XtraReports.UI.XtraReport
    {
        //private Modelo.OrcamentoServico orcamentoServico = null;
        public XtraReportOrdemServicoModelo04()
        {
            InitializeComponent();
            //orcamentoServico = OrcamentoServico;
            //Configuracao objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();
            //
            //// Rotina para carregar a foto
            //string arquivoExe = Assembly.GetEntryAssembly().Location;
            //string caminho = Path.Combine(Path.GetDirectoryName(arquivoExe), "");
            //try
            //{
            //    xrPictureBox1.Image = Image.FromFile(caminho + "\\LogoEmpresa.jpg");
            //}
            //catch (Exception e)
            //{
            //    System.Windows.Forms.MessageBox.Show("O Logotipo da Empresa não está definido",
            //        "Aviso", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
            //}
            //
            //#region Empresa
            //
            //ovTXT_Empresa.Text = objConfiguracao.Filial?.Nome.ToUpper();


            //#endregion

        }

    }
}
