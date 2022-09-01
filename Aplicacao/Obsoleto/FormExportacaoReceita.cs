using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Modelo;
using cwkGestao.Negocio.Utils;
using cwkGestao.Modelo.ValidaPR;
using System.IO;
using System.Reflection;
using System.Globalization;

namespace Aplicacao
{
    public partial class FormExportacaoReceita : Form
    {
        BLL.IExpNotas exportacao;

        private Filial FilialSelecionada
        {
            get { return (Filial)lkpFilial.Selecionado; }
            set { lkpFilial.EditValue = value; }
        }
        private Inventario InventarioSelecionada
        {
            get { return (Inventario)lkpInventario.Selecionado; }
            set { lkpInventario.EditValue = value; }
        }

        public FormExportacaoReceita()
        {
            InitializeComponent();
            Name = "FormExportacaoReceita";
            DateTime data = DateTime.Now;
            dtInicial.DateTime = data.AddDays(-(data.Day - 1));
            dtFinal.DateTime = DateTime.Now;
            chInventario.Checked = false;


            InicializaLookups();
            HabilitarInvenario();
        }

        private void InicializaLookups()
        {
            Object sessao = FilialController.Instancia.getSession();
            lkpFilial.Sessao = sessao;
            lkpFilial.Exemplo = new Filial();

            lkpInventario.Sessao = sessao;
            lkpInventario.Exemplo = new Inventario();
        }

        private void lkbFilial_Click(object sender, EventArgs e)
        {
            GridGenerica<Filial> grid = new GridGenerica<Filial>(cwkGestao.Negocio.FilialController.Instancia.GetAll(), new FormFilial(), (cwkGestao.Modelo.Filial)lkpFilial.Selecionado, false);
            grid.Selecionando = true;
            grid.ShowDialog();

            lkpFilial.EditValue = grid.Selecionado;
        }

        private void lkbInventario_Click(object sender, EventArgs e)
        {
            GridGenerica<Inventario> grid = new GridGenerica<Inventario>(cwkGestao.Negocio.InventarioController.Instancia.GetAll(), new FormInventario(), (cwkGestao.Modelo.Inventario)lkpInventario.Selecionado, false);
            grid.Selecionando = true;
            grid.ShowDialog();

            lkpInventario.EditValue = grid.Selecionado;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            exportacao = new BLL.ExpNotaValidaPR();
            Modelo.EntSaiType entsai = Modelo.EntSaiType.Ambas;
            CupomFiscal _cupomFiscal = new CupomFiscal("x86");

            if (chInventario.Checked)
            {
                //verifico se a empresa selecionada é a mesma empresa do inventario;
                if (((Filial)lkpFilial.Selecionado).Nome != ((Inventario)lkpInventario.Selecionado).FilialNome)
                {
                    MessageBox.Show("Selecione um inventário da mesma empresa selecionada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }

            //verifico se o diretório está vazio;
            if (txtArquivo.Text == null || txtArquivo.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, selecione um diretório ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (chEntrada.Checked == true && chSaida.Checked == false)
                entsai = Modelo.EntSaiType.Entrada;
            else if (chEntrada.Checked == false && chSaida.Checked == true)
                entsai = Modelo.EntSaiType.Saida;


            string ok = Validacao();
            if (ok.Length == 0)
            {
                try
                {
                    ValidaPRController valida = new ValidaPRController();
                    DateTime datainicial = ((DateTime)dtInicial.EditValue).Date;
                    DateTime datafinal = ((DateTime)dtFinal.EditValue).Date;

                    //gera arquivo de cupom fiscal da impressora térmica;
                    if (chGeraRegistro60.Checked && chImpTermica.Checked)
                    {
                        try
                        {
                            ValidaPRTipo60.GeraRegistros60MFD(_cupomFiscal, @txtArquivo.Text, datainicial, datafinal, (Filial)lkpFilial.Selecionado);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Verifique se a impressora suporta a exportação do registro 60, Erro: " + ex.Message);
                        }
                    }

                    //gera arquivo com todas as informações;
                    try
                    {
                        valida.GerarArquivoMagnetico(FilialSelecionada, datainicial, datafinal, (InOutType)entsai, (Inventario)lkpInventario.Selecionado, txtArquivo.Text, chGeraRegistro60.Checked);
                        MessageBox.Show("Arquivo Gerado com Sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception z)
                    {
                        string erro = "\r\n" + "O arquivo está inconsistente.";
                        MessageBox.Show("Ocorreram erros na geração do arquivo: \r\n\r\n" + z.Message + erro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    new Aplicacao.Base.FormErro(ex).ShowDialog();
                }

            }
            else
                MessageBox.Show(ok, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void FormExportacaoReceita_Load(object sender, EventArgs e)
        {
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormExportacaoReceita_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Exportação Receita");
                    break;
            }
        }

        private String Validacao()
        {
            StringBuilder sb = new StringBuilder();


            if (dtInicial.DateTime.Day != 1)
                sb.Append("A data inicial não pode ser diferente do primeiro dia do mês.\n");
            if (dtFinal.DateTime > DateTime.Now)
                sb.Append("A data final não pode ser maior do que a a data atual.\n");

            return sb.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarInvenario();
        }

        private void HabilitarInvenario()
        {
            lkpInventario.EditValue = null;
            lkpInventario.Enabled = chInventario.Checked;
            lkbInventario.Enabled = chInventario.Checked;
        }

        private void lkpDiretorio_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserDialog1.SelectedPath == "C:\\" || folderBrowserDialog1.SelectedPath == "D:\\")
                {
                    txtArquivo.Text = folderBrowserDialog1.SelectedPath;
                }
                else
                {
                    txtArquivo.Text = folderBrowserDialog1.SelectedPath + @"\";

                }
            }
        }

        private void chGeraRegistro60_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
        }

        private void chGeraRegistro60_CheckStateChanged(object sender, EventArgs e)
        {
            if (chGeraRegistro60.Checked)
            {
                chImpTermica.Enabled = true;
            }
            else
            {
                chImpTermica.Enabled = false;
                chImpTermica.Checked = false;
            }
        }
    }
}
