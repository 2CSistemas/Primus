using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Padroes;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormExpedicao : Form
    {
        private Pedido pedido;
        private Dictionary<int, IList<pxyEstoqueIdentificador>> identificadores = new Dictionary<int, IList<pxyEstoqueIdentificador>>();
        private IList<Identificador> ListaIdentificadorParaCancelar = new List<Identificador>();
        private IList<EstoqueIdentificadorExpedicao> objAuxiliar = new List<EstoqueIdentificadorExpedicao>();
        private IList<EstoqueIdentificadorExpedicao> estadoIniEstoqueIdent = new List<EstoqueIdentificadorExpedicao>();

        private pxyEstoqueIdentificador GetIdentificador(Produto produto, string codigoBarra)
        {
            EstoqueIdentificadorExpedicao _aux = new EstoqueIdentificadorExpedicao();

            identificadores.Add(produto.ID, NotaItemController.Instancia.SaldoEstoqueLocalEstoqueListaIdentificador(pedido.LocalEstoquePedido.ID, produto.ID, 0, true));
            var todosIdentificadores = NotaItemController.Instancia.ListaTodosIdentificadores(pedido.LocalEstoquePedido.ID, produto.ID, 0);

            var lista = identificadores[produto.ID];

            var _identificador = new Identificador();

            var proximoIdentificador = lista.FirstOrDefault();

            EstoqueIdentificadorExpedicao EstoqueIdentificadorExpedicao = new EstoqueIdentificadorExpedicao();

            if(proximoIdentificador != null)
               _aux = EstoqueIdentificadorExpedicaoController.Instancia.GetPorIDIdentificador(proximoIdentificador.IdIdentificador);

            if (proximoIdentificador == null)
            {
                identificadores.Clear();
                throw new Exception("Identificador " + codigoBarra + " já verificado, ou não encontrado!");
            }
            _identificador = IdentificadorController.Instancia.LoadObjectById(proximoIdentificador.IdIdentificador);

            if (codigoBarra.IndexOf(proximoIdentificador.Identificador) != 0)
            {
                // Busca o identificador informado pelo usuário
                string inicioAno = DateTime.Now.ToString("yyyy").Substring(0, 2);
                int ano = Convert.ToInt32(inicioAno + codigoBarra.Substring(0, 2));
                int sequencia = Convert.ToInt32(codigoBarra.Substring(2, 3));
                Identificador forcaIdentificador = IdentificadorController.Instancia.getByAnoSequencia(ano, sequencia);
                var identificadorDigitado = todosIdentificadores.Where(i => i.IdIdentificador == forcaIdentificador.ID).FirstOrDefault();
                string mensagem = "";

                if (identificadorDigitado == null)
                {
                    identificadores.Clear();
                    throw new Exception("Não foi possivel recuperar as informações do código de barras "+codigoBarra+", esse código foi gerado por uma versão da aplicação em teste!");
                }

                if (identificadorDigitado.SaldoDisponivel <= 0)
                {
                    mensagem = "O identificador " + codigoBarra + " já não possui mais saldo para conferência, deseja conferi-lo mesmo assim?";
                }
                else
                {
                    mensagem = "O identificador " + codigoBarra + " não esta na sequência, deseja conferi-lo mesmo assim?";
                }

                if (MessageBox.Show("Pelo controle de estoque o próximo código de barras deve iniciar com os seguintes dígitos: " + proximoIdentificador.Identificador +" "+ mensagem, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool usuarioEhGerente = cwkControleUsuario.Facade.getUsuarioLogado.Tipo == 2;
                    if (!usuarioEhGerente)
                    {
                        if (!RequisitaGerente())
                        {
                            identificadores.Clear();
                            return null;
                        }
                    }
                    _aux = EstoqueIdentificadorExpedicaoController.Instancia.GetPorIDIdentificador(forcaIdentificador.ID);
                    _identificador = forcaIdentificador;
                    proximoIdentificador = identificadorDigitado;
                }
                else
                {
                    identificadores.Clear();
                    return null;
                }
            }

            /*
             * Implementada nova regra de controle de saldo de identificador.
             */ 
            if (_aux != null)
            {
                //quardo o estado inicial dos identificadores que estão sendo conferidos para caso o usuário cancele a operação o sistema volte as quantidades iniciais
                if (estadoIniEstoqueIdent.Where(i => i.ID == _aux.ID).FirstOrDefault() == null) 
                {
                    EstoqueIdentificadorExpedicao auxEstadoIni = new EstoqueIdentificadorExpedicao();
                    auxEstadoIni = EstoqueIdentificadorExpedicaoController.Instancia.LoadObjectById(_aux.ID);
                    estadoIniEstoqueIdent.Add(auxEstadoIni);
                }
                    
                _aux.QuantidadeBaixada++;
                _aux.SaldoDisponivel -= 1;
 
                EstoqueIdentificadorExpedicaoController.Instancia.Salvar(_aux, Acao.Alterar);

                objAuxiliar.Add(_aux);
                if (_aux.SaldoDisponivel == 0)
                {
                    _identificador.bVerificado = true;
                    IdentificadorController.Instancia.Salvar(_identificador, Acao.Alterar);
                    identificadores.Clear();
                }
            }
            else
            {
                EstoqueIdentificadorExpedicao.IDIdentificador = _identificador;
                EstoqueIdentificadorExpedicao.QuantidadeBaixada++;
                EstoqueIdentificadorExpedicao.Saldo = proximoIdentificador.Saldo;
                EstoqueIdentificadorExpedicao.SaldoDisponivel = proximoIdentificador.SaldoDisponivel - 1;
                EstoqueIdentificadorExpedicao.CustoUnitario = proximoIdentificador.CustoUnitario;

                EstoqueIdentificadorExpedicaoController.Instancia.Salvar(EstoqueIdentificadorExpedicao, Acao.Incluir);

                //quardo o estado inicial dos identificadores que estão sendo conferidos para caso o usuário cancele a operação o sistema volte as quantidades iniciais
                if (estadoIniEstoqueIdent.Where(i => i.IDIdentificador.ID == EstoqueIdentificadorExpedicao.IDIdentificador.ID).FirstOrDefault() == null)
                {
                    EstoqueIdentificadorExpedicao auxEstadoIni = new EstoqueIdentificadorExpedicao();
                    auxEstadoIni = EstoqueIdentificadorExpedicaoController.Instancia.GetPorIDIdentificador(EstoqueIdentificadorExpedicao.IDIdentificador.ID);
                    auxEstadoIni.QuantidadeBaixada--;
                    auxEstadoIni.SaldoDisponivel++;
                    estadoIniEstoqueIdent.Add(auxEstadoIni);
                }

                objAuxiliar.Add(EstoqueIdentificadorExpedicao);

                if (EstoqueIdentificadorExpedicao.SaldoDisponivel <= 0)
                {
                    _identificador.bVerificado = true;
                    IdentificadorController.Instancia.Salvar(_identificador, Acao.Alterar);
                    identificadores.Clear();
                }
            }
             

            identificadores.Clear();
            return proximoIdentificador;
        }

        public FormExpedicao(Pedido pedido)
        {
            InitializeComponent();

            this.pedido = pedido;

            txtPedido.Text = pedido.Numero.ToString();
            txtCliente.Text = pedido.Pessoa.Nome;

            if (pedido.Status == StatusOrcamento.AguardandoExpedicao || pedido.Status == StatusOrcamento.Expedicao)
                GerarItensExpedicao();

            gcProdutos.DataSource = pedido.ItemsExpedicao;
        }

        private void GerarItensExpedicao()
        {
            int sequencia = 1;

            foreach (var item in pedido.Items)
            {
                var itemExpedicaoExistente = pedido.ItemsExpedicao.Where(p => p.Produto.ID == item.Produto.ID).FirstOrDefault();

                if (itemExpedicaoExistente == null)
                    pedido.ItemsExpedicao.Add(new ExpedicaoItem(item) { Sequencia = sequencia++ });
                else
                    itemExpedicaoExistente.Quantidade = item.Quantidade;
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var param = base.CreateParams;
                param.ClassStyle = param.ClassStyle | 0x200;

                return param;
            }
        }

        private void sbGerar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in objAuxiliar)
                {
                    var obj = EstoqueIdentificadorExpedicaoController.Instancia.LoadObjectById(item.ID);
                    obj.bGravado = true;
                    EstoqueIdentificadorExpedicaoController.Instancia.Salvar(obj, Acao.Alterar);  
                }

                if (TodosItemsConferidos())
                {
                    pedido.Status = StatusOrcamento.AguardandoFaturamento;
                    PedidoController.Instancia.Salvar(pedido, Acao.Alterar);
                }
                else
                {
                    pedido.Status = StatusOrcamento.Expedicao;
                    pedido.UsuarioExpedicao = cwkControleUsuario.Facade.getUsuarioLogado.Login;
                    PedidoController.Instancia.Salvar(pedido, Acao.Alterar);

                    MessageBox.Show("No momento em que todos os itens estiverem conferidos, um novo formulário será aberto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Dispose();
            }
            catch (Exception ex)
            {
                FormErro.ShowDialog(ex);
            }
        }

        private bool TodosItemsConferidos()
        {
            return pedido.ItemsExpedicao.Where(i => i.Conferido == false).Count() == 0;
        }

        private void VoltarEstoqueIdentificadorExpedicaoOriginal(int idIdentificador)
        {
            EstoqueIdentificadorExpedicaoController.Instancia.Salvar(estadoIniEstoqueIdent.Where(i => i.IDIdentificador.ID == idIdentificador).FirstOrDefault(), Acao.Alterar);
        }


        private void sbCancelar_Click(object sender, EventArgs e)
        {
            if (ListaIdentificadorParaCancelar.Count != 0 && objAuxiliar != null)
            {
                foreach (var item in ListaIdentificadorParaCancelar)
                {
                    item.bVerificado = false;
                    IdentificadorController.Instancia.Salvar(item, Acao.Alterar);
                    VoltarEstoqueIdentificadorExpedicaoOriginal(item.ID);
                }               
            }

            this.Dispose();
        }

        private void FormFechamentoFaturas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Expedição");
                    break;
            }
        }

        private void sbAjuda_Click(object sender, EventArgs e)
        {
            this.ChamarHelp();
        }

        private void txtCodigoBarras_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCodigoBarras.Text))
            {
                try
                {
                    var produto = ProdutoController.Instancia.FindByCodigoBarra(txtCodigoBarras.Text);

                    if (produto == null)
                        throw new Exception("Produto não encontrado");

                    var itemExpedicao = pedido.ItemsExpedicao.Where(i => i.Produto.ID == produto.ID).FirstOrDefault();

                    if (itemExpedicao == null)
                        throw new Exception("O produto informado não está presente neste pedido");

                    if (itemExpedicao.Conferido)
                        throw new Exception("O produto informado já está conferido. Verifique a quantidade informada no pedido");

                    produto = ProdutoController.Instancia.LoadObjectById(produto.ID);
                    var codBarra = produto.ProdutoCodBarra.Where(p => p.CodigoBarra == txtCodigoBarras.Text).FirstOrDefault();
                    if (codBarra == null) return;

                    if (codBarra.BControleIdentificacao)
                    {
                        var pedidoItem = pedido.Items.Where(i => i.Produto.ID == produto.ID).FirstOrDefault();
                        var identificador = GetIdentificador(produto, txtCodigoBarras.Text);
                        if (identificador == null)
                        {
                            return;
                        }
                        var _auxIdentificador = IdentificadorController.Instancia.LoadObjectById(identificador.IdIdentificador);

                        //adiciono na lista os identificadores, caso o usuário clique no cancelar,
                        //irei voltar os identificadores para não verificados.
                        ListaIdentificadorParaCancelar.Add(_auxIdentificador);
                        var estoqueItem = pedidoItem.Estoques.Where(p => p.Identificador.ID == identificador.IdIdentificador).FirstOrDefault();

                        if (estoqueItem == null)
                        {
                            estoqueItem = new PedidoItemEstoque { Identificador = new Identificador { ID = identificador.IdIdentificador }, CMVUnit = identificador.CustoUnitario };
                            pedidoItem.Estoques.Add(estoqueItem);
                            estoqueItem.PedidoItem = pedidoItem;
                        }

                        estoqueItem.Quantidade++;
                    }

                    itemExpedicao.QuantidadeConferida++;
                    itemExpedicao.UsuarioExpedicao = cwkControleUsuario.Facade.getUsuarioLogado.Login;
                    itemExpedicao.DataHoraExpedicao = System.DateTime.Now;

                    txtCodigoBarras.Text = String.Empty;

                    gcProdutos.RefreshDataSource();
                }
                catch (Exception ex)
                {
                    identificadores.Clear();
                    FormErro.ShowDialog(ex);
                }
                finally
                {
                    txtCodigoBarras.Focus();
                }
            }
        }
        
        private void FormExpedicao_Shown(object sender, EventArgs e)
        {
            gcProdutos.RefreshDataSource();
        }


        string UltimoLoginGerente = "";
        private bool RequisitaGerente()
        {
            Modelo.Cw_Usuario usuarioLogado = Modelo.cwkGlobal.objUsuarioLogado;
            if (cwkControleUsuario.Facade.getUsuarioLogado.Tipo == 2 || cwkControleUsuario.Facade.LoginGerente())
            {
                UltimoLoginGerente = cwkControleUsuario.Facade.UltimoLoginGerente;
                Modelo.cwkGlobal.objUsuarioLogado = usuarioLogado;
                return true;
            }
            else
            {
                UltimoLoginGerente = String.Empty;
                return false;
            }
        }
    }
}
