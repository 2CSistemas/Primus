using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Aplicacao.Base;

namespace Aplicacao
{
    public partial class FormManutImprimeBoletoRemessa : Form
    {
        private Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext();
        private BLL.CarregaProxyBoleto BllICarregaProxyBoleto = new BLL.CarregaProxyBoleto();
        private BLL.ImprimeBoletoRemessa BllImprimeBoletoRemessa = new BLL.ImprimeBoletoRemessa();
        private BLL.Remessa BLLRemessa = new BLL.Remessa();
       
        private Modelo.Remessa ObjRemessa = new Modelo.Remessa();
        private BLL.Documento BllDocumento = new BLL.Documento();
        private List<Modelo.Objeto.pxyDocCobreBem> ListaRows = new List<Modelo.Objeto.pxyDocCobreBem>();
        private int IDEmpresa, IDRemessa, IDNota;
        private int[] Rows;
        private string Docs, Marcados;
        private bool flag;

        public FormManutImprimeBoletoRemessa()
        {
            InitializeComponent();
            lkempresa.ContextoLinq = db;
            lkRemessa.ContextoLinq = db;
            this.Text = "Gerar Boleto";
            btGerarImprimir.Enabled = false;
        }
        public FormManutImprimeBoletoRemessa(int pIDNota)
        {
            InitializeComponent();
            IDNota = pIDNota;
            lkempresa.ContextoLinq = db;
            lkRemessa.ContextoLinq = db;
            DesabilitaBotoes();
            this.Text = "Gerar Boleto";
            btGerarImprimir.Enabled = false;
        }

