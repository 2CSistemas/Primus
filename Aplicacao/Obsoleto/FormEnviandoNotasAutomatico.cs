using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Aplicacao.Obsoleto
{
    public partial class FormEnviandoNotasAutomatico : Form
    {
        public FormEnviandoNotasAutomatico()
        {
            InitializeComponent();
        }

        private DateTime GetDateOfFirstDayInTheMonth()
        {
            var month = DateTime.Now.Month - 1 == 0 ? 12 : DateTime.Now.Month - 1;
            return new DateTime(DateTime.Now.Year, month, 1);
        }

        private DateTime GetDateOfLastDayInTheMonth()
        {
            var month = DateTime.Now.Month - 1 == 0 ? 12 : DateTime.Now.Month - 1;
            return new DateTime(DateTime.Now.Year, month, DateTime.DaysInMonth(DateTime.Now.Year, month), 23, 59, 59);
        }

        private void FormEnviandoNotasAutomatico_Load(object sender, EventArgs e)
        {
            label1.Refresh();
            label1.Update();

            backgroundWorker1.RunWorkerAsync();
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var form = new FormManutXMLNFe(GetDateOfFirstDayInTheMonth(), GetDateOfLastDayInTheMonth());
            form.Gravar(true);
            form.GravarClick();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("E-mail enviado com sucesso.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show($"Notas do mês {GetDateOfFirstDayInTheMonth().Month}/{GetDateOfFirstDayInTheMonth().Year} enviadas com sucesso.", "Atenção!");
            Close();
        }
    }
}
