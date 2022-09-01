using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using LicenceLibrary;

namespace Aplicacao
{
    public partial class UCLicencaChave : UserControl
    {
        public cwkGestao.Modelo.Sistema Sistema
        {
            get { return (cwkGestao.Modelo.Sistema)lkpSistema.Selecionado; }
            set
            {
                cbTabela.Properties.Items.Clear();
                cbModulo.Properties.Items.Clear();
                lkpSistema.EditValue = value;
                LicenceLibrary.Sistema sis = GetSistema(value);
                if (sis != LicenceLibrary.Sistema.Nenhum)
                {
                    cbTabela.Properties.Items.AddRange(LicenceLibrary.TabelaResolver.Resolve(sis));
                    cbModulo.Properties.Items.AddRange(LicenceLibrary.ModuloResolver.Resolve(sis));
                    this.EnableCampos(true);
                }
                else
                    this.EnableCampos(false);
            }
        }

        private LicenceLibrary.Sistema GetSistema(cwkGestao.Modelo.Sistema Sistema)
        {
            try
            {
                return (LicenceLibrary.Sistema)((cwkGestao.Modelo.Sistema)lkpSistema.Selecionado).SistemaLicenca;
            }
            catch
            {
                return LicenceLibrary.Sistema.Nenhum;
            }
        }

        public Versao Versao
        {
            get
            {
                return (Versao)lkpVersao.EditValue;
            }
            set
            {
                lkpVersao.EditValue = value;
            }
        }

        public bool Demonstracao
        {
            set { chDemonstracao.Checked = value; }
        }

        public List<KeyValuePair<String, int>> LimiteTabela;

        public List<String> Modulos;

        private string _arquivoLicencaSerializado;

        public String ArquivoLicencaSerializado
        {
            get
            {
                if (!DesignMode)
                    GeraArquivoLicenca();
                return _arquivoLicencaSerializado;
            }
            set
            {
                _arquivoLicencaSerializado = value;
                if (!String.IsNullOrEmpty(value) && value.Length > 2)
                {
                    ArquivoLicenca al = ArquivoLicenca.Deserialize(value);
                    txtQtdMaquinas.EditValue = al.QtdMaquinas;
                    txtCodigoHw.EditValue = al.IdHardwareServidor;
                    txtDataExpiracao.EditValue = al.DataExpiracao;
                    txtLimiteReg.EditValue = 0;
                    LimiteTabela = new List<KeyValuePair<string, int>>();
                    Modulos = new List<string>();
                    foreach (var item in al.QtdMaxRegistrosPorTabela.Keys)
                    {
                        LimiteTabela.Add(new KeyValuePair<string, int>(item, al.QtdMaxRegistrosPorTabela[item]));
                    }
                    gcLimiteTabelas.DataSource = LimiteTabela;
                    gvLimiteTabelas.RefreshData();
                    foreach (string modulo in al.ModulosLiberados)
                    {
                        Modulos.Add(modulo);
                    }
                    gcModulos.DataSource = Modulos;
                    gvModulos.RefreshData();
                }
            }
        }

        public String NumeroSerie {             
            get
            {
                return txtNumSerie.Text;
            }
            set
            {
                txtNumSerie.Text = value.ToString();
            }
        }

        public UCLicencaChave()
        {
            InitializeComponent();

            LimiteTabela = new List<KeyValuePair<string, int>>();
            Modulos = new List<string>();
        }

        public void EnableCampos(bool on)
        {
            txtCodigoHw.Enabled = txtDataExpiracao.Enabled = txtLimiteReg.Enabled = txtQtdMaquinas.Enabled = cbTabela.Enabled = sbAdicionarLimiteTabela.Enabled = btAdicionarModulo.Enabled = on;
        }

        private void sbAdicionarLimiteTabela_Click(object sender, EventArgs e)
        {
            int limiteReg;
            if (cbTabela.Text == "" || !Int32.TryParse(txtLimiteReg.Text, out limiteReg))
            {
                MessageBox.Show("Verifique os valores informados.");
                return;
            }

            if (LimiteTabela.Where(kvp => kvp.Key == cbTabela.EditValue.ToString()).Count() == 0)
                LimiteTabela.Add(new KeyValuePair<string, int>(cbTabela.EditValue.ToString(), limiteReg));
            gcLimiteTabelas.DataSource = LimiteTabela;
            gcLimiteTabelas.Refresh();
            gvLimiteTabelas.RefreshData();
        }

        private void lkpSistema_EditValueChanged(object sender, EventArgs e)
        {
            CarregaComboBoxTabela();
        }

        private void CarregaComboBoxTabela()
        {
            cbTabela.Properties.Items.Clear();
            cbTabela.Properties.Items.Add("Empresa");
        }

        private void sbGerarArquivo_Click(object sender, EventArgs e)
        {
            GeraArquivoLicenca();
        }

        private void GeraArquivoLicenca()
        {
            Dictionary<string, int> af = new Dictionary<string, int>();
            DateTime dtExpiracao = new DateTime();
            UInt32 qtdMaquinas = UInt32.MinValue;
            
            DateTime.TryParse(txtDataExpiracao.Text, out dtExpiracao);
            UInt32.TryParse(txtQtdMaquinas.Text, out qtdMaquinas);

            foreach (var item in LimiteTabela)
            {
                af.Add(item.Key, item.Value);
            }
            ArquivoLicenca arquivoLicenca = new ArquivoLicenca(GetSistema(Sistema), lkpVersao.Selecionado.ToString(), dtExpiracao, qtdMaquinas, txtCodigoHw.Text, af, Modulos, NumeroSerie);
            arquivoLicenca.Demonstracao = chDemonstracao.Checked;
            _arquivoLicencaSerializado = arquivoLicenca.ToSerializedString();
        }

        private void btAdicionarModulo_Click(object sender, EventArgs e)
        {
            if (!Modulos.Contains(cbModulo.Text)) Modulos.Add(cbModulo.Text);
            gvModulos.RefreshData();

        }

        private void gvModulos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Delete)
            {
                Modulos.Remove(gvModulos.GetRow(gvModulos.GetSelectedRows()[0]).ToString());
                gvModulos.RefreshData();
                gvModulos.MoveLastVisible();
            }
        }

        private void UCLicencaChave_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                lkpSistema.Sessao = lkpVersao.Sessao = PessoaController.Instancia.getSession();
                lkpSistema.Exemplo = new cwkGestao.Modelo.Sistema();
                lkpVersao.Exemplo = new Versao();
                gcLimiteTabelas.DataSource = LimiteTabela;
                gcModulos.DataSource = Modulos;
            }
        }


    }
}
