using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using cwkGestao.Negocio;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Util;
using cwkGestao.Modelo;

namespace Aplicacao
{
    public partial class FormFiltroABC : Form
    {
        private Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext();
        private BLL.CurvaABC bllCurvaABC = new BLL.CurvaABC();
        public FormFiltroABC()
        {
            InitializeComponent();
            lkFilial.ContextoLinq = db;
            lkFilial.Sessao = cwkGestao.Negocio.FilialController.Instancia.getSession();
            lkFilial.Exemplo = new cwkGestao.Modelo.Filial();
        }

        private void sbConsultar_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                try
                {
                    Modelo.ConsultaABC consulta = bllCurvaABC.ConsultarCurvaABC(lkFilial.ID, txtDtInicial.DateTime, txtDtFinal.DateTime, db);
                    if (consulta.ClasseA == null)
                    {
                        MessageBox.Show("Não existem vendas suficientes no período consultado para gerar a curva ABC.");
                    }
                    else
                    {
                        Modelo.Filial objFilial = db.Filials.Where(f => f.ID == lkFilial.ID).First();
                        FormCurvaABC form = new FormCurvaABC(consulta, objFilial.Nome, txtDtInicial.DateTime, txtDtFinal.DateTime);
                        if (this.MdiParent != null)
                            form.MdiParent = this.MdiParent;
                        form.Show();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao realizar consulta: " + Environment.NewLine + ex.Message);
                }
            }
        }

        private bool CamposValidos()
        {
            StringBuilder mensagem = new StringBuilder();
            errorProvider1.SetError(lkFilial, "");
            errorProvider1.SetError(txtDtInicial, "");
            errorProvider1.SetError(txtDtFinal, "");
            if (lkFilial.ID == 0)
            {
                mensagem.AppendLine("Empresa: Selecione a empresa.");
                errorProvider1.SetError(lkFilial, "Selecione a empresa.");
            }
            if (txtDtInicial.EditValue == null)
            {
                mensagem.AppendLine("Período: Selecione a data inicial.");
                errorProvider1.SetError(txtDtInicial, "Selecione a data inicial.");
            }
            if (txtDtFinal.EditValue == null)
            {
                mensagem.AppendLine("Período: Selecione a data final.");
                errorProvider1.SetError(txtDtFinal, "Selecione a data final.");
            }
            else if (txtDtFinal.DateTime < txtDtInicial.DateTime)
            {
                mensagem.AppendLine("Período: A data final deve ser maior ou igual a data inicial.");
                errorProvider1.SetError(txtDtFinal, "A data final deve ser maior ou igual a data inicial.");
            }

            if (mensagem.Length > 0)
            {
                MessageBox.Show("Preencha os campos corretamente:" + Environment.NewLine + mensagem.ToString());
                return false;
            }
            return true;
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
    }
}
