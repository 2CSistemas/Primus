using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using Aplicacao.Util;

namespace Aplicacao.Modulos.Telefonia
{
    public partial class FormManutGrupoClienteTelefoneFaixa : Form
    {
        private List<Tel_GrupoClienteTelefone> Lista;
        public Tel_GrupoCliente GrupoCliente;

        public FormManutGrupoClienteTelefoneFaixa(List<Tel_GrupoClienteTelefone> lista)
        {
            InitializeComponent();

            this.Lista = lista;
        }

        private void sbGravar_Click(object sender, EventArgs e)
        {
            int RangeInicial = Convert.ToInt32(txtRangeInicial.EditValue);
            int length = Convert.ToInt32(txtRangeFinal.EditValue) - Convert.ToInt32(txtRangeInicial.EditValue);
            Tel_GrupoClienteTelefone tel;

            for (int i = 0; i < length + 1 ; i++)
            {
                tel = new Tel_GrupoClienteTelefone();
                tel.GrupoCliente = this.GrupoCliente;
                tel.Telefone = txtArea.EditValue.ToString() + txtPrefixo.EditValue.ToString() + (RangeInicial + i).ToString();

                Lista.Add(tel);
            }

            this.Close();
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sbAjuda_Click(object sender, EventArgs e)
        {
            this.ChamarHelp();
        }
    }
}
