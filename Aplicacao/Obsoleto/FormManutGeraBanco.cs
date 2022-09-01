using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using System.IO;
using cwkGestao.Negocio;
using System.Data.SqlClient;
using System.Linq;
using SimpleCrypto;
using System.Threading.Tasks;
using Aplicacao.Obsoleto;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;


namespace Aplicacao
{
    public partial class FormManutGeraBanco : Aplicacao.Base.ManutBase
    {

        CwkPedido pedido;
        CwkPedidoController pedidoController = CwkPedidoController.Instancia;

        public FormManutGeraBanco(CwkPedido pedido)
        {
            InitializeComponent();
            this.pedido = pedido;
            txtPedido.EditValue = pedido.Data.Value.ToShortDateString() + " | " + pedido.Codigo + "-" + pedido.NumeroSerie + " | " + pedido.Sistema.Nome;
            if (pedido.Sistema.Nome.Contains("PONTO WEB"))
            {
                string nomeBkp = pedido.CwkPedidoEmpresas.FirstOrDefault().ClienteRevenda.Cnpj.Replace("/", "").Replace("-", "").Replace(".", "");
                if (String.IsNullOrEmpty(nomeBkp))
                {
                    nomeBkp = pedido.CwkPedidoEmpresas.FirstOrDefault().ClienteRevenda.Cpf.Replace("/", "").Replace("-", "").Replace(".", "");
                }
                txtCaminho.EditValue = pedido.Versao.CaminhoBackup + nomeBkp + ".BAK";
                txtCaminho.Enabled = false;    
            }
            this.Text = "Gerar Banco";
        }

        public override Dictionary<string, string> Salvar()
        {
            Dictionary<string, string> ret = null;
            if (pedido.Sistema.Nome.Contains("PONTO"))
            {
                string nomeBackupBanco = "";
                ret = pedidoController.GeraPontoMT(pedido, new FileInfo(txtCaminho.Text), out nomeBackupBanco);
              
                if (ret.Count == 0)
                {
                    try
                    {
                        if (pedido.Sistema.Nome.Contains("PONTO WEB"))
                        {
                            bool ok = false;
                            SincronizarCentralCliente(pedido, ok);
                            string nomeBanco;
                            string _connectionStringPontoWeb;
                            GeraBancoPontoWeb(out nomeBanco, out _connectionStringPontoWeb);
                            AdicionaSenhaCentraldoCliente(nomeBanco, "cwork", pedido.Versao.CaminhoCentralCliente);
                            AdicionaSenhaCentraldoCliente(nomeBanco + "re", "revendas@cwork", pedido.Versao.CaminhoCentralCliente);
                            AdicionaSenhaCentraldoCliente(nomeBanco + "cw", "cwork@1212", pedido.Versao.CaminhoCentralCliente);

                            VincularUsuarioCliente(pedido);

                            ObjetoLoginWebAPI login = new ObjetoLoginWebAPI();
                            login.UserName = nomeBanco;
                            login.Password = "comunicador";
                            login.Email = nomeBanco + "@cwork.com.br";
                            login.ConfirmPassword = login.Password;
                            bool sucesso = CadastraUsuarioWebAPI(pedido.Versao.CaminhoWebAPI, "", login);
                            if (sucesso)
                            {
                                VinculaUsuarioAspnetUsers(nomeBanco, pedido.Versao.CaminhoCentralCliente);
                            }
                            else
                            {
                                MessageBox.Show("Erro ao gerar usuário do Comunicador. Favor verifique!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erro ao restaurar banco de dados. Verifique! Detalhes: " + ex.Message);
                    }

                    MessageBox.Show("Banco gerado com sucesso!");
                    pedido.Status = OrcamentoStatus.AguardandoFaturamento;
                    pedidoController.Salvar(pedido, Acao.Alterar);
                }
            }
            return ret;
        }

        private bool SincronizarCentralCliente(CwkPedido pedido, bool ok)
        {
            var conexao = new SqlConnection(Modelo.cwkGlobal.CONN_STRING);
            using (conexao)
            {
                using (var cmd = conexao.CreateCommand())
                {
                    conexao.Open();
                    cmd.CommandText = "exec p_ReplicacaoCentralCliente";
                    cmd.ExecuteNonQuery();
                }
            }
            return true;
        }


        private void VincularUsuarioCliente (CwkPedido pedido)
        {
            try
            {
                string caminhoCentralCliente = pedido.Versao.CaminhoCentralCliente;
                using (var conn = new SqlConnection(caminhoCentralCliente))
                {
                    using (var cmd = conn.CreateCommand())
                    {
                        conn.Open();
                        cmd.CommandText = "update Usuario set IDCliente = (select c.id from Cliente c inner join Entidade e on c.IDEntidade = e.ID where e.CNPJ_CPF  = @nomebanco), IDRevenda = @IDRevenda  from Usuario u where u.Login = @login or u.Login = @loginre or u.Login = @logincw";
                        cmd.Parameters.AddWithValue("@nomebanco", pedido.CwkPedidoEmpresas.FirstOrDefault().ClienteRevenda.Cnpj);
                        cmd.Parameters.AddWithValue("@login", pedido.CwkPedidoEmpresas.FirstOrDefault().ClienteRevenda.Cnpj.Replace("-", "").Replace(".", "").Replace("/", ""));
                        cmd.Parameters.AddWithValue("@loginre", pedido.CwkPedidoEmpresas.FirstOrDefault().ClienteRevenda.Cnpj.Replace("-", "").Replace(".", "").Replace("/", "") +"re");
                        cmd.Parameters.AddWithValue("@logincw", pedido.CwkPedidoEmpresas.FirstOrDefault().ClienteRevenda.Cnpj.Replace("-", "").Replace(".", "").Replace("/", "") + "cw");
                        cmd.Parameters.AddWithValue("@IDRevenda", pedido.Pessoa.IDRevendaCentralCliente);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void GeraBancoPontoWeb(out string nomeBanco, out string _connectionStringPontoWeb)
        {
            nomeBanco = pedido.CwkPedidoEmpresas.FirstOrDefault().ClienteRevenda.Cnpj.Replace("/", "").Replace(".", "").Replace("-", "");
            if (String.IsNullOrEmpty(nomeBanco))
            {
                nomeBanco = pedido.CwkPedidoEmpresas.FirstOrDefault().ClienteRevenda.Cpf.Replace("/", "").Replace(".", "").Replace("-", "");
            }
            string _connectionString = "Data Source=" + pedido.Versao.Servidor + ";initial catalog=master;user id=sa;password=" + pedido.Versao.Senha + ";MultipleActiveResultSets=true;Asynchronous Processing=true";
            _connectionStringPontoWeb = "Data Source=" + pedido.Versao.Servidor + ";initial catalog=" + nomeBanco + ";user id=sa;password=" + pedido.Versao.Senha + ";MultipleActiveResultSets=true;Asynchronous Processing=true";
            using (var conn = new SqlConnection(_connectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();

                    string caminhoBackup = pedido.Versao.CaminhoBackup + "cwkPontoMT_" + nomeBanco + ".BAK";
                    cmd.CommandText = "exec RestauraBancoLicencaPontoWeb @NOMEBANCO, @CAMINHOBACKUP, @NOMEREVENDA, @CONNECTIONSTRINGPONTOWEB";
                    cmd.Parameters.AddWithValue("@NOMEBANCO", nomeBanco);
                    cmd.Parameters.AddWithValue("@CAMINHOBACKUP", caminhoBackup);
                    cmd.Parameters.AddWithValue("@NOMEREVENDA", pedido.Pessoa.Nome);
                    cmd.Parameters.AddWithValue("@CONNECTIONSTRINGPONTOWEB", _connectionStringPontoWeb);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        private void AdicionaSenhaCentraldoCliente(string nomebanco, string senha, string caminhoCentralCliente)
        {
            ICryptoService crypto = new PBKDF2();
            string salt = crypto.GenerateSalt();
            string passCrypto = crypto.Compute(senha);
            string _connectionString = caminhoCentralCliente;
            using (var conn = new SqlConnection(_connectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "update usuario set Password =@Password, PasswordSalt = @PasswordSalt where login = @Login";
                    cmd.Parameters.AddWithValue("@Password", passCrypto);
                    cmd.Parameters.AddWithValue("@PasswordSalt", salt);
                    cmd.Parameters.AddWithValue("@Login", nomebanco);
                    cmd.ExecuteNonQuery();
                }

            }
        }

        private void VinculaUsuarioAspnetUsers(string nomebanco, string caminhoCentralCliente)
        {
            string _connectionString = caminhoCentralCliente;
            using (var conn = new SqlConnection(_connectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "update AspnetUsers  set IDUsuario = (select id from Usuario where Usuario.Login = @nomebanco) from AspnetUsers where UserName = @nomebanco";
                    cmd.Parameters.AddWithValue("@nomebanco", nomebanco);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        private bool CadastraUsuarioWebAPI(string caminhoWebAPI, string uriWebservice, ObjetoLoginWebAPI login)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    MemoryStream ms = new MemoryStream();
                    DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(ObjetoLoginWebAPI));
                    ser.WriteObject(ms, login);
                    ms.Position = 0;
                    StreamReader sr = new StreamReader(ms);
                    StringContent conteudo = new StringContent(sr.ReadToEnd(), System.Text.Encoding.UTF8, "application/json");
                    string posturi = caminhoWebAPI +"api/Account/Register";
                    client.BaseAddress = new Uri(posturi);
                    client.DefaultRequestHeaders.Accept.Clear();
                    var response = client.PostAsync(posturi, conteudo).Result;
                    response.EnsureSuccessStatusCode();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private void sbCaminho_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtCaminho.Text))
                {
                    folderBrowserDialog1.SelectedPath = (string)txtCaminho.EditValue;
                }
                else
                {
                    folderBrowserDialog1.SelectedPath = "";
                }

                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtCaminho.Text = folderBrowserDialog1.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
