using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Negocio;
using DevExpress.XtraGrid;
using System.IO;
using Ionic.Zip;
using cwkGestao.Negocio.Utils;
using Aplicacao.Modulos.Financeiro;
using Aplicacao.Interfaces;
using System.Reflection;
using System.Drawing;

namespace Aplicacao.Modulos.Comercial
{
    public partial class GridAprovacaoPedido : Form, IFormGrid
    {
        private bool layoutNovo = false;
        private readonly IList<TupleIFormGrid> grids = new List<TupleIFormGrid>();
        public IList<TupleIFormGrid> Grids { get { return grids; } }
        public DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler CustomSort { get; set; }

        bool houveErros = false;
        bool existemSelecionados = false;
        private bool salvar = true;
        IList<Pedido> listaDeObjetosSelecionados = new List<Pedido>();

        public GridAprovacaoPedido(IList<Pedido> pedidosParaAprovar)
        {
            InitializeComponent();
            gcAprovacaoPedido.DataSource = pedidosParaAprovar;

            VerificaExistenciaXMLLayout();
        }

        private void VerificaExistenciaXMLLayout()
        {
            grids.Add(new TupleIFormGrid
            {
                View = gvAprovacaoPedido,
                Control = gcAprovacaoPedido,
                Tipo = typeof(Pedido),
                XmlLayout = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)+"\\Telas\\Grid"  + new System.Text.RegularExpressions.Regex("[\\\\|:/*?\"><]").Replace(Text, "") + "_" + cwkControleUsuario.Facade.getUsuarioLogado.Login + ".xml"
            });
        } 
        
        private void sbSelecionarTodos_Click(object sender, EventArgs e)
        {
            AlterarSelecaoPedidos(true);
        }

        private void sbLimparSelecao_Click(object sender, EventArgs e)
        {
            AlterarSelecaoPedidos(false);
        }

