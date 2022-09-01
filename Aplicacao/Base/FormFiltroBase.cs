using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao.Base
{
    public partial class FormFiltroBase : Form
    {
        protected Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext();
        protected string nomerel = "";
        protected string ds = "";

        public FormFiltroBase()
        {
            InitializeComponent();
        }

        private void FormFiltroRelMovCaixa_Load(object sender, EventArgs e)
        {
            inicializaTela();
        }

        private void FormFiltroRelMovCaixa_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    sbFechar_Click(sender, e);
                    break;
            }
        }

        private void sbImprimir_Click(object sender, EventArgs e)
        {
            string mensagem;
            if (ValidaDados(out mensagem))
            {
                if (MessageBox.Show("Deseja imprir o relatório?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Imprime();
            }
            else
            {
                MessageBox.Show("Preencha os dados corretamente:\n" + mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Método responsável pela inicialização dos campos da tela.
        /// Deve ser sobrescrito.
        /// </summary>
        protected virtual void inicializaTela()
        {
        }

        /// <summary>
        /// Método responsável por processar e exibir o relatório.
        /// Deve ser sobrescrito.
        /// </summary>
        protected virtual void Imprime()
        {            
        }

        /// <summary>
        /// Método responsável por validar os campos da tela.
        /// Deve ser sobrescrito.
        /// </summary>
        /// <param name="mensagem">Mensagem de erro</param>
        /// <returns>true = campos preenchidos corretamente; false = campos não foram preenchido corretamente</returns>
        protected virtual bool ValidaDados(out string mensagem)
        {
            bool ret = true;            
            mensagem = "";
            return ret;
        }        
    }
}
