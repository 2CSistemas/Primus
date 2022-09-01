using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

using cwkGestao.Negocio;

using MO = Modelo;

namespace Aplicacao
{
    public partial class FormMsgVencimentoCertificado : Form
    {
        private readonly MO.DataClassesDataContext db = new MO.DataClassesDataContext();

        public FormMsgVencimentoCertificado()
        {
            InitializeComponent();

            var Filial = FilialController.Instancia.LoadObjectById((from emp in db.Filials
                                                                    where emp.Codigo == 1
                                                                    select emp).Single().ID);
            var DataVencimento = GetExpiration(Filial.Certificado);
            if (string.IsNullOrEmpty(DataVencimento))
            {
                lblAviso.Text = "Erro ao processar data de validade do certificado.";
                return;
            }

            var qtdeDias = Convert.ToInt32(Convert.ToDateTime(DataVencimento).Subtract(DateTime.Now).TotalDays);
            lblAviso.Text = $"Faltam {qtdeDias} Dias para seu certificado digital, da empresa [{Filial.Nome}], CNPJ: {Filial.CNPJ}, Vencer!!";
        }

        public bool DeveAbrirTela()
        {
            var Filial = FilialController.Instancia.LoadObjectById((from emp in db.Filials
                                                                    where emp.Codigo == 1
                                                                    select emp).Single().ID);
            var DataVencimento = GetExpiration(Filial.Certificado);
            if (string.IsNullOrEmpty(DataVencimento))
                return false;

            var qtdeDias = Convert.ToInt32(Convert.ToDateTime(DataVencimento).Subtract(DateTime.Now).TotalDays);
            return Filial.QuantDiasVencCertificado >= qtdeDias;
        }

        private string GetExpiration(string SerialNumber)
        {
            try
            {
                X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
                store.Open(OpenFlags.ReadOnly);
                foreach (var item in store.Certificates)
                    if (item.SerialNumber == SerialNumber)
                        return item.GetExpirationDateString();

                return string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
