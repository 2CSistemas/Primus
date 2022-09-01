using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormExportacaoNfe : Form
    {
        BLL.NFe bllNFe;
        Modelo.Filial objFilial = new Modelo.Filial();
        Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext();

        public FormExportacaoNfe()
        {
            InitializeComponent();
            Name = "FormExportacaoNfe";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            objFilial = (Modelo.Filial)objFilial.getObjeto(db, (int)cbFilial.EditValue);

            string mensagem;
            bllNFe = new BLL.NFe();
            if (!bllNFe.PreencherNFe(objFilial, out mensagem))
            {
                MessageBox.Show(mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int entsai = 0;

            if (chEntrada.Checked == true && chSaida.Checked == false)
            {
                entsai = 1;
            }
            else if (chEntrada.Checked == false && chSaida.Checked == true)
            {
                entsai = 2;
            }

            bllNFe.ExportarDanfe(objFilial.ID, entsai, dtInicial.DateTime, dtFinal.DateTime, pbExportacao);

            MessageBox.Show("Arquivo Gerado com Sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormExportacaoReceita_Load(object sender, EventArgs e)
        {
            cbFilial.Properties.DataSource = objFilial.getListaCombo(db);
            cbFilial.EditValue = 0;
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
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Exportação DANFE - PDF");
                    break;
            }
        }
    }
}
