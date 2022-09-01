using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using cwkGestao.Negocio.RelatoriosMatriciais;
using Aplicacao.Base;
using DevExpress.XtraGrid;
using Relatorio.Relatorios;
using System.Reflection;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Threading;

namespace Aplicacao
{
    public partial class FormFaturamentoOrcamentoH : Aplicacao.IntermediariasTela.FormManutOrcamentoIntermediaria
    {

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            //lkbFilial.SubForm = new FormFilial();
            lkbFilial.SubFormType = typeof(FormFilial);
            lkpPessoa.Exemplo = new Pessoa() { BCliente = true };
            lkpPessoa.CamposRestricoesAND = new List<string>() { "bcliente" };
            lkpPessoa.Sessao = PedidoController.Instancia.getSession();
            //lkbTipoPedido.SubForm = new FormTipoPedido();
            lkbTipoPedido.SubFormType = typeof(FormTipoPedido);

            sbGravar.Text = "Excluir";
            sbGravar.Image = Aplicacao.Properties.Resources.Excluir_copy;
            Text = "Lote de Orçamento";
            repositoryItemCheckEdit1.CheckedChanged += new EventHandler(repositoryItemCheckEdit1_CheckedChanged);

        }

        void repositoryItemCheckEdit1_CheckedChanged(object sender, EventArgs e)
        {
            lkpTipoPedido.Focus();
            gcPedidos.Focus();

            gvPedidos.UpdateSummary();
        }
        private void sbCarregarPedido_Click(object sender, EventArgs e)
        {
            CarregarPedidos();
        }

        protected override bool ValidarFormulario()
        {
            dxErroProvider.ClearErrors();

            if (lkpFilial.Selecionado == null)
            {
                dxErroProvider.SetError(lkpFilial, "Selecione uma Filial");
            }

            if (lkpPessoa.Selecionado == null)
            {
                dxErroProvider.SetError(lkpPessoa, "Selecione uma Pessoa");
            }

            if (lkpTipoPedido.Selecionado == null)
            {
                dxErroProvider.SetError(lkpTipoPedido, "Selecione um Tipo de Pedido");
            }

            if (dtInicial.EditValue == null)
            {
                dxErroProvider.SetError(dtInicial, "Selecione uma data de início do período à ser filtrado");
            }

            if (dtFinal.EditValue == null)
            {
                dxErroProvider.SetError(dtFinal, "Selecione uma data de término do período à ser filtrado");
            }

            if (dtInicial.EditValue != null && dtFinal.EditValue != null && (dtInicial.DateTime > dtFinal.DateTime))
            {
                dxErroProvider.SetError(dtInicial, "A data inicial deve ser menor que a data final");
                dxErroProvider.SetError(dtFinal, "A data inicial deve ser menor que a data final");
            }
            return !dxErroProvider.HasErrors;
        }

        private void CarregarPedidos()
        {
            if (!ValidarFormulario())
            {
                return;
            }
            gcPedidos.DataSource =
            PedidoGrid.Converte(PedidoController.Instancia.GetByAllParameters
            ((Pessoa)lkpPessoa.Selecionado, 9999, dtInicial.DateTime, dtFinal.DateTime, (TipoPedido)lkpTipoPedido.Selecionado,
            (Filial)lkpFilial.Selecionado));
            gvPedidos.RefreshData();
            
        }

