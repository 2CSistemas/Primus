using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Mask;

namespace Aplicacao.Modulos.Telefonia
{
    public partial class FormGrupoCliente : Aplicacao.IntermediariasTela.FormManutGrupoClienteIntermediaria
    {
        public FormGrupoCliente() {}

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            tpPrecos.Tag = Selecionado;
            tpTelefones.Tag = Selecionado;

            lkpCidade.Exemplo = new Cidade() { UF = new UF { Pais = new Pais() } };
            lkpAcrescimo.Exemplo = new Acrescimo();
            //lkbCidade.SubForm = new FormCidade();
            lkbCidade.SubFormType = typeof(FormCidade);
            //lkbAcrescimo.SubForm = new FormAcrescimo();
            lkbAcrescimo.SubFormType = typeof(FormAcrescimo);

            object[] parms = new[] { new Tel_GrupoClientePreco() { GrupoCliente = Selecionado } };
            Type formType = typeof(FormGrupoClientePreco);

            btIncluirP.SubFormType = btAlterarP.SubFormType = btExcluirP.SubFormType = btConsultarP.SubFormType = formType;
            btIncluirP.SubFormTypeParams = btAlterarP.SubFormTypeParams = btExcluirP.SubFormTypeParams = btConsultarP.SubFormTypeParams = parms;

            //FormGrupoClientePreco formGrupoClientePreco = new FormGrupoClientePreco() { Selecionado = new Tel_GrupoClientePreco() { GrupoCliente = Selecionado } };
            //btIncluirP.SubForm = formGrupoClientePreco;
            //btAlterarP.SubForm = formGrupoClientePreco;
            //btExcluirP.SubForm = formGrupoClientePreco;
            //btConsultarP.SubForm = formGrupoClientePreco;
        }

        private void btIncluirFaixaT_Click_1(object sender, EventArgs e)
        {
            var Lista = new List<Tel_GrupoClienteTelefone>();
            var form = new FormManutGrupoClienteTelefoneFaixa(Lista);
            form.GrupoCliente = Selecionado;
            form.ShowDialog();

            foreach (var item in Lista)
            {
                ((IList<Tel_GrupoClienteTelefone>)gcTelefones.DataSource).Add(item);
            }
            gcTelefones.Refresh();
            gvTelefones.RefreshData();
        }

        protected override void OK()
        {
            if (Selecionado.Precos.Count > 0)
            {
                foreach (var item in Selecionado.Precos)
                {
                    item.GrupoCliente = Selecionado;
                }
            }
            base.OK();
        }

        private void FormGrupoCliente_Shown(object sender, EventArgs e)
        {
            RepositoryItemTextEdit textEdit = new RepositoryItemTextEdit();
            textEdit.Mask.MaskType = MaskType.RegEx;
            textEdit.Mask.UseMaskAsDisplayFormat = true;
            textEdit.Mask.EditMask = @"\d{10,10}";
            textEdit.Mask.SaveLiteral = true;
            textEdit.Mask.ShowPlaceHolders = false;

            gvTelefones.Columns[0].ColumnEdit = textEdit;
        }
    }
}
