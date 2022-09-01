using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using System.Linq;

namespace Aplicacao
{
    public partial class FormManutVersao : Aplicacao.Base.ManutBase
    {
        private cwkGestao.Modelo.Versao objVersao;
        private cwkGestao.Modelo.Sistema objSistema;
        private VersaoController versaoController = VersaoController.Instancia;

        public FormManutVersao(cwkGestao.Modelo.Sistema pSistema)
        {
            InitializeComponent();
            objSistema = pSistema;
        }

        public override void CarregaObjeto()
        {
            switch (cwAcao)
            {
                case 1:
                    objVersao = new cwkGestao.Modelo.Versao();
                    txtCodigo.EditValue = versaoController.MaxCodigo(objSistema.Versaos);
                    break;
                default:
                    objVersao = objSistema.Versaos.Where(v => v.Codigo == cwID).First();
                    txtCodigo.EditValue = objVersao.Codigo;
                    txtNumero.EditValue = objVersao.Numero;
                    txtDataLiberacao.EditValue = objVersao.DataLiberacao;
                    txtObservacao.EditValue = objVersao.Observacao;
                    cbTipoBanco.SelectedIndex = Convert.ToInt32(objVersao.Tipobanco);
                    txtCaminhobancolimpo.EditValue = objVersao.Caminhobancolimpo;
                    txtServidor.EditValue = objVersao.Servidor;
                    txtBanco.EditValue = objVersao.Banco;
                    txtUsuario.EditValue = objVersao.Usuario;
                    txtSenha.EditValue = objVersao.Senha;
                    txtParametros.EditValue = objVersao.Parametros;
                    break;
            }
        }

        private void CopiaPropriedades(cwkGestao.Modelo.Versao origem, cwkGestao.Modelo.Versao destino)
        {
            destino.Codigo = origem.Codigo;
            destino.Numero = origem.Numero;
            destino.DataLiberacao = origem.DataLiberacao;
            destino.Observacao = origem.Observacao;
            destino.Tipobanco = origem.Tipobanco;
            destino.Caminhobancolimpo = origem.Caminhobancolimpo;
            destino.Servidor = origem.Servidor;
            destino.Banco = origem.Banco;
            destino.Usuario = origem.Usuario;
            destino.Senha = origem.Senha;
            destino.Parametros = origem.Parametros;
        }

        public override Dictionary<string, string> Salvar()
        {
            cwkGestao.Modelo.Versao clone = new cwkGestao.Modelo.Versao();
            CopiaPropriedades(objVersao, clone);

            objVersao.Codigo = Convert.ToInt32(txtCodigo.Value);
            objVersao.Numero = txtNumero.Text;
            objVersao.DataLiberacao = (DateTime?)txtDataLiberacao.EditValue;
            objVersao.Observacao = txtObservacao.Text;
            objVersao.Tipobanco = Convert.ToInt16(cbTipoBanco.SelectedIndex);
            objVersao.Caminhobancolimpo = txtCaminhobancolimpo.Text;
            objVersao.Servidor = txtServidor.Text;
            objVersao.Banco = txtBanco.Text;
            objVersao.Usuario = txtUsuario.Text;
            objVersao.Senha = txtSenha.Text;
            objVersao.Parametros = txtParametros.Text;
            switch (cwAcao)
            {
                case 1:
                    objVersao.Incdata = DateTime.Now;
                    objVersao.Incusuario = Modelo.cwkGlobal.objUsuarioLogado.Login;
                    break;
                case 2:
                    objVersao.Altdata = DateTime.Now;
                    objVersao.Altusuario = Modelo.cwkGlobal.objUsuarioLogado.Login;
                    break;
            }
            Dictionary<string, string> ret = versaoController.Salvar(objVersao, (cwkGestao.Modelo.Acao)cwAcao, objSistema);
            if (ret.Count > 0)
                CopiaPropriedades(clone, objVersao);
            return ret;
        }

        private void sbCaminhobancolimpo_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTipoBanco.SelectedIndex >= 0)
                {
                    if (!String.IsNullOrEmpty(txtCaminhobancolimpo.Text))
                    {
                        openFileDialog1.InitialDirectory = (string)txtCaminhobancolimpo.EditValue;
                        openFileDialog1.FileName = "";
                    }
                    else
                    {
                        openFileDialog1.FileName = "";
                    }
                    if (cbTipoBanco.SelectedIndex == 0)
                        openFileDialog1.Filter = "Arquivos Firebird(*.fdb)|*.fdb";
                    else
                        openFileDialog1.Filter = "Arquivos MS SQL Server(*.mdf)|*.mdf";

                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        txtCaminhobancolimpo.Text = openFileDialog1.FileName;
                    }
                }
                else
                {
                    MessageBox.Show("Selecione o tipo de banco.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
