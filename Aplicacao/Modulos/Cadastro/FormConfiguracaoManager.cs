using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Aplicacao.Base;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Linq;
using cwkGestao.Negocio.RelatoriosMatriciais;
using Cwork.Utilitarios.Componentes;
using DevExpress.Data;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using Aplicacao.Util;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Integracao.Magento.Exportacao;
using cwkGestao.Negocio.Padroes;

namespace Aplicacao.Modulos.Cadastro
{
    public partial class FormConfiguracaoManager : Base.ManutBase
    {
        private ConfiguracaoManager _obj;

        public FormConfiguracaoManager(ConfiguracaoManager obj)
        {
            InitializeComponent();
            _obj = obj;

            if (_obj == null)
            {
                _obj = new ConfiguracaoManager();
            }
            if (obj != null)
            {
                txtusuario.EditValue = obj.usuario;
                txtsenha.EditValue = obj.senha;
                txthost.EditValue = obj.host;
                txtGrupo.EditValue = obj.grupo;
                edtCXml.EditValue = obj.CaminhoXMLNFSE;
                edtCPdf.EditValue = obj.CaminhoPDFNFSE;
            }
            
        }

        private void sbGravar_Click_1(object sender, EventArgs e)
        {
               _obj.usuario = txtusuario.Text;
               _obj.senha = txtsenha.Text;
               _obj.host = txthost.Text;
               _obj.grupo = txtGrupo.Text;
               _obj.CaminhoPDFNFSE = edtCPdf.Text;
               _obj.CaminhoXMLNFSE = edtCXml.Text;
               cwkGestao.Modelo.Acao acao = cwkGestao.Modelo.Acao.Alterar;
               if (_obj.ID == 0)
               {
                   acao = cwkGestao.Modelo.Acao.Incluir;
               }
               ConfiguracaoManagerController.Instancia.Salvar(_obj, acao);
        }

        private void btCPdf_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                edtCPdf.Text = folderBrowserDialog1.SelectedPath;
                folderBrowserDialog1.Reset();
            }
        }

        private void btCHtml_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                edtCXml.Text = folderBrowserDialog2.SelectedPath;
                folderBrowserDialog1.Reset();
            }
        }

        private void lbGrupo_Click(object sender, EventArgs e)
        {

        }
        
    }
}