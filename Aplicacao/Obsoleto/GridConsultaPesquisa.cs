using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cwork.Utilitarios.Componentes;
using System.IO;

namespace Aplicacao
{
    public partial class GridConsultaPesquisa : Form
    {
        List<Modelo.Objeto.pxyConsultaPesquisa> listaObjs = new List<Modelo.Objeto.pxyConsultaPesquisa>();
        Dictionary<String, int> Header = new Dictionary<string, int>();

        public string Caption { get; set; }
        protected string arquivo;

        public GridConsultaPesquisa(List<Lookup.Resultado> pValores, Dictionary<String, int> pHeader)
        {
            InitializeComponent();
            Header = pHeader;
            CarregaGrid(pValores);

            arquivo = Modelo.cwkGlobal.objUsuarioLogado.Login + "_" + Caption.TrimEnd();
        }

        private void CarregaGrid(List<Cwork.Utilitarios.Componentes.Lookup.Resultado> Valores) 
        {
            int k = 1;
            foreach (KeyValuePair<String, int> Dic in Header)
            {
                dataGridView1.Columns[k].Caption = Dic.Key;
                dataGridView1.Columns[k].Width = Dic.Value;
                k++;
            }
            dataGridView1.Columns[0].Visible = false;

            for (int i = (Header.Count + 1); i < 6; i++)
            {
                dataGridView1.Columns[i].Visible = false;
            }
            gcConsultaPesquisa.Refresh();

            foreach (Lookup.Resultado obj in Valores)
            {
                Modelo.Objeto.pxyConsultaPesquisa objConsPesq = new Modelo.Objeto.pxyConsultaPesquisa();
                objConsPesq.id = obj.id.ToString();
                objConsPesq.campo1 = obj.campo1.ToString();
                objConsPesq.campo2 = obj.campo2.ToString();
                objConsPesq.campo3 = obj.campo3.ToString();
                objConsPesq.campo4 = obj.campo4.ToString();
                objConsPesq.campo5 = obj.campo5.ToString();
                listaObjs.Add(objConsPesq);
            }
            gcConsultaPesquisa.DataSource = listaObjs;
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            FecharJanela();
        }

        private void FecharJanela()
        {
            Header.Clear();
            Header.Add("Resultado", 0);

            this.Close();
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            SelecionarRegistro();
        }

        private void GridConsultaPesquisa_Load(object sender, EventArgs e)
        {
            Text = Caption;

            if (File.Exists("PadraoCorSistema.xml"))
            {
                dataGridView1.Appearance.RestoreLayoutFromXml("PadraoCorSistema.xml");
            }

            //Carrega a configuração da última tela
            if (File.Exists(Modelo.cwkGlobal.DirApp + "\\Telas\\" + arquivo + ".xml"))
                dataGridView1.RestoreLayoutFromXml(Modelo.cwkGlobal.DirApp + "\\Telas\\" + arquivo + ".xml");
        }

        public void SelecionarRegistro()
        {
            Header.Clear();
            Header.Add("Resultado", Convert.ToInt32(dataGridView1.GetFocusedRowCellValue(id)));
            this.Close();
        }

        private void ValidaSelectManutencao()
        {
            SelecionarRegistro();
        }

        private void gcConsultaPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    ValidaSelectManutencao();
                    break;
                case Keys.Delete:
                    if (Form.ModifierKeys == Keys.Control)
                    {
                        if (File.Exists(Modelo.cwkGlobal.DirApp + "\\Telas\\" + arquivo + ".xml"))
                        {
                            File.Delete(Modelo.cwkGlobal.DirApp + "\\Telas\\" + arquivo + ".xml");
                            arquivo = "";
                        }
                    }
                    break;
            }
        }

        private void gcConsultaPesquisa_DoubleClick(object sender, EventArgs e)
        {
            ValidaSelectManutencao();
        }

        private void GridConsultaPesquisa_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Salva a configuração da janela
            if (arquivo != "")
                dataGridView1.SaveLayoutToXml(Modelo.cwkGlobal.DirApp + "\\Telas\\" + arquivo + ".xml");

            FecharJanela();
        }
    }
}
