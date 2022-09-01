﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormMotivoCancProjeto : Form
    {
        public Modelo.MotivoCancelamentoProjeto motivo { get; set; }

        public FormMotivoCancProjeto()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            motivo = (Modelo.MotivoCancelamentoProjeto)cbMotivo.SelectedIndex;
            this.Close();
        }
    }
}
