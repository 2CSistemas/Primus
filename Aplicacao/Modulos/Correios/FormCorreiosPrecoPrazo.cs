using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using System.Linq;
using System.Reflection;
using cwkGestao.Integracao.Correios;
using Aplicacao.Util;

namespace Aplicacao.Modulos.Correios
{
    public partial class FormCorreiosPrecoPrazo : Aplicacao.IntermediariasTela.FormManutCorreiosPrecoPrazo
    {
        public IList<CorreiosPrecoPrazo> ListaVolumesServicosCorreios { get; set; }
        public IList<CorreiosPrecoPrazo> ListaVolumesExcluidos { get; set; }
        private IList<ServicoEnvioCorreio> ServicosCorreio { get; set; }
        private IList<FormatoPacoteTransporte> FormatosPacote { get; set; }
        public DialogResult Result { get; set; }
        public FormCorreiosPrecoPrazo(IList<CorreiosPrecoPrazo> lista)
        {
            ListaVolumesServicosCorreios = lista == null ? new List<CorreiosPrecoPrazo>() : lista;
            foreach (CorreiosPrecoPrazo item in ListaVolumesServicosCorreios)
            {
                item.SCdAvisoRecebimento = item.SCdAvisoRecebimento == "S" ? "Sim" : "Não";
                item.SCdMaoPropria = item.SCdMaoPropria == "S" ? "Sim" : "Não";
            }
            ServicosCorreio = ServicoEnvioCorreioController.Instancia.GetAll();
            ServicosCorreio.Add(new ServicoEnvioCorreio() { Codigo = "0", Servico = "Verificar Orcamentos de Envio" });
            FormatosPacote = FormatoPacoteTransporteController.Instancia.GetAll();
            InitializeComponent();
            lkpFormato.DataSource = FormatosPacote;
            
            gcCadastroVolumes.DataSource = ListaVolumesServicosCorreios;
        }

        #region Eventos

        #region Botões

        private void sbGeraVolumes_Click(object sender, EventArgs e)
        {
            int volumes = (int)seVolumes.Value;
            if (ListaVolumesServicosCorreios.Count > 0)
            {
                if (ListaVolumesServicosCorreios.Count < volumes)
                {
                    int dif = volumes - ListaVolumesServicosCorreios.Count;
                    for (int i = 0; i < dif ; i++)
                    {
                        ListaVolumesServicosCorreios.Add(new CorreiosPrecoPrazo() { SCdAvisoRecebimento = "Não", SCdMaoPropria = "Não"});
                    }
                }
                else
                {
                    int count = 0;
                    List<CorreiosPrecoPrazo> x = new List<CorreiosPrecoPrazo>();
                    List<CorreiosPrecoPrazo> y = new List<CorreiosPrecoPrazo>();
                    while (count < volumes)
                    {
                        x.Add(ListaVolumesServicosCorreios[count]);
                        count++;
                    }
                    for (int i = count; i < ListaVolumesServicosCorreios.Count; i++ )
                    {
                        if (ListaVolumesServicosCorreios[i].ID != 0)
                        {
                            y.Add(ListaVolumesServicosCorreios[i]);
                        }
                    }
                    ListaVolumesServicosCorreios = x;
                    ListaVolumesExcluidos = y;
                }

            }
            else
            {
                for (int i = 0; i < volumes; i++)
                {
                    ListaVolumesServicosCorreios.Add(new CorreiosPrecoPrazo() { SCdAvisoRecebimento = "Não", SCdMaoPropria = "Não" });
                }
            }
            gcCadastroVolumes.DataSource = ListaVolumesServicosCorreios;
            gcCadastroVolumes.RefreshDataSource();
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CamposValidos())
                {
                    return;
                }
                if (ListaVolumesServicosCorreios.Count == 0)
                {
                    MessageBox.Show("Informe pelo menos um volume.","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }
                ListaVolumesServicosCorreios = (IList<CorreiosPrecoPrazo>)gcCadastroVolumes.DataSource;
                foreach (CorreiosPrecoPrazo item in ListaVolumesServicosCorreios)
                {
                    item.SCdAvisoRecebimento = item.SCdAvisoRecebimento == "Sim" ? "S" : "N";
                    item.SCdMaoPropria = item.SCdMaoPropria == "Sim" ? "S" : "N";
                    item.NCdFormato = item.FormatoPacoteTransporte.Codigo;
                }
                Result = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        #endregion

        #region Validadores

        private bool CamposValidos()
        {
            bool ok = true;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ListaVolumesServicosCorreios.Count; i++ )
            {
                CorreiosPrecoPrazo item = ListaVolumesServicosCorreios[i];
                if (item.NVlLargura == 0)
                {
                    sb.AppendLine("O campo Largura da linha " + (i+1).ToString() + " não pode ser 0.");
                }
                if (item.NVlAltura == 0)
                {
                    sb.AppendLine("O campo Altura da linha " + (i + 1).ToString() + " não pode ser 0.");
                }
                if (item.NVlComprimento == 0)
                {
                    sb.AppendLine("O campo Comprimento da linha " + (i + 1).ToString() + " não pode ser 0.");
                }
                if (item.NVlDiametro == 0)
                {
                    sb.AppendLine("O campo Diâmetro da linha " + (i + 1).ToString() + " não pode ser 0.");
                }
                if (item.NVlPeso == 0)
                {
                    sb.AppendLine("O campo Peso da linha " + (i + 1).ToString() + " não pode ser 0.");
                }
                if (item.FormatoPacoteTransporte == null)
                {
                    sb.AppendLine("O campo Formato da linha " + (i + 1).ToString() + " não pode ser vazio.");
                }
                if (item.SCdMaoPropria == "")
                {
                    sb.AppendLine("O campo Mão Própria da linha " + (i + 1).ToString() + " não pode ser vazio.");
                }
                if (item.SCdAvisoRecebimento == "")
                {
                    sb.AppendLine("O campo Aviso de Recebimento da linha " + (i + 1).ToString() + " não pode ser vazio.");
                }
            }
            if (sb.Length > 0)
            {
                MessageBox.Show("Favor verificar os erros de preenchimento informados abaixo:" + "\n\n" + sb.ToString(), "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return !ok;
            }
            return ok;
        }

        #endregion

        private void FormCorreiosPrecoPrazo_Shown(object sender, EventArgs e)
        {
            if (ListaVolumesServicosCorreios.Count > 0)
            {
                seVolumes.EditValue = ListaVolumesServicosCorreios.Count;
            }
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            Result = DialogResult.Cancel;
            this.Close();
        }

        private void FormCorreiosPrecoPrazo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Result = DialogResult.Cancel;
                Cancelar();
            }
        }

        #endregion



    }
}