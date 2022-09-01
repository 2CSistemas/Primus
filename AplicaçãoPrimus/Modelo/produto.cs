using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicaçãoPrimus.model
{
    public class produto
    {
        public int ID { get; set; }
        public String Codigo { get; set; }
        public String Barra { get; set; }
        public String Nome { get; set; }
        public String DescReduzida { get; set; }
        public int IDUnidade { get; set; }
        public int IDGrupoEstoque { get; set; }
        public int IDFornecedor { get; set; }
        public String BarraFornecedor { get; set; }
        public String DescLonga1 { get; set; }
        public String DescLonga2 { get; set; }
        public String DescLonga3 { get; set; }
        public Decimal PesoLiquido { get; set; }
        public Decimal PesoBruto { get; set; }
        public Decimal PrecoFornecedor { get; set; }
        public Decimal DescontoFornecedor { get; set; }
        public DateTime DtPrecoFornecedor { get; set; }
        public Decimal UltimoCusto { get; set; }
        public DateTime DtUltimoCusto { get; set; }
        public Decimal PrecoBase { get; set; }
        public DateTime DtPrecoBase { get; set; }
        public Decimal AliqISS { get; set; }
        public int IDPlanoConta_Est { get; set; }
        public int IDPlanoConta_FinAV { get; set; }
        public int IDPlanoConta_FinAP { get; set; }
        public int bServico { get; set; }
        public int IDPlanoNegocio { get; set; }
        public String ClassFiscal { get; set; }
        public Decimal CustoFrete { get; set; }
        public Decimal CustoIPI { get; set; }
        public Decimal CustoExtra { get; set; }
        public int Tributacao { get; set; }
        public int OrigemProd { get; set; }
        public int modBCICMS { get; set; }
        public Decimal AliqContrib { get; set; }
        public Decimal AliqContribNormal { get; set; }
        public Decimal ReducaoContrib { get; set; }
        public String TextoLeiContrib { get; set; }
        public Decimal AliqNContrib { get; set; }
        public Decimal AliqNContribNormal { get; set; }
        public Decimal ReducaoNContrib { get; set; }
        public String TextoLeiNContrib { get; set; }
        public int modBCST { get; set; }
        public Decimal LucroST { get; set; }
        public Decimal pRedBCST { get; set; }
        public Decimal AliqSubstTributaria { get; set; }
        public Decimal AliqSimplesSubst { get; set; }
        public int CST_Pis { get; set; }
        public Decimal pPIS_Q08 { get; set; }
        public int CST_Cofins { get; set; }
        public Decimal pCOFINS_S08 { get; set; }
        public int ENQ_IPI { get; set; }
        public int CST_IPI { get; set; }
        public Decimal AliquotaIPI { get; set; }
        public String NCM { get; set; }
        public int GENERO_NCM { get; set; }
        public int IDCFOP { get; set; }
        public String InfAdicionais { get; set; }
        public String AliqCupomContrib { get; set; }
        public String AliqCupomNContrib { get; set; }
        public int CSOSN { get; set; }
        public String CaminhoImagem { get; set; }
        public Byte Imagem { get; set; }
        public int IDGrupo1 { get; set; }
        public int IDGrupo2 { get; set; }
        public int IDGrupo3 { get; set; }
        public DateTime IncData { get; set; }
        public String IncUsuario { get; set; }
        public DateTime AltData { get; set; }
        public String AltUsuario { get; set; }
        public int LEGADOCODIGO { get; set; }
        public int IDIntegracao { get; set; }
        public Boolean CodigoBarrasRegistrado { get; set; }
        public Boolean UtilizaIdentificadorEstoque { get; set; }
        public Boolean Inativo { get; set; }
        public int IDCFOPForaDoEstado { get; set; }
        public int IDFornecedor2 { get; set; }
        public int IDFornecedor3 { get; set; }
        public int IDFornecedor4 { get; set; }
        public int IDFornecedor5 { get; set; }
        public DateTime DTFornec1 { get; set; }
        public DateTime DTFornec2 { get; set; }
        public DateTime DTFornec3 { get; set; }
        public DateTime DTFornec4 { get; set; }
        public DateTime DTFornec5 { get; set; }
        public String BarraFornecedor2 { get; set; }
        public String BarraFornecedor3 { get; set; }
        public String BarraFornecedor4 { get; set; }
        public String BarraFornecedor5 { get; set; }
        public Decimal UltimoCusto1 { get; set; }
        public Decimal UltimoCusto2 { get; set; }
        public Decimal UltimoCusto3 { get; set; }
        public Decimal UltimoCusto4 { get; set; }
        public Decimal UltimoCusto5 { get; set; }
        public String Observacao { get; set; }
        public Decimal Largura { get; set; }
        public Decimal Altura { get; set; }
        public Decimal Comprimento { get; set; }
        public Decimal Peso { get; set; }
        public Boolean BEnviadoSHL { get; set; }
        public int IDUnidadeEntrada { get; set; }
        public String Localizacao { get; set; }
        public String DescricaoAnterior { get; set; }
        public Boolean UtilizarIMEI { get; set; }
        public int EscRelevante { get; set; }
        public String RAZAO_Fab { get; set; }
        public String CNPJ_Fab { get; set; }
        public String CBenef { get; set; }
        public int ID_NCM { get; set; }
        public DateTime DtCadastroProduto { get; set; }
        public int IntegrarEcommerce { get; set; }
        public int IdEcommerce { get; set; }
        public String SenhaEcommerce { get; set; }
        public String cProdANP { get; set; }
        public String descANP { get; set; }
        public String UFCons { get; set; }
        public DateTime DataPromocionalInicial { get; set; }
        public DateTime DataPromocionalFinal { get; set; }


    }
}
