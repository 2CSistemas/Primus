using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormManutGrupo : Aplicacao.Base.ManutBase
    {
        Modelo.Empresa ObjEmpresa = new Modelo.Empresa();
        Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext();
        private int acao, ID;

        public FormManutGrupo() { }

        public FormManutGrupo(int pAcao, int pID)
        {
            InitializeComponent();
            acao = pAcao;
            ID = pID;
            txtCodigo.Text = ObjEmpresa.RetornaMAXCodigo(db).ToString();
            CarregaObjeto();
            this.Text = "Manutenção Grupo";
        }

        public override void CarregaObjeto()
        {
            switch (acao) 
            {
                case 1://incluir
                    db.Empresas.InsertOnSubmit(ObjEmpresa);
                    break;
                
                case 2://alterar
                    PreencherValores();
                    break;
                
                case 3://excluir
                    PreencherValores();
                    db.Empresas.DeleteOnSubmit(ObjEmpresa);
                    MontaTela();
                    sbGravar.Text = "&OK";
                    break;

                case 4://consultar
                    PreencherValores();
                    MontaTela();
                    sbGravar.Enabled = false;
                    break;
            
            }
        }

        private void PreencherValores()
            {
                ObjEmpresa = (Modelo.Empresa)ObjEmpresa.getObjeto(db, ID);
                txtCodigo.Text = ObjEmpresa.Codigo.ToString();
                txtNome.Text = ObjEmpresa.Nome;
            }

        private void MontaTela()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
        }

        private void FormManutFilial_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F9:
                    if (acao != 4)
                    {
                        sbGravar_Click(sender, e);
                    }
                    break;
                case Keys.Escape:
                    sbCancelar_Click(sender, e);
                    break;
            }
        }
        public override Dictionary<string, string> Salvar()
        {
            ObjEmpresa.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjEmpresa.Nome = txtNome.Text;

            return BLL.Empresa.Salvar(db, ObjEmpresa);
        }

    }}