        private void DesabilitaBotoes()
        {
            lkempresa.Enabled = false;
            lkbtEmpresa.Enabled = false;            
            cbFiltro.Enabled = false;
            txtDataInicial.Enabled = false;
            txtDataFinal.Enabled = false;
            cbTipo.Enabled = false;
            chImpresso.Enabled = false;
            chbEmail.Enabled = false;
            chbPDF.Enabled = false;
            chbRemessa.Enabled = false;
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sbCarregarPedido_Click(object sender, EventArgs e)
        {
            StringBuilder text = new StringBuilder();
            if (IDNota != 0)
            {
                if (lkRemessa.Text == String.Empty)
                    text.AppendLine("Selecione uma Remessa.");
            }
            else
            {
                if (lkempresa.Text == String.Empty)
                    text.AppendLine("Selecione uma Empresa.");
                if (txtDataInicial.Text == String.Empty)
                    text.AppendLine("Selecione uma data inicial.");
                if (txtDataFinal.Text == String.Empty)
                    text.AppendLine("Selecione uma data final.");
                if (cbTipo.Text == String.Empty)
                    text.AppendLine("Selecione um tipo");
                if (txtDataInicial.DateTime > txtDataFinal.DateTime)
                    text.AppendLine("Selecione uma data inicial menor que a data final");
            }

            if (!(text.Length == 0))
            {
                MessageBox.Show(text.ToString(), "Gera Boleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                IDRemessa = lkRemessa.ID;
                IDEmpresa = lkempresa.ID;
                if (cbFiltro.SelectedIndex == 0)
                {
                    gcPedido.DataSource = BllICarregaProxyBoleto.ColetaDocumentosVencimento(IDEmpresa, Convert.ToDateTime(txtDataInicial.Text), Convert.ToDateTime(txtDataFinal.Text), IDRemessa, (cbTipo.SelectedIndex + 1), chImpresso.Checked, chbEmail.Checked, chbPDF.Checked, chbRemessa.Checked);
                }
                else if (cbFiltro.SelectedIndex == 1)
                {
                    gcPedido.DataSource = BllICarregaProxyBoleto.ColetaDocumentosEmissao(IDEmpresa, Convert.ToDateTime(txtDataInicial.Text), Convert.ToDateTime(txtDataFinal.Text), IDRemessa, (cbTipo.SelectedIndex + 1), chImpresso.Checked, chbEmail.Checked, chbPDF.Checked, chbRemessa.Checked);
                }
                else
                {
                    gcPedido.DataSource = BllICarregaProxyBoleto.ColetaDocumentosNota(IDNota, IDRemessa);
                }
                btGerarImprimir.Enabled = Convert.ToBoolean(gvPedidoItem.RowCount);
            }
        }

        private void btGerarImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Rows = gvPedidoItem.GetSelectedRows();

                Marcados = "";

                if (!String.IsNullOrEmpty(Marcados))
                {
                    if (MessageBox.Show("Os boletos ou remessas desses documentos ja foram impressos ou gerados:\n" + Marcados + "\n Desja imprimi-los novamente?", "Boletos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ImprimeBoletos();
                    }
                }
                else
                {
                    ImprimeBoletos();
                }

                gcPedido.DataSource = null;

                if (cbFiltro.SelectedIndex == 0)
                {
                    gcPedido.DataSource = BllICarregaProxyBoleto.ColetaDocumentosVencimento(IDEmpresa, Convert.ToDateTime(txtDataInicial.Text), Convert.ToDateTime(txtDataFinal.Text), IDRemessa, (cbTipo.SelectedIndex + 1), chImpresso.Checked, chbEmail.Checked, chbPDF.Checked, chbRemessa.Checked);
                }
                else if (cbFiltro.SelectedIndex == 1)
                {
                    gcPedido.DataSource = BllICarregaProxyBoleto.ColetaDocumentosEmissao(IDEmpresa, Convert.ToDateTime(txtDataInicial.Text), Convert.ToDateTime(txtDataFinal.Text), IDRemessa, (cbTipo.SelectedIndex + 1), chImpresso.Checked, chbEmail.Checked, chbPDF.Checked, chbRemessa.Checked);
                }
                else
                {
                    gcPedido.DataSource = BllICarregaProxyBoleto.ColetaDocumentosNota(IDNota, IDRemessa);
                }
            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
        }

        private void lkbtEmpresa_Click(object sender, EventArgs e)
        {
            GridPadrao grid = new GridPadrao("Tabela de Empresa", false, 0);
            grid.Show();
            if (grid.Retorno != String.Empty)
            {
                lkRemessa.Focus();
                lkRemessa.EditValue = BLLRemessa.GetCodigoPorID(Convert.ToInt32(grid.Retorno));
                txtDataInicial.Focus();
            }
        }

        private void lkRemessa_EditValueChanged(object sender, EventArgs e)
        {
            gcPedido.DataSource = null;
        }

        private void ImprimeBoletos() 
        {
            ListaRows.Clear();

            for (int i = 0; i < Rows.Length; i++)
            {
                flag = true;
                Modelo.Objeto.pxyDocCobreBem aux = (Modelo.Objeto.pxyDocCobreBem)gvPedidoItem.GetRow(Rows[i]);
                if (!(File.Exists(aux.Logotipo) && File.Exists(aux.ArquivoDeLicensa) && File.Exists(aux.CaminhoLayoutBoleto)))
                {
                    MessageBox.Show("Caminho de imagem, logotipo, arquivo de licensa ou layout do boleto estão incorretos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    flag = false;
                    break;
                }
                ListaRows.Add((Modelo.Objeto.pxyDocCobreBem)gvPedidoItem.GetRow(Rows[i]));
            }

            if (flag)
            {
                FormManutEscolhaBoletos form = new FormManutEscolhaBoletos(ListaRows, lkRemessa.ID);
                form.ShowDialog();

                ListaRows.Clear();
            }
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            gcPedido.DataSource = null;
            btGerarImprimir.Enabled = false;
        }

        private void txtDataInicial_EditValueChanged(object sender, EventArgs e)
        {
            gcPedido.DataSource = null;
            btGerarImprimir.Enabled = false;
        }

        private void txtDataFinal_EditValueChanged(object sender, EventArgs e)
        {
            gcPedido.DataSource = null;
            btGerarImprimir.Enabled = false;
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            gcPedido.DataSource = null;
            btGerarImprimir.Enabled = false;
        }

        private void lkbtRemessa_Click_1(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.Remessa> grid = new GridGenerica<cwkGestao.Modelo.Remessa>(cwkGestao.Negocio.RemessaController.Instancia.GetAll(), new FormRemessa(), lkRemessa.ID != 0 ? cwkGestao.Negocio.RemessaController.Instancia.LoadObjectById(lkRemessa.ID) : null, false) { Selecionando = true };
            grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkRemessa.Focus();
                lkRemessa.Localizar(Convert.ToInt32(grid.Selecionado.ID));
                //lkRemessa.EditValue = BLLRemessa.GetCodigoPorID(Convert.ToInt32(grid.Retorno));
                if (txtDataInicial.Enabled)
                    txtDataInicial.Focus();
                else
                    gcPedido.Focus();
            }
            gcPedido.DataSource = null;
            btGerarImprimir.Enabled = false;
        }

        private void chImpresso_CheckedChanged(object sender, EventArgs e)
        {
            gcPedido.DataSource = null;
            btGerarImprimir.Enabled = false;
        }

        private void chbEmail_CheckedChanged(object sender, EventArgs e)
        {
            gcPedido.DataSource = null;
            btGerarImprimir.Enabled = false;
        }

        private void chbPDF_CheckedChanged(object sender, EventArgs e)
        {
            gcPedido.DataSource = null;
            btGerarImprimir.Enabled = false;
        }

        private void chbRemessa_CheckedChanged(object sender, EventArgs e)
        {
            gcPedido.DataSource = null;
            btGerarImprimir.Enabled = false;
        }
    }
}

