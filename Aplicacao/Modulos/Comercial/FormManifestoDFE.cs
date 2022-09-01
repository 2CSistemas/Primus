//using MDFe.Classes.Flags;
//using MDFe.Utils.Configuracoes;
//using MetroFramework;
//using MetroFramework.Forms;
//using PDV.CONTROLER.Funcoes;
//using PDV.CONTROLLER.MDFE.Configuracao;
//using PDV.CONTROLLER.MDFE.Eventos;
//using PDV.CONTROLLER.MDFE.Util;
//using PDV.DAO.Custom;
//using PDV.DAO.DB.Utils;
//using PDV.DAO.Entidades;
//using PDV.DAO.Entidades.MDFe;
//using PDV.DAO.Entidades.MDFe.Tipos;
//using PDV.DAO.Enum;
//using PDV.UTIL;
//using PDV.VIEW.App_Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace PDV.VIEW.Forms.Vendas.Manifesto
{
    public partial class FormManifestoDFE : Form
    {
        private string NOME_TELA = "MANIFESTO DE DOCUMENTO FISCAL ELETRÔNICO";

        private Mdfe MDFe = null;

        //*UFs */
        private List<UF> UFPercurso;
        private List<UF> UFCarregamento;
        private List<UF> UFDescarregamento;

        ///* Identificacao */
        //private List<TipoEmitente> TiposEmitente;
        //private List<TipoTransportador> TiposTransportador;

        ///* Veiculo */
        private List<Veiculo> Veiculo;
        private List<ProprietarioVeiculoMdfe> Proprietario;
        private List<Condutor> Condutor;

        ///* Lacres */
        //private DataTable Lacres;

        ///* Condutores */
        //private DataTable Condutores;

        ///* Percurso */
        //private DataTable Percurso;

        ///* NFeCTe */
        //private DataTable NFeVinculado;

        ///* Contratante */
        //private DataTable Contratantes;

        ///* private DataTable Seguro */
        //public DataTable Seguros;
        //public Dictionary<decimal, DataTable> Averbacoes;

        //private decimal? NumeroMDFe = null;

        public FormManifestoDFE(Mdfe _MDFe = null)
        {
            InitializeComponent();
            metroTabControl1.SelectedTab = metroTabPage1;
            //    NumeroMDFe = _NumeroMDFe;
            //    ConfigMDFe.PreencheConfiguracao(Contexto.CaminhoSchemasMDFe);
            //    AplicaMascaraContratante();
            //    Averbacoes = new Dictionary<decimal, DataTable>();

            //    ovTXT_PesoBrutoTotal.AplicaAlteracoes();

            if (_MDFe == null)
                _MDFe = new Mdfe
                {
                    DataCadastro = DateTime.Now,
                    Emissao = DateTime.Now,
                    Filial = FilialController.Instancia.GetFilialPrincipal(),
                    //            Serie = Contexto.CONFIGURACAO_SERIE.SerieMDFe,
                    //            NMDF = NumeroMDFe.HasValue ? NumeroMDFe.Value : Sequence.GetNextID(Contexto.CONFIGURACAO_SERIE.NomeSequenceMDFe),
                    //            TipoAmbiente = (int)MDFeConfiguracao.VersaoWebService.TipoAmbiente,
                    Modelo = 58,
                    //            TipoEmissao = (int)MDFeTipoEmissao.Normal
                };

            MDFe = _MDFe;

            IniciaSeletoresUF();
            CarregaEmitente();
            //    IniciaSeletoresIdentificacao();
            //    IniciaSeletoresVeiculo();

            //    PreencherTela();
        }

        private void PreencherTela()
        {
            //CarregaLacres(true);
            //CarregaCondutores(true);
            //CarregaPercurso(true);
            //CarregaNFe(true);
            //CarregaContratantes(true);
            //CarregaSeguro(true);

            //ovCMB_TipoEmitente.SelectedItem = TiposEmitente.Where(o => o.IDTipoEmitente == MDFe.TipoEmitente).FirstOrDefault();
            //ovCMB_TipoTransportador.SelectedItem = TiposTransportador.Where(o => o.IDTransportador == MDFe.TipoTransportador).FirstOrDefault();

            //ovTXT_Serie.Text = Contexto.CONFIGURACAO_SERIE.SerieMDFe.ToString();
            //ovTXT_NumeroMDFe.Text = MDFe.NMDF.ToString();
            //ovTXT_Emissao.Text = MDFe.Emissao.ToString();

            //DataTable dtVeiculoEProprietario = FuncoesVeiculoMDFe.GetVeiculoEProprietarioMDFe(MDFe.IDMDFe);

            //ovCMB_Veiculo.SelectedItem = null;
            //ovCMB_Proprietario.SelectedItem = null;
            //ovCMB_Condutor.SelectedItem = null;
            //if (dtVeiculoEProprietario != null && dtVeiculoEProprietario.Rows.Count > 0)
            //{
            //    ovCMB_Veiculo.SelectedItem = Veiculo.Where(o => o.IDVeiculo == Convert.ToDecimal(dtVeiculoEProprietario.Rows[0]["IDVEICULO"])).FirstOrDefault();
            //    if (dtVeiculoEProprietario.Rows[0]["IDPROPRIETARIOVEICULOMDFE"] != DBNull.Value)
            //        ovCMB_Proprietario.SelectedItem = Proprietario.Where(o => o.IDProprietarioVeiculoMDFe == Convert.ToDecimal(dtVeiculoEProprietario.Rows[0]["IDPROPRIETARIOVEICULOMDFE"])).FirstOrDefault();
            //}

            //ovCMB_UFPercurso.SelectedItem = null;
            //ovTXT_InformacoesComplementares.Text = MDFe.InformacoesComplementares;
            //ovCMB_UFDescarregamento.SelectedItem = UFDescarregamento.Where(o => o.IDUnidadeFederativa == MDFe.IDUnidadeFederativaDescarregamento).FirstOrDefault();

            //if (MDFe.CodigoUNPesoCarga == 1)
            //    ovCKB_KG.Checked = true;
            //else
            //    ovCKB_TON.Checked = true;

            //RecalculaTotalizadores();
        }

        private void CarregaContratantes(bool Banco)
        {
            //if (Banco)
            //    Contratantes = FuncoesContratanteMDFe.GetContratantesPorMDFe(MDFe.IDMDFe);

            //ovGRD_Contratantes.DataSource = Contratantes;
            //AjustaGridContratantes();
        }

        private void AjustaGridContratantes()
        {
            //ovGRD_Contratantes.RowHeadersVisible = false;
            //int WidthGrid = ovGRD_Contratantes.Width;

            //foreach (DataGridViewColumn column in ovGRD_Contratantes.Columns)
            //{
            //    switch (column.Name)
            //    {
            //        case "cpfcnpj":
            //            column.DisplayIndex = 0;
            //            column.FillWeight = WidthGrid;
            //            column.HeaderText = "CPF/CNPJ";
            //            break;
            //        default:
            //            column.DisplayIndex = 0;
            //            column.Visible = false;
            //            break;
            //    }
            //}
        }

        private void CarregaNFe(bool CarregaBanco)
        {
            //if (CarregaBanco)
            //    NFeVinculado = FuncoesDocumentoFiscalMDFe.GetDocumentosFiscal(MDFe.IDMDFe);

            //ovGRD_Documentos.DataSource = NFeVinculado;
            //AjustaGridDocumentos();
            //RecalculaTotalizadores();
        }

        private void AjustaGridDocumentos()
        {
            //ovGRD_Documentos.RowHeadersVisible = false;
            //int WidthGrid = ovGRD_Documentos.Width;

            //foreach (DataGridViewColumn column in ovGRD_Documentos.Columns)
            //{
            //    switch (column.Name)
            //    {
            //        case "chavenfe":
            //            column.DisplayIndex = 1;
            //            column.FillWeight = Convert.ToInt32(WidthGrid * 0.60);
            //            column.HeaderText = "CHAVE NF-E";
            //            break;
            //        case "municipio":
            //            column.DisplayIndex = 2;
            //            column.FillWeight = Convert.ToInt32(WidthGrid * 0.30);
            //            column.HeaderText = "MUNICÍPIO";
            //            break;
            //        case "sigla":
            //            column.DisplayIndex = 3;
            //            column.FillWeight = Convert.ToInt32(WidthGrid * 0.10);
            //            column.HeaderText = "UF";
            //            break;
            //        default:
            //            column.DisplayIndex = 0;
            //            column.Visible = false;
            //            break;
            //    }
            //}
        }

        private void CarregaPercurso(bool CarregaBanco)
        {
            //if (CarregaBanco)
            //    Percurso = FuncoesPercurso.GetPercursosPorMDFe(MDFe.IDMDFe);

            //ovGRD_Percurso.DataSource = Percurso;
            //AjustaGridPercurso();
        }

        private void AjustaGridPercurso()
        {
            //ovGRD_Percurso.RowHeadersVisible = false;
            //int WidthGrid = ovGRD_Percurso.Width;

            //foreach (DataGridViewColumn column in ovGRD_Percurso.Columns)
            //{
            //    switch (column.Name)
            //    {
            //        case "sigla":
            //            column.DisplayIndex = 1;
            //            column.FillWeight = Convert.ToInt32(WidthGrid * 0.10);
            //            column.HeaderText = "UF";
            //            break;
            //        case "inicioviagem":
            //            column.DisplayIndex = 2;
            //            column.FillWeight = Convert.ToInt32(WidthGrid * 0.90);
            //            column.HeaderText = "INÍCIO DA VIAGEM";
            //            break;
            //        default:
            //            column.DisplayIndex = 0;
            //            column.Visible = false;
            //            break;
            //    }
            //}
        }

        private void IniciaSeletoresVeiculo()
        {
            //Veiculo = FuncoesVeiculoMDFe.GetVeiculos();
            //ovCMB_Veiculo.DataSource = Veiculo;
            //ovCMB_Veiculo.ValueMember = "idveiculo";
            //ovCMB_Veiculo.DisplayMember = "descricao";

            //Proprietario = FuncoesProprietario.GetProprietarios();
            //ovCMB_Proprietario.DataSource = Proprietario;
            //ovCMB_Proprietario.ValueMember = "idproprietarioveiculomdfe";
            //ovCMB_Proprietario.DisplayMember = "descricao";

            //Condutor = FuncoesCondutor.GetCondutoresAtivos();
            //ovCMB_Condutor.DataSource = Condutor;
            //ovCMB_Condutor.DisplayMember = "descricao";
            //ovCMB_Condutor.ValueMember = "idcondutor";
            //ovCMB_Condutor.SelectedItem = null;
        }

        private void CarregaCondutores(bool CarregaBanco)
        {
            //if (CarregaBanco)
            //    Condutores = FuncoesCondutor.GetCondutoresPorMDFe(MDFe.IDMDFe);

            //ovGRD_Condutores.DataSource = Condutores;
            //AjustaGridCondutores();
        }

        private void AjustaGridCondutores()
        {
            //ovGRD_Condutores.RowHeadersVisible = false;
            //int WidthGrid = ovGRD_Condutores.Width;

            //foreach (DataGridViewColumn column in ovGRD_Condutores.Columns)
            //{
            //    switch (column.Name)
            //    {
            //        case "cpf":
            //            column.DisplayIndex = 1;
            //            column.FillWeight = Convert.ToInt32(WidthGrid * 0.20);
            //            column.HeaderText = "CPF";
            //            break;
            //        case "nome":
            //            column.DisplayIndex = 2;
            //            column.FillWeight = Convert.ToInt32(WidthGrid * 0.70);
            //            column.HeaderText = "NOME";
            //            break;
            //        case "sigla":
            //            column.DisplayIndex = 3;
            //            column.FillWeight = Convert.ToInt32(WidthGrid * 0.10);
            //            column.HeaderText = "UF";
            //            break;
            //        default:
            //            column.DisplayIndex = 0;
            //            column.Visible = false;
            //            break;
            //    }
            //}
        }

        private void CarregaLacres(bool CarregaBanco)
        {
            //if (CarregaBanco)
            //    Lacres = FuncoesLacreMDFe.GetLacresPorMDFe(MDFe.IDMDFe);

            //ovGRD_Lacres.DataSource = Lacres;
            //AjustaGridLacres();
        }

        private void AjustaGridLacres()
        {
            //ovGRD_Lacres.RowHeadersVisible = false;
            //int WidthGrid = ovGRD_Lacres.Width;

            //foreach (DataGridViewColumn column in ovGRD_Lacres.Columns)
            //{
            //    switch (column.Name)
            //    {
            //        case "numero":
            //            column.DisplayIndex = 1;
            //            column.FillWeight = WidthGrid;
            //            column.HeaderText = "NÚMERO";
            //            break;
            //        default:
            //            column.DisplayIndex = 0;
            //            column.Visible = false;
            //            break;
            //    }
            //}
        }

        private void IniciaSeletoresIdentificacao()
        {
            //TiposTransportador = TipoTransportador.GetTipos();
            //ovCMB_TipoTransportador.DataSource = TiposTransportador;
            //ovCMB_TipoTransportador.DisplayMember = "descricao";
            //ovCMB_TipoTransportador.ValueMember = "idtransportador";


            //TiposEmitente = TipoEmitente.GetTipos();
            //ovCMB_TipoEmitente.DataSource = TiposEmitente;
            //ovCMB_TipoEmitente.DisplayMember = "descricao";
            //ovCMB_TipoEmitente.ValueMember = "idtipoemitente";
        }

        private void CarregaEmitente()
        {
            ovTXT_CNPJEmitente.Text = MDFe.Filial.CNPJ;
            ovTXT_NomeEmiente.Text = MDFe.Filial.Fantasia;

            ovTXT_LogradouroEmitente.Text = MDFe.Filial.Endereco;
            ovTXT_NumeroEmitente.Text = MDFe.Filial.Numero;
            ovTXT_ComplementoEmitente.Text = MDFe.Filial.Complemento;
            ovTXT_CidadeEmitente.Text = MDFe.Filial.Cidade.Nome;
            ovTXT_UFEmitente.Text = MDFe.Filial.Cidade.UF.Sigla;
            ovTXT_PaisEmitente.Text = MDFe.Filial.Cidade.UF.Pais.Nome;

            ovCMB_UFCarregamento.SelectedItem = UFCarregamento.FirstOrDefault(o => o.ID == MDFe.Filial.Cidade.UF.ID);
        }

        private void IniciaSeletoresUF()
        {
            UFPercurso = UFController.Instancia.GetAll().Where(o => o.Pais.IBGE == "1058").ToList();
            ovCMB_UFPercurso.DisplayMember = "Sigla";
            ovCMB_UFPercurso.ValueMember = "ID";
            ovCMB_UFPercurso.DataSource = UFPercurso;
            ovCMB_UFPercurso.SelectedItem = null;

            UFCarregamento = UFController.Instancia.GetAll().Where(o => o.Pais.IBGE == "1058").ToList();
            ovCMB_UFCarregamento.DisplayMember = "Sigla";
            ovCMB_UFCarregamento.ValueMember = "ID";
            ovCMB_UFCarregamento.DataSource = UFCarregamento;
            ovCMB_UFCarregamento.SelectedItem = null;

            UFDescarregamento = UFController.Instancia.GetAll().Where(o => o.Pais.IBGE == "1058").ToList();
            ovCMB_UFDescarregamento.DisplayMember = "Sigla";
            ovCMB_UFDescarregamento.ValueMember = "ID";
            ovCMB_UFDescarregamento.DataSource = UFDescarregamento;
            ovCMB_UFDescarregamento.SelectedItem = null;
        }

        private void RecalculaTotalizadores()
        {
            //if (NFeVinculado != null && NFeVinculado.Rows.Count > 0)
            //{
            //    var NFes = NFeVinculado.Copy().AsEnumerable().Where(o => o.RowState != DataRowState.Deleted);
            //    if (NFes.Count() == 0)
            //        RedefinirTotalizadores();
            //    else
            //    {
            //        foreach (DataRow dr in NFes)
            //            dr["CHAVENFE"] = $"'NFe{dr["CHAVENFE"].ToString()}'";

            //        DataTable dt = FuncoesVolume.GetTotalVolumesPorNFe(string.Join(",", NFes.Select(o => o["CHAVENFE"].ToString())));

            //        ovTXT_TotalNFe.Text = Convert.ToInt32(dt.Rows[0]["QTDNFE"]).ToString();
            //        ovTXT_ValorTotalCarga.Text = Convert.ToDecimal(dt.Rows[0]["TOTALNFE"]).ToString("n2");
            //        ovTXT_PesoBrutoTotal.Value = Convert.ToDecimal(dt.Rows[0]["PESOBRUTO"]);
            //    }
            //}
            //else
            //    RedefinirTotalizadores();
        }

        private void RedefinirTotalizadores()
        {
            //ovTXT_TotalNFe.Text = "0";
            //ovTXT_ValorTotalCarga.Text = "0,00";
            //ovTXT_PesoBrutoTotal.Value = 0;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            // Adiciona Lacre
            //if (string.IsNullOrEmpty(ovTXT_NumeroLacre.Text))
            //{
            //    MetroMessageBox.Show(this, "Informe o Número do Lacre.", NOME_TELA);
            //    return;
            //}

            //DataRow drLacre = Lacres.NewRow();
            //drLacre["IDLACRERODOVIARIOMDFE"] = Sequence.GetNextID("LACRERODOVIARIOMDFE", "IDLACRERODOVIARIOMDFE");
            //drLacre["IDMDFE"] = MDFe.IDMDFe;
            //drLacre["NUMERO"] = ovTXT_NumeroLacre.Text;
            //Lacres.Rows.Add(drLacre);
            //CarregaLacres(false);
            //ovTXT_NumeroLacre.Text = string.Empty;
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            // RemoveLacre
            //Lacres.DefaultView.RowFilter = "[IDLACRERODOVIARIOMDFE] = " + Convert.ToDecimal(ZeusUtil.GetValueFieldDataRowView((ovGRD_Lacres.CurrentRow.DataBoundItem as DataRowView), "IDLACRERODOVIARIOMDFE"));
            //Lacres.DefaultView[0].Delete();
            //Lacres.DefaultView.RowFilter = string.Empty;
            //CarregaLacres(false);
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            // Adiciona Condutor

            //if (ovCMB_Veiculo.SelectedItem == null)
            //{
            //    MetroMessageBox.Show(this, "Selecione o Veículo.", NOME_TELA);
            //    return;
            //}

            //if (ovCMB_Condutor.SelectedItem == null)
            //{
            //    MetroMessageBox.Show(this, "Selecione o Condutor.", NOME_TELA);
            //    return;
            //}

            //DataRow drCondutor = Condutores.NewRow();
            //drCondutor["IDVEICULOTRACAOMDFE"] = Sequence.GetNextID("VEICULOTRACAOMDFE", "IDVEICULOTRACAOMDFE");
            //drCondutor["IDCONDUTOR"] = (ovCMB_Condutor.SelectedItem as Condutor).IDCondutor;
            //drCondutor["IDVEICULO"] = (ovCMB_Veiculo.SelectedItem as Veiculo).IDVeiculo;
            //drCondutor["IDMDFE"] = MDFe.IDMDFe;

            //drCondutor["IDPROPRIETARIOVEICULOMDFE"] = DBNull.Value;
            //if (ovCMB_Proprietario.SelectedItem != null)
            //    drCondutor["IDPROPRIETARIOVEICULOMDFE"] = (ovCMB_Proprietario.SelectedItem as ProprietarioVeiculoMDFe).IDProprietarioVeiculoMDFe;

            //drCondutor["CPF"] = (ovCMB_Condutor.SelectedItem as Condutor).CPF;
            //drCondutor["NOME"] = (ovCMB_Condutor.SelectedItem as Condutor).Nome;
            //drCondutor["IDUNIDADEFEDERATIVA"] = (ovCMB_Condutor.SelectedItem as Condutor).IDUnidadeFederativa;
            //drCondutor["SIGLA"] = FuncoesUF.GetUnidadeFederativa((ovCMB_Condutor.SelectedItem as Condutor).IDUnidadeFederativa).Sigla;

            //Condutores.Rows.Add(drCondutor);
            //CarregaCondutores(false);
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            // Remove Condutor
            //Condutores.DefaultView.RowFilter = "[IDVEICULOTRACAOMDFE] = " + Convert.ToDecimal(ZeusUtil.GetValueFieldDataRowView((ovGRD_Condutores.CurrentRow.DataBoundItem as DataRowView), "IDVEICULOTRACAOMDFE"));
            //Condutores.DefaultView[0].Delete();
            //Condutores.DefaultView.RowFilter = string.Empty;
            //CarregaCondutores(false);
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            // Adicionar Percurso
            //if (ovCMB_UFPercurso.SelectedItem == null)
            //{
            //    MetroMessageBox.Show(this, "Selecione a UF do Percurso.", NOME_TELA);
            //    return;
            //}

            //DataRow drPercurso = Percurso.NewRow();
            //drPercurso["SIGLA"] = (ovCMB_UFPercurso.SelectedItem as UnidadeFederativa).Sigla;

            //drPercurso["INICIOVIAGEM"] = DBNull.Value;
            //if (ovTXT_InicioViagem.Checked)
            //    drPercurso["INICIOVIAGEM"] = ovTXT_InicioViagem.Value;

            //drPercurso["IDPERCURSOMDFE"] = Sequence.GetNextID("PERCURSOMDFE", "IDPERCURSOMDFE");
            //drPercurso["IDMDFE"] = MDFe.IDMDFe;
            //drPercurso["IDUNIDADEFEDERATIVAPERCURSO"] = (ovCMB_UFPercurso.SelectedItem as UnidadeFederativa).IDUnidadeFederativa;

            //Percurso.Rows.Add(drPercurso);
            //CarregaPercurso(false);
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            // Remover Percurso
            //Percurso.DefaultView.RowFilter = "[IDPERCURSOMDFE] = " + Convert.ToDecimal(ZeusUtil.GetValueFieldDataRowView((ovGRD_Percurso.CurrentRow.DataBoundItem as DataRowView), "IDPERCURSOMDFE"));
            //Percurso.DefaultView[0].Delete();
            //Percurso.DefaultView.RowFilter = string.Empty;
            //CarregaPercurso(false);
        }

        private void ovGRD_Percurso_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //switch (ovGRD_Percurso.Columns[e.ColumnIndex].Name)
            //{
            //    case "inicioviagem":
            //        if (e.Value == null || e.Value == DBNull.Value)
            //            e.Value = "<Não Informado>";
            //        else
            //            e.Value = Convert.ToDateTime(e.Value).ToString("dd/MM/yyyy");
            //        break;
            //}
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            // Adiciona NFe/CTe
            //SeletorNFe SeletorNFe = new SeletorNFe();
            //SeletorNFe.ShowDialog(this);
            //if (SeletorNFe.Selecionados != null)
            //{
            //    foreach (DataRow dr in SeletorNFe.Selecionados.Rows)
            //    {
            //        DataRow drNFe = NFeVinculado.NewRow();

            //        Cliente Cliente = FuncoesCliente.GetCliente(Convert.ToDecimal(dr["IDCLIENTE"]));
            //        Endereco EnderecoCliente = FuncoesEndereco.GetEndereco(Cliente.IDEndereco.Value);
            //        Municipio MunicipioCliente = FuncoesMunicipio.GetMunicipio(EnderecoCliente.IDMunicipio.Value);
            //        UnidadeFederativa UFCliente = FuncoesUF.GetUnidadeFederativa(EnderecoCliente.IDUnidadeFederativa.Value);

            //        drNFe["IDDOCUMENTOFISCALMDFE"] = Sequence.GetNextID("DOCUMENTOFISCALMDFE", "IDDOCUMENTOFISCALMDFE");
            //        drNFe["IDMDFE"] = MDFe.IDMDFe;
            //        drNFe["IDMUNICIPIODESCARGA"] = MunicipioCliente.IDMunicipio;
            //        drNFe["IDNFEREFERENCIADAMDFE"] = Sequence.GetNextID("NFEREFERENCIADAMDFE", "IDNFEREFERENCIADAMDFE");
            //        drNFe["IDUNIDADEFEDERATIVA"] = UFCliente.IDUnidadeFederativa;
            //        drNFe["CHAVENFE"] = dr["CHAVE"].ToString().ToUpper().Replace("NFE", string.Empty);
            //        drNFe["MUNICIPIO"] = MunicipioCliente.Descricao;
            //        drNFe["SIGLA"] = UFCliente.Sigla;
            //        NFeVinculado.Rows.Add(drNFe);
            //    }
            //    CarregaNFe(false);
            //}
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            // Remove NFe
            //NFeVinculado.DefaultView.RowFilter = "[IDDOCUMENTOFISCALMDFE] = " + Convert.ToDecimal(ZeusUtil.GetValueFieldDataRowView((ovGRD_Documentos.CurrentRow.DataBoundItem as DataRowView), "IDDOCUMENTOFISCALMDFE"));
            //NFeVinculado.DefaultView[0].Delete();
            //NFeVinculado.DefaultView.RowFilter = string.Empty;
            //CarregaNFe(false);
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            // Salvar MDFe
            //SalvarMDFe(false);
        }

        private void SalvarMDFe(bool Transmitir)
        {
            //try
            //{
            //    PDVControlador.BeginTransaction();
            //    ValidaMDFe();

            //    TipoOperacao Op = !FuncoesMDFe.Existe(MDFe.IDMDFe) ? TipoOperacao.INSERT : TipoOperacao.UPDATE;

            //    MDFe.InformacoesComplementares = ovTXT_InformacoesComplementares.Text;
            //    MDFe.TipoEmitente = (ovCMB_TipoEmitente.SelectedItem as TipoEmitente).IDTipoEmitente;
            //    MDFe.TipoTransportador = (ovCMB_TipoTransportador.SelectedItem as TipoTransportador).IDTransportador;
            //    MDFe.ModalidadeTransporte = (int)MDFeModal.Rodoviario;
            //    MDFe.CodigoUNPesoCarga = ovCKB_KG.Checked ? 1 : 2;
            //    MDFe.IDUnidadeFederativaDescarregamento = (ovCMB_UFDescarregamento.SelectedItem as UnidadeFederativa).IDUnidadeFederativa;
            //    MDFe.PesoBrutoTotal = ovTXT_PesoBrutoTotal.Value;

            //    if (!FuncoesMDFe.Salvar(MDFe, Op))
            //        throw new Exception("Não foi possível Salvar o MDFe");

            //    DataTable dt = null;

            //    // Lacres
            //    dt = ZeusUtil.GetChanges(Lacres, TipoOperacao.INSERT);
            //    if (dt != null)
            //        foreach (DataRow dr in dt.Rows)
            //            if (!FuncoesLacreMDFe.Salvar(EntityUtil<LacreRodoviarioMDFe>.ParseDataRow(dr)))
            //                throw new Exception("Não foi possível Salvar os Lacres.");

            //    dt = ZeusUtil.GetChanges(Lacres, TipoOperacao.DELETE);
            //    if (dt != null)
            //        foreach (DataRow dr in dt.Rows)
            //            if (!FuncoesLacreMDFe.Remover(Convert.ToDecimal(dr["IDLACRERODOVIARIOMDFE"])))
            //                throw new Exception("Não foi possível Salvar os Lacres.");

            //    // Veiculo/Condutores
            //    var lQueryCondutores = Condutores.AsEnumerable().Where(o => o.RowState != DataRowState.Deleted);
            //    if (lQueryCondutores != null && lQueryCondutores.Count() > 0)
            //    {
            //        dt = ZeusUtil.GetChanges(Condutores, TipoOperacao.INSERT);
            //        if (dt != null)
            //            foreach (DataRow dr in dt.Rows)
            //                if (!FuncoesVeiculoTracaoMDFe.Salvar(EntityUtil<VeiculoTracaoMDFe>.ParseDataRow(dr), TipoOperacao.INSERT))
            //                    throw new Exception("Não foi possível Salvar Veículo/Condutores.");

            //        dt = ZeusUtil.GetChanges(Condutores, TipoOperacao.UPDATE);
            //        if (dt != null)
            //            foreach (DataRow dr in dt.Rows)
            //                if (!FuncoesVeiculoTracaoMDFe.Salvar(EntityUtil<VeiculoTracaoMDFe>.ParseDataRow(dr), TipoOperacao.UPDATE))
            //                    throw new Exception("Não foi possível Salvar Veículo/Condutores.");

            //        dt = ZeusUtil.GetChanges(Condutores, TipoOperacao.DELETE);
            //        if (dt != null)
            //            foreach (DataRow dr in dt.Rows)
            //                if (!FuncoesVeiculoTracaoMDFe.Remover(Convert.ToDecimal(dr["IDVEICULOTRACAOMDFE"])))
            //                    throw new Exception("Não foi possível Salvar Veículo/Condutores.");

            //    }
            //    else // Não tem condutores, mas é preciso salvar o IDVeiculo e IDProprietario
            //    {
            //        dt = ZeusUtil.GetChanges(Condutores, TipoOperacao.DELETE);
            //        if (dt != null)
            //            foreach (DataRow dr in dt.Rows)
            //                if (!FuncoesVeiculoTracaoMDFe.Remover(Convert.ToDecimal(dr["IDVEICULOTRACAOMDFE"])))
            //                    throw new Exception("Não foi possível Salvar Veículo/Condutores.");

            //        if (!FuncoesVeiculoTracaoMDFe.Salvar(new VeiculoTracaoMDFe()
            //        {
            //            IDCondutor = null,
            //            IDMDFe = MDFe.IDMDFe,
            //            IDProprietarioVeiculoMDFe = ovCMB_Proprietario.SelectedItem == null ? null : (decimal?)(ovCMB_Proprietario.SelectedItem as ProprietarioVeiculoMDFe).IDProprietarioVeiculoMDFe,
            //            IDVeiculo = (ovCMB_Veiculo.SelectedItem as Veiculo).IDVeiculo,
            //            IDVeiculoTracaoMDFe = Sequence.GetNextID("VEICULOTRACAOMDFE", "IDVEICULOTRACAOMDFE")
            //        }, TipoOperacao.INSERT))
            //            throw new Exception("Não foi possível Salvar Veículo/Condutores.");
            //    }

            //    // Percurso
            //    dt = ZeusUtil.GetChanges(Percurso, TipoOperacao.INSERT);
            //    if (dt != null)
            //        foreach (DataRow dr in dt.Rows)
            //            if (!FuncoesPercurso.Salvar(EntityUtil<PercursoMDFe>.ParseDataRow(dr)))
            //                throw new Exception("Não foi possível Salvar o Percurso.");

            //    dt = ZeusUtil.GetChanges(Percurso, TipoOperacao.DELETE);
            //    if (dt != null)
            //        foreach (DataRow dr in dt.Rows)
            //            if (!FuncoesPercurso.Remover(Convert.ToDecimal(dr["IDPERCURSOMDFE"])))
            //                throw new Exception("Não foi possível Salvar o Percurso.");

            //    // NFe Referenciada
            //    dt = ZeusUtil.GetChanges(NFeVinculado, TipoOperacao.INSERT);
            //    if (dt != null)
            //        foreach (DataRow dr in dt.Rows)
            //            if (!FuncoesDocumentoFiscalMDFe.SalvarNFeReferenciada(EntityUtil<NFeReferenciadaMDFe>.ParseDataRow(dr), MDFe.IDMDFe, Convert.ToDecimal(dr["IDMUNICIPIODESCARGA"])))
            //                throw new Exception("Não foi possível Salvar as NFe Referenciada.");

            //    dt = ZeusUtil.GetChanges(NFeVinculado, TipoOperacao.DELETE);
            //    if (dt != null)
            //        foreach (DataRow dr in dt.Rows)
            //            if (!FuncoesDocumentoFiscalMDFe.RemoverNFeReferenciada(Convert.ToDecimal(dr["IDDOCUMENTOFISCALMDFE"]), Convert.ToDecimal(dr["IDNFEREFERENCIADAMDFE"])))
            //                throw new Exception("Não foi possível Salvar as NFe Referenciada.");

            //    // Contratantes
            //    dt = ZeusUtil.GetChanges(Contratantes, TipoOperacao.INSERT);
            //    if (dt != null)
            //        foreach (DataRow dr in dt.Rows)
            //            if (!FuncoesContratanteMDFe.Salvar(EntityUtil<ContratanteMDFe>.ParseDataRow(dr)))
            //                throw new Exception("Não foi possível salvar os Contratantes.");

            //    dt = ZeusUtil.GetChanges(Contratantes, TipoOperacao.DELETE);
            //    if (dt != null)
            //        foreach (DataRow dr in dt.Rows)
            //            if (!FuncoesContratanteMDFe.Remover(Convert.ToDecimal(dr["IDCONTRATANTEMDFE"])))
            //                throw new Exception("Não foi possível salvar os Contratantes.");

            //    /* Seguro */
            //    dt = ZeusUtil.GetChanges(Seguros, TipoOperacao.INSERT);
            //    if (dt != null)
            //        foreach (DataRow dr in dt.Rows)
            //        {
            //            SeguradoraMDFe SeguradoraMDFe = EntityUtil<SeguradoraMDFe>.ParseDataRow(dr);

            //            SalvaResponsavelSeguro(dr, TipoOperacao.INSERT);
            //            if (!FuncoesSeguradoraMDFe.Salvar(SeguradoraMDFe, TipoOperacao.INSERT))
            //                throw new Exception("Não foi possível salvar o Seguro.");
            //            SalvarAverbacoesDoSeguro(SeguradoraMDFe);
            //        }

            //    dt = ZeusUtil.GetChanges(Seguros, TipoOperacao.UPDATE);
            //    if (dt != null)
            //        foreach (DataRow dr in dt.Rows)
            //        {
            //            SeguradoraMDFe SeguradoraMDFe = EntityUtil<SeguradoraMDFe>.ParseDataRow(dr);
            //            if (!FuncoesSeguradoraMDFe.Salvar(SeguradoraMDFe, TipoOperacao.UPDATE))
            //                throw new Exception("Não foi possível salvar o Seguro.");

            //            SalvaResponsavelSeguro(dr, TipoOperacao.UPDATE);
            //            SalvarAverbacoesDoSeguro(SeguradoraMDFe);
            //        }

            //    dt = ZeusUtil.GetChanges(Seguros, TipoOperacao.DELETE);
            //    if (dt != null)
            //        foreach (DataRow dr in dt.Rows)
            //        {
            //            SalvarAverbacoesDoSeguro(EntityUtil<SeguradoraMDFe>.ParseDataRow(dr));
            //            if (!FuncoesSeguradoraMDFe.Remover(Convert.ToDecimal(dr["IDSEGURADORAMDFE"])))
            //                throw new Exception("Não foi possível salvar o Seguro.");

            //            SalvaResponsavelSeguro(dr, TipoOperacao.DELETE);
            //        }

            //    PDVControlador.Commit();
            //    MetroMessageBox.Show(this, "MDFe Salvo com Sucesso.", NOME_TELA);
            //    if (Transmitir)
            //        TransmitirMDFe();

            //    Close();
            //}
            //catch (Exception Ex)
            //{
            //    if (PDVControlador.CONTROLADOR.InTransaction(Contexto.IDCONEXAO_PRIMARIA))
            //        PDVControlador.Rollback();

            //    MetroMessageBox.Show(this, Ex.Message, NOME_TELA);
            //}
        }

        //private void SalvaResponsavelSeguro(DataRow dr, TipoOperacao Op)
        //{
        //switch (Op)
        //{
        //    case TipoOperacao.INSERT:
        //    case TipoOperacao.UPDATE:
        //        if (!FuncoesResponsavelSeguroCargaMDFe.Salvar(new ResponsavelSeguroCargaMDFe()
        //        {
        //            CNPJ = dr["CNPJ"].ToString(),
        //            CPF = dr["CPF"].ToString(),
        //            IDResponsavelSeguroCargaMDFe = Convert.ToDecimal(dr["IDRESPONSAVELSEGUROCARGAMDFE"]),
        //            ResponsavelSeguro = Convert.ToDecimal(dr["RESPONSAVELSEGURO"].ToString())
        //        }, Op))
        //            throw new Exception("Não foi possível salvar o Seguro.");
        //        break;
        //    case TipoOperacao.DELETE:
        //        if (!FuncoesResponsavelSeguroCargaMDFe.Remover(Convert.ToDecimal(dr["IDRESPONSAVELSEGUROCARGAMDFE"])))
        //            throw new Exception("Não foi possível salvar o Seguro.");
        //        break;
        //}
        //}

        //private void SalvarAverbacoesDoSeguro(SeguradoraMDFe SeguradoraMDFe)
        //{
        /* Averbações */
        //DataTable dtAverbacoes = ZeusUtil.GetChanges(GetAverbacoes(SeguradoraMDFe.IDSeguradoraMDFe), TipoOperacao.INSERT);
        //if (dtAverbacoes != null)
        //    foreach (DataRow drAverbacao in dtAverbacoes.Rows)
        //        if (!FuncoesAverbacaoMDFe.Salvar(EntityUtil<AverbacaoSeguradoraMDFe>.ParseDataRow(drAverbacao)))
        //            throw new Exception("Não foi possível salvar as Averbações.");

        //dtAverbacoes = ZeusUtil.GetChanges(GetAverbacoes(SeguradoraMDFe.IDSeguradoraMDFe), TipoOperacao.DELETE);
        //if (dtAverbacoes != null)
        //    foreach (DataRow drAverbacao in dtAverbacoes.Rows)
        //        if (!FuncoesAverbacaoMDFe.Remover(Convert.ToDecimal(drAverbacao["IDAVERBACAOSEGURADORAMDFE"])))
        //            throw new Exception("Não foi possível salvar as Averbações.");
        //}

        //private void ValidaMDFe()
        //{
        //if (ovCMB_TipoEmitente.SelectedItem == null)
        //    throw new Exception("Selecione o Tipo Emitente.");

        //if (ovCMB_TipoTransportador.SelectedItem == null)
        //    throw new Exception("Selecione o Tipo Transportador.");

        //if (ovCMB_UFDescarregamento.SelectedItem == null)
        //    throw new Exception("Selecione a UF de Descarregamento.");

        //if (ovCMB_Veiculo.SelectedItem == null)
        //    throw new Exception("Selecione o Veículo.");
        //}

        private void TransmitirMDFe()
        {
            //try
            //{
            //    PDVControlador.BeginTransaction();

            //    decimal? IDMovimentoFiscalMDFe = null;
            //    MovimentoFiscalMDFe Mov = FuncoesMovimentoFiscalMDFe.GetMovimentoPorMDFe(MDFe.IDMDFe);
            //    if (Mov != null)
            //        IDMovimentoFiscalMDFe = Mov.IDMovimentoFiscalMDFe;

            //    RetornoTransmissaoMDFe Retorno = EventosMDFe.TransmitirMDFe(MDFe, IDMovimentoFiscalMDFe, Contexto.CaminhoSchemasMDFe);
            //    PDVControlador.Commit();

            //    if (Retorno.isAutorizada)
            //    {
            //        if (Retorno.isAutorizada && !string.IsNullOrEmpty(Retorno.NomeImpressora))
            //            Retorno.Danfe.Imprimir(Retorno.isCaixaDialogo, Retorno.NomeImpressora);
            //        else
            //            Retorno.Danfe.Visualizar(Retorno.isCaixaDialogo);
            //    }
            //    else
            //        throw new Exception(Retorno.Motivo);
            //}
            //catch (Exception Ex)
            //{
            //    if (PDVControlador.CONTROLADOR.InTransaction(Contexto.IDCONEXAO_PRIMARIA))
            //        PDVControlador.Rollback();

            //    MetroMessageBox.Show(this, Ex.Message, NOME_TELA);
            //}
        }

        private void ovBTN_SalvarETransmitir_Click(object sender, EventArgs e)
        {
            //SalvarMDFe(true);
        }

        private void metroButton12_Click(object sender, EventArgs e)
        {
            // Adicionar Contratante
            //if (string.IsNullOrEmpty(ZeusUtil.SomenteNumeros(ovTXT_CNPJCPFContratante.Text)))
            //{
            //    MetroMessageBox.Show(this, "Informe o CPF/CNPJ do Contratante.", NOME_TELA);
            //    return;
            //}

            //DataRow dr = Contratantes.NewRow();
            //dr["IDCONTRATANTEMDFE"] = Sequence.GetNextID("CONTRATANTEMDFE", "IDCONTRATANTEMDFE");
            //dr["IDMDFE"] = MDFe.IDMDFe;
            //if (ovCKB_ContratanteFisica.Checked)
            //{
            //    dr["CPF"] = ZeusUtil.SomenteNumeros(ovTXT_CNPJCPFContratante.Text);
            //    dr["CNPJ"] = DBNull.Value;
            //    dr["CPFCNPJ"] = ZeusUtil.SomenteNumeros(ovTXT_CNPJCPFContratante.Text);
            //}
            //else
            //{
            //    dr["CPF"] = DBNull.Value;
            //    dr["CNPJ"] = ZeusUtil.SomenteNumeros(ovTXT_CNPJCPFContratante.Text);
            //    dr["CPFCNPJ"] = ZeusUtil.SomenteNumeros(ovTXT_CNPJCPFContratante.Text);
            //}
            //Contratantes.Rows.Add(dr);
            //ovTXT_CNPJCPFContratante.Text = string.Empty;
            //CarregaContratantes(false);
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            // Remover Contratante
            //Contratantes.DefaultView.RowFilter = "[IDCONTRATANTEMDFE] = " + Convert.ToDecimal(ZeusUtil.GetValueFieldDataRowView((ovGRD_Contratantes.CurrentRow.DataBoundItem as DataRowView), "IDCONTRATANTEMDFE"));
            //Contratantes.DefaultView[0].Delete();
            //Contratantes.DefaultView.RowFilter = string.Empty;
            //ovTXT_CNPJCPFContratante.Text = string.Empty;
            //CarregaContratantes(false);
        }

        private void ovCMB_Veiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //VinculaVeiculoEProprietario();
        }

        private void ovCMB_Proprietario_SelectedIndexChanged(object sender, EventArgs e)
        {
            //VinculaVeiculoEProprietario();
        }

        private void VinculaVeiculoEProprietario()
        {
            //if ((ovCMB_Veiculo.SelectedItem as Veiculo) == null || Condutores == null)
            //    return;

            //foreach (DataRow dr in Condutores.Rows)
            //{
            //    if (dr.RowState == DataRowState.Deleted)
            //        continue;

            //    dr["IDVEICULO"] = (ovCMB_Veiculo.SelectedItem as Veiculo).IDVeiculo;

            //    dr["IDPROPRIETARIOVEICULOMDFE"] = DBNull.Value;
            //    if (ovCMB_Proprietario.SelectedItem != null)
            //        dr["IDPROPRIETARIOVEICULOMDFE"] = (ovCMB_Proprietario.SelectedItem as ProprietarioVeiculoMDFe).IDProprietarioVeiculoMDFe;

            //    CarregaCondutores(false);
            //}
        }

        private void ovCKB_ContratanteFisica_CheckedChanged(object sender, EventArgs e)
        {
            //AplicaMascaraContratante();
        }

        private void ovCKB_ContratanteJuridica_CheckedChanged(object sender, EventArgs e)
        {
            //AplicaMascaraContratante();
        }

        private void AplicaMascaraContratante()
        {
            //if (ovCKB_ContratanteFisica.Checked)
            //    ovTXT_CNPJCPFContratante.Mask = "###,###,###-##";
            //else
            //    ovTXT_CNPJCPFContratante.Mask = "##,###,###/####-##";
        }

        private void CarregaSeguro(bool Banco)
        {
            //if (Banco)
            //    Seguros = FuncoesSeguradoraMDFe.GetSegurosPorMDFe(MDFe.IDMDFe);

            //ovGRD_Seguradora.DataSource = Seguros;
            //AjustaGridSeguros();
        }

        private void AjustaGridSeguros()
        {
            //ovGRD_Seguradora.RowHeadersVisible = false;
            //int WidthGrid = ovGRD_Seguradora.Width;

            //foreach (DataGridViewColumn column in ovGRD_Seguradora.Columns)
            //{
            //    switch (column.Name)
            //    {
            //        case "numeroapolice":
            //            column.DisplayIndex = 1;
            //            column.FillWeight = Convert.ToInt32(WidthGrid * 0.40);
            //            column.HeaderText = "NÚMERO APOLICE";
            //            break;
            //        case "seguradora":
            //            column.DisplayIndex = 2;
            //            column.FillWeight = Convert.ToInt32(WidthGrid * 0.30);
            //            column.HeaderText = "SEGURADORA";
            //            break;
            //        case "responsavel":
            //            column.DisplayIndex = 3;
            //            column.FillWeight = Convert.ToInt32(WidthGrid * 0.30);
            //            column.HeaderText = "RESPONSÁVEL";
            //            break;
            //        default:
            //            column.DisplayIndex = 0;
            //            column.Visible = false;
            //            break;
            //    }
            //}
        }

        private void metroButton14_Click(object sender, EventArgs e)
        {
            //decimal IDSeguradoraMDFe = Sequence.GetNextID("SEGURADORAMDFE", "IDSEGURADORAMDFE");

            //DataRow drSeguro = Seguros.NewRow();
            //drSeguro["IDMDFE"] = MDFe.IDMDFe;
            //drSeguro["IDRESPONSAVELSEGUROCARGAMDFE"] = Sequence.GetNextID("RESPONSAVELSEGUROCARGAMDFE", "IDRESPONSAVELSEGUROCARGAMDFE");
            //drSeguro["IDSEGURADORAMDFE"] = IDSeguradoraMDFe;

            //Seguro FormSeguro = new Seguro(drSeguro, GetAverbacoes(IDSeguradoraMDFe));
            //FormSeguro.ShowDialog(this);
            //if (FormSeguro.Salvou)
            //{
            //    drSeguro["NUMEROAPOLICE"] = FormSeguro.drSeguradora["NUMEROAPOLICE"];
            //    drSeguro["RESPONSAVEL"] = FormSeguro.drSeguradora["RESPONSAVEL"];
            //    drSeguro["IDSEGURADORA"] = FormSeguro.drSeguradora["IDSEGURADORA"];
            //    drSeguro["SEGURADORA"] = FormSeguro.drSeguradora["SEGURADORA"];
            //    drSeguro["RESPONSAVELSEGURO"] = FormSeguro.drSeguradora["RESPONSAVELSEGURO"];
            //    drSeguro["CPF"] = FormSeguro.drSeguradora["CPF"];
            //    drSeguro["CNPJ"] = FormSeguro.drSeguradora["CNPJ"];

            //    Seguros.Rows.Add(drSeguro);
            //    Averbacoes[IDSeguradoraMDFe] = FormSeguro.Averbacoes;
            //}
            //CarregaSeguro(false);
        }

        private DataTable GetAverbacoes(decimal IDSeguradoraMDFe)
        {
            //    if (Averbacoes.ContainsKey(IDSeguradoraMDFe))
            //        return Averbacoes[IDSeguradoraMDFe];

            //    Averbacoes.Add(IDSeguradoraMDFe, FuncoesAverbacaoMDFe.GetAverbacoes(IDSeguradoraMDFe));
            //    return Averbacoes[IDSeguradoraMDFe];
            return null;
        }

        private void metroButton15_Click(object sender, EventArgs e)
        {
            //    // Editar Seguro
            //    decimal IDSeguradoraMDFe = Convert.ToDecimal(ZeusUtil.GetValueFieldDataRowView((ovGRD_Seguradora.CurrentRow.DataBoundItem as DataRowView), "IDSEGURADORAMDFE"));

            //    DataTable dtSeguros = Seguros.Copy();
            //    dtSeguros.DefaultView.RowFilter = "[IDSEGURADORAMDFE] = " + IDSeguradoraMDFe;

            //    Seguro FormSeguro = new Seguro(dtSeguros.DefaultView[0].Row, GetAverbacoes(IDSeguradoraMDFe));
            //    FormSeguro.ShowDialog(this);

            //    if (FormSeguro.Salvou)
            //    {
            //        Seguros.DefaultView.RowFilter = "[IDSEGURADORAMDFE] = " + IDSeguradoraMDFe; ;
            //        Seguros.DefaultView[0].BeginEdit();
            //        Seguros.DefaultView[0]["NUMEROAPOLICE"] = FormSeguro.drSeguradora["NUMEROAPOLICE"];
            //        Seguros.DefaultView[0]["RESPONSAVEL"] = FormSeguro.drSeguradora["RESPONSAVEL"];
            //        Seguros.DefaultView[0]["IDSEGURADORA"] = FormSeguro.drSeguradora["IDSEGURADORA"];
            //        Seguros.DefaultView[0]["SEGURADORA"] = FormSeguro.drSeguradora["SEGURADORA"];
            //        Seguros.DefaultView[0]["RESPONSAVELSEGURO"] = FormSeguro.drSeguradora["RESPONSAVELSEGURO"];
            //        Seguros.DefaultView[0]["CPF"] = FormSeguro.drSeguradora["CPF"];
            //        Seguros.DefaultView[0]["CNPJ"] = FormSeguro.drSeguradora["CNPJ"];
            //        Seguros.DefaultView[0].EndEdit();
            //        Seguros.DefaultView.RowFilter = string.Empty;

            //        Averbacoes[IDSeguradoraMDFe] = FormSeguro.Averbacoes;
            //    }
            //    CarregaSeguro(false);
        }

        private void metroButton13_Click(object sender, EventArgs e)
        {
            // Remover Seguro
            //decimal IDSeguradoraMDFe = Convert.ToDecimal(ZeusUtil.GetValueFieldDataRowView((ovGRD_Seguradora.CurrentRow.DataBoundItem as DataRowView), "IDSEGURADORAMDFE"));
            //Seguros.DefaultView.RowFilter = "[IDSEGURADORAMDFE] = " + IDSeguradoraMDFe;
            //Seguros.DefaultView[0].Delete();
            //Seguros.DefaultView.RowFilter = string.Empty;

            //foreach (DataRowView dr in GetAverbacoes(IDSeguradoraMDFe).DefaultView)
            //    dr.Delete();

            //CarregaSeguro(false);
        }

        private void ovGRD_Seguradora_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //switch (ovGRD_Seguradora.Columns[e.ColumnIndex].Name)
            //{
            //    case "numeroapolice":
            //        if (e.Value == null || string.IsNullOrEmpty(e.Value.ToString()) || e.Value == DBNull.Value)
            //            e.Value = "<Não Informado>";
            //        break;
            //}
        }
    }
}