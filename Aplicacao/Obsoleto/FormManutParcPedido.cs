using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aplicacao
{
    public partial class FormManutParcPedido : Form
    {
        Modelo.DataClassesDataContext db;
        //Variável da Acao da Tela
        int acao;
        decimal valorant = 0;

        Modelo.TipoDocumento objTipoDoc;
        BLL.PedidoParcela bllPedidoParcela;

        Modelo.Pedido objPedido;
        Modelo.PedidoParcela objPedidoParcela;

        public FormManutParcPedido(Modelo.DataClassesDataContext pdb, int pAcao, int pSeq, Modelo.Pedido pPedido)
        {
            InitializeComponent();
            this.acao = pAcao;
            this.db = pdb;
            objPedido = pPedido;

            objTipoDoc = new Modelo.TipoDocumento();
            bllPedidoParcela = new BLL.PedidoParcela();

            cbTipoDoc.Properties.DataSource = objTipoDoc.getListaCombo(db);
            cbTipoDoc.Properties.DisplayMember = "Nome";
            cbTipoDoc.Properties.ValueMember = "ID";

            if (pSeq != 0)
            {
                objPedidoParcela = (from p in pPedido.PedidoParcelas
                                    where p.Parcela == pSeq
                                    select p).Single();

                txtParcela.EditValue = objPedidoParcela.Parcela;
                txtVencimento.DateTime = (DateTime)objPedidoParcela.Vencimento;
                txtValor.EditValue = objPedidoParcela.Valor;
//#582b                
                txtAgencia.EditValue = objPedidoParcela.NumAgencia;
                txtCC.EditValue = objPedidoParcela.NumContaCorrente;
                txtCpfCnpj.EditValue = objPedidoParcela.CpfCnpj;
                txtEmitente.EditValue = objPedidoParcela.Emitente;
                txtNomeBanco.EditValue = objPedidoParcela.NomeBanco;
                txtNumBanco.EditValue = objPedidoParcela.NumBanco;
                txtNumCheque.EditValue = objPedidoParcela.NumCheque;
//#582e
                cbTipoDoc.EditValue = objPedidoParcela.TipoDocumento.ID;
                chkEntrada.EditValue = objPedidoParcela.bEntrada == 1 ? true : false;
                valorant = (decimal)objPedidoParcela.Valor;

                this.Text = "Alterando parcela do Pedido";
                if (acao == 3)
                {
                    foreach (Control campo in this.Controls)
                    {
                        if ((campo is TextBox) || (campo is ComboBox) || (campo is GroupBox) || (campo is DevExpress.XtraTab.XtraTabControl))
                        {
                            campo.Enabled = false;
                        }
                    }
                    this.Text = "Excluindo parcela do Pedido";
                    btSalvar.Text = "&OK";
                }
                else
                {
                    if (acao == 4)
                    {
                        this.Text = "Consultando parcela do Pedido";
                        btSalvar.Enabled = false;
                        btSalvar.Visible = false;
                    }
                }
            }
            else
            {
                this.Text = "Incluindo parcela do Pedido";

                objPedidoParcela = new Modelo.PedidoParcela();

                objPedidoParcela.Parcela = objPedido.PedidoParcelas.Count + 1;
                objPedidoParcela.Vencimento = objPedido.Dt;
                objPedidoParcela.Valor = 0;
                valorant = (decimal)objPedidoParcela.Valor;

                txtParcela.EditValue = objPedidoParcela.Parcela;
                txtVencimento.DateTime = (DateTime)objPedidoParcela.Vencimento;
                txtValor.EditValue = objPedidoParcela.Valor;
                cbTipoDoc.EditValue = 0;
                chkEntrada.EditValue = false;
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (acao != 3)
                {
                    if (bllPedidoParcela.Valida(errorProvider1, this.Controls) == false)
                    {
                        throw new Exception("Verificar Anomalias");
                    }
                }

                
                objPedidoParcela.Parcela = (int)txtParcela.Value;
                objPedidoParcela.bEntrada = chkEntrada.Checked == true ? (byte)(1) : (byte)0;
                objPedidoParcela.TipoDocumento = (Modelo.TipoDocumento)objTipoDoc.getObjeto(db, (int)cbTipoDoc.EditValue);
                objPedidoParcela.Vencimento = txtVencimento.DateTime;
                objPedidoParcela.Valor = (Decimal)txtValor.EditValue;
                //#582b
                objPedidoParcela.Emitente = txtEmitente.Text;
                objPedidoParcela.CpfCnpj = txtCpfCnpj.Text;
                objPedidoParcela.NumAgencia = txtAgencia.Text;
                objPedidoParcela.NumBanco = txtNumBanco.Text;
                objPedidoParcela.NumCheque = txtNumCheque.Text;
                objPedidoParcela.NumContaCorrente = txtCC.Text;
                objPedidoParcela.NomeBanco = txtNomeBanco.Text;

                

                if (objPedido.PedidoParcelas.OrderBy(u => u.Vencimento).First().Vencimento.Value.CompareTo(objPedidoParcela.Vencimento) == 0 &&(
                    txtAgencia.EditValue != null ||
                    txtCC.EditValue != null ||
                    txtCpfCnpj.EditValue != null ||
                    txtEmitente.EditValue != null ||
                    txtNomeBanco.EditValue != null ||
                    txtNumBanco.EditValue != null ||
                    txtNumCheque.EditValue != null))
                {
                    if (MessageBox.Show("Replicar informações de cheque nas outras parcelas?", "Replicação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int difSerie = 0;
                        foreach (Modelo.PedidoParcela item in objPedido.PedidoParcelas)
                        {

                            item.Emitente = txtEmitente.Text;
                            item.CpfCnpj = txtCpfCnpj.Text;
                            item.NumAgencia = txtAgencia.Text;
                            item.NumBanco = txtNumBanco.Text;
                            if (txtNumCheque.Text.Trim().Length > 0)
                                item.NumCheque = (Convert.ToInt32(txtNumCheque.Text) + difSerie++).ToString();
                            item.NumContaCorrente = txtCC.Text;
                            item.NomeBanco = txtNomeBanco.Text;
                        }
                    }

                }

                //#582e                

                if ((decimal)objPedidoParcela.Valor != valorant)
                {
                    objPedidoParcela.bAlterado = 1;
                }

                if (acao == 1)
                    objPedido.PedidoParcelas.Add(objPedidoParcela);

                bllPedidoParcela.Dispose();

                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(Modelo.MetodosEstaticos.SqlExcecao(ex), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridSelecao(string ptitulo, Componentes.devexpress.cwk_DevLookup pCb, Modelo.IMetodosCwork gl)
        {
            GridPadrao pGp = new GridPadrao(ptitulo, true, (int)pCb.EditValue);
            if (cwkControleUsuario.Facade.ControleAcesso(pGp))
            {
                pGp.ShowDialog();
                if (pGp.atualiza == true)
                {
                    pCb.Properties.DataSource = gl.getListaCombo(db);
                }
                if (pGp.Retorno.Length != 0)
                {
                    pCb.EditValue = int.Parse(pGp.Retorno);
                }
            }
            pCb.Focus();
        }

        private void btTipoDocumento_Click(object sender, EventArgs e)
        {
            cwkGestao.Modelo.TipoDocumento tipoDocumentoSelecionado = null;
            if ((int)cbTipoDoc.EditValue > 0)
                tipoDocumentoSelecionado = cwkGestao.Negocio.TipoDocumentoController.Instancia.LoadObjectById((int)cbTipoDoc.EditValue);

            GridGenerica<cwkGestao.Modelo.TipoDocumento> grid = new GridGenerica<cwkGestao.Modelo.TipoDocumento>(cwkGestao.Negocio.TipoDocumentoController.Instancia.GetAll(), new FormTipoDocumento(), tipoDocumentoSelecionado, false);
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            {
                grid.Selecionando = true;
                grid.ShowDialog();

                if (grid.Selecionado != null)
                {
                    cbTipoDoc.EditValue = grid.Selecionado.ID;
                    cbTipoDoc.Properties.DataSource = objTipoDoc.getListaCombo(db);
                }
            }
            cbTipoDoc.Focus();
        }

        private void FormManutParcPedido_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F9:
                    if (acao != 4)
                    {
                        btSalvar_Click(sender, e);
                    }
                    break;
                case Keys.Escape:
                    btCancelar_Click(sender, e);
                    break;
            }
        }
    }
}
