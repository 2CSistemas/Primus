using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Rel
{
    public partial class XRReportResponsavelPorCliente : DevExpress.XtraReports.UI.XtraReport
    {
        public XRReportResponsavelPorCliente(DataTable dt)
        {
            InitializeComponent();
            Configuracao objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();

            try
            {
                xrPictureBox1.Image = Image.FromFile(objConfiguracao.Filial.CaminhoLogoEmpresa);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("O Logotipo da Empresa não está definido",
                    "Aviso", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
            }
            
            

            ovTXT_Empresa.Text = objConfiguracao.Filial?.Nome.ToUpper();
            ovTXT_Endereco.Text = $"{objConfiguracao.Filial?.Endereco}, {objConfiguracao.Filial?.Numero}, {objConfiguracao.Filial?.Bairro}, Cep: {objConfiguracao.Filial?.CEP} - {objConfiguracao.Filial?.Cidade} {objConfiguracao.Filial?.Cidade?.UF.Sigla}".ToUpper();
            ovTXT_CnpjInscricao.Text = objConfiguracao.Filial?.CNPJ;
            TXT_IE.Text = objConfiguracao.Filial?.Inscricao;
            ovTXT_Telefone.Text = objConfiguracao.Filial?.Telefone?.ToUpper();
            ovTXT_Site.Text = objConfiguracao.Filial?.Site?.ToUpper();

            dt.TableName = "DADOS";
            ovDS_Dados.Clear();
            ovDS_Dados.Tables.Clear();
            ovDS_Dados.Tables.Add(dt);
        }
    }
}