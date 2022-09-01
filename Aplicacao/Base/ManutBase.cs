using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao.Base
{
    public partial class ManutBase : Form
    {
        #region Atributos
        private int _acao;
        private int _id;
        private string _tabela;
        private Dictionary<string, string> _erro = new Dictionary<string, string>();
        private StringBuilder message = new StringBuilder();


        protected Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext();
        #endregion

        #region Propriedades
        public int cwAcao
        {
            get { return _acao; }
            set { _acao = value; }
        }
        public int cwID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string cwTabela
        {
            get { return _tabela; }
            set { _tabela = value; }
        }
        public Dictionary<string, string> cwErro
        {
            get { return _erro; }
            set { _erro = value; }
        }
        #endregion

        public ManutBase()
        {
            InitializeComponent();

        }

        #region Métodos Privados
        private void ManutBase_Load(object sender, EventArgs e)
        {
            switch (cwAcao)
            {
                case 1:
                    this.Text = "Incluindo registro de " + cwTabela;
                    break;
                case 2:
                    this.Text = "Alterando registro de " + cwTabela;
                    break;
                case 3:
                    this.Text = "Excluindo registro de " + cwTabela;
                    xtraTabControl1.Enabled = false;
                    sbGravar.Text = "&Ok";
                    break;
                case 4:
                    this.Text = "Consultando registro de " + cwTabela;
                    sbGravar.Visible = false;
                    sbGravar.Enabled = false;
                    break;
                default:
                    break;
            }

            CarregaObjeto();
        }
        protected void setErro(Control.ControlCollection pControles)
        {
            string label = "";

            //}
            //foreach (Control ctr in pControles)
            //{
            Control ctr;
            for (int i = 0; i < pControles.Count; i++)
            {
                ctr = pControles[i];

                if ((ctr is DevExpress.XtraTab.XtraTabControl) || (ctr is DevExpress.XtraTab.XtraTabPage) || (ctr is DevExpress.XtraEditors.GroupControl))
                {
                    setErro(ctr.Controls);
                }
                else
                {
                    if ((ctr is DevExpress.XtraEditors.LabelControl) || (ctr is DevExpress.XtraEditors.SimpleButton))
                    {
                        continue;
                    }

                    //errorProvider1.SetError(ctr, "");                    
                    dxErroProvider.SetError(ctr, "");
                    label = "";
                    foreach (KeyValuePair<string, string> erro in cwErro)
                    {
                        if (ctr.Name.ToLower() == erro.Key.ToLower())
                        {
                            dxErroProvider.SetError(ctr, erro.Value);

                            label = EncontraLabel(pControles, ctr);
                            if (label.Length != 0)
                                message.AppendLine(label + " " + erro.Value);
                            break;
                        }
                    }
                }
            }
        }
        private string EncontraLabel(Control.ControlCollection pControles, Control pControle)
        {
            string label = "";

            Control ctr;
            for (int i = 0; i < pControles.Count; i++)
            {
                ctr = pControles[i];
                if ((ctr is DevExpress.XtraTab.XtraTabControl) || (ctr is DevExpress.XtraTab.XtraTabPage) || (ctr is DevExpress.XtraEditors.GroupControl))
                {
                    EncontraLabel(ctr.Controls, pControle);
                }
                else
                {
                    if (ctr.TabIndex == pControle.TabIndex - 1)
                    {
                        label = ctr.Text;
                        break;
                    }
                }
            }

            return label;
        }
        protected virtual void sbGravar_Click(object sender, EventArgs e)
        {
            try
            {
                sbGravar.Enabled = false;
                sbCancelar.Enabled = false;
                cwErro = Salvar();
                if (cwErro == null || cwErro.Count == 0)
                {
                    this.Close();
                }
                else
                {
                    message.Remove(0, message.Length);
                    setErro(this.Controls);
                    if (!String.IsNullOrEmpty(message.ToString()))
                        MessageBox.Show("Verifique Anomalias.\n\n" + message.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (SqlException ex)
            {
                //MessageBox.Show("Problema com o banco de dados: \n" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                new FormErro(ex).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                sbGravar.Enabled = true;
                sbCancelar.Enabled = true;

            }
        }
        protected virtual void sbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected void GridSelecao(GridBase pForm, string ptitulo, Componentes.devexpress.cwk_DevLookup pCb, Modelo.IMetodosCwork gl)
        {
            if (cwkControleUsuario.Facade.ControleAcesso(pForm))
            {
                pForm.ShowDialog();
                if (pForm.atualiza == true)
                {
                    pCb.Properties.DataSource = gl.getListaCombo(db);
                }
                if (pForm.Retorno.Length != 0)
                {
                    pCb.EditValue = int.Parse(pForm.Retorno);
                }
            }
            pCb.Focus();
        }
        protected void GridSelecao(GridPadrao pForm, string ptitulo, Componentes.devexpress.cwk_DevLookup pCb, Modelo.IMetodosCwork gl)
        {
            if (cwkControleUsuario.Facade.ControleAcesso(pForm))
            {
                pForm.ShowDialog();
                if (pForm.atualiza == true)
                {
                    pCb.Properties.DataSource = gl.getListaCombo(db);
                }
                if (pForm.Retorno.Length != 0)
                {
                    pCb.EditValue = int.Parse(pForm.Retorno);
                }
            }
            pCb.Focus();
        }
        #endregion

        #region Métodos Virtuais
        public virtual void CarregaObjeto()
        {
        }
        public virtual Dictionary<string, string> Salvar()
        {
            return cwErro;
        }
        /// <summary>
        /// Método que chama o grid para selecionar um elemento
        /// </summary>
        /// <param name="ptitulo">Título do grid</param>
        /// <param name="pCb">combobox que irá chamar o grid</param>
        /// <param name="gl">objeto que irá retornar a lista para preencher o combo</param>
        protected void GridSelecao(string ptitulo, Componentes.devexpress.cwk_DevLookup pCb, Modelo.IMetodosCwork gl)
        {
            Aplicacao.GridPadrao pGp = new Aplicacao.GridPadrao(ptitulo, true, (int)pCb.EditValue);
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
        #endregion

        private void ManutBase_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F9:
                    if (cwAcao != 4)
                    {
                        ChamaGravar(sender, e);
                    }
                    break;
                case Keys.Enter:
                    if (cwAcao != 4)
                    {
                        if (e.Modifiers != Keys.Control)
                        {
                            ChamaGravar(sender, e);
                        }
                    }
                    break;
                case Keys.Escape:
                    if (MessageBox.Show("Tem certeza de que deseja fechar esta janela sem salvar as alterações?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        sbCancelar.Focus();
                        sbCancelar_Click(sender, e);
                    }
                    break;
            }
        }

        private void ChamaGravar(object sender, KeyEventArgs e)
        {
            if (sbGravar.Enabled)
            {
                sbGravar.Focus();
                sbGravar_Click(sender, e);
            }
        }

        private void ManutBase_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void ucFiltroGridGenerica_Load(object sender, EventArgs e)
        {

        }

        private void sbAjuda_Click(object sender, EventArgs e)
        {

        }
    }
}
