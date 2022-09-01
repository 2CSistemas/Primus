using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo;
using System.Configuration;
using System.Xml;


namespace Aplicacao
{
    public partial class FormConfigBancoDeDados : Form
    {
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        string str;
        public int Retorno { get; private set; }
        
        public FormConfigBancoDeDados()
        {
            InitializeComponent();
            //builder.ConnectionString = (string)Modelo.Properties.Settings.Default.GetUserOverride("cwkGestaoConnectionString");
            if (Modelo.cwkGlobal.CONN_STRING.Trim() != String.Empty)
            {
                txtDataSource.Text = builder.DataSource;
                txtBancoDeDados.Text = builder.InitialCatalog;
                txtUsuario.Text = builder.UserID;
                txtSenha.Text = builder.Password;
                if (builder.ConnectionString.Contains("Pooling"))
                    txtParametros.Text = "Pooling=" + builder.Pooling.ToString() + ";";
                if (builder.ConnectionString.Contains("Connect Timeout"))
                    txtParametros.Text += "Connect Timeout=" + builder.ConnectTimeout.ToString() + ";";
                if (builder.ConnectionString.Contains("MultipleActiveResultSets"))
                    txtParametros.Text += "MultipleActiveResultSets=" + builder.MultipleActiveResultSets.ToString() + ";";
            }
        }

        public void MontaStringDeConexao()
        {
            builder = new SqlConnectionStringBuilder();
            builder.DataSource = txtDataSource.Text;
            builder.InitialCatalog = txtBancoDeDados.Text;
            builder.UserID = txtUsuario.Text;
            builder.Password = txtSenha.Text;
            #region Verifica se foi configurado algum parâmetro
            if (txtParametros.Text.Length > 0)
            {
                string[] aux = txtParametros.Text.Split(new char[] { ';' });
                string[] aux2;
                foreach (string item in aux)
                {
                    if (item.Contains('='))
                    {
                        aux2 = item.Split(new char[] { '=' });
                        switch (aux2[0])
                        {
                            case "Pooling":
                                bool p = false;
                                if (Boolean.TryParse(aux2[1], out p))
                                    builder.Pooling = p;
                                break;
                            case "Connect Timeout":
                                int c = 60;
                                if (Int32.TryParse(aux2[1], out c))
                                    builder.ConnectTimeout = c;
                                break;
                            case "MultipleActiveResultSets":
                                bool m = false;
                                if (Boolean.TryParse(aux2[1], out m))
                                    builder.MultipleActiveResultSets = m;
                                break;
                        }
                    }
                }
            }
            #endregion
        }

        private bool ConnStringOK()
        {
            System.Windows.Forms.Application.DoEvents();
            SqlConnection conn = new SqlConnection(builder.ConnectionString);
            try
            {
                conn.Open();

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            MontaStringDeConexao(builder);
            Configuration conf = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            conf.ConnectionStrings.ConnectionStrings["Modelo.Properties.Settings.cwkGestaoConnectionString"].ConnectionString = builder.ConnectionString;
            conf.Save();
            Modelo.Properties.Settings.Default.SetUserOverride("cwkGestaoConnectionString", builder.ConnectionString);
            Modelo.Properties.Settings.Default.Save();
            MontaStringDeConexao();
            if (ConnStringOK())
            {
                Modelo.cwkGlobal.CONN_STRING = builder.ConnectionString;
                XmlDocument doc = new XmlDocument();
                doc.Load("DAL.xml");
                XmlNode no = doc.SelectSingleNode("DAL").SelectSingleNode("cwkConnectionString").SelectSingleNode("Sql");
                no.Attributes["connectionString"].Value = Modelo.Criptografia.Criptografar(builder.ConnectionString);
                doc.Save("DAL.xml");
                Retorno = 1;
                this.Close();
            }
            this.Close();
        }

        public void MontaStringDeConexao(SqlConnectionStringBuilder pBuilder)
        {
            pBuilder.DataSource = txtDataSource.Text;
            pBuilder.InitialCatalog = txtBancoDeDados.Text;
            pBuilder.UserID = txtUsuario.Text;
            pBuilder.Password = txtSenha.Text;
            #region Verifica se foi configurado algum parâmetro
            if (txtParametros.Text.Length > 0)
            {
                string[] aux = txtParametros.Text.Split(new char[] { ';' });
                string[] aux2;
                foreach (string item in aux)
                {
                    if (item.Contains('='))
                    {
                        aux2 = item.Split(new char[] { '=' });
                        switch (aux2[0])
                        {
                            case "Pooling":
                                bool p = false;
                                if (Boolean.TryParse(aux2[1], out p))
                                    builder.Pooling = p;
                                break;
                            case "Connect Timeout":
                                int c = 60;
                                if (Int32.TryParse(aux2[1], out c))
                                    builder.ConnectTimeout = c;
                                break;
                            case "MultipleActiveResultSets":
                                bool m = false;
                                if (Boolean.TryParse(aux2[1], out m))
                                    builder.MultipleActiveResultSets = m;
                                break;
                        }
                    }
                }
            }
            #endregion
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormConfigBancoDeDados_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F9:
                    btSalvar_Click(sender, e);
                    break;
                case Keys.Escape:
                    btCancelar_Click(sender, e);
                    break;
            }
        }
    }
}
