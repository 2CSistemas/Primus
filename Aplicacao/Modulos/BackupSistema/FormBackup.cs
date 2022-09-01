using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio.Backup;
using System.IO;
using Aplicacao.Base;
using Aplicacao.Util;
using System.Xml;
using System.Xml.Linq;
using System.Linq;

namespace Aplicacao
{
    public partial class FormBackup : Aplicacao.Base.ManutBase
    {
        public FormBackup()
        {
            InitializeComponent();
            Diretorio = new List<string>();
            Carregar();
            sbGravar.Text = "Backup";
            sbCancelar.Text = "Fechar";
        }


        private List<string> Diretorio;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //folderDialog.SelectedPath = txtDiretorio.Text;
            //folderDialog.ShowDialog();

            //txtDiretorio.Text = folderDialog.SelectedPath;
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {

        }

        public string CriarDiretorioDataDeAgora(string diretorio)
        {
            DateTime dateTime = DateTime.Now;
            string nomeDiretorio = diretorio + "\\" + String.Format("backup{0:0000}.{1:00}.{2:00}-{3:00}.{4:00}", dateTime.Year, dateTime.Month,
                                                 dateTime.Day, dateTime.Hour, dateTime.Minute);

            try
            {
                Directory.CreateDirectory(nomeDiretorio);
            }
            catch (IOException)
            {
                MessageBox.Show("Erro ao tentar criar o diretório de backup.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Privilégios insuficientes para criar diretórios na pasta de destino. Execute a aplicação em modo administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return nomeDiretorio;
        }

        private void Gravar()
        {
            try
            {
                if (File.Exists("Configuração.xml"))
                    File.Delete("Configuração.xml");

                XmlDocument doc = new XmlDocument();

                XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlElement root = doc.DocumentElement;
                doc.InsertBefore(xmlDeclaration, root);

                XmlElement element1 = doc.CreateElement(string.Empty, "Backup", string.Empty);
                doc.AppendChild(element1);
                doc.Save("Configuração.xml");

                XElement x = new XElement("config");
                x.Add(new XAttribute("Logs", chbLogs.Checked));
                x.Add(new XAttribute("XML", chbXmlDestinatario.Checked));
                x.Add(new XAttribute("Banco", chbBancoDeDados.Checked));
                x.Add(new XAttribute("Automatico", cbAutomatico.Checked));
                x.Add(new XAttribute("BackupSairSistema", cbBackupSairSistema.Checked));
                x.Add(new XAttribute("Horario", txtHorario.Text));

                XElement xml = XElement.Load("Configuração.xml");
                xml.Add(x);

                foreach (var item in Diretorio)
                {
                    x = new XElement("local");
                    x.Add(new XAttribute("Diretorio", item));
                    xml.Add(x);
                }

                xml.Save("Configuração.xml");

                MessageBox.Show("As configurações foram salvas com Sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Carregar()
        {
            try
            {
                if (!File.Exists("Configuração.xml"))
                    return;

                XElement xml = XElement.Load("Configuração.xml");

                foreach (XElement x in xml.Elements())
                {
                    if (x.Name == "config")
                    {
                        chbLogs.Checked = bool.Parse(x.Attribute("Logs").Value);
                        chbXmlDestinatario.Checked = bool.Parse(x.Attribute("XML").Value);
                        chbBancoDeDados.Checked = bool.Parse(x.Attribute("Banco").Value);
                        cbAutomatico.Checked = bool.Parse(x.Attribute("Automatico").Value);
                        cbBackupSairSistema.Checked = bool.Parse(x.Attribute("BackupSairSistema").Value);
                        txtHorario.Text = x.Attribute("Horario").Value;
                    }
                    else
                        Diretorio.Add(x.Attribute("Diretorio").Value);
                }

                gridControl1.DataSource = Diretorio;
                gridControl1.RefreshDataSource();
            }
            catch (Exception ex)
            {
                string text = ex.Message;
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        public void sbGravar_Click_1(object sender, EventArgs e)
        {
            if (Diretorio.Count == 0)
                return;

            Cursor = Cursors.WaitCursor;

            new BackupDatabase(BackupDatabase.TipoBackup.MANUAL, chbLogs.Checked, chbXmlDestinatario.Checked, chbBancoDeDados.Checked, false).ShowDialog(this);

            Cursor = Cursors.Default;
            MessageBox.Show("Cópia de Segurança concluída.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_IncluirDiretorio_Click(object sender, EventArgs e)
        {
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Diretorio.Add(folderDialog.SelectedPath);
                    gridControl1.DataSource = Diretorio;
                    gridControl1.RefreshDataSource();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao selecionar Diretório" + Environment.NewLine + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_RemoverDiretorio_Click(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle < 0)
                return;

            try
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
                gridControl1.RefreshDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao remover Diretório" + Environment.NewLine + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