        protected override void OK()
        {
            if (MessageBox.Show("Deseja excluir os orçamentos selecionados?", "Confirme",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PedidoController.Instancia.RegisterDeleteIntoTransaction(GetPedidosSelecionados());
                try
                {
                    PedidoController.Instancia.CommitUnitOfWorkTransaction();
                    CarregarPedidos();
                }
                catch (Exception exx)
                {
                    new FormErro(exx).ShowDialog();
                }
            }
        }

        private void Imprimir()
        {
            if (!ValidarFormulario())
            {
                return;
            }
            if (GetPedidosIDSelecionados().Count == 0)
            {
                MessageBox.Show("Selecione pelo menos um Pedido/Orçamento para imprimir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("Deseja imprimir orçamentos agrupados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string newmail = "";
                string observacaoEmail = String.Empty;

                CwkMessageBox<cwkGestao.Modelo.DestinoImpressao> ask =
                    new CwkMessageBox<cwkGestao.Modelo.DestinoImpressao>("Destino da impressão",
                                                                         "Selecione a forma de impressão");
                cwkGestao.Modelo.DestinoImpressao di = ask.ShowDialog();
                if (di == cwkGestao.Modelo.DestinoImpressao.Email)
	            {
                    PessoaEmail email = ((Pessoa)lkpPessoa.Selecionado).PessoaEmails.FirstOrDefault();

                    Aplicacao.InputBox input = new InputBox();
                    if (!input.Show(email != null ? email.Email : "", "Email da Pessoa", out newmail))
                        return;
                    if (!input.Show(String.Empty, "Observação Email", out observacaoEmail))
                        return;
	            }
                try
                {
                    IList<int> listaids = GetPedidosIDSelecionados();
                    string ids = String.Empty;
                    foreach (int item in listaids)
                    {
                        ids += item.ToString() + ",";
                    }

                    rptImpressaoOrcamentoLote rpt = new rptImpressaoOrcamentoLote(ids);
                    switch (di)
                    {
                        case cwkGestao.Modelo.DestinoImpressao.Vídeo:
                            rpt.ShowPreview();
                            break;
                        case cwkGestao.Modelo.DestinoImpressao.Impressora:
                            rpt.PrintDialog();
                            break;
                        case cwkGestao.Modelo.DestinoImpressao.Email:
                            string nomeArquivo = String.Empty;
                            if (listaids.Count > 1)
                            {
                                nomeArquivo = "lista_orçamentos_" + DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + ".pdf";
                            }
                            else
                            {
                                nomeArquivo = "pedido_" + listaids.FirstOrDefault().ToString() + ".pdf";
                            }
                            nomeArquivo = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), nomeArquivo);
                            rpt.ExportToPdf(nomeArquivo);
                            Thread.Sleep(2000);
                            EnviarEmail((Filial)lkpFilial.Selecionado, nomeArquivo, newmail, observacaoEmail);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception e)
                {
                    FormErro fe = new FormErro(e);
                    fe.ShowDialog();
                }
            }
        }

        private void EnviarEmail(Filial objFilial, string pNomeArquivo, string pEmailCliente, string corpoMensagem)
        {
            try
            {
                SmtpClient cliente = new SmtpClient(objFilial.ServidorSMTP);
                cliente.Credentials = new NetworkCredential(objFilial.UsuarioEmail, objFilial.SenhaEmail);
                MailMessage mensagem = new MailMessage(new MailAddress(objFilial.UsuarioEmail), new MailAddress(pEmailCliente));
                mensagem.Subject = "Orçamento";
                cliente.Port = objFilial.PortaSmtp;

                mensagem.IsBodyHtml = true;
                mensagem.Body = corpoMensagem.TrimEnd() + "<br><br>Pedido em anexo";

                Attachment arqPedido = new Attachment(pNomeArquivo);
                mensagem.Attachments.Add(arqPedido);

                cliente.Send(mensagem);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao enviar email.\n", ex);
            }
        }

        private List<int> GetPedidosIDSelecionados()
        {
            List<int> idsSelecionados = new List<int>();
            ((IList<PedidoGrid>)gcPedidos.DataSource).Where(item => item.Selecionado).ToList().ForEach(item => idsSelecionados.Add(item.Pedido.ID));
            return idsSelecionados;
        }

        private IList<Pedido> GetPedidosSelecionados()
        {
            List<Pedido> pedidosSelecionados = new List<Pedido>();

            ((IList<PedidoGrid>)gcPedidos.DataSource).Where(item => item.Selecionado).ToList().ForEach(item => pedidosSelecionados.Add(item.Pedido));
            return pedidosSelecionados;
        }
        public enum DestinoImpressao { Vídeo, Matricial, Email, Cancelar }

        class PedidoGrid
        {
            public Pedido Pedido { get; set; }
            public bool Selecionado { get; set; }
            public String Codigo { get { return Pedido.Codigo.ToString(); } }
            public int Numero { get { return Pedido.Numero; } }
            public DateTime Data { get { return Pedido.Dt; } }
            public DateTime Digitacao { get { return Pedido.DtDigitacao; } }
            public decimal QtdItens { get { return Pedido.Items.Count; } }
            public decimal TProdutos { get { return Pedido.TotalProduto; } }
            public decimal Desconto { get { return Pedido.PercDesconto; } }
            public decimal Acrescimo { get { return Pedido.ValorAcrescimo; } }
            public decimal TPedido { get { return Pedido.TotalPedido; } }
            public decimal STributaria { get { return 0; } }
            public decimal TImposto { get { return Pedido.TotalPedido; } }

            public PedidoGrid(Pedido ped)
            {
                this.Pedido = ped;
                this.Selecionado = false;
            }
            public static IList<PedidoGrid> Converte(IList<Pedido> pedidos)
            {
                IList<PedidoGrid> ret = new List<PedidoGrid>();
                foreach (var pedido in pedidos)
                {
                    ret.Add(new PedidoGrid(pedido));
                }
                return ret;
            }
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void lkbPessoa_Click(object sender, EventArgs e)
        {
            var pessoas = PessoaController.Instancia.GetAllClientes();
            var grid = new GridCliente(pessoas, new FormPessoa(), (Pessoa)lkpPessoa.Selecionado, "Cliente", false);

            grid.Selecionando = true;
            grid.ShowDialog();
            if (grid.Selecionado != null)
            {
                lkpPessoa.Localizar(grid.Selecionado.ID);
            }
            lkpPessoa.Focus();
        }

        private void FormFaturamentoOrcamentoH_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F3:
                    OK();
                    break;
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Lote Orçamento");
                    break;
            }
        }

        private void gvPedidos_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            IEnumerable<PedidoGrid> pedidoSelecionados = ((IList<PedidoGrid>)gvPedidos.DataSource).Where(i => i.Selecionado);

            if (((GridColumnSummaryItem)e.Item).FieldName == "QtdItens")
            {
                e.TotalValue = pedidoSelecionados.Sum(i => i.QtdItens);
            }
            else if (((GridColumnSummaryItem)e.Item).FieldName == "TPedido")
            {
                e.TotalValue = pedidoSelecionados.Sum(i => i.TPedido);
            }
            else if (((GridColumnSummaryItem)e.Item).FieldName == "TImposto")
            {
                e.TotalValue = pedidoSelecionados.Sum(i => i.TImposto);
            }
        }

        private void chbSelecionarTodos_CheckedChanged(object sender, EventArgs e)
        {
            ((List<PedidoGrid>)gcPedidos.DataSource).ForEach(p => p.Selecionado = chbSelecionarTodos.Checked);
            gcPedidos.RefreshDataSource();
        }

        private void tpPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
