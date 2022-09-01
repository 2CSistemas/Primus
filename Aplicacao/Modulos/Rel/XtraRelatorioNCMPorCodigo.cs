using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using cwkGestao.Negocio;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Modulos.Rel
{
    public partial class XtraRelatorioNCMPorCodigo : XtraReport
    {
        public XtraRelatorioNCMPorCodigo(string NomeEmpresa, bool? NCMRevogados, string inicial, string final)
        {
            InitializeComponent();
            ovTXT_Empresa.Text = NomeEmpresa;

            var dt = new DataTable();
            dt.TableName = "DADOS";

            dt.Columns.Add("CODIGO");
            dt.Columns.Add("NOME");
            dt.Columns.Add("CEST");
            dt.Columns.Add("REVOGACAO");

            var Todos = string.IsNullOrEmpty(inicial) && string.IsNullOrEmpty(final);
            var ncms = NCMController.Instancia.GetAll();
            if (!Todos)
                ncms = ncms.Where(o => !string.IsNullOrEmpty(o.Ncm))
                           .Where(o => Convert.ToInt32(o.Ncm) >= Convert.ToInt32(inicial) &&
                                       Convert.ToInt32(o.Ncm) <= Convert.ToInt32(final)).ToList();

            switch (NCMRevogados)
            {
                case true:
                    ncms = ncms.Where(o => o.DtRevogacao.HasValue && o.DtRevogacao?.Date <= DateTime.Now.Date).ToList();
                    break;
                case false:
                    ncms = ncms.Where(o => o.DtRevogacao == null || o.DtRevogacao?.Date >= DateTime.Now.Date).ToList();
                    break;
            }

            ncms = ncms.OrderBy(o => o.Ncm).ToList();

            foreach (var ncm in ncms)
            {
                var dr = dt.NewRow();
                dr["CODIGO"] = ncm.Ncm;
                dr["NOME"] = ncm.Descricao;
                dr["CEST"] = ncm.Cest;
                dr["REVOGACAO"] = ncm.DtRevogacao?.ToString("dd/MM/yyyy");
                dt.Rows.Add(dr);
            }

            ovDS_Dados.Tables.Clear();
            ovDS_Dados.Tables.Add(dt);
        }
    }
}