        private void AlterarSelecaoPedidos(bool selecionado)
        {
            var lista = gcAprovacaoPedido.DataSource;
            if (lista != null)
            {
                foreach (var itemSelecionado in (List<Pedido>)lista)
                {
                    itemSelecionado.Selecionado = selecionado;
                }
            }
            gcAprovacaoPedido.RefreshDataSource();
        }

                             
        private void sbAjuda_Click(object sender, EventArgs e)
        {
            this.ChamarHelp();
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void Sair()
        {
            this.Close();
        }

        private void GridAprovacaoPedido_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Aprovação de Pedidos");
                    break;

                case Keys.Escape:
                    Sair();
                    break;

                case Keys.Delete:
                    if (Form.ModifierKeys == Keys.Control)
                    {
                        salvar = false;
                        this.DeletarLayoutGrids();
                    }
                    break;
                case Keys.F5:

                    var Peds = PedidoController.Instancia.GetPedidosParaAprovar();
                    gcAprovacaoPedido.DataSource = Peds;
                    gcAprovacaoPedido.RefreshDataSource();
                    break;
              }
        }

      
        private void sbConsultar_Click(object sender, EventArgs e)
        {
            FormOrcamento formOrcamento = new FormOrcamento(cwkGestao.Modelo.InOutType.Saída);
            Pedido registroSelecionado = PegaRegistroSelecionado();

            if (registroSelecionado != null)
            {
                formOrcamento.Selecionado = registroSelecionado;
                formOrcamento.Operacao = cwkGestao.Modelo.Acao.Consultar;
                formOrcamento.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private Pedido PegaRegistroSelecionado()
        {
            Pedido pedido = new Pedido();
            try
            {
                pedido = (Pedido)gvAprovacaoPedido.GetRegistroSelecionado();
                return pedido;
            }
            catch (IndexOutOfRangeException e)
            {
                return null;
            }
        }

        private void sbAprovar_Click(object sender, EventArgs e)
        {
            Modelo.Cw_Usuario usuarioLogado = Modelo.cwkGlobal.objUsuarioLogado; 
            existemSelecionados = false;
            houveErros = false;

            if (VerificaSelecionado((List<Pedido>)gcAprovacaoPedido.DataSource))
            {
                List<int> idsListaDeObjetosSelecionados = ((List<Pedido>)gcAprovacaoPedido.DataSource).Where(s => s.Selecionado == true).Select(s => s.ID).ToList();

                listaDeObjetosSelecionados = PedidoController.Instancia.LoadAllByID(idsListaDeObjetosSelecionados);
                existemSelecionados = listaDeObjetosSelecionados != null && listaDeObjetosSelecionados.Count() > 0 ? true : false;
                try
                {
                    StringBuilder erros = new StringBuilder();
                    if (existemSelecionados)
                    {
                        if (PodeAprovarRevogar("Aprovar"))
                        {
                            foreach (var item in listaDeObjetosSelecionados)
                            {
                                if ((item.StatusExibicao == "Aguardando Aprovação") && (item.Status == StatusOrcamento.AguardandoAprovacao))
                                {
                                    if (item.TipoPedido.StatusPosAprovacao == 6)
                                    {
                                        item.Status = StatusOrcamento.AguardandoExpedicao;
                                        item.UsuarioAprovacao = usuarioLogado.Login;
                                        item.dtAprovacao = DateTime.Now;
                                        PedidoController.Instancia.Salvar(item, Acao.Alterar);
                                    }
                                    else if (item.TipoPedido.StatusPosAprovacao == 8)
                                    {
                                        item.Status = StatusOrcamento.AguardandoFaturamento;
                                        item.UsuarioAprovacao = usuarioLogado.Login;
                                        item.dtAprovacao = DateTime.Now;
                                        PedidoController.Instancia.Salvar(item, Acao.Alterar);
                                    }
                                    try
                                    {
                                        if (SHLUtil.UsarSHL() && !(item.CodShl > 0))
                                        {
                                            SHLUtil.EnviarPedidosSHL((Pedido)item);
                                        }
                                        else if (item.CodShl > 0)
                                        {
                                            MessageBox.Show("O pedido já foi enviado para SHL. Os dados do mesmo não foram atualizados no SHL.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                    catch (Exception x)
                                    {

                                        erros.AppendLine("Ocorreu um erro na comunicação com o Webservice SHL: " + x.Message);
                                    }
                                }
                                else
                                {
                                    houveErros = true;
                                }
                            }
                            if (!String.IsNullOrEmpty(erros.ToString()))
                            {
                                MessageBox.Show("Ocorreram erros na sincronia com a SHL: \r\n" + erros.ToString() + "\r\n" +
                                    "Os pedidos serão inseridos em sincronia pendente.",
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    MessageBox.Show("Documentos aprovados com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var Peds = PedidoController.Instancia.GetPedidosParaAprovar();
                    gcAprovacaoPedido.DataSource = Peds;
                    gcAprovacaoPedido.RefreshDataSource();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool PodeAprovarRevogar(string acao)
        {
            return MessageBox.Show("Deseja " + acao + " os Documentos selecionados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void sbRevogar_Click(object sender, EventArgs e)
        {
            Modelo.Cw_Usuario usuarioLogado = Modelo.cwkGlobal.objUsuarioLogado;
            existemSelecionados = false;
            houveErros = false;

            if (VerificaSelecionado((List<Pedido>)gcAprovacaoPedido.DataSource))
            {
                List<int> idsListaDeObjetosSelecionados = ((List<Pedido>)gcAprovacaoPedido.DataSource).Where(s => s.Selecionado == true).Select(s => s.ID).ToList();

                listaDeObjetosSelecionados = PedidoController.Instancia.LoadAllByID(idsListaDeObjetosSelecionados);
                existemSelecionados = listaDeObjetosSelecionados != null && listaDeObjetosSelecionados.Count() > 0 ? true : false;
                try
                {
                    if (existemSelecionados)
                    {
                        if (PodeAprovarRevogar("Revogar"))
                        {
                            foreach (var item in listaDeObjetosSelecionados)
                            {
                                if ((item.StatusExibicao != "Aguardando Aprovação") && (item.Status != StatusOrcamento.AguardandoAprovacao))
                                {
                                    item.Status = StatusOrcamento.AguardandoAprovacao;
                                    item.UsuarioRevogacao = usuarioLogado.Login;
                                    item.dtRevogacao = DateTime.Now;
                                    PedidoController.Instancia.Salvar(item, Acao.Alterar);
                                }
                                else
                                {
                                    houveErros = true;
                                }
                            }
                            if (houveErros)
                            {
                                MessageBox.Show("Alguns documentos selecionados não foram revogados pois não tinham sido aprovados anteriormente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }

                    MessageBox.Show("Documentos reprovados com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gcAprovacaoPedido.DataSource = PedidoController.Instancia.GetPedidosParaAprovar();
                    gcAprovacaoPedido.RefreshDataSource();

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        private bool VerificaSelecionado(List<Pedido> listaDeObjetosSelecionados)
        {
            bool retorno = false;
            if (listaDeObjetosSelecionados == null)
            {
                MessageBox.Show("Nenhum documento selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var documentosSelecionados = listaDeObjetosSelecionados.Where(n => n.Selecionado == true).ToList();
                if (documentosSelecionados.Count == 0)
                    MessageBox.Show("Nenhum documento selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    retorno = true;
            }
            return retorno;
        }

        private void GridAprovacaoPedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (salvar)
                this.SalvarLayoutGrids();
        }



        private void GridAprovacaoPedido_Load(object sender, EventArgs e)
        {
            try
            {
                this.CarregarLayoutSalvo();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
          
        }

        private void gvAprovacaoPedido_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            Bitmap groupPanelImage;
            groupPanelImage = (Bitmap)Aplicacao.Properties.Resources.HeaderGrid;
            groupPanelImage.MakeTransparent();
            Brush brush = e.Cache.GetGradientBrush(e.Bounds, Color.White, Color.WhiteSmoke,
              System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(brush, e.Bounds);
            Image img = groupPanelImage;
            Rectangle r = new Rectangle(e.Bounds.X + e.Bounds.Width - img.Size.Width - 5,
              e.Bounds.Y + (e.Bounds.Height - img.Size.Height) / 2, img.Width, img.Height);
            e.Graphics.DrawImageUnscaled(img, r);
            e.Handled = true;
        }
    }
}
