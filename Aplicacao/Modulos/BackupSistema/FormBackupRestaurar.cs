using Aplicacao.Base;
using cwkGestao.Negocio.Backup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormBackupRestaurar : Aplicacao.Base.ManutBase
    {
        public FormBackupRestaurar()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            fileDialog.FileName = txtDiretorio.Text;
            fileDialog.ShowDialog();

            txtDiretorio.Text = fileDialog.FileName;
        }
        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            try
            {
                Backup.Restaurar(txtDiretorio.Text);
                MessageBox.Show("Backup restaurado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                new FormErro(exception).ShowDialog();
            }
        }

    }
}
