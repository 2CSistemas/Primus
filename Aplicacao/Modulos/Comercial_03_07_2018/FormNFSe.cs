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
using cwkGestao.Negocio.Comercial;
using cwkGestao.Negocio.Padroes;
using System.Web;
using System.IO;
using System.Runtime.InteropServices;
using System.Net;
using System.Collections.Specialized;
using System.Globalization;
using Aplicacao.Util;
using System.Reflection;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormNFSe : Form
    {
        private Nota NFSe;
        private HttpManager httpManager = new HttpManager();
        private ConfiguracaoManager configManager = ConfiguracaoManagerController.Instancia.GetAll().FirstOrDefault();
        

        public FormNFSe(Nota _NFSe)
        {
            InitializeComponent();
            this.NFSe = _NFSe;
        }

        public void AtualizarGrid(IList<string> lista)
        {

        }

        private void FormNFSe_Shown(object sender, EventArgs e)
        {
            IList<string> frasesNFSe = new List<string>();
            frasesNFSe.Add(NFSe.FrasesNFSe);

            txtSerie.EditValue = NFSe.Serie;
            txtNumero.EditValue = NFSe.Numero;
            txtPessoaNome.EditValue = NFSe.Pessoa.Nome;
            txtData.EditValue = NFSe.Dt;
            txtTotalNota.EditValue = NFSe.TotalNota;
            txtNumeroNFSe.EditValue = NFSe.NumeroNFSe == null ? 0 : NFSe.NumeroNFSe;
            txtSituacao.EditValue = NFSe.StatusLegivel;
            txtdtAutorizacao.Text = String.Format("{0:dd/MM/yyyy HH:mm}", NFSe.DtHoraAuto);
            txtdtCancelamento.Text = String.Format("{0:dd/MM/yyyy HH:mm}", NFSe.DtHoraCanc);
            gridControl1.DataSource = frasesNFSe;
            MostrarCamposErrados(NFSe);
            HabilitaBotoes();
        }

        private void MostrarCamposErrados(Nota nota)
        {
            bool ok = false;
            StringBuilder erros = new StringBuilder();
            erros.Append("Por favor, verifique os seguintes campos: \n");

            if (nota.Pessoa.TelefonePrincipal == null || nota.Pessoa.TelefonePrincipal == "")
            {
                erros.Append("- Telefone Principal \n");
                ok = true;
            }

            if (ok)
                MessageBox.Show(erros.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HabilitaBotoes()
        {
            switch (NFSe.Status)
            {
                case "2":
                    btEnviarNFSe.Enabled = false;
                    sbResolve.Enabled = true;
                    btCancelarNFSe.Enabled = true;
                    btImprimirNFSe.Enabled = true;
                    btEmail.Enabled = true;
                    txtSerie.Enabled = false;
                    txtNumero.Enabled = false;
                    break;
                case "0":
                    sbResolve.Enabled = false;
                    btCancelarNFSe.Enabled = true;
                    btImprimirNFSe.Enabled = true;
                    btEmail.Enabled = false;
                    btEnviarNFSe.Enabled = true;
                    break;
                case "3":
                    btEnviarNFSe.Enabled = false;
                    sbResolve.Enabled = true;
                    btEmail.Enabled = true;
                    btImprimirNFSe.Enabled = true;
                    btCancelarNFSe.Enabled = false;
                    txtSerie.Enabled = false;
                    txtNumero.Enabled = false;
                    break;
                case "1":
                    btEnviarNFSe.Enabled = true;
                    sbResolve.Enabled = true;
                    btCancelarNFSe.Enabled = true;
                    btImprimirNFSe.Enabled = true;
                    btEmail.Enabled = true;
                    break;
                default:
                    btEnviarNFSe.Enabled = true;
                    sbResolve.Enabled = true;
                    btCancelarNFSe.Enabled = true;
                    btImprimirNFSe.Enabled = true;
                    btEmail.Enabled = true;
                    break;
            }

            this.Refresh();
        }

        private void DesabilitaBotoes()
        {
            btCancelarNFSe.Enabled = false;
            btEmail.Enabled = false;
            btImprimirNFSe.Enabled = false;
            sbResolve.Enabled = false;
            btEnviarNFSe.Enabled = false;

            this.Refresh();
        }

        private void btEnviarNFSe_Click(object sender, EventArgs e)
        {
            NFSe.Serie = txtSerie.Text;
            NFSe.Numero = Convert.ToInt32(txtNumero.Text);
            var notaBD = NotaController.Instancia.VerificaSeExisteNFSePeloNumeroBD(NFSe.Numero).FirstOrDefault();
            if (notaBD != null && notaBD.ID != NFSe.ID && notaBD.Serie == NFSe.Serie)
            {
                MessageBox.Show("Já existe uma NFSe cadastrada com esse número e serie no Gestão !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            NotaController.Instancia.Salvar(NFSe, Acao.Alterar);
            IList<string> auxRetornoEnvia = new List<string>();

            try
            {
                DesabilitaBotoes();

                var TX2 = NFSEManager.GeradorTX2(NFSEManager.ConstrutorNFSE(NFSe));
                StringBuilder sd = new StringBuilder();

                foreach (var item in TX2)
                {
                    sd.AppendLine(item);
                }
                string s = sd.ToString();

                try
                {
                    string caminho = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    caminho = caminho + "\\tx2NFSE.txt";
                    using (StreamWriter outfile = new StreamWriter(caminho))
                    {
                        outfile.Write(s);
                    }

                }
                catch (Exception)
                {
                    
                }
                //Parametros necessários para o envio da NFSe para o Manager eDoc.
                NameValueCollection reqparm = new NameValueCollection();
                reqparm.Add("CNPJ", NFSe.Filial.CNPJ.Replace(".", "").Replace("/", "").Replace("-", ""));
                reqparm.Add("senha", configManager.senha);
                reqparm.Add("usuario", configManager.usuario);
                reqparm.Add("grupo", NFSe.Filial.GrupoManager);
                reqparm.Add("arquivo", s.Trim());

                ExibeCursorEspera cursor = new ExibeCursorEspera();
                using (cursor)
                {
                    NFSe.FrasesNFSe = httpManager.PostManager(configManager, NFSe, "nfse", "envia", reqparm).FirstOrDefault().Replace(@"\delimiter", "\r\n");
                    ConsultaNFSe();
                }

                auxRetornoEnvia.Add(NFSe.FrasesNFSe);
                NotaController.Instancia.Salvar(NFSe, Acao.Alterar);
                gridControl1.DataSource = auxRetornoEnvia;

                this.WindowState = FormWindowState.Normal;

                HabilitaBotoes();
            }
            catch (Exception exc)
            {
                HabilitaBotoes();
                if (exc.Message.Contains("startIndex não pode ser maior que o comprimento da seqüência de caracteres"))
                    MessageBox.Show("Existem campos que não foram preenchidos corretamente !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (exc.Message.Contains("Impossível conectar-se ao servidor remoto"))
                    MessageBox.Show("Verifique sua conexão com a internet, \r\nVerifique o ip do Manager em configuração Manager, \r\nVerifique se o Manager está ativo !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
           
            }
        }

        private void ConsultaNFSe()
        {
            IList<string> ConsultaNFSe = new List<string>();
            IList<string> ParametrosConsulta = new List<string>();

            //parametros para consulta da NFSe no Manager.
            ParametrosConsulta.Add("CNPJ=" + NFSe.Filial.CNPJ.Replace(".", "").Replace("/", "").Replace("-", ""));
            ParametrosConsulta.Add("grupo=" + NFSe.Filial.GrupoManager);
            ParametrosConsulta.Add("Filtro=nrps=" + NFSe.Numero.ToString());
            ParametrosConsulta.Add("Campos=handle,nnfse,situacao,dtautorizacao,dtcancelamento");
            ConsultaNFSe = httpManager.GetManager(configManager, NFSe, "nfse", "consulta", ParametrosConsulta);

            string[] ret = ConsultaNFSe.FirstOrDefault().Split(new char[] { ',' });

            if (ConsultaNFSe.FirstOrDefault().ToLower().Contains("nenhum"))
            {
                NFSe.Status = "-1";
                NFSe.ModeloDocto = 2;
                return;
            }

            NFSe.Handle = Convert.ToInt32(ret[0]);

            if (ret[1] == "")
                ret[1] = "0";

            NFSe.NumeroNFSe = Convert.ToInt32(ret[1]);
            switch (ret[2].ToLower())
            {
                case "autorizada":
                    NFSe.Status = "2";
                    NFSe.ModeloDocto = 3;
                    NFSe.BImpressa = true;
                    NFSe.DtHoraAuto = NFSe.DtHoraAuto != null ? NFSe.DtHoraAuto : DateTime.Now;
                    txtNumeroNFSe.EditValue = NFSe.NumeroNFSe;
                    txtdtAutorizacao.Text = String.Format("{0:dd/MM/yyyy HH:mm}", NFSe.DtHoraAuto);
                    SalvarXmlDestinatarioComPdf();
                    break;
                case "rejeitada":
                    NFSe.Status = "0";
                    NFSe.ModeloDocto = 2;
                    NFSe.LoteNFSe = NotaController.Instancia.GetNovoLoteNFSe() + 1;
                    DescartaNFSe();
                    break;
                case "cancelada":
                    NFSe.Status = "3";
                    NFSe.ModeloDocto = 3;
                    NFSe.CancDt = DateTime.Today;
                    NFSe.CancUsuario = MO.cwkGlobal.objUsuarioLogado.Login;
                    NFSe.DtHoraCanc = NFSe.DtHoraCanc != null ? NFSe.DtHoraCanc : DateTime.Now;
                    txtdtCancelamento.Text = String.Format("{0:dd/MM/yyyy HH:mm}", NFSe.DtHoraCanc);
                    SalvarXmlDestinatarioComPdf();
                    break;
                case "registrada":
                    NFSe.Status = "6";
                    NFSe.ModeloDocto = 2;
                    break;
                case "enviada":
                    NFSe.Status = "5";
                    NFSe.ModeloDocto = 2;
                    break;
                case "pendente":
                    NFSe.Status = "4";
                    NFSe.ModeloDocto = 2;
                    break;

                default:
                    NFSe.Status = "4";
                    NFSe.ModeloDocto = 2;
                    break;
            }

            txtSituacao.EditValue = NFSe.StatusLegivel;
        }

        private void btCancelarNFSe_Click(object sender, EventArgs e)
        {
            
            IList<string> auxRetornoCancela = new List<string>();
            try
            {
                DesabilitaBotoes();

                if (NFSe.Status != "2")
                {
                    MessageBox.Show("Não é possível cancelar uma NFSe que não esteja Autorizada !","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    HabilitaBotoes();
                    return;
                }
                var documentosNota = DocumentoController.Instancia.GetDocumentosPorNota(NFSe.ID);
                if (DocumentoController.Instancia.ExisteDocumentoBaixado(documentosNota))
                {
                    throw new Exception("Nota não pode ser cancelada porque possui documentos no financeiro já baixados.");
                }


                if ((MessageBox.Show("Deseja cancelar a NFSe ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    NameValueCollection reqparm = new NameValueCollection();
                    reqparm.Add("Grupo", NFSe.Filial.GrupoManager);
                    reqparm.Add("CNPJ", NFSe.Filial.CNPJ.Replace(".", "").Replace("/", "").Replace("-", ""));
                    reqparm.Add("NomeCidade", cwkGestao.Negocio.Utils.NFSEUtils.RemoveAcentos(NFSe.Filial.Cidade.Nome));
                    reqparm.Add("NumNFSe", NFSe.NumeroNFSe.ToString());

                    ExibeCursorEspera cursor = new ExibeCursorEspera();
                    using (cursor)
                    {
                        NFSe.FrasesNFSe = httpManager.PostManager(configManager, NFSe, "nfse", "cancela", reqparm).FirstOrDefault();
                        //atualizar status NFSe e depois salvar;
                        ConsultaNFSe();
                    }
                    

                    auxRetornoCancela.Add(NFSe.FrasesNFSe);
                    if (NFSe.FrasesNFSe.Contains("Cancelamento de NFS-e Homologado"))
                    {
                    var docsnota = DocumentoController.Instancia.GetDocumentosPorNota(NFSe.ID);
                    DocumentoController.Instancia.CancelarDocumentosNFSe(docsnota);    
                    }
                    gridControl1.DataSource = auxRetornoCancela;

                    NotaController.Instancia.Salvar(NFSe, Acao.Alterar);
                    this.WindowState = FormWindowState.Normal;

                    LogicaTelaNotaFiscal logicaTelaNotaFiscal = new LogicaTelaNotaFiscal(NFSe);
                    logicaTelaNotaFiscal.AlteraStatusOSOrdemServico(logicaTelaNotaFiscal.PegaIDOrdemServico());

                }

                HabilitaBotoes();
            }
            catch (Exception exc)
            {
                HabilitaBotoes();
                MessageBox.Show(exc.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
        }

        private void btEmail_Click(object sender, EventArgs e)
        {
            DesabilitaBotoes();

            try
            {
                //chama tela de envio de email da NFSe.
                if (NFSe.Status == "2" || NFSe.Status == "3")
                {
                    FormEnviaEmailNFSe form = new FormEnviaEmailNFSe(NFSe);
                    form.ShowDialog();
                }
                else
                    MessageBox.Show("Somente Notas Autorizadas ou Canceladas pode-se enviar email.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                HabilitaBotoes();
            }
            catch (Exception exc)
            {
                HabilitaBotoes();
                new FormErro(exc).ShowDialog();
                
            }
        }

        private void btImprimirNFSe_Click(object sender, EventArgs e)
        {
            string ret = "";

            DesabilitaBotoes();

            try
            {
                if (NFSe.Status == "2" || NFSe.Status == "3")
                {
                    IList<string> ParametrosImprimir = new List<string>();

                    ParametrosImprimir.Add("NomeCidade=" + cwkGestao.Negocio.Utils.NFSEUtils.RemoveAcentos(NFSe.Filial.Cidade.Nome));
                    ParametrosImprimir.Add("NumNFSe=" + NFSe.NumeroNFSe.ToString());
                    ParametrosImprimir.Add("ModoImpressao=" + "PDF");
                    ParametrosImprimir.Add("Url=1");
                    ParametrosImprimir.Add("Quantidade=1");

                    ExibeCursorEspera cursor = new ExibeCursorEspera();
                    using (cursor)
                    {
                        ret = httpManager.GetManager(configManager, NFSe, "nfse", "imprime", ParametrosImprimir).FirstOrDefault();
                    }

                    this.WindowState = FormWindowState.Normal;

                    System.Diagnostics.Process.Start(ret);
                }
                else
                    MessageBox.Show("Somente Notas Autorizadas ou Canceladas pode-se imprimir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                HabilitaBotoes();

                
            }
            catch (Exception exc)
            {
                HabilitaBotoes();
                new FormErro(exc).ShowDialog();
                
            }
        }

        private void DescartaNFSe()
        {
            NameValueCollection reqparm = new NameValueCollection();
            reqparm.Add("NomeCidade", cwkGestao.Negocio.Utils.NFSEUtils.RemoveAcentos(NFSe.Filial.Cidade.Nome));
            reqparm.Add("Handle", NFSe.Handle.ToString());

            httpManager.PostManager(configManager, NFSe, "nfse", "descarta", reqparm);
        }

        private void SalvarXmlDestinatarioComPdf()
        {
            IList<string> parametros = new List<string>();
            parametros.Add("NomeCidade=" + cwkGestao.Negocio.Utils.NFSEUtils.RemoveAcentos(NFSe.Filial.Cidade.Nome));
            parametros.Add("handle=" + NFSe.Handle);

            var xml = httpManager.GetManager(configManager,NFSe,"nfse","xml",parametros);

            if (Directory.Exists(configManager.CaminhoXMLNFSE))
            {
                File.WriteAllText(configManager.CaminhoXMLNFSE + @"\" + NFSe.Handle + ".xml", xml.FirstOrDefault());
            }
            else
            {
                MessageBox.Show("Diretório de xml's não foi informado ou não existe em Configuração Manager. \r\nNão foi possível gerar o xml !",
                    "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            GeraPdfAutomatico();
        }

        private void GeraPdfAutomatico()
        {
            IList<string> ParametrosImprimir = new List<string>();

            ParametrosImprimir.Add("NomeCidade=" + cwkGestao.Negocio.Utils.NFSEUtils.RemoveAcentos(NFSe.Filial.Cidade.Nome));
            ParametrosImprimir.Add("NumNFSe=" + NFSe.NumeroNFSe.ToString());
            ParametrosImprimir.Add("ModoImpressao=" + "PDF");
            ParametrosImprimir.Add("Url=1");
            ParametrosImprimir.Add("Quantidade=1");

            httpManager.GetManager(configManager, NFSe, "nfse", "imprime", ParametrosImprimir).FirstOrDefault();
            this.WindowState = FormWindowState.Normal;
        }

        private void sbResolve_Click(object sender, EventArgs e)
        {
            DesabilitaBotoes();

            IList<string> auxRet = new List<string>();

            try
            {
                NameValueCollection reqparm = new NameValueCollection();
                reqparm.Add("CNPJ" , NFSe.Filial.CNPJ.Replace(".", "").Replace("/", "").Replace("-", ""));
                reqparm.Add("grupo" , NFSe.Filial.GrupoManager);
                reqparm.Add("NomeCidade", cwkGestao.Negocio.Utils.NFSEUtils.RemoveAcentos(NFSe.Filial.Cidade.Nome));
                reqparm.Add("Handle", NFSe.Handle.ToString());

                ExibeCursorEspera cursor = new ExibeCursorEspera();
                using (cursor)
                {
                    NFSe.FrasesNFSe = httpManager.PostManager(configManager, NFSe, "nfse", "resolve", reqparm).FirstOrDefault();
                    ConsultaNFSe();
                }

                NotaController.Instancia.Salvar(NFSe, Acao.Alterar);

                auxRet.Add(NFSe.FrasesNFSe);
                gridControl1.DataSource = auxRet;

                this.WindowState = FormWindowState.Normal;

                HabilitaBotoes();
            }
            catch (Exception ex)
            {
                HabilitaBotoes();
                new FormErro(ex).ShowDialog();
            }

        }
    }
}