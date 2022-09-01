using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.NFe;
using cwkGestao.Modelo;
using Aplicacao.Base;
using cwkGestao.Negocio;
using MO = Modelo;
using Aplicacao.Modulos.Comercial;
using cwkGestao.Negocio.Padroes;

namespace Aplicacao
{
    public partial class FormNFe : Form, IObserverNFe
    {
        public int IDNota;
        private cwkGestao.Modelo.Nota objNota;
        private cwkGestao.Modelo.Nota objNotaReferenciada;

        private cwkGestao.NFe.NFeController nfeController;
        private FormaEmissaoNFe formaEmissao;
        
        protected override CreateParams CreateParams
        {
            get
            {
                var param = base.CreateParams;
                param.ClassStyle = param.ClassStyle | 0x200;
                return param;
            }
        }

        public FormNFe()
        {
            InitializeComponent();
        }

        private void VerificaModoEnvio()
        {
            if (objNota.Filial.FormaEmissao == (int)FormaEmissaoNFe.Contigencia && objNota.Status == "-1" && objNota.Status != "0")
            {
                MessageBox.Show("A nota será enviado em modo de contingência." + Environment.NewLine + "O número e a série podem sofrer alterações.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                objNota.Serie = objNota.Filial.SerieScan.ToString();
                objNota.Numero = NotaController.Instancia.NovoNumeroSerie(objNota);
            }
        }

        private void FormNFe_Load(object sender, EventArgs e)
        {
            objNota = NotaController.Instancia.LoadObjectById(IDNota);
            
            objNota = CamposDiferentesPessoa(objNota);
            objNota.EmailDestinatario = objNota.EmailNota;

            if (objNota.NotaReferenciada != null)
                objNota.NotaReferenciada = NotaController.Instancia.LoadObjectById(objNota.NotaReferenciada.ID);

            //VerificaModoEnvio(); // chamada comentada, haja vista que as notas 
                                   // devem ser emitidas normalmente, sem alteração da série
                                   // mesmo que em contingência. Ticket #2875
            formaEmissao = (FormaEmissaoNFe)objNota.Filial.FormaEmissao;

            //bool? utilizaLayout4 = ConfiguracaoController.Instancia.GetConfiguracao().UtilizaLayout4;

            int LayoutNFe = ConfiguracaoController.Instancia.GetConfiguracao().LayoutNFe;

            cwkGestao.NFe.Enums.TipoCertificado tipoCertificado = cwkGestao.NFe.Enums.TipoCertificado.ckFile;

            switch (objNota.Filial.TipoCertificadoNFe)
            {
                case 0: tipoCertificado = cwkGestao.NFe.Enums.TipoCertificado.ckFile; break;
                case 1: tipoCertificado = cwkGestao.NFe.Enums.TipoCertificado.ckSmartCard; break;
                case 2: tipoCertificado = cwkGestao.NFe.Enums.TipoCertificado.ckMemory; break;
                case 3: tipoCertificado = cwkGestao.NFe.Enums.TipoCertificado.ckLocalMachine; break;
                case 4: tipoCertificado = cwkGestao.NFe.Enums.TipoCertificado.ckActiveDirectory; break;
            }

            //nfeController = cwkGestao.NFe.NFeController.ProduceFromNHibernate(objNota, utilizaLayout4.HasValue == true ? utilizaLayout4.Value : false, tipoCertificado, this);
            ConfiguracaoManager configManager = ConfiguracaoManagerController.Instancia.GetAll().FirstOrDefault();
            nfeController = cwkGestao.NFe.NFeController.ProduceFromNHibernate(objNota, LayoutNFe, tipoCertificado, this, configManager);

            txtSerie.DataBindings.Add("EditValue", objNota, "Serie", true, DataSourceUpdateMode.OnPropertyChanged, objNota.Numero);
            txtNumero.DataBindings.Add("EditValue", objNota, "Numero", true, DataSourceUpdateMode.OnPropertyChanged, objNota.Numero);
            txtData.DataBindings.Add("EditValue", objNota, "Dt", true, DataSourceUpdateMode.OnPropertyChanged, objNota.Dt);
            txtTotalNota.DataBindings.Add("EditValue", objNota, "TotalNota", true, DataSourceUpdateMode.OnPropertyChanged, objNota.TotalNota);
            txtPessoaNome.DataBindings.Add("EditValue", objNota, "PessoaNome", true, DataSourceUpdateMode.OnPropertyChanged, objNota.PessoaNome);
            txt2CNPJ_CPF.DataBindings.Add("EditValue", objNota, "PessoaCNPJCPF", true, DataSourceUpdateMode.OnPropertyChanged, objNota.PessoaCNPJCPF);
            txtEmail.DataBindings.Add("EditValue", objNota, "EmailDestinatario", true, DataSourceUpdateMode.OnPropertyChanged, objNota.EmailDestinatario);
            txtChaveNota.DataBindings.Add("EditValue", objNota, "ChaveNota", true, DataSourceUpdateMode.OnPropertyChanged, objNota.ChaveNota);
            txtNumRecibo.DataBindings.Add("EditValue", objNota, "NumeroRecibo", true, DataSourceUpdateMode.OnPropertyChanged, objNota.NumeroRecibo);
            txtNumProtocolo.DataBindings.Add("EditValue", objNota, "NumeroProtocolo", true, DataSourceUpdateMode.OnPropertyChanged, objNota.NumeroProtocolo);
            gridControl1.DataSource = nfeController.DesmembrarXml();

            VerificaBotaoEnviar();

            if (objNota.CancDt != null)
            {
                btEnviarNFe.Enabled = false;
                btReciboNFe.Enabled = false;
                btConsultaNFe.Enabled = false;
                btEmail.Enabled = true;
                btCancelarNFe.Enabled = false;
                btEditarDanfe.Enabled = false;
            }

            if (objNota.ModeloDocto == 65)
            {
                btnResolve.Visible = true;
            }

            if (objNota.Filial.FormaEmissao == 1)
                txtEmail.Enabled = true;
            else
            {
                txtEmail.Text = String.Empty;
                txtEmail.Enabled = false;
            }
            
            txt2CNPJ_CPF.Enabled = !InformouCPF();

            this.Refresh();
        }

        private bool InformouCPF()
        {
            return Convert.ToInt64(cwkGestao.Modelo.Util.StringUtil.GetSomenteNumeros(txt2CNPJ_CPF.Text)) != 0;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string statusAnterior = objNota.Status;

            try
            {
                if (InformouCPF() || (MessageBox.Show("Deseja informar o CPF?", "Informar CPF", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No))
                {
                    if (!String.IsNullOrEmpty(txtEmail.Text))
                    {
                        EnviarNota();
                    }
                    else
                    {
                        if (!txtEmail.Enabled)
                        {
                            EnviarNota();
                        }
                        else if (String.IsNullOrEmpty(txtEmail.Text) && (MessageBox.Show("Deseja informar o e-mail? Caso contrário o e-mail não será enviado", "Informar E-mail", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No))
                        {
                            EnviarNota();
                        }
                        else
                        {
                            txtEmail.Focus();
                        }
                    }
                }
                else
                {
                    txt2CNPJ_CPF.Focus();
                }
            }
            catch (Exception exc)
            {
                new FormErro(exc).ShowDialog();
                NotaController.Instancia.Salvar(objNota, Acao.Alterar);
            }
            finally
            {
                btFechar.Enabled = true;
                if (statusAnterior == "8")
                    objNota.Status = statusAnterior;
            }
            Clipboard.SetText(objNota.UltimoXmlRecebido ?? "Não houve retorno da RF.");
            VerificaBotaoEnviar();
        }

        private void EnviarNota()
        {
            string emailsErrados = String.Empty;
            string emailsValidos = String.Empty;

            objNota.EmailDestinatario = txtEmail.Text;
            if (ValidaEmails(txtEmail.Text, out emailsErrados, out emailsValidos) || (MessageBox.Show("Deseja corrigir? (" + emailsErrados + "). Serão considerados apenas os e-mail válidos.", "Erro nos E-mails", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No))
            {
                btEnviarNFe.Enabled = false;
                btFechar.Enabled = false;
                objNota.PessoaCNPJCPF = txt2CNPJ_CPF.Text;
                objNota.EmailDestinatario = txtEmail.Text = emailsValidos;
                List<string> xmlNota = new List<string>();
                nfeController.GerarNFe(objNota.EmailDestinatario, objNota.Filial.FormaEmissao);
                if (nfeController.bEnviadoEmailNFE)
                {
                    objNota.DataEnvioNfe = DateTime.Now;
                }

                NotaController.Instancia.Salvar(objNota, Acao.Alterar);

                txtChaveNota.Text = objNota.ChaveNota;
                txtNumRecibo.Text = objNota.NumeroRecibo;
                txtNumProtocolo.Text = objNota.NumeroProtocolo;
            }
            else
            {
                txtEmail.Focus();
            }
        }

        private bool ValidaEmails(string listaEmails, out string emailsErrados, out string emailsValidos)
        {
            emailsErrados = String.Empty;
            List<string> lEmailsErrados = new List<string>();
            List<string> lEmailsValidos = new List<string>();
            if (!String.IsNullOrEmpty(listaEmails))
            {
                char separador = ',';
                if (listaEmails.Contains(";"))
                    separador = ';';
                string[] emails = listaEmails.Split(separador);
                for (int i = 0; i < emails.Count(); i++)
                {
                    int arroba = emails[i].IndexOf("@");
                    int ponto = -1;
                    if (arroba > 0)
                    {
                        ponto = emails[i].IndexOf(".", arroba);
                    }

                    if (arroba < 0 || ponto < 0)
                    {
                        lEmailsErrados.Add(emails[i]);
                    }
                    else
                    {
                        lEmailsValidos.Add(emails[i]);
                    }
                }
            }
            emailsValidos = String.Join(",", lEmailsValidos);
            if (lEmailsErrados.Count() > 0)
            {
                emailsErrados = "Verifique os seguintes e-mails: " + String.Join(",", lEmailsErrados);
                return false;
            }
            else
                return true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            nfeController.VisualizarDANFE();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var documentosNota = DocumentoController.Instancia.GetDocumentosPorNota(objNota.ID);
            if (DocumentoController.Instancia.ExisteDocumentoBaixado(documentosNota))
            {
                throw new Exception("Nota não pode ser cancelada porque possui documentos no financeiro já baixados.");
            }

            List<string> xmlNota = new List<string>();
            string motivo;
            if (new Aplicacao.InputBox().Show("", "Motivo Cancelamento", out motivo))
            {
                if (nfeController.CancelarNFe(motivo, MO.cwkGlobal.objUsuarioLogado.Login))
                {
                    if (objNota.TipoNota.BAtualizaPedido && objNota.NotaItems.Select(ni => ni.PedidoItens) != null
                        && objNota.NotaItems.Select(ni => ni.PedidoItens).Count() > 0 && objNota.Status == "3")
                    {
                        foreach (NotaItem notaItem in objNota.NotaItems)
                        {
                            foreach (NotaItemPedidoItem item in notaItem.PedidoItens)
                                NotaItemPedidoItemController.Instancia.RegisterDeleteIntoTransaction(item);
                            notaItem.PedidoItens = null;
                        }
                    }

                    NotaController.Instancia.RegisterNewIntoTransaction(objNota);
                    
                    NotaController.Instancia.CommitUnitOfWorkTransaction();

                    LogicaTelaNotaFiscal logicaTelaNotaFiscal = new LogicaTelaNotaFiscal(objNota);
                    logicaTelaNotaFiscal.AlteraStatusOSOrdemServico(logicaTelaNotaFiscal.PegaIDOrdemServico());

                    VerificaBotaoEnviar();

                    if (objNota.CancDt != null)
                    {
                        btEnviarNFe.Enabled = false;
                        btReciboNFe.Enabled = false;
                        btConsultaNFe.Enabled = false;
                        btEmail.Enabled = true;
                        btCancelarNFe.Enabled = false;
                        btEditarDanfe.Enabled = false;
                    }

                    this.Refresh();
                }
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            List<string> xmlNota = new List<string>();
            nfeController.ConsultarNFe();

            NotaController.Instancia.Salvar(objNota, Acao.Alterar);
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> xmlNota = new List<string>();
                nfeController.ConsultarRecibo();

                NotaController.Instancia.Salvar(objNota, Acao.Alterar);
            }
            catch (Exception exc)
            {
                new FormErro(exc).ShowDialog();
                NotaController.Instancia.Salvar(objNota, Acao.Alterar);
            }
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEditarDanfe_Click(object sender, EventArgs e)
        {
            nfeController.EditarDANFE();
        }

        private void btEmail_Click_1(object sender, EventArgs e)
        {
            new FormManutEnviaEmail(objNota, nfeController).ShowDialog();
        }

        public void AtualizarGrid(IList<string> lista)
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = lista;

            gridControl1.Refresh();
            this.Refresh();
            Application.DoEvents();
        }

        private void VerificaBotaoEnviar()
        {
            btPreDanfe.Enabled = true;
            switch (objNota.Status)
            {
                case "-1": EnableBotoes(false); btEnviarNFe.Enabled = true; btPreDanfe.Enabled = true; btnResolve.Enabled = true; break;
                case "0": EnableBotoes(false); btEnviarNFe.Enabled = true; btPreDanfe.Enabled = true; btnResolve.Enabled = true; break;
                case "1": EnableBotoes(false); btReciboNFe.Enabled = true; btnResolve.Enabled = true; break;
                case "2": EnableBotoes(true); objNota.BImpressa = true; btEnviarNFe.Enabled = false; btnResolve.Enabled = true; break;
                case "3": EnableBotoes(true); btEnviarNFe.Enabled = false; btnResolve.Enabled = false; break;
                case "8": EnableBotoes(true); btCancelarNFe.Enabled = false; btnResolve.Enabled = false; btEmail.Enabled = false; break;
                default: EnableBotoes(false); btEnviarNFe.Enabled = true; break;
            }
        }

        private void EnableBotoes(bool enabled)
        {
            btEnviarNFe.Enabled = enabled;
            btCancelarNFe.Enabled = enabled;
            btConsultaNFe.Enabled = enabled;
            btEditarDanfe.Enabled = enabled;
            btEmail.Enabled = enabled;
            btImprimirNFe.Enabled = enabled;
            btReciboNFe.Enabled = enabled;
            btnResolve.Enabled = enabled;
        }

        private void btPreDanfe_Click(object sender, EventArgs e)
        {
            try
            {
                nfeController.GerarXmlPreDanfe();
            }
            catch (Exception ex)
            {
                
                new FormErro(ex).ShowDialog();
            }
        }

        private void sbCCe_Click(object sender, EventArgs e)
        {

            if (objNota != null && objNota.ModeloDocto == 55 && objNota.Status == "2")
                {
                    FormCartaCorrecao form = new FormCartaCorrecao(objNota);
                    form.ShowDialog();
                }
                else
                {
                    string mensagem = "";
                    if (objNota == null)
                        mensagem = "Nenhum registro selecionado.";
                    else
                    {
                        if (objNota.ModeloDocto != 55)
                            mensagem = "Somente NFe podem emitir carta de correção.";
                        else
                        {
                            if (objNota.Status != "2")
                                mensagem = "Somente NFe autorizada pode emitir carta de correção.";
                        }                       
                    }

                    MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        private void sbConsultaCCe_Click(object sender, EventArgs e)
        {
            GridConsultaCCe Grid = new GridConsultaCCe(objNota);
            Grid.ShowDialog();
        }

        public Nota CamposDiferentesPessoa(Nota registroSelecionado)
        {
            var pessoa = PessoaController.Instancia.LoadObjectById(registroSelecionado.Pessoa.ID);
            StringBuilder strErros = new StringBuilder();
            int erros = 0;
            strErros.Append("Existem campos no cliente da nota divergentes do cadastro: " + "\n" + "\n" + "\n");

            if (registroSelecionado.PessoaNome != pessoa.Nome)
            {
                erros = 1;
                strErros.Append("Nome informado = " + registroSelecionado.PessoaNome + "\n" + "Nome Cadastro = " + pessoa.Nome + "\n" + "\n");
            }
            if (registroSelecionado.PessoaTelefone != pessoa.PessoaTelefones.Where(x => x.BPrincipal == true).First().Numero)
            {
                erros = 1;
                strErros.Append( "Telefone informado = " + registroSelecionado.PessoaTelefone + "\n" + "Telefone Cadastro = " + pessoa.PessoaTelefones.Where(x => x.BPrincipal == true).First().Numero + "\n" + "\n");
            }
            if (registroSelecionado.PessoaCNPJCPF != pessoa.CNPJ_CPF)
            {
                erros = 1;
                strErros.Append( "CNPJ informado = " + registroSelecionado.PessoaCNPJCPF + "\n" + "CNPJ Cadastro = " + pessoa.CNPJ_CPF + "\n" + "\n");
            }
            if (registroSelecionado.PessoaEndereco != (pessoa.EnderecoPrincipal().Endereco+ ", "+pessoa.EnderecoPrincipal().Numero))
            {
                strErros.Append("Endereço informado = " + registroSelecionado.PessoaEndereco + "\n" + "Endereço Cadastro = " + (pessoa.EnderecoPrincipal().Endereco + ", " + pessoa.EnderecoPrincipal().Numero) + "\n" + "\n");
                erros = 1;
            }
            if (registroSelecionado.PessoaCidade != pessoa.EnderecoPrincipal().Cidade.Nome)
            {
                strErros.Append("Cidade informada = " + registroSelecionado.PessoaCidade + "\n" + "Cidade Cadastro = " + pessoa.EnderecoPrincipal().Cidade.Nome + "\n" + "\n");
                erros = 1;
            }
            if (registroSelecionado.PessoaCidadeIBGE != pessoa.EnderecoPrincipal().Cidade.IBGE)
            {
                strErros.Append("IBGE informado = " + registroSelecionado.PessoaCidadeIBGE + "\n" + "IBGE Cadastro = " + pessoa.EnderecoPrincipal().Cidade.IBGE + "\n" + "\n");
                erros = 1;
            }
            if (registroSelecionado.PessoaInscRG != pessoa.Inscricao)
            {
               strErros.Append("IE informado = " + registroSelecionado.PessoaInscRG + "\n" + "IE Cadastro = " + pessoa.Inscricao + "\n" + "\n");
               erros = 1; 
            }
            if (registroSelecionado.PessoaBairro != pessoa.EnderecoPrincipal().Bairro)
            {
                strErros.Append("Bairro informado = " + registroSelecionado.PessoaBairro + "\n" + "Bairro Cadastro = " + pessoa.EnderecoPrincipal().Bairro + "\n" + "\n");
                erros = 1;
            }
            if (registroSelecionado.PessoaCEP != pessoa.EnderecoPrincipal().CEP)
            {
                strErros.Append("CEP informado = " + registroSelecionado.PessoaCEP + "\n" + "CEP Cadastro = " + pessoa.EnderecoPrincipal().CEP + "\n" + "\n");
                erros = 1;
            }
            if (registroSelecionado.PessoaUF != pessoa.EnderecoPrincipal().Cidade.UF.Sigla)
            {
                strErros.Append("UF informado = " + registroSelecionado.PessoaUF + "\n" + "UF Cadastro = " + pessoa.EnderecoPrincipal().Cidade.UF.Sigla + "\n" + "\n" + "\n");
                erros = 1;
            }
            strErros.Append("Deseja atualizar a nota?");

            if (erros == 1 && registroSelecionado.Status != "2"
                        && registroSelecionado.Status != "3" && registroSelecionado.Status != "7")
            {
                if (MessageBox.Show(strErros.ToString(), "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    registroSelecionado = AtualizarDadosPessoa(registroSelecionado, pessoa);
                }
                return registroSelecionado;
            }
            else
            {
                return registroSelecionado;
            }

        }

        public Nota AtualizarDadosPessoa(Nota registroSelecionado, Pessoa pessoa)
        {
            registroSelecionado.PessoaNome = pessoa.Nome;
            registroSelecionado.PessoaTelefone = pessoa.PessoaTelefones.Where(x => x.BPrincipal == true).First().Numero;
            registroSelecionado.PessoaCNPJCPF = pessoa.CNPJ_CPF;
            registroSelecionado.PessoaCidade = pessoa.EnderecoPrincipal().Cidade.Nome;
            registroSelecionado.PessoaBairro = pessoa.EnderecoPrincipal().Bairro;
            registroSelecionado.PessoaCEP = pessoa.EnderecoPrincipal().CEP;
            registroSelecionado.PessoaUF = pessoa.EnderecoPrincipal().Cidade.UF.Sigla;
            registroSelecionado.PessoaInscRG = pessoa.Inscricao;
            registroSelecionado.PessoaCidadeIBGE = pessoa.EnderecoPrincipal().Cidade.IBGE;
            registroSelecionado.PessoaEndereco = pessoa.EnderecoPrincipal().Endereco + ", " + pessoa.EnderecoPrincipal().Numero;

            NotaController.Instancia.Salvar(registroSelecionado, Acao.Alterar);
            return registroSelecionado;
        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
             if (objNota.ModeloDocto == 65)
            {
                if (!String.IsNullOrEmpty(objNota.ChaveNota))
                {
                    nfeController.ResolveNfce();

                    if (!String.IsNullOrEmpty(objNota.CancMotivo) && String.IsNullOrEmpty(objNota.CancUsuario))
                    {
                        objNota.CancUsuario = MO.cwkGlobal.objUsuarioLogado.Login;
                    }
                }
                else
                {
                    MessageBox.Show("Nota não enviada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
                MessageBox.Show("Está operação é apenas para notas NFC-e.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            
            NotaController.Instancia.Salvar(objNota, Acao.Alterar);

            txtChaveNota.Text = objNota.ChaveNota;
            txtNumRecibo.Text = objNota.NumeroRecibo;
            txtNumProtocolo.Text = objNota.NumeroProtocolo;
        }
    }
}