using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using cwkGestao.Integracao.Magento.Exportacao;
using cwkGestao.Modelo;
using System.Windows.Forms;
using Aplicacao.Modulos.Utilitarios;
using Aplicacao.Base;

namespace Aplicacao.Util
{
    public class SincronizacoesMagentoUtil
    {
        public void Exportador(ModeloBase obj)
        {
            Thread t = new Thread(new ThreadStart(() =>
            {
                try
                {
                    MegaExportador.ExportarUnicoObjeto(obj);
                    MessageBox.Show("Sincronização realizada com sucesso!", "Sucesso", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    new FormErro(ex).ShowDialog();
                }
            }));

            t.Start();
        }
    }
}
