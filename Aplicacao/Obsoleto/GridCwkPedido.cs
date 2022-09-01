using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Linq;
using LicenceLibrary;
using cwkGestao.Modelo.Proxy;
using Aplicacao.Util.Telas;
using Cwork.Utilitarios.Componentes.Mascaras;
using Aplicacao.Base;

namespace Aplicacao
{
    public partial class GridCwkPedido : Aplicacao.Base.GridBase
    {
        CwkPedidoController cwkPedidoController = CwkPedidoController.Instancia;

        public GridCwkPedido(string tabela)
        {
            InicializaTela(tabela);
        }

        private void InicializaTela(string tabela)
        {
            InitializeComponent();
            this.Name = "GridCwkPedido";
            this.Text = tabela;
            this.tabela = tabela;
            arquivo = Modelo.cwkGlobal.objUsuarioLogado.Login + "_" + this.Name.TrimEnd();
            ListaMultiSelect = new List<int>();
            filtro = "";
            Retorno = "";
        }

        protected override void PersonalizaGrid()
        {
            dataGridView1.SortInfo.Clear();
            dataGridView1.SortInfo.ClearSorting();

            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.OptionsView.ColumnAutoWidth = false;

            dataGridView1.Columns["Codigo"].Caption = "Código";
            dataGridView1.Columns["Codigo"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            dataGridView1.Columns["Codigo"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            dataGridView1.Columns["Codigo"].Width = 70;
            dataGridView1.Columns["Codigo"].VisibleIndex = 0;

            dataGridView1.Columns["Data"].Caption = "Data";
            dataGridView1.Columns["Data"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            dataGridView1.Columns["Data"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            dataGridView1.Columns["Data"].Width = 80;
            dataGridView1.Columns["Data"].VisibleIndex = 1;

            dataGridView1.Columns["Hora"].Caption = "Hora";
            dataGridView1.Columns["Hora"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            dataGridView1.Columns["Hora"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            dataGridView1.Columns["Hora"].Width = 60;
            dataGridView1.Columns["Hora"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dataGridView1.Columns["Hora"].DisplayFormat.FormatString = "t";
            dataGridView1.Columns["Hora"].VisibleIndex = 2;

            dataGridView1.Columns["Revenda"].Caption = "Revenda";
            dataGridView1.Columns["Revenda"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            dataGridView1.Columns["Revenda"].Width = 270;
            dataGridView1.Columns["Revenda"].VisibleIndex = 3;

            dataGridView1.Columns["Cliente"].Caption = "Cliente";
            dataGridView1.Columns["Cliente"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            dataGridView1.Columns["Cliente"].Width = 270;
            dataGridView1.Columns["Cliente"].VisibleIndex = 4;

            dataGridView1.Columns["Status"].Caption = "Status";
            dataGridView1.Columns["Status"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            dataGridView1.Columns["Status"].Width = 130;
            dataGridView1.Columns["Status"].VisibleIndex = 5;

            dataGridView1.Columns["NumeroSerie"].Caption = "Nº Série";
            dataGridView1.Columns["NumeroSerie"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            dataGridView1.Columns["NumeroSerie"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            dataGridView1.Columns["NumeroSerie"].Width = 100;
            dataGridView1.Columns["NumeroSerie"].VisibleIndex = 6;

            dataGridView1.Columns["NumeroSerieEmpresas"].Caption = "Nº Série Empresas";
            dataGridView1.Columns["NumeroSerieEmpresas"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            dataGridView1.Columns["NumeroSerieEmpresas"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            dataGridView1.Columns["NumeroSerieEmpresas"].Width = 130;
            dataGridView1.Columns["NumeroSerieEmpresas"].VisibleIndex = 6;

            dataGridView1.Columns["Sistema"].Caption = "Sistema";
            dataGridView1.Columns["Sistema"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            dataGridView1.Columns["Sistema"].Width = 250;
            dataGridView1.Columns["Sistema"].VisibleIndex = 7;

            dataGridView1.Columns["BDemonstracao"].Caption = "Demonstração";
            dataGridView1.Columns["BDemonstracao"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            dataGridView1.Columns["BDemonstracao"].Width = 100;
            dataGridView1.Columns["BDemonstracao"].VisibleIndex = 8;            

            SelecionaRegistroPorPos(dataGridView1.RowCount - 1);
            CarregaLayoutSalvo();
        }

        protected override void CarregarGrid(String pFiltro)
        {
            var lista = cwkPedidoController.GetPedidos();

            try
            {
                gridControl1.DataSource = lista;
                OrdenaGrid("Data", DevExpress.Data.ColumnSortOrder.Ascending);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected override void CarregaFormulario(int pAcao, int pID)
        {
            FormManutPedido form = new FormManutPedido();
            form.cwAcao = pAcao;
            form.cwID = pID;
            form.cwTabela = "Orçamento";
            form.ShowDialog();
        }

        private void btnGerarBanco_Click(object sender, EventArgs e)
        {
            int id = this.RegistroSelecionado();
            if (id > 0)
            {
                cwkGestao.Modelo.CwkPedido cwkPedido = cwkPedidoController.LoadObjectById(id);
                if (cwkPedido.Sistema.Nome.Contains("PONTO"))
                {
                    FormManutGeraBanco form = new FormManutGeraBanco(cwkPedido);
                    form.ShowDialog(this);
                }
                else
                    MessageBox.Show("Operação permitida somente para os sistemas do grupo Cwork Ponto.");
            }
            else
                MessageBox.Show("Nenhum registro selecionado.");    
        }

        private void btnAtestadoPontoMT_Click(object sender, EventArgs e)
        {
            int idPedido = this.RegistroSelecionado();
            if (idPedido > 0)
            {
                if (!cwkPedidoController.TermoResponsabilidade(idPedido))
                    MessageBox.Show("Operação permitida somente para o sistema Cwork Ponto MT.");
            }
        }

        private void btnGerarArquivoLicenca_Click(object sender, EventArgs e)
        {

            DialogResult res = saveFileDialog1.ShowDialog();
            String filename = saveFileDialog1.FileName;
            CwkPedidoEmpresa cwkPedidoEmpresa = CwkPedidoController.Instancia.LoadObjectById(RegistroSelecionado()).CwkPedidoEmpresas.FirstOrDefault();
            if (cwkPedidoEmpresa != null)
            {
                ArquivoLicenca arquivoLicenca = ArquivoLicenca.Deserialize(cwkPedidoEmpresa.ArquivoLicencaSerializado);
                arquivoLicenca.Demonstracao = cwkPedidoEmpresa.Pedido.BDemonstracao;
                if (res == DialogResult.OK)
                {
                    cwkEncriptacao.EncriptadorTripleDES.EncryptAndSerializeToXmlFile(filename, arquivoLicenca);
                    ArquivoLicenca bla =
                        (ArquivoLicenca)
                        cwkEncriptacao.EncriptadorTripleDES.DecryptAndDeserializeXmlFile(filename,
                                                                                         typeof (ArquivoLicenca));
                    MessageBox.Show("Arquivo gerado com sucesso.");
                }
            }
            else
                MessageBox.Show("Pedido não possui arquivos de licença.");
        }

        private void btnGerarLicenca_Click(object sender, EventArgs e)
        {
            int id = this.RegistroSelecionado();
            if (id > 0)
            {
                string quantidade = "1";
                if (FormInputBox.InputBox("Gerar Pacote de Licença", "Quantidade", ref quantidade, Mascara.NUMERAL) == DialogResult.OK)
                {
                    int qtd = 0;
                    try
                    {
                        qtd = Convert.ToInt32(quantidade);
                        if (qtd > 0)
                        {
                            cwkPedidoController.GerarLicenca(id, qtd);
                            CarregarGrid("");
                        }
                        else
                        {
                            MessageBox.Show("Quantidade para gerar pacote de licença deve ser maior que 0");
                        }
                    }
                    catch (Exception ex)
                    {
                        FormErro formErro = new FormErro("A quantidade para geração de licença deve ser numérico!", " Erro: "+ex.Message);
                        formErro.ShowDialog();
                    }
                }
            }
            else
                MessageBox.Show("Nenhum registro selecionado.");
        }

        private void FormErro(string p)
        {
            throw new NotImplementedException();
        }

        public  void GridCwkPedido_Load(object sender, EventArgs e)
        {
            MaximizeBox = true;
        }
    }
}
