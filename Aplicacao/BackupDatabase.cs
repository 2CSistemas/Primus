using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

using cwkGestao.Negocio.Backup;

namespace Aplicacao
{
    public partial class BackupDatabase : Form
    {
        public enum TipoBackup
        {
            AUTOMATICO = 1,
            MANUAL = 2,
            AOSAIRDOSISTEMA = 3
        }

        private bool logs = false;
        private bool xmlDest = false;
        private bool bancoDeDados = false;
        private bool backupSairSistema = false;
        private TipoBackup tipoBackup;

        public BackupDatabase(TipoBackup _tipoBackup, bool _logs, bool _xmlDest, bool _bancoDeDados, bool _backupSairSistema)
        {
            InitializeComponent();

            tipoBackup = _tipoBackup;
            logs = _logs;
            xmlDest = _xmlDest;
            bancoDeDados = _bancoDeDados;
            backupSairSistema = _backupSairSistema;

            Shown += BackupDatabase_Shown;
        }

        public BackupDatabase(TipoBackup _tipoBackup)
        {
            InitializeComponent();

            tipoBackup = _tipoBackup;
            Shown += BackupDatabase_Shown;
        }

        private void BackupDatabase_Shown(object sender, System.EventArgs e)
        {
            label1.Refresh();
            label1.Update();

            if (tipoBackup == TipoBackup.MANUAL)
                fazerBackupManual();
            else
                fazerBackup();
        }

        private void fazerBackupManual()
        {
            try
            {
                var diretorios = new List<string>();

                if (!File.Exists("Configuração.xml"))
                    return;

                var xml = XElement.Load("Configuração.xml");
                foreach (var x in xml.Elements())
                    if (x.Name != "config")
                        diretorios.Add(x.Attribute("Diretorio")?.Value);

                foreach (var diretorio in diretorios.Select(criarDiretorioDataDeAgora))
                {
                    if (logs)
                        Backup.Logs(diretorio);
                    if (xmlDest)
                        Backup.XmlDestinatario(diretorio);
                    if (bancoDeDados)
                        Backup.BancoDeDados(diretorio);
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fazerBackup()
        {
            try
            {
                var diretorios = new List<string>();

                if (!File.Exists("Configuração.xml"))
                    return;

                var xml = XElement.Load("Configuração.xml");
                foreach (var x in xml.Elements())
                {
                    if (x.Name == "config")
                    {
                        logs = bool.Parse(x.Attribute("Logs")?.Value);
                        xmlDest = bool.Parse(x.Attribute("XML")?.Value);
                        bancoDeDados = bool.Parse(x.Attribute("Banco")?.Value);
                        backupSairSistema = bool.Parse(x.Attribute("BackupSairSistema").Value);
                    }
                    else
                        diretorios.Add(x.Attribute("Diretorio")?.Value);
                }

                if (tipoBackup == TipoBackup.AOSAIRDOSISTEMA && !backupSairSistema)
                    return;

                foreach (var diretorio in diretorios.Select(criarDiretorioDataDeAgora))
                {
                    if (logs)
                        Backup.Logs(diretorio);
                    if (xmlDest)
                        Backup.XmlDestinatario(diretorio);
                    if (bancoDeDados)
                        Backup.BancoDeDados(diretorio);
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string criarDiretorioDataDeAgora(string diretorio)
        {
            DateTime dateTime = DateTime.Now;
            string nomeDiretorio = diretorio + "\\" + $"backup{dateTime.Year:0000}.{dateTime.Month:00}.{dateTime.Day:00}-{dateTime.Hour:00}.{dateTime.Minute:00}";

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
    }
}