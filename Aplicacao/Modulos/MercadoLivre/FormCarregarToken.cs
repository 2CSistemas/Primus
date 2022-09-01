using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using cwkGestao.Negocio;
using System.Text.RegularExpressions;
using cwkGestao.Modelo;
using MercadoLibre.SDK;
using cwkGestao.Integracao.MercadoLivre;
using cwkGestao.Integracao.MercadoLivre.WebService;


namespace Aplicacao.Modulos.MercadoLivre
{
    public partial class FormCarregarToken : DevExpress.XtraEditors.XtraForm
    {
        MercadoLivreConfiguracao conf = MercadoLivreConfiguracaoController.Instancia.GetAll()[0];
        WS_Autorizacao autorizar = new WS_Autorizacao();

        public FormCarregarToken()
        {
            InitializeComponent();
            Meli m = autorizar.InstanciaMeli();
            wbGeraToken.Navigate(m.GetAuthUrl(conf.URL));
        }

        private void wbGeraToken_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            if (e.Url.AbsoluteUri.Contains("code="))
            {
                string auth_code = Regex.Split(e.Url.AbsoluteUri, "code=")[1];
                autorizar.Autorizar(auth_code);

               // autorizar.GetPedido();
                this.Close();
            }
        }

    }
}