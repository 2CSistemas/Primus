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

namespace Aplicacao.Modulos.Telefonia
{
    public partial class GridEnvioFaturaEmLote : Form
    {
        IList<pxyPesquisaTel_Fatura> faturasCarregadas = new List<pxyPesquisaTel_Fatura>();
        IList<pxyPesquisaTel_Fatura> faturasSelecionadas = new List<pxyPesquisaTel_Fatura>();
        bool houveErros = false;
        bool existemSelecionados = false;
        private bool salvar = true;
        private DateTime dataInicial;
        private DateTime dataFinal;
        private DateTime referencia;

        private Tel_GrupoCliente grupoClientes;
        private IList<Tel_Cliente> clientesSelecionados;

        public GridEnvioFaturaEmLote()
        {
            InitializeComponent();
            lkpGrupoCliente.Exemplo = new Tel_GrupoCliente();
            lkpGrupoCliente.Sessao = cwkGestao.Negocio.Tel_GrupoClienteController.Instancia.getSession();
            txtReferencia.EditValue = String.Format("{0:00}/{1:0000}", DateTime.Today.Month, DateTime.Today.Year);
        }

        private bool CamposValidos()
        {
            dxErrorProvider.ClearErrors();

            if ((txtReferencia.EditValue == null) || (txtReferencia.EditValue == ""))
                dxErrorProvider.SetError(txtReferencia, "Campo obrigatório");

            if (lkpGrupoCliente.Selecionado == null)
                dxErrorProvider.SetError(lkpGrupoCliente, "Campo obrigatório");

            return !dxErrorProvider.HasErrors;
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
            IList<object> listaObjFiltrada = new List<object>();
            IList<pxyPesquisaTel_Fatura> listaFiltrada = new List<pxyPesquisaTel_Fatura>();
            listaFiltrada = PegaListaFiltrada(listaObjFiltrada);

            var lista = listaFiltrada;
            if (lista != null)
            {
                foreach (var itemSelecionado in (List<pxyPesquisaTel_Fatura>)lista)
                {
                    itemSelecionado.Selecionado = selecionado;
                }
            }
            gcFaturas.RefreshDataSource();
        }

        private IList<pxyPesquisaTel_Fatura> PegaListaFiltrada(IList<object> listaFiltrada)
        {
            List<pxyPesquisaTel_Fatura> listaDeRetorno = new List<pxyPesquisaTel_Fatura>();
            for (int i = 0; i < gvFaturas.RowCount; i++)
            {
                listaFiltrada.Add(gvFaturas.GetRow(i));
            }

            // convertendo de List<object> para List<pxyPesquisaTel_Fatura>
            listaDeRetorno.AddRange(listaFiltrada.Select(q => (pxyPesquisaTel_Fatura)q));
            return listaDeRetorno;
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

        private bool PodeAprovarRevogar(string acao)
        {
            return MessageBox.Show("Deseja " + acao + " os Documentos selecionados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void GridEnvioFaturaEmLote_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Envio de faturas em Lote");
                    break;

                case Keys.Escape:
                    Sair();
                    break;
            }
        }

        private void sbEmail_Click(object sender, EventArgs e)
        {
            List<pxyPesquisaTel_Fatura> faturasComErro = new List<pxyPesquisaTel_Fatura>();
            faturasSelecionadas = (faturasCarregadas.Where(s => s.Selecionado == true)).ToList();
            clientesSelecionados = faturasSelecionadas.Select(c => c.clienteCarregado).ToList();
            if (faturasSelecionadas.Count <= 0)
            {
                MessageBox.Show("Nenhuma fatura Selecionada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                new FormEnviarFaturaEmailEmLote(faturasSelecionadas, clientesSelecionados, txtReferencia.EditValue.ToString(), ref faturasComErro).ShowDialog();
                if (faturasComErro.Count > 0)
                {
                    gcFaturas.DataSource = faturasComErro;
                }
                gcFaturas.RefreshDataSource();
            }
        }

        private void sbCarregarFaturas_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                Carregarfatura();
            }
        }

        private void Carregarfatura()
        {
            this.referencia = Convert.ToDateTime("01/" + txtReferencia.EditValue);
            dataInicial = referencia;
            dataFinal = new DateTime(referencia.Year, referencia.Month, System.DateTime.DaysInMonth(referencia.Year, referencia.Month));

            grupoClientes = Tel_GrupoClienteController.Instancia.LoadObjectById(((Tel_GrupoCliente)lkpGrupoCliente.Selecionado).ID);
            if (CamposValidos())
            {
                gcFaturas.DataSource = faturasCarregadas
                                     = Tel_FaturaController.Instancia
                                                           .GetPesquisaFaturaEmLote(dataInicial, dataFinal, grupoClientes);


                gcFaturas.RefreshDataSource();

            }
        }

        private void lkbGrupoCliente_Click(object sender, EventArgs e)
        {
            try
            {
                GridGenerica<Tel_GrupoCliente> grid = new GridGenerica<Tel_GrupoCliente>
                                                     (Tel_GrupoClienteController.Instancia.GetAll(), new FormGrupoCliente(), (Tel_GrupoCliente)lkpGrupoCliente.Selecionado, false);
                Tel_GrupoCliente grupo = new Tel_GrupoCliente();
                grid.Selecionando = true;

                if (cwkControleUsuario.Facade.ControleAcesso(grid))
                    grid.ShowDialog();

                if (grid.Selecionado == null)
                {
                    grid.Close();
                }
                else
                {
                    grupo = Tel_GrupoClienteController.Instancia.LoadObjectById(grid.Selecionado.ID);
                    lkpGrupoCliente.Localizar(grupo.ID);
                }
                lkpGrupoCliente.Focus();
            }
            catch (Exception ex)
            {
                throw new Exception("", ex);
            }
        }

        private void gvFaturas_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
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

        private IEnumerable<int> GetIdsFaturasSelecionados()
        {
            return faturasCarregadas.Where(f => f.Selecionado).Select(f => f.IdFatura);
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            List<pxyPesquisaTel_Fatura> faturasComErro = new List<pxyPesquisaTel_Fatura>();
            faturasSelecionadas = (faturasCarregadas.Where(s => s.Selecionado == true)).ToList();
            clientesSelecionados = faturasSelecionadas.Select(c => c.clienteCarregado).ToList();
            if (faturasSelecionadas.Count <= 0)
            {
                MessageBox.Show("Nenhuma fatura Selecionada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                // new FormEnviarFaturaEmailEmLote(faturasSelecionadas, clientesSelecionados, txtReferencia.EditValue.ToString(), ref faturasComErro).ShowDialog();
                var form = new Aplicacao.Modulos.Telefonia.Impressao.FormFiltroImpressaoFaturas(GetIdsFaturasSelecionados().ToList());
                form.Show();
                if (faturasComErro.Count > 0)
                {
                    gcFaturas.DataSource = faturasComErro;
                }
                gcFaturas.RefreshDataSource();
            }
        }
    }
}
