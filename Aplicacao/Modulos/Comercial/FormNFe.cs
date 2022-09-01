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
using NFe.Servicos.Retorno;
using DBUtils.Classes;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using cwkGestao.Modelo.Util;

namespace Aplicacao
{
    public partial class FormNFe : Form, IObserverNFe
    {
        public int IDNota;
        private bool lConfirmaEmail = true;
        private cwkGestao.Modelo.Nota objNota;
        public cwkGestao.NFe.NFeController nfeController;
        private FormaEmissaoNFe formaEmissao;
        private int? Serie = 0;
        private string CPF;
        protected override CreateParams CreateParams
        {
            get
            {
                var param = base.CreateParams;
                param.ClassStyle = param.ClassStyle | 0x200;
                return param;
            }
        }

        public FormNFe(int? _Serie = null, string _CPF = null)
        {
            InitializeComponent();

            Serie = _Serie;
            CPF = _CPF;
        }

        private void FormNFe_Load(object sender, EventArgs e)
        {
            FillObjNFe();
        }

        public void FillObjNFe(bool PreencherDataBinds = true)
        {
            objNota = NotaController.Instancia.LoadObjectById(IDNota);
            objNota.EmailDestinatario = objNota.EmailNota;

            if (!string.IsNullOrEmpty(CPF))
                objNota.PessoaCNPJCPF = CPF;

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

            if (!Serie.HasValue)
                Serie = string.IsNullOrEmpty(objNota.Serie) ? 1 : Convert.ToInt32(objNota.Serie);
            else
                objNota.Serie = Serie.ToString();

            if (PreencherDataBinds)
            {
                txtSerie.DataBindings.Add("EditValue", objNota, "Serie", true, DataSourceUpdateMode.OnPropertyChanged, Serie);
                txtNumero.DataBindings.Add("EditValue", objNota, "Numero", true, DataSourceUpdateMode.OnPropertyChanged, objNota.Numero);
                txtData.DataBindings.Add("EditValue", objNota, "Dt", true, DataSourceUpdateMode.OnPropertyChanged, objNota.Dt);
                txtTotalNota.DataBindings.Add("EditValue", objNota, "TotalNota", true, DataSourceUpdateMode.OnPropertyChanged, objNota.TotalNota);
                txtPessoaNome.DataBindings.Add("EditValue", objNota, "PessoaNome", true, DataSourceUpdateMode.OnPropertyChanged, objNota.PessoaNome);

                txt2CNPJ_CPF.DataBindings.Add("EditValue", objNota, "PessoaCNPJCPF", true, DataSourceUpdateMode.OnPropertyChanged, objNota.PessoaCNPJCPF);

                var Mask = @"\d\d\d\.\d\d\d\.\d\d\d-\d\d";
                if (objNota.PessoaCNPJCPF.OnlyNumbers().Length == 14)
                    Mask = @"\d\d\.\d\d\d\.\d\d\d\.\d\d\d\d-\d\d";

                txt2CNPJ_CPF.Properties.Mask.EditMask = Mask;

                txtEmail.DataBindings.Add("EditValue", objNota, "EmailDestinatario", true, DataSourceUpdateMode.OnPropertyChanged, objNota.EmailDestinatario);
                txtChaveNota.DataBindings.Add("EditValue", objNota, "ChaveNota", true, DataSourceUpdateMode.OnPropertyChanged, objNota.ChaveNota);
                txtNumRecibo.DataBindings.Add("EditValue", objNota, "NumeroRecibo", true, DataSourceUpdateMode.OnPropertyChanged, objNota.NumeroRecibo);
                txtNumProtocolo.DataBindings.Add("EditValue", objNota, "NumeroProtocolo", true, DataSourceUpdateMode.OnPropertyChanged, objNota.NumeroProtocolo);
            }

            gridControl1.DataSource = nfeController.DesmembrarXml();

            VerificaBotaoEnviar();

            if (!string.IsNullOrEmpty(objNota.UltimoXmlRecebido) && objNota.UltimoXmlRecebido.Contains("<cStat>100</cStat>") && btEnviarNFe.Enabled)
            {
                // Duplicidade
                gridControl1.DataSource = new List<string> { "NFe em duplicidade." };
            }

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
                if (objNota.Filial.ComponenteDfe == 0) // 0 = TecnoSpeed / 1 = Zeus Automação
                {
                    btnResolve.Visible = true;
                }
                else
                {
                    btnResolve.Enabled = false;
                    btPreDanfe.Enabled = false;
                    btEditarDanfe.Enabled = false;
                }
            }

            if (objNota.Filial.FormaEmissao == 1)
                txtEmail.Enabled = true;
            else
            {
                txtEmail.Text = String.Empty;
                txtEmail.Enabled = false;
            }

            txt2CNPJ_CPF.Enabled = objNota.Status != "2"; //!InformouCPF();

            this.Refresh();
        }

        private string GetExpiration(string SerialNumber)
        {
            try
            {
                X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
                store.Open(OpenFlags.ReadOnly);
                foreach (var item in store.Certificates)
                    if (item.SerialNumber == SerialNumber)
                        return item.GetExpirationDateString();

                return string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }

        private bool verificarValidadeCertificado()
        {
            var Data = GetExpiration(objNota.Filial.Certificado);
            if (string.IsNullOrEmpty(Data))
                return false;

            if (Convert.ToDateTime(Data).Date < DateTime.Now.Date)
            {
                MessageBox.Show($"Certificado vencido. Data de validade: {Convert.ToDateTime(Data)}.", "Atenção!");
                return false;
            }

            return true;
        }

        public Nota ShowEnvia(bool MostrarFormulario, Nota ObjNota)
        {
            lConfirmaEmail = false;

            objNota = ObjNota;
            
            FillObjNFe(false);

            EnviarNota();

            if (MostrarFormulario)
                ShowDialog();

            // Se tiver número do protocolo apos o envio, considera que enviou a NFCe
            return objNota;
        }

        private bool InformouCPF()
        {
            if (string.IsNullOrEmpty(txt2CNPJ_CPF.Text))
                return false;
            long cnpj = 0;
            string strNumeros = cwkGestao.Modelo.Util.StringUtil.GetSomenteNumeros(txt2CNPJ_CPF.Text);

            if ("00000000000" == strNumeros)
                return false;

            return long.TryParse(strNumeros, out cnpj);
        }

        private void EnviarNFCe()
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
                        else if (!lConfirmaEmail || (String.IsNullOrEmpty(txtEmail.Text) && (MessageBox.Show("Deseja informar o e-mail? Caso contrário o e-mail não será enviado", "Informar E-mail", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)))
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            EnviarNFCe();
        }

        private bool ConexaoInternet()
        {
            try
            {
                using (var webClient = new System.Net.WebClient())
                using (webClient.OpenRead("https://www.google.com"))
                    return true;
            }
            catch
            {
                return false;
            }
        }

        public void EnviarNota()
        {
            if (!verificarValidadeCertificado())
                return;

            var emailsErrados = string.Empty;
            var emailsValidos = string.Empty;

            objNota.EmailDestinatario = txtEmail.Text;
            if (ValidaEmails(txtEmail.Text, out emailsErrados, out emailsValidos) || (MessageBox.Show("Deseja corrigir? (" + emailsErrados + "). Serão considerados apenas os e-mail válidos.", "Erro nos E-mails", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No))
            {
                btEnviarNFe.Enabled = false;
                btFechar.Enabled = false;
                if (!string.IsNullOrEmpty(CPF))
                    objNota.PessoaCNPJCPF = CPF;

                if (objNota.PessoaCNPJCPF == "000.000.000-00")
                    objNota.PessoaCNPJCPF = null;

                objNota.EmailDestinatario = txtEmail.Text = emailsValidos;
                List<string> xmlNota = new List<string>();

                // nfceOffline = Retorno da validação da conexão: SIM = Irá gerar nfce em contingencia
                var nfceOffline = objNota.ModeloDocto == 65 ? !ConexaoInternet() : false;

                if (!string.IsNullOrEmpty(objNota.PessoaCNPJCPF))
                {
                    if (!CpfCnpjUtils.IsValid(objNota.PessoaCNPJCPF))
                        throw new Exception("O CPF/CNPJ é inválido.");
                }

                nfeController.GerarNFe(objNota.EmailDestinatario, objNota.Filial.FormaEmissao, nfceOffline, objNota.Filial.CaminhoLogoNfe);
                if (nfeController.Duplicidade)
                {
                    txtChaveNota.Text = objNota.ChaveNota;
                    txtNumRecibo.Text = objNota.NumeroRecibo;
                    txtNumProtocolo.Text = objNota.NumeroProtocolo;
                    CancelarNfe(true);
                }
                else
                {
                    if (nfeController.bEnviadoEmailNFE)
                        objNota.DataEnvioNfe = DateTime.Now;

                    NotaController.Instancia.Salvar(objNota, Acao.Alterar);

                    txtChaveNota.Text = objNota.ChaveNota;
                    txtNumRecibo.Text = objNota.NumeroRecibo;
                    txtNumProtocolo.Text = objNota.NumeroProtocolo;
                }
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

        private IniFile ArquivoIni;
        private string CaminhoIni => Debugger.IsAttached
            ? $"{Path.GetFullPath(".").Substring(0, Path.GetFullPath(".").IndexOf("cwkGestao"))}cwkGestao\\App_Data\\Start.ini"
            : $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\App_Data\\Start.ini";
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ArquivoIni = new IniFile(CaminhoIni);
            string NomeImpressora = ArquivoIni.GetValue("Configuracoes_PDV", "NOME_IMPRESSORA_NOTANFCE", "");

            nfeController.ImprimirNFCe(NomeImpressora, false, objNota.Filial?.CaminhoLogoNfe);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            CancelarNfe(false);
        }

        private void CancelarNfe(bool CancelamentoPorDuplicidade)
        {
            var documentosNota = DocumentoController.Instancia.GetDocumentosPorNota(objNota.ID);
            if (DocumentoController.Instancia.ExisteDocumentoBaixado(documentosNota))
                if (CancelamentoPorDuplicidade)
                {
                    FormErro.ShowDialog("NFe está em duplicidade. Nota não pode ser cancelada porque possui documentos no financeiro já baixados.", "");
                    return;
                }
                else
                {
                    FormErro.ShowDialog("Nota não pode ser cancelada porque possui documentos no financeiro já baixados.", "");
                    return;
                }

            if (CancelamentoPorDuplicidade)
            {
                if (nfeController.CancelarNFe("DOCUMENTO FISCAL EM DUPLICIDADE", MO.cwkGlobal.objUsuarioLogado.Login, true))
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
            else
            {
                List<string> xmlNota = new List<string>();
                string motivo;
                if (new Aplicacao.InputBox().Show("", "Motivo Cancelamento", out motivo))
                {
                    if (nfeController.CancelarNFe(motivo, MO.cwkGlobal.objUsuarioLogado.Login, false))
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
            nfeController.EditarDANFE(objNota.Filial?.CaminhoLogoNfe);
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
                case "9": EnableBotoes(true); btEnviarNFe.Enabled = true; btPreDanfe.Enabled = true; btnResolve.Enabled = true; break;
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

        public void btPreDanfe_Click(object sender, EventArgs e)
        {
            VisualizarPreDanfe();
        }

        public void VisualizarPreDanfe()
        {
            try
            {
                nfeController.GerarXmlPreDanfe(objNota.Filial?.CaminhoLogoNfe);

                TopMost = true;
                Activate();
                BringToFront();
            }
            catch (Exception ex)
            {

                new FormErro(ex).ShowDialog();
            }

            TopMost = false;
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

    public static class CpfCnpjUtils
    {
        public static bool IsValid(string cpfCnpj)
        {
            return (IsCpf(cpfCnpj) || IsCnpj(cpfCnpj));
        }

        private static bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = cpf.Trim().Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;

            for (int j = 0; j < 10; j++)
                if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == cpf)
                    return false;

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

        private static bool IsCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            cnpj = cnpj.Trim().Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;

            string tempCnpj = cnpj.Substring(0, 12);
            int soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            int resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);
        }
    }
}