using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormManutReparcelamento : Form
    {
        Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext();
        Modelo.Reparcelamento objReparcelamento;
        int ID = 0;
        bool excluir = false;

        public FormManutReparcelamento(int pID, bool pExcluir)
        {
            InitializeComponent();
            ID = pID;
            excluir = pExcluir;
        }

        private void FormManutReparcelamento_Load(object sender, EventArgs e)
        {
            objReparcelamento = (from r in db.Reparcelamentos
                                 where r.ID == ID
                                 select r).Single();

            txtData.DataBindings.Add("EditValue", objReparcelamento, "Data", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDataBase.DataBindings.Add("EditValue", objReparcelamento, "Data_Base", true, DataSourceUpdateMode.OnPropertyChanged);
            txtJuros.DataBindings.Add("EditValue", objReparcelamento, "Juros", true, DataSourceUpdateMode.OnPropertyChanged);
            txtValorTotal.DataBindings.Add("EditValue", objReparcelamento, "ValorTotal", true, DataSourceUpdateMode.OnPropertyChanged);
            txtObservacao.DataBindings.Add("EditValue", objReparcelamento, "Observacao", true, DataSourceUpdateMode.OnPropertyChanged);

            var docAntigos = (from da in db.ReparcelamentoDocs
                              join d in db.Documentos on da.IdDocumento equals d.ID
                              where da.IdReparcelamento == objReparcelamento.ID
                              && da.Tipo == false
                              select new
                              {
                                  Codigo = d.Codigo,
                                  NumDocumento = d.NumDocumento,
                                  Vencimento = d.DtVencimento,
                                  Valor = d.Valor
                              }
                              );

            gcDocAntigos.DataSource = docAntigos;

            var docNovos = (from da in db.ReparcelamentoDocs
                            join d in db.Documentos on da.IdDocumento equals d.ID
                            where da.IdReparcelamento == objReparcelamento.ID
                            && da.Tipo == true
                            select new
                            {
                                Codigo = d.Codigo,
                                NumDocumento = d.NumDocumento,
                                Vencimento = d.DtVencimento,
                                Valor = d.Valor
                            }
                      );

            gcDocNovos.DataSource = docNovos;

            if (excluir)
            {
                Text = "Excluindo " + Text.TrimEnd();             
            }
            sbGravar.Visible = excluir;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sbGravar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o Parcelamento?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BLL.Financeiro bllFinanceiro = new BLL.Financeiro(db);
                bllFinanceiro.excluirRenegociacao(ID);
                bllFinanceiro.Dispose();
                Close();
            }
        }
    }
}
