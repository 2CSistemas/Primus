using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Negocio.Tributacao;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Integracao;
using cwkGestao.Modelo;

namespace Aplicacao.Interfaces.Impl
{
    public class NotaItemTributadaMediator : ITributavel
    {
        BConfiguraçãoMagento configuracaoMagento = new BConfiguraçãoMagento();
        private Modelo.NotaItem notaItem;
        private Modelo.Nota nota;
        cwkGestao.Modelo.TabelaFaixaFatSimples tabelaFaixa;

        public NotaItemTributadaMediator(Modelo.NotaItem _notaItem, Modelo.Nota _nota)
        {
            notaItem = _notaItem;
            nota = _nota;
        }

        public decimal BaseCalculoGeral
        {
            get
            {
                if (configuracaoMagento.GetConfiguracaoMagento())
                    return notaItem.Total + (decimal)notaItem.RateioFrete;
                else
                    return notaItem.Total;
            }
            set
            {

            }
        }

        public string PisCST
        {
            get { return notaItem.CST_Pis; }
        }

        public decimal PisBaseCalculo
        {
            get
            {
                return notaItem.vBC_Q07.Value;
            }
            set
            {
                notaItem.vBC_Q07 = value;
            }
        }

        public decimal PisAliquota
        {
            get
            {
                return notaItem.pPIS_Q08.Value;
            }
            set
            {
                notaItem.pPIS_Q08 = value;
            }
        }

        public decimal PisValor
        {
            get
            {
                return notaItem.vPIS_Q09.Value;
            }
            set
            {
                notaItem.vPIS_Q09 = value;
            }
        }

        public string IpiCST
        {
            get { return notaItem.CST_Ipi; }
        }

        public decimal IpiBaseCalculo
        {
            get
            {
                return notaItem.vBC_O10.Value;
            }
            set
            {
                notaItem.vBC_O10 = value;
            }
        }

        public decimal IpiAliquota
        {
            get
            {
                return notaItem.pIPI_O13.Value;
            }
            set
            {
                notaItem.pIPI_O13 = value;
            }
        }

        public decimal IpiValor
        {
            get
            {
                return notaItem.vIPI_O14.Value;
            }
            set
            {
                notaItem.vIPI_O14 = value;
            }
        }

        public string CofinsCST
        {
            get
            {
                return notaItem.CST_Cofins;
            }
            set
            {
                notaItem.CST_Cofins = value;
            }
        }

        public decimal CofinsBaseCalculo
        {
            get
            {
                return notaItem.vBC_S07.Value;
            }
            set
            {
                notaItem.vBC_S07 = value;
            }
        }

        public decimal CofinsAliquota
        {
            get
            {
                return notaItem.pCOFINS_S08.Value;
            }
            set
            {
                notaItem.pCOFINS_S08 = value;
            }
        }

        public decimal CofinsValor
        {
            get
            {
                return notaItem.vCOFINS_S11.Value;
            }
            set
            {
                notaItem.vCOFINS_S11 = value;
            }
        }

        public string IcmsCST
        {
            get
            {
                return notaItem.TAG_CST;
            }
            set
            {
                notaItem.TAG_CST = value;
            }
        }

        public string IcmsTextoLei
        {
            get
            {
                return notaItem.TextoLei;
            }
            set
            {
                notaItem.TextoLei = value;
            }
        }

        public decimal IcmsBaseCalculo
        {
            get
            {
                return notaItem.BaseICMS.Value;
            }
            set
            {
                notaItem.BaseICMS = value;
            }
        }

        public decimal IcmsReducaoBaseCalculo
        {
            get
            {
                return notaItem.pRedBC_N14.Value;
            }
            set
            {
                notaItem.pRedBC_N14 = value;
            }
        }

        public decimal IcmsAliquota
        {
            get
            {
                return notaItem.AliqICMS.Value;
            }
            set
            {
                notaItem.AliqICMS = value;
            }
        }

        public decimal IcmsAliquotaNormal
        {
            get
            {
                return notaItem.AliqICMSNormal.Value;
            }
            set
            {
                notaItem.AliqICMSNormal = value;
            }
        }

        public decimal IcmsValorDiferencaComReducao
        {
            get
            {
                return notaItem.ValorICMSReducaoDif.Value;
            }
            set
            {
                notaItem.ValorICMSReducaoDif = value;
            }
        }

        public decimal IcmsValor
        {
            get
            {
                return notaItem.ValorICMS.Value;
            }
            set
            {
                notaItem.ValorICMS = value;
            }
        }

        public decimal IcmsValorIsento
        {
            get
            {
                return notaItem.ValorIsentoICMS.Value;
            }
            set
            {
                notaItem.ValorIsentoICMS = value;
            }
        }

        public decimal IcmsValorRetido
        {
            get
            {
                return notaItem.ValorRetidoICMS.Value;
            }
            set
            {
                notaItem.ValorRetidoICMS = value;
            }
        }

        public decimal IcmsValorOutros
        {
            get
            {
                return notaItem.ValorOutroICMS.Value;
            }
            set
            {
                notaItem.ValorOutroICMS = value;
            }
        }

        public decimal IcmsSTBaseCalculo
        {
            get
            {
                return notaItem.BaseICMSSubst.Value;
            }
            set
            {
                notaItem.BaseICMSSubst = value;
            }
        }

        public decimal IcmsSTReducaoBaseCalculo
        {
            get
            {
                return notaItem.pRedBCST_N20.Value;
            }
            set
            {
                notaItem.pRedBCST_N20 = value;
            }
        }

