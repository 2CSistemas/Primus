using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using Ionic.Zip;
using System.Windows.Forms;
using System.Linq;


namespace Aplicacao
{
    public partial class FormManutXMLNFe : Aplicacao.Base.ManutBase
    {
        FilialController filialController = FilialController.Instancia;
        NotaController notaController = NotaController.Instancia;
        string folderXmls = "./XMLDestinatario";
        string folderPdfs = "./PDF";
        DataTable dt;
        DataSet ds;
        string path = "menubase2.xml";
        int idcod = 0;

        Filial objFilial;
        List<Filial> listFilial;
        public FormManutXMLNFe(DateTime? DataInicial, DateTime? DataFinal)
        {
            InitializeComponent();
            base.sbGravar.Text = "Enviar";
            ds = new DataSet();

            carregaComboEmpresa();

            if (System.IO.File.Exists(path))
            {
                ds.ReadXml(path);
                if (ds.Tables.IndexOf("FILTROS") > -1)
                {
                    DataRow drFind = ds.Tables["FILTROS"].Select("KEYWORD = 'KEY' AND CONTROL = '" + chbSalvarFiltro2.Name + "'").FirstOrDefault();
                    if (drFind != null && drFind["VALUE"].ToString().ToLower() == "true")
                    {
                        //Checkbox Pdf
                        chbSalvarFiltro2.Checked = (drFind["VALUE"].ToString().ToLower() ?? "false") == "true";
                        drFind = ds.Tables["FILTROS"].Select("KEYWORD = 'KEY' AND CONTROL = '" + cbPDF.Name + "'").FirstOrDefault();
                        if (drFind != null)
                        {
                            cbPDF.Checked = (drFind["VALUE"].ToString().ToLower() ?? "false") == "true";
                        }
                        //Destinatário
                        drFind = ds.Tables["FILTROS"].Select("KEYWORD = 'KEY' AND CONTROL = '" + txtDestinatario.Name + "'").FirstOrDefault();
                        if (drFind != null)
                        {
                            txtDestinatario.Text = drFind["VALUE"].ToString() ?? "";
                        }
                        //Assunto
                        drFind = ds.Tables["FILTROS"].Select("KEYWORD = 'KEY' AND CONTROL = '" + txtAssunto.Name + "'").FirstOrDefault();
                        if (drFind != null)
                        {
                            txtAssunto.Text = drFind["VALUE"].ToString() ?? "";
                        }
                        //Texto
                        drFind = ds.Tables["FILTROS"].Select("KEYWORD = 'KEY' AND CONTROL = '" + txtTexto.Name + "'").FirstOrDefault();
                        if (drFind != null)
                        {
                            txtTexto.Text = drFind["VALUE"].ToString() ?? "";
                        }
                        //Empresa
                        drFind = ds.Tables["FILTROS"].Select("KEYWORD = 'KEY' AND CONTROL = '" + cbIdEmpresa.Name + "'").FirstOrDefault();
                        if (drFind != null)
                        {
                            if (drFind["VALUE"].ToString() != "" && Convert.ToInt32(drFind["VALUE"].ToString()) > 0)
                            {
                                cbIdEmpresa.Properties.ValueMember = "ID";
                                cbIdEmpresa.Properties.DisplayMember = "Nome";
                                cbIdEmpresa.EditValue = Convert.ToInt32(drFind["VALUE"]);

                            }

                        }
                        // Data inicial
                        drFind = ds.Tables["FILTROS"].Select("KEYWORD = 'KEY' AND CONTROL = '" + dtInicio.Name + "'").FirstOrDefault();
                        if (drFind != null)
                        {
                            DateTime? dataInicial;
                            if (drFind["VALUE"].ToString() == "")
                            {
                                dataInicial = null;
                            }
                            else
                            {
                                dataInicial = Convert.ToDateTime(drFind["VALUE"].ToString() ?? "");
                            }
                            dtInicio.EditValue = dataInicial;
                        }
                        //Data final
                        drFind = ds.Tables["FILTROS"].Select("KEYWORD = 'KEY' AND CONTROL = '" + dtFim.Name + "'").FirstOrDefault();
                        if (drFind != null)
                        {
                            DateTime? dataFinal;
                            if (drFind["VALUE"].ToString() == "")
                            {
                                dataFinal = null;
                            }
                            else
                            {
                                dataFinal = Convert.ToDateTime(drFind["VALUE"].ToString() ?? "");
                            }
                            dtFim.EditValue = dataFinal;
                        }

                        // Envio Automático
                        drFind = ds.Tables["FILTROS"].Select("KEYWORD = 'KEY' AND CONTROL = '" + cbEnvioAutomatico.Name + "'").FirstOrDefault();
                        if (drFind != null)
                            cbEnvioAutomatico.Checked = (drFind["VALUE"].ToString().ToLower() ?? "false") == "true";

                        if (DataInicial.HasValue && DataFinal.HasValue)
                        {
                            dtInicio.EditValue = DataInicial;
                            dtFim.EditValue = DataFinal;
                        }
                    }
                }
            }
            else
            {
                dt = new DataTable("FILTROS");
                dt.Columns.Add("KEYWORD", typeof(string));
                dt.Columns.Add("CONTROL", typeof(string));
                dt.Columns.Add("VALUE", typeof(string));
            }
        }

