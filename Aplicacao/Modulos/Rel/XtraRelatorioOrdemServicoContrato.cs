using System;
using System.Drawing;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Data;
using System.Linq;

namespace Aplicacao.Modulos.Rel
{
    public partial class XtraRelatorioOrdemServicoContrato : DevExpress.XtraReports.UI.XtraReport
    {
        private OrdemServico osSelecionado = null;
        public XtraRelatorioOrdemServicoContrato(OrdemServico ordemServico)
        {
            InitializeComponent();
            osSelecionado = ordemServico;
            Configuracao objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();

            // Rotina para carregar foto
            //Pedido.(PedidoID);
            try
            {
               // xrPictureBox1.Image = Image.FromFile(ordemServico.Filial?.CaminhoLogoEmpresa ?? objConfiguracao.Filial?.CaminhoLogoEmpresa);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("O Logotipo da Empresa não está definido",
                    "Aviso", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
            }


            // Rotina para impressão dos 03 modelos do mesmo relatório de OS
            // 01 - Impresão Normal
            // 02 - Impressão para Produção
            // 03 - Impressão para Contrato de OS

            

            #region Empresa

            TXT_RazaoSocialEmpresa.Text = objConfiguracao.Filial?.Nome.ToUpper();
            TXT_NomeFantasiaEmpresa.Text = objConfiguracao.Filial?.Fantasia.ToUpper();
            TXT_CNPJEmpresa.Text = objConfiguracao.Filial?.CNPJ;
            TXT_EnderecoEmpresa.Text = objConfiguracao.Filial?.Endereco;
            TXT_CepCidadeEmpresa.Text = $"Cep: {objConfiguracao.Filial?.CEP}, {objConfiguracao.Filial?.Cidade}".ToUpper();
            TXT_FoneEmpresa.Text = objConfiguracao.Filial?.Telefone;

            TXT_RazaoSocialEmpresa02.Text = objConfiguracao.Filial?.Nome.ToUpper();
            TXT_RazaoSocialEmpresa03.Text = objConfiguracao.Filial?.Nome.ToUpper();
            TXT_EnderecoEmpresa02.Text = $"{objConfiguracao.Filial?.Endereco}, {objConfiguracao.Filial?.CEP}," +
                                         $"{objConfiguracao.Filial?.Cidade},{objConfiguracao.Filial?.Telefone},";


            #endregion

            #region Dados do Cliente

            TXT_RazalSocialCliente.Text = ordemServico.IDCliente.ToString();
            TXT_NomeFantasiaCliente.Text =
            TXT_NomeFantasiaCliente.Text =
            TXT_CNPJCliente.Text =
            TXT_TelefoneCliente.Text =
            TXT_EnderecoNumeroCliente.Text =
            TXT_BairroCliente.Text =
            TXT_CepCliente.Text =
            TXT_CidadeCliente.Text =
            TXT_ContatoNomeCliente.Text =
            TXT_EmailCliente.Text =

            #endregion

            #region Dados do Vendedor

            TXT_NomeVendedor.Text =

            #endregion

            //#region Itens

            //DataTable dt = new DataTable();
            //dt.Columns.Add("item");
            //dt.Columns.Add("quantidade", typeof(decimal));
            //dt.Columns.Add("codigo");
            //dt.Columns.Add("descricao");
            //dt.Columns.Add("medida", typeof(decimal));
            //dt.Columns.Add("unitario", typeof(decimal));
            //dt.Columns.Add("total", typeof(decimal));
            //dt.Columns.Add("valortotal", typeof(decimal));

            //foreach (var item in ordemServico.Itens)
            //{
            //    var Row = dt.NewRow();
            //    Row["item"] = item();
            //    Row["quantidade"] = item();
            //    Row["codigo"] = item();
            //    Row["descricao"] = item();
            //    Row["medida"] = item();
            //    Row["unitario"] = item();
            //    Row["total"] = item();
            //    Row["valortotal"] = item();
            //}

            //dsOsContrato.Tables.Clear();
            //dt.TableName = "dados";
            //dsOsContrato.Tables.Add(dt);

            //#endregion

            #region Dados da OS

            TXT_NumeroOS.Text = ordemServico.Codigo.ToString();

            #endregion

        }
    }
}