        public decimal IcmsSTAliquota
        {
            get
            {
                return notaItem.pICMSST_N22.Value;
            }
            set
            {
                notaItem.pICMSST_N22 = value;
            }
        }

        public decimal IcmsSTMargemValorAgregado
        {
            get
            {
                return notaItem.pMVAST_N19.Value;
            }
            set
            {
                notaItem.pMVAST_N19 = value;
            }
        }

        public decimal CreditoReducaoBasePercentual
        {
            get
            {
                try
                {
                    if (tabelaFaixa == null)
                    {
                        tabelaFaixa = TabelaFaixaFatSimplesController.Instancia.LoadObjectById(nota.Filial.IdTabelaFaixaFatSimples.Value);
                    }
                    return tabelaFaixa.PercReducaoBC;
                }
                catch
                {
                    return 200;
                }
            }
            set
            { }
        }

        public decimal CreditoPercentualReduzido
        {
            get
            {
                return notaItem.pCredSN_N29.Value;
            }
            set
            {
                notaItem.pCredSN_N29 = value;
            }
        }

        public decimal CreditoValor
        {
            get
            {
                return notaItem.vCredICMSSN_N30.Value;
            }
            set
            {
                notaItem.vCredICMSSN_N30 = value;
            }
        }

        public decimal CreditoPercentual
        {
            get
            {
                try
                {
                    if (tabelaFaixa == null)
                    {
                        tabelaFaixa = TabelaFaixaFatSimplesController.Instancia.LoadObjectById(nota.Filial.IdTabelaFaixaFatSimples.Value);
                    }
                    return tabelaFaixa.ICMS;
                }
                catch
                {
                    return 66.6m;
                }
            }
            set
            { }
        }

        public decimal EmpresaAliquota
        {
            get
            {
                return nota.Filial.AliqSimplesSubst.Value;
            }
            set
            {
                nota.Filial.AliqSimplesSubst = value;
            }
        }

        public cwkGestao.Negocio.Enums.EmpresaST EmpresaST
        {
            get
            {
                switch (nota.Filial.SimplesNacional)
                {
                    case 0: return cwkGestao.Negocio.Enums.EmpresaST.Simples;
                    case 1: return cwkGestao.Negocio.Enums.EmpresaST.SimplesComExcesso;
                    case 2: return cwkGestao.Negocio.Enums.EmpresaST.Normal;
                    default: return cwkGestao.Negocio.Enums.EmpresaST.Simples;
                }
            }
        }

        public bool EhClienteOrgaoPublico
        {
            get { return Convert.ToBoolean(nota.Pessoa.bOrgaoPublico.Value); }
        }

        public bool EhCfopTributavelEmIcms
        {
            get
            {
                try { return notaItem.TabelaCFOP.bCalcICMS.Value; }
                catch { throw new Exception("CFOP não atribuído."); }
            }
        }

        public bool EhSubstitutoTributario
        {
            get
            {
                return nota.Filial.TipoST == Modelo.TipoST.Substituto;
            }
            set
            { }
        }

        public bool EhICMSProprio
        {
            get
            {
                if (EmpresaST != cwkGestao.Negocio.Enums.EmpresaST.Normal)
                {
                    return ConversorCsts.CSOSNsGeramST.Contains(notaItem.TAG_CST);
                }
                return false;
            }
        }

        public decimal ReducaoImposto
        {
            get
            {
                return notaItem.ReducaoImposto;
            }
            set
            {
                notaItem.ReducaoImposto = value;
            }
        }

        public decimal FCPAliquota
        {
            get
            {
                return notaItem.pFCP_N17b;
            }
            set
            {
                notaItem.pFCP_N17b = value;
            }
        }
        public decimal FCPBaseClaculo
        {
            get
            {
                return notaItem.vBCFCP_N17a;
            }
            set
            {
                notaItem.vBCFCP_N17a = value;
            }
        }
        public decimal FCPValor
        {
            get
            {
                return notaItem.vFCP_N17c;
            }
            set
            {
                notaItem.vFCP_N17c = value;
            }
        }

        public decimal FCPAliquotaST
        {
            get => notaItem.pFCPST_N23b;
            set => notaItem.pFCPST_N23b = value;
        }

        public decimal FCPBaseClaculoST
        {
            get => notaItem.vBCFCPST_N23a;
            set => notaItem.vBCFCPST_N23a = value;
        }

        public decimal FCPValorST
        {
            get => notaItem.vFCPST_N23d;
            set => notaItem.vFCPST_N23d = value;
        }

        public decimal AliquotaDiferimento
        {
            get =>notaItem.AliquotaDiferimento;
            set => notaItem.AliquotaDiferimento = value;
        }

        public decimal ValorIcmsDiferimento
        {
            get => notaItem.ValorIcmsDiferimento;
            set => notaItem.ValorIcmsDiferimento = value;
        }

        public decimal ValorIcmsOp
        {
            get => notaItem.ValorIcmsOp;
            set => notaItem.ValorIcmsOp = value;
        }

        public decimal ValorICMSDesoneracao 
        { 
            get => notaItem.ValorICMSDesoneracao; 
            set => notaItem.ValorICMSDesoneracao = value; 
        }

        public decimal PrecoProduto
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public Filial Filial
        {
            get
            {
                return FilialController.Instancia.LoadObjectById(nota.Filial.ID);
            }
        }

        public Pessoa Pessoa
        {
            get
            {
                return PessoaController.Instancia.LoadObjectById(nota.Pessoa.ID);
            }
        }
    }
}