        private void carregaComboEmpresa()
        {
            listFilial = new List<Filial>();
            listFilial.AddRange(filialController.GetAll());
            cbIdEmpresa.Properties.DataSource = listFilial;
            cbIdEmpresa.Properties.ValueMember = "ID";
        }

        protected override void sbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Gravar(bool Automatico = false)
        {
            objFilial = listFilial.FirstOrDefault(item => item.ID == Convert.ToInt32(cbIdEmpresa.EditValue));

            if (objFilial != null && objFilial.Ambiente == 1)
            {
                folderXmls = "./XmlDestinatarioHom";
                folderPdfs = "./pdfHom";
            }

            if (ValidaCampos())
            {
                var anexos = new List<FileInfo>();

                var xmls = getFiles(objFilial, dtInicio.DateTime, dtFim.DateTime, "xml");
                if (xmls.Count > 0)
                    anexos.Add(ZipTo(new FileInfo(objFilial.DiretorioPadraoNFe + folderXmls + "/XmlsZipados.zip"), xmls));
                else
                {
                    MessageBox.Show("Não há XMLs que atendam os critérios selecionados.");
                    return;
                }

                var pdfs = getFiles(objFilial, dtInicio.DateTime, dtFim.DateTime, "pdf");
                if (cbPDF.Checked)
                {
                    if (pdfs.Count > 0)
                        anexos.Add(ZipTo(new FileInfo(objFilial.DiretorioPadraoNFe + folderPdfs + "/PdfsZipados.zip"), pdfs));
                    else
                        MessageBox.Show("Não há PDFs que atendam os critérios selecionados.");
                }

                if (Automatico)
                {
                    LogExportacaoNotaController.Instancia.Salvar(new LogExportacaoNota
                    {
                        DataCadastro = DateTime.Now,
                        Periodo = $"{DateTime.Now.Month}/{DateTime.Now.Year}",
                        QuantidadePDF = pdfs.Count,
                        QuantidadeXML = xmls.Count
                    }, Acao.Incluir);
                }

                if (SendMail(txtDestinatario.EditValue.ToString(), txtAssunto.EditValue.ToString(), txtTexto.EditValue.ToString(), anexos.ToArray()))
                {
                    if (!Automatico)
                        MessageBox.Show("E-mail enviado com sucesso.", "Sucesso", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private bool ValidaCampos()
        {
            dxErroProvider.ClearErrors();

            if (cbIdEmpresa.EditValue == null) { dxErroProvider.SetError(cbIdEmpresa, "Selecione empresa"); }
            if (cbIdEmpresa.EditValue == null) { dxErroProvider.SetError(cbIdEmpresa, "Selecione empresa"); }
            if (dtInicio.EditValue == null) { dxErroProvider.SetError(dtInicio, "Selecione data inicial"); }
            if (dtFim.EditValue == null) { dxErroProvider.SetError(dtFim, "Selecione data final"); }
            if (dtFim.EditValue != null && dtInicio.EditValue != null && ((DateTime)dtInicio.EditValue) > ((DateTime)dtFim.EditValue)) { dxErroProvider.SetError(dtFim, "Período inválido"); }
            if (txtDestinatario.EditValue.ToString().Trim().Length < 5) { dxErroProvider.SetError(txtDestinatario, "Destinatário inválido"); } // melhorar

            return !dxErroProvider.HasErrors;
        }

        private List<FileInfo> getFiles(Filial filial, DateTime inicio, DateTime fim, String extensaoSemPonto)
        {
            DirectoryInfo pasta = null;
            if (extensaoSemPonto.Equals("xml"))
                pasta = new DirectoryInfo(filial.DiretorioPadraoNFe + folderXmls);
            else if (extensaoSemPonto.Equals("pdf"))
                pasta = new DirectoryInfo(filial.DiretorioPadraoNFe + folderPdfs);

            fim = fim.AddHours(23).AddMinutes(59).AddSeconds(59);

            var arquivos = new HashSet<FileInfo>();
            var notasFilial = notaController.GetNotasPorFilialNoPeriodo(filial, inicio, fim);

            foreach (var fileinfo in pasta.GetFiles("*." + extensaoSemPonto))
            {
                if (fileinfo.Name.Length < 39) continue;
                if (fileinfo.Name.Length < 40) continue;
                if (fileinfo.Name.Substring(6, 14).Equals(filial.CNPJ.Replace(".", "").Replace("-", "").Replace("/", "")))
                {
                    foreach (var nota in notasFilial)
                    {
                        if (Int32.Parse(fileinfo.Name.Substring(25, 9)).Equals(nota.Numero))
                        {
                            arquivos.Add(fileinfo);
                            break;
                        }
                    }
                }
            }

            return new List<FileInfo>(arquivos);
        }

        private FileInfo ZipTo(FileInfo destino, List<FileInfo> origens)
        {
            var filename = destino.FullName.Insert(destino.FullName.Length - 4, DateTime.Now.ToString("yyyy-MM-dd"));
            using (var zip = new ZipFile())
            {
                foreach (var item in origens)
                    zip.AddFile(item.FullName, ".");

                zip.Save(filename);
            }
            return new FileInfo(filename);
        }

        private bool SendMail(string destino, string assunto, string texto, FileInfo[] files)
        {
            try
            {
                var message = new System.Net.Mail.MailMessage(objFilial.UsuarioEmail, destino, assunto, texto);
                var anexos = new System.Net.Mail.Attachment[files.Length];

                for (var i = 0; i < files.Length; i++)
                    anexos[i] = new System.Net.Mail.Attachment(files[i].FullName);

                foreach (var anexo in anexos)
                    message.Attachments.Add(anexo);

                var client = new System.Net.Mail.SmtpClient(objFilial.ServidorSMTP, objFilial.PortaSmtp);
                var credencial = new System.Net.NetworkCredential(objFilial.UsuarioEmail, objFilial.SenhaEmail);
                client.UseDefaultCredentials = false;
                client.Credentials = credencial;
                client.Send(message);
                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Erro no envio do email:\n" + e.Message);
                return false;
            }
        }

        private void FormManutXMLNFe_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
                cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, typeof(FormManutXMLNFe).Name);
        }

        private void cbIdEmpresa_EditValueChanged(object sender, EventArgs e)
        {
            //DevExpress.XtraEditors.LookUpEdit editor = sender as DevExpress.XtraEditors.LookUpEdit;
            //try
            //{
            //    cwkGestao.Modelo.Filial filial = editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue) as cwkGestao.Modelo.Filial;
            //    idcod = Convert.ToInt32(filial.ID);
            //}
            //catch
            //{
            //}
        }

        private void sbGravar_Click_1(object sender, EventArgs e)
        {
            GravarClick();
        }

        public void GravarClick(bool mensagem = false)
        {
            if (ds.Tables.IndexOf("FILTROS") == -1)
            {
                ds.Tables.Add(dt);
            }
            DataRow drFind = ds.Tables["FILTROS"].Select("KEYWORD = 'KEY' AND CONTROL = '" + chbSalvarFiltro2.Name + "'").FirstOrDefault();
            if (drFind == null)
            {
                drFind = ds.Tables["FILTROS"].NewRow();
                drFind["KEYWORD"] = "KEY";
                drFind["CONTROL"] = chbSalvarFiltro2.Name;
                drFind["VALUE"] = chbSalvarFiltro2.Checked.ToString();
                ds.Tables["FILTROS"].Rows.Add(drFind);

            }
            else
            {
                drFind["CONTROL"] = chbSalvarFiltro2.Name;
                drFind["VALUE"] = chbSalvarFiltro2.Checked.ToString();
            }

            drFind = ds.Tables["FILTROS"].Select("KEYWORD = 'KEY' AND CONTROL = '" + cbPDF.Name + "'").FirstOrDefault();
            if (drFind == null)
            {
                drFind = ds.Tables["FILTROS"].NewRow();
                drFind["KEYWORD"] = "KEY";
                drFind["CONTROL"] = cbPDF.Name;
                drFind["VALUE"] = cbPDF.Checked.ToString();
                ds.Tables["FILTROS"].Rows.Add(drFind);
            }
            else
            {
                drFind["CONTROL"] = cbPDF.Name;
                drFind["VALUE"] = cbPDF.Checked.ToString();
            }


            drFind = ds.Tables["FILTROS"].Select("KEYWORD = 'KEY' AND CONTROL = '" + cbEnvioAutomatico.Name + "'").FirstOrDefault();
            if (drFind == null)
            {
                drFind = ds.Tables["FILTROS"].NewRow();
                drFind["KEYWORD"] = "KEY";
                drFind["CONTROL"] = cbEnvioAutomatico.Name;
                drFind["VALUE"] = cbEnvioAutomatico.Checked.ToString();
                ds.Tables["FILTROS"].Rows.Add(drFind);
            }
            else
            {
                drFind["CONTROL"] = cbEnvioAutomatico.Name;
                drFind["VALUE"] = cbEnvioAutomatico.Checked.ToString();
            }

            drFind = ds.Tables["FILTROS"].Select("KEYWORD = 'KEY' AND CONTROL = '" + txtDestinatario.Name + "'").FirstOrDefault();
            if (drFind == null)
            {
                drFind = ds.Tables["FILTROS"].NewRow();
                drFind["KEYWORD"] = "KEY";
                drFind["CONTROL"] = txtDestinatario.Name;
                drFind["VALUE"] = txtDestinatario.Text.ToString();
                ds.Tables["FILTROS"].Rows.Add(drFind);
            }
            else
            {
                drFind["CONTROL"] = txtDestinatario.Name;
                string destinatario;
                if (txtDestinatario.Text.ToString() == null)
                    destinatario = "";
                else
                    destinatario = txtDestinatario.Text.ToString();
                drFind["VALUE"] = destinatario;
            }

            drFind = ds.Tables["FILTROS"].Select("KEYWORD = 'KEY' AND CONTROL = '" + txtAssunto.Name + "'").FirstOrDefault();
            if (drFind == null)
            {
                drFind = ds.Tables["FILTROS"].NewRow();
                drFind["KEYWORD"] = "KEY";
                drFind["CONTROL"] = txtAssunto.Name;
                drFind["VALUE"] = txtAssunto.Text.ToString();
                ds.Tables["FILTROS"].Rows.Add(drFind);

            }
            else
            {
                drFind["CONTROL"] = txtAssunto.Name;
                string assunto = "";
                if (txtAssunto.Text.ToString() == null)
                {
                    assunto = "";
                }
                else
                {
                    assunto = txtAssunto.Text.ToString();
                }
                drFind["VALUE"] = assunto;
            }

            drFind = ds.Tables["FILTROS"].Select("KEYWORD = 'KEY' AND CONTROL = '" + txtTexto.Name + "'").FirstOrDefault();
            if (drFind == null)
            {
                drFind = ds.Tables["FILTROS"].NewRow();
                drFind["KEYWORD"] = "KEY";
                drFind["CONTROL"] = txtTexto.Name;
                drFind["VALUE"] = txtTexto.Text.ToString();
                ds.Tables["FILTROS"].Rows.Add(drFind);

            }
            else
            {
                drFind["CONTROL"] = txtTexto.Name;
                string texto = "";
                if (txtTexto.Text.ToString() == null)
                {
                    texto = "";
                }
                else
                {
                    texto = txtTexto.Text.ToString();
                }
                drFind["VALUE"] = texto;
            }

            drFind = ds.Tables["FILTROS"].Select("KEYWORD = 'KEY' AND CONTROL = '" + cbIdEmpresa.Name + "'").FirstOrDefault();
            Filial objFil = (Filial)listFilial.Where(item => item.ID == Convert.ToInt32(cbIdEmpresa.EditValue)).FirstOrDefault();
            if (objFil != null)
            {
                if (drFind == null)
                {
                    drFind = ds.Tables["FILTROS"].NewRow();
                    drFind["KEYWORD"] = "KEY";
                    drFind["CONTROL"] = cbIdEmpresa.Name;
                    drFind["VALUE"] = objFil.ID;
                    ds.Tables["FILTROS"].Rows.Add(drFind);

                }
                else
                {
                    drFind["CONTROL"] = cbIdEmpresa.Name;
                    drFind["VALUE"] = objFil.ID;
                }
            }

            drFind = ds.Tables["FILTROS"].Select("KEYWORD = 'KEY' AND CONTROL = '" + dtInicio.Name + "'").FirstOrDefault();
            if (drFind == null)
            {
                drFind = ds.Tables["FILTROS"].NewRow();
                drFind["KEYWORD"] = "KEY";
                drFind["CONTROL"] = dtInicio.Name;
                drFind["VALUE"] = dtInicio.EditValue.ToString();
                ds.Tables["FILTROS"].Rows.Add(drFind);

            }
            else
            {
                drFind["CONTROL"] = dtInicio.Name;
                string datInicio = "";
                if (dtInicio.EditValue == null)
                {
                    datInicio = "";
                }
                else
                {
                    datInicio = dtInicio.EditValue.ToString();
                }
                drFind["VALUE"] = datInicio;
            }

            drFind = ds.Tables["FILTROS"].Select("KEYWORD = 'KEY' AND CONTROL = '" + dtFim.Name + "'").FirstOrDefault();
            if (drFind == null)
            {
                drFind = ds.Tables["FILTROS"].NewRow();
                drFind["KEYWORD"] = "KEY";
                drFind["CONTROL"] = dtFim.Name;
                drFind["VALUE"] = dtFim.EditValue.ToString();
                ds.Tables["FILTROS"].Rows.Add(drFind);

            }
            else
            {
                drFind["CONTROL"] = dtFim.Name;
                string dataFinal;
                if (dtFim.EditValue == null)
                {
                    dataFinal = "";
                }
                else
                {
                    dataFinal = dtFim.EditValue.ToString();
                }
                drFind["VALUE"] = dataFinal;
            }

            ds.WriteXml(path);

            if (mensagem)
                MessageBox.Show("Configurações salvas com sucesso!", "Atenção");
        }

        private void btIncluirProduto_Click(object sender, EventArgs e)
        {
            GravarClick(true);
            Close();
        }
    }
}
