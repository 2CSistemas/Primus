using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio.RelatoriosMatriciais;
using cwkGestao.Negocio;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao
{
    public partial class GridNotaServico : Aplicacao.IntermediariasTela.GridNotaServicoIntermediaria
    {
        NotaServicoController controller = NotaServicoController.Instancia;

        #region Construtores
        public GridNotaServico(IList<NotaServico> lista, Type formManut, params object[] parametros)
            : this(lista, null, formManut, parametros)
        {
        }
        public GridNotaServico(IList<NotaServico> lista, NotaServico selecionado, Type formManut, params object[] parametros)
            : base(lista, selecionado, false, formManut, parametros)
        {
            InitializeComponent();
        }
        #endregion

        private void sbFuncao10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja imprimir a nota?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NotaServico nota = GetRegistroSelecionado();
                if (nota != null)
                {
                    nota = controller.LoadObjectById(nota.ID);
                    bool video = new Aplicacao.DestinoImpressaoNota().Show() == Modelo.DestinoImpressao.Vídeo;
                    NotaServicoMatricial notaServicoMatricial = new NotaServicoMatricial(nota);
                    notaServicoMatricial.ImprimeNota(video);
                }
                else
                {
                    MessageBox.Show("Nenhum Registro Selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        protected override void Incluir()
        {
            int RowNumber = gvPrincipal.RowCount;
            base.Incluir();
            if (RowNumber < gvPrincipal.RowCount)
                sbFuncao10_Click(null, null);
        }
    }
}
