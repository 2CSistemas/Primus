using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Aplicacao.Util;
using cwkGestao.Modelo;

namespace Aplicacao
{
    public partial class FormManutProjeto : Aplicacao.Base.ManutBase
    {
        private Modelo.Projeto objProjeto;
        private int Status_Ant;

        public FormManutProjeto(Modelo.DataClassesDataContext pDb)
        {
            InitializeComponent();
            this.Name = "FormManutProjeto";
            db = pDb;
        }

        public override void CarregaObjeto()
        {
            lkPessoa.ContextoLinq = db;
            lkFilial.ContextoLinq = db;
            switch (cwAcao)
            {
                case 1:
                    objProjeto = new Modelo.Projeto();
                    cbStatus.SelectedIndex = 0;
                    cbStatus.Enabled = false;
                    txtData.DateTime = DateTime.Now;
                    Status_Ant = 0;
                    break;
                default:
                    objProjeto = db.Projetos.Where(p => p.ID == cwID).First();
                    txtNome.EditValue = objProjeto.Nome;
                    txtDescricao.EditValue = objProjeto.Descricao;
                    cbStatus.SelectedIndex = objProjeto.Status== null ? 0 : (int)objProjeto.Status;
                    if (objProjeto.Data != null)
                    {
                        txtData.DateTime = (DateTime)objProjeto.Data;
                    }
                    lkFilial.ID = objProjeto.IDFilial == null ? 0 : (int)objProjeto.IDFilial;
                    lkPessoa.ID = objProjeto.IDPessoa == null ? 0 : (int)objProjeto.IDPessoa;
                    lkFilial.Localizar(lkFilial.ID);
                    lkPessoa.Localizar(lkPessoa.ID);
                    txtCaminhoDocumento.Text = objProjeto.CaminhoDocumento;
                    txtNumeroProposta.Text = objProjeto.NumeroProposta;
                    Status_Ant = objProjeto.Status == null ? 0 : (int)objProjeto.Status;
                    if (cwAcao == 4)
                    {
                        sbGravar.Enabled = false;
                    }
                    break;
            }
            if (objProjeto.Status == 2)
                cbStatus.Enabled = false;
            base.CarregaObjeto();
        }

        public override Dictionary<string, string> Salvar()
        {
            Dictionary<string, string> ret;
            if ((Status_Ant == 0) && (cbStatus.SelectedIndex != 1 && cbStatus.SelectedIndex != 0 && cbStatus.SelectedIndex != 4 && cbStatus.SelectedIndex != 3))
            {
                ret = new Dictionary<string, string>();
                ret.Add("cbStatus", "Orçamento Em Digitação só pode ser alterado para: \n Aberto \n Cancelado");
                return ret;
            }
            else if ((Status_Ant == 1) && (cbStatus.SelectedIndex != 1 && cbStatus.SelectedIndex != 4 && cbStatus.SelectedIndex != 3))
            {
                ret = new Dictionary<string, string>();
                ret.Add("cbStatus", "Orçamento Em Aberto só pode ser alterado para: \n Cancelado \n Aprovado ");
                return ret;
            }
            else if ((Status_Ant == 2) && (cbStatus.SelectedIndex != 2 && cbStatus.SelectedIndex != 5))
            {
                ret = new Dictionary<string, string>();
                ret.Add("cbStatus", "Orçamento Aprovado só pode ser alterado para: \n Concluído \n Não Aprovado \n Para não aprovação do Orçamento é necessário desaprová-lo \n na tela anterior.");
                return ret;
            }
            else if ((Status_Ant == 3) && (cbStatus.SelectedIndex != 3 && cbStatus.SelectedIndex != 4 && cbStatus.SelectedIndex != 1))
            {
                ret = new Dictionary<string, string>();
                ret.Add("cbStatus", "Orçamento Não Aprovado só pode ser alterado para: \n Cancelado \n Aberto");
                return ret;
            }
            else if ((Status_Ant == 4) && (cbStatus.SelectedIndex != 4 && cbStatus.SelectedIndex != 1))
            {
                ret = new Dictionary<string, string>();
                ret.Add("cbStatus", "Orçamento Cancelado só pode ser alterado para: \n Aberto");
                return ret;
            }
            else if (Status_Ant == 5 && cbStatus.SelectedIndex != 5 && cbStatus.SelectedIndex != 2)
            {
                ret = new Dictionary<string, string>();
                ret.Add("cbStatus", "Orçamento Concluído não pode ser alterado.");
                return ret;
            }

            switch (cwAcao)
            {
                case 1:
                    db.Projetos.InsertOnSubmit(objProjeto);
                    break;
                case 3:
                    db.Projetos.DeleteOnSubmit(objProjeto);
                    break;
            }
            
            objProjeto.Descricao = txtDescricao.Text;
            objProjeto.Nome = txtNome.Text;
            objProjeto.Status = cbStatus.SelectedIndex;
            if (objProjeto.Status == 4 || objProjeto.Status == 3)
            {
                if (objProjeto.MotivoCancelamento == null
                    || (objProjeto.Status_Ant != 3 && objProjeto.Status == 3)
                    || (objProjeto.Status_Ant != 4 && objProjeto.Status == 4))
                {
                    FormMotivoCancProjeto formMotivo = new FormMotivoCancProjeto();
                    formMotivo.ShowDialog();
                    objProjeto.MotivoCancelamento = formMotivo.motivo;
                }
            }
            else
                objProjeto.MotivoCancelamento = null;

            objProjeto.Data = txtData.DateTime;
            objProjeto.IDFilial = lkFilial.ID;
            objProjeto.IDPessoa = lkPessoa.ID;
            objProjeto.CaminhoDocumento = txtCaminhoDocumento.Text;
            objProjeto.NumeroProposta = txtNumeroProposta.Text;
            ret = BLL.Projeto.Salvar(db, objProjeto);

            if (ret.Count > 0)
            {
                Modelo.MetodosEstaticos.DiscardInsertsAndDeletes(db);
                if (objProjeto.ID > 0)
                    db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, objProjeto);
            }

            return ret;
        }

        private void lkbPessoa_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookupPessoa(lkPessoa, cwkGestao.Negocio.PessoaController.Instancia.GetAllClientes(), "Cliente", typeof(FormPessoa));
        }

        private void lkbFilial_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<Filial>(lkFilial, typeof(FormFilial));
        }

        private void GridSelecao(string ptitulo, Cwork.Utilitarios.Componentes.Lookup pLookup)
        {
            GridPadrao pGp = new GridPadrao(ptitulo, true, pLookup.ID);
            if (cwkControleUsuario.Facade.ControleAcesso(pGp))
            {
                pGp.ShowDialog();
                if (pGp.Retorno.Length != 0)
                    pLookup.Localizar(int.Parse(pGp.Retorno));
            }
            pLookup.Focus();
        }

        private void btCaminhoDocumento_Click(object sender, EventArgs e)
        {
            SelecionaArquivo(txtCaminhoDocumento, "Documentos do Word |*.docx | Documentos do Word 97-2003 |*.doc");
        }

        private void SelecionaArquivo(DevExpress.XtraEditors.TextEdit txt, string tipoArquivo)
        {
            openFileDialog1.Filter = tipoArquivo;
            if (!String.IsNullOrEmpty(txt.Text))
            {
                openFileDialog1.FileName = txt.Text;
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt.Text = openFileDialog1.FileName;
            }
        }
    }
}
