using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using cwkGestao.Negocio;
using DevExpress.XtraReports.UI;
using Relatorio.Relatorios.Obras_Fundacoes;

namespace Aplicacao.Relatorios
{
    public partial class VerificacacaoEMedicaoDePerfuracao : Aplicacao.Relatorios.Base.FormBaseEmpresa
    {
        public VerificacacaoEMedicaoDePerfuracao()
        {
            InitializeComponent();
            cbStatus.SelectedIndex = 0;
            Carrega();
        }

        protected override void btOk_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                base.btOk_Click(sender, e);
                rptVerificacaoEMedicao relatorio = new rptVerificacaoEMedicao(Titulo);

                Relatorio.dsVerificacaoMedicaoPerfuracaoTableAdapters.VerificacaoTableAdapter verificacaoTableAdapter = new Relatorio.dsVerificacaoMedicaoPerfuracaoTableAdapters.VerificacaoTableAdapter();
                relatorio.DataSource = verificacaoTableAdapter.GetData(MontaString());
                relatorio.ShowPreview();
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente.");
            }
        }

        protected string MontaStringStatus()
        {
            XElement status = new XElement("Status");
            foreach (var i in cbStatus.SelectedIndices)
            {
                XElement elemento = new XElement("Status");
                elemento.SetAttributeValue("id", i);
                status.Add(elemento);
            }
            return status.ToString();
        }

        protected string MontaString()
        {
            StringBuilder str = new StringBuilder("<Elementos>");
            str.Append(MontaStringStatus());
            str.Append("</Elementos>");
            return str.ToString();
        }

        protected bool ValidaCampos()
        {
            dxErrorProvider1.ClearErrors();

            if (cbStatus.SelectedIndices.Count == 0)
                dxErrorProvider1.SetError(cbStatus, "Selecione pelo menos um status.");

            return !dxErrorProvider1.HasErrors;
        }
    }
}
