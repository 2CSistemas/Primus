using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aplicacao
{
    public partial class FormConsultaCustoProjeto : Form
    {
        Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext();
        Modelo.Projeto objProjeto;

        public FormConsultaCustoProjeto(int pID)
        {
            InitializeComponent();
            cbProjeto.Properties.DataSource = (from p in db.Projetos
                                               select new
                                               {
                                                   ID = p.ID,
                                                   Nome = p.Nome
                                               });
            if (pID != 0)
            {
                CarregaDadosProjeto(pID);
            }
        }

        private void FormConsultaCustoProjeto_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    btFechar_Click(sender, e);
                    break;
            }
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdProjeto_Click(object sender, EventArgs e)
        {
            GridSelecao("Tabela de Projetos", cbProjeto, objProjeto);
        }

        /// <summary>
        /// Método que chama o grid para selecionar um elemento
        /// </summary>
        /// <param name="ptitulo">Título do grid</param>
        /// <param name="pCb">combobox que irá chamar o grid</param>
        /// <param name="gl">objeto que irá retornar a lista para preencher o combo</param>
        private void GridSelecao(string ptitulo, Componentes.devexpress.cwk_DevLookup pCb, Modelo.IMetodosCwork gl)
        {
            GridPadrao pGp = new GridPadrao(ptitulo, true, (int)pCb.EditValue);
            if (cwkControleUsuario.Facade.ControleAcesso(pGp))
            {
                pGp.ShowDialog();
                if (pGp.atualiza == true)
                {
                    pCb.Properties.DataSource = gl.getListaCombo(db);
                }
                if (pGp.Retorno.Length != 0)
                {
                    pCb.EditValue = int.Parse(pGp.Retorno);
                }
            }
            pCb.Focus();
        }

        private void CarregaDadosProjeto(int pID)
        {
            objProjeto = db.Projetos.Where(c => c.ID == pID).Single();
            cbProjeto.EditValue = pID;

            //Receitas
            gcReceitas.DataSource = Modelo.Projeto.getReceitasDespesas(db, pID, Modelo.TipoDocumentoType.Receber);
            //Despesas
            gcDespesas.DataSource = Modelo.Projeto.getReceitasDespesas(db, pID, Modelo.TipoDocumentoType.Pagar);
            //Notas de Compra
            gcNotasCompra.DataSource = Modelo.Projeto.getNotas(db, pID, Modelo.InOutType.Entrada);
            //Pedidos
            gcPedidos.DataSource = Modelo.Projeto.getPedidos(db, pID, Modelo.InOutType.Entrada);

        }

        private void cbProjeto_EditValueChanged(object sender, EventArgs e)
        {
            int id = (int)cbProjeto.EditValue;
            if (id > 0)
            {
                CarregaDadosProjeto(id);
            }
        }
    }
}
