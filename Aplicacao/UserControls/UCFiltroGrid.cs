using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao.UserControls
{
    public partial class UCFiltroGrid : UserControl
    {
        #region Sets/Gets componentes do UC
        public DevExpress.XtraEditors.DateEdit deDataInicial
        {
            get
            {
                return this._deDataInicial;
            }
            set
            {
                this._deDataInicial = value;
            }
        }
        public DevExpress.XtraEditors.DateEdit deDataFinal
        {
            get
            {
                return this._deDataFinal;
            }
            set
            {
                this._deDataFinal = value;
            }
        }
        public DevExpress.XtraEditors.SimpleButton sbFiltrar
        {
            get
            {
                return this._sbFiltrar;
            }
            set
            {
                this._sbFiltrar = value;
            }
        }
        #endregion
        // ao instanciar o UC, fazer a atribuição do método que for tratar o evento
        // do botão de filtro de acordo com o seguinte exemplo
        //
        // variavel_onde_o_uc_foi_instanciado.BotaoFiltrarClicado += new EventHandler(componente_BotaoFiltrarClicado);
        public event EventHandler BotaoFiltrarClicado;
        public UCFiltroGrid()
        {
            //default data inicial = 3 meses anteriores à data atual
            InitializeComponent();
            DateTime data = DateTime.Now.Date;
            if (deDataFinal.EditValue == null)
            {
                deDataFinal.EditValue = data.AddYears(1);
            }
            if (deDataInicial.EditValue == null)
            {
                deDataInicial.EditValue = data.AddYears(-1);                
            }
            
        }

        public UCFiltroGrid(DateTime dtInicio, DateTime dtFim) : base()
        {
            deDataInicial.EditValue = dtInicio;
            deDataFinal.EditValue = dtFim;
        }

        private void _sbFiltrar_Click(object sender, EventArgs e)
        {
            if (((DateTime)deDataInicial.EditValue).Date
                .Equals(((DateTime)deDataFinal.EditValue).Date))
            {
                deDataInicial.EditValue = ((DateTime)deDataInicial.EditValue).Date;
                deDataFinal.EditValue = ((DateTime)deDataFinal.EditValue).Date
                    .AddHours(23)
                    .AddMinutes(59)
                    .AddSeconds(59);
            }
            if (this.BotaoFiltrarClicado != null)
            {
                this.BotaoFiltrarClicado(new object(), new EventArgs());
            }
        }
    }
}
