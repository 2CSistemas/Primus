using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using cwkGestao.Modelo;
using cwkGestao.Modelo.Util;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Integracao;

namespace Aplicacao.Utilitarios
{
    public partial class FormImportaNcmCestCFOP : Form
    {
        #region Propriedades

        #endregion

        #region Construtores

        public FormImportaNcmCestCFOP()
        {
            InitializeComponent();
            cboTipoRegistro.Text = cboTipoRegistro.Items[0].ToString();
        }

        #endregion

        #region Eventos
        private void btnProcurarArquivo_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                CheckFileExists = true,
                Multiselect = false,
                Filter = "Excel | *.xlsx;*.xls"
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            txtCaminhoArquivo.Text = dialog.FileName;
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (SeArquivoInvalido()) return;
            CarregarDadosDoArquivo();
        }

        private void btnImportarRegistros_Click(object sender, EventArgs e)
        {
            #region Validação

            if (ValidateWithMessage(dgvDados.DataSource == null, "Sem dados para importação!")) return;

            #endregion

            if (MessageBox.Show("Deseja Importar os Dados?", "Importar os Dados", MessageBoxButtons.YesNo) == DialogResult.No) return;

            switch (cboTipoRegistro.Text)
            {
                case "CEST":
                    ImportarCest();
                    break;
                case "CFOP":
                    ImportarCFOP();
                    break;
                case "NCM":
                    ImportarNcm();
                    break;
                default:
                    MessageBox.Show("Importação não configurada para o tipo selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Métodos

        private void ImportarNcm()
        {
            // 0 Codigo
            // 1 Descricao
            // 2 Fim Vigência
            // 3 CEST

            var configuracao = ConfiguracaoController.Instancia.GetConfiguracao();
            var dataTable = (DataTable)dgvDados.DataSource;
            var ncmImportados = 0;
            var ncmAtualizados = 0;

            foreach (DataRow item in dataTable.Rows)
            {
                if (item["NCM"].ToString().IsNullOrEmpty())
                    continue;

                Acao _Acao = Acao.Alterar;
                var _Ncm = NCMController.Instancia.GetByNcm(item["NCM"].ToString());
                if (_Ncm == null)
                {
                    _Acao = Acao.Incluir;
                    _Ncm = new NCM
                    {
                        Codigo = NCMController.Instancia.MaxCodigo(),
                        Ncm = item["NCM"].ToString(),
                        Descricao = item["DESCRICAO"].ToString().TrimCk(),
                        DtRevogacao = item["FIM VIGENCIA"].ToString().IsNullOrEmpty() ? null : (DateTime?)Convert.ToDateTime(item["FIM VIGENCIA"]),
                        Cest = item["CEST"].ToString().TrimCk(),
                        EnqGeral = configuracao.CodigoEnquadramentoIPI ?? 999
                    };
                    ncmImportados++;
                }
                else
                {
                    _Ncm.Descricao = item["DESCRICAO"].ToString().TrimCk();
                    _Ncm.DtRevogacao = item["FIM VIGENCIA"].ToString().IsNullOrEmpty() ? null : (DateTime?)Convert.ToDateTime(item["FIM VIGENCIA"]);
                    _Ncm.Cest = item["CEST"].ToString().TrimCk();
                    _Ncm.EnqGeral = configuracao.CodigoEnquadramentoIPI ?? 999;
                    ncmAtualizados++;
                }

                NCMController.Instancia.Salvar(_Ncm, _Acao);
            }
            MessageBox.Show($"Dados importados com sucesso!{Environment.NewLine}Importados: {ncmImportados},{Environment.NewLine}Atualizados: {ncmAtualizados}");
        }

        private void ImportarCest()
        {

        }

        private void ImportarCFOP()
        {
            // CODIGO
            // DESCRICAO
            var dataTable = (DataTable)dgvDados.DataSource;
            var cfopImportados = 0;
            var cfopAtualizados = 0;

            foreach (DataRow item in dataTable.Rows)
            {
                if (item["CODIGO"].ToString().IsNullOrEmpty())
                    continue;

                Acao _Acao = Acao.Alterar;
                var _Cfop = TabelaCFOPController.Instancia.GetCFOPPorNumero(item["CODIGO"].ToString());
                if (_Cfop == null)
                {
                    _Acao = Acao.Incluir;
                    _Cfop = new TabelaCFOP
                    {
                        Codigo = TabelaCFOPController.Instancia.MaxCodigo(),
                        CFOP = item["CODIGO"].ToString(),
                        Nome = item["DESCRICAO"].ToString().TrimCk()
                    };
                    cfopImportados++;
                }
                else
                {
                    _Cfop.Nome = item["DESCRICAO"].ToString().TrimCk();
                    cfopAtualizados++;
                }

                TabelaCFOPController.Instancia.Salvar(_Cfop, _Acao);
            }
            MessageBox.Show($"Dados importados com sucesso!{Environment.NewLine}Importados: {cfopImportados},{Environment.NewLine}Atualizados: {cfopAtualizados}");
        }

        private void CarregarDadosDoArquivo()
        {
            var dataTable = ObterTabela();
            dgvDados.DataSource = dataTable;
            txtRegistros.Text = dataTable == null ? "0" : dataTable.Rows.Count.ToString();
        }

        private DataTable ObterTabela()
        {
            var dataTable = new DataTable();

            try
            {
                var extensao = Path.GetExtension(txtCaminhoArquivo.Text);
                var connectionString = extensao.Equals(".xls")
                    ? "Provider=Microsoft.Jet.OLEDB.4.0; Data Source =" + txtCaminhoArquivo.Text.TrimCk() + "; Extended Properties = 'Excel 8.0;HDR=YES'"
                    : "Provider=Microsoft.ACE.OLEDB.12.0; Data Source =" + txtCaminhoArquivo.Text.TrimCk() + "; Extended Properties = 'Excel 8.0;HDR=YES'";

                using (var conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    var schema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    var nomePlanilha = schema.Rows[0]["TABLE_NAME"].ToString();

                    if (!nomePlanilha.Contains(cboTipoRegistro.Text))
                    {
                        dataTable = null;
                        MessageBox.Show("Arquivo inválido de acordo com o tipo selecionado. Por favor, tente novamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        var cmd = new OleDbCommand($"SELECT * From [{nomePlanilha}]", conn);
                        var dataAdapter = new OleDbDataAdapter(cmd);
                        dataAdapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return dataTable;
        }

        private bool SeArquivoInvalido()
        {
            if (ValidateWithMessage(txtCaminhoArquivo.Text.IsNullOrEmpty(), "Arquivo inválido. Por favor, tente novamente"))
                return true;

            if (ValidateWithMessage(!File.Exists(txtCaminhoArquivo.Text), "Arquivo não encontrado. Por favor, tente novamente"))
                return true;

            return false;
        }

        private bool ValidateWithMessage(bool predicate, string message)
        {
            if (predicate) MessageBox.Show(message, "Importação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return predicate;
        }

        #endregion
    }
}
