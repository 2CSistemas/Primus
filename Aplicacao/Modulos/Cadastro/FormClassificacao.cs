using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.IO;
using System.Xml.Linq;
using cwkGestao.Integracao.SHL;
using System.Collections.Generic;
using System.Linq;
using Aplicacao.Util;

namespace Aplicacao
{
    public partial class FormClassificacao : Aplicacao.IntermediariasTela.FormManutClassificacaoIntermediaria
    {
        public FormClassificacao()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
        }

        protected override void SetarMascaras()
        {
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            SHLUtil.HabilitarCamposSHL(chbbShlMailing);
        }

        protected override void AcoesAntesSalvar()
        {
            Selecionado.bShlMailing = chbbShlMailing.Checked;
            string caminho = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            caminho = Path.Combine(caminho, "ConfiguracaoCwork.xml");
            if (Selecionado.bShlMailing && Convert.ToInt32(XDocument.Load(caminho).Element("Cwork").Element("UtilizaSHL").Value) == 1)
            {
                try
                {
                    SHLConfiguracao conf = SHLConfiguracaoController.Instancia.GetAll().FirstOrDefault();
                    if (conf != null)
                    {
                        if (String.IsNullOrEmpty(conf.ChaveSHL))
                        {
                            MessageBox.Show("A configuração de utilização do sistema SHL está habilitada porém não há chave ou interface para comunicação. Verifique.", 
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Selecionado.bShlMailing = false;
                            chbbShlMailing.Checked = false;
                            return;
                        }
                        string retorno = cwkGestao.Integracao.SHL.Util.CadastraClassificacao(conf.ChaveSHL, conf.InterfaceSHL, Selecionado.Descricao);
                        try
                        {
                            int codigoshl = Convert.ToInt32(retorno);
                            Selecionado.CodShl = codigoshl;
                            conf.Classificacao = Selecionado;
                        }
                        catch (Exception a)
                        {
                            Selecionado.bShlMailing = false;
                            chbbShlMailing.Checked = false;
                            Selecionado.CodShl = 0;
                            throw new Exception(retorno, a);
                        }
                    }
                    else
                    {
                        MessageBox.Show("SHL não configurado nesta instância", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception b)
                {
                    MessageBox.Show("Erro ao comunicar com o Webservice SHL: \r\n" + 
                        b.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            base.AcoesAntesSalvar();
        }

        protected override void AcoesDepoisSalvar()
        {
            if (Selecionado.bShlMailing && Selecionado.CodShl > 0)
            {
                try
                {
                    IList<Classificacao> classificacoes = ClassificacaoController.Instancia.GetAll();
                    foreach (Classificacao item in classificacoes)
                    {
                        if (item.ID != Selecionado.ID)
                        {
                            item.bShlMailing = false;
                        }
                    }
                    foreach (Classificacao item in classificacoes)
                    {
                        if (item.ID != Selecionado.ID)
                        {
                            ClassificacaoController.Instancia.Salvar(item, Acao.Alterar);
                        }
                    }
                    SHLConfiguracao conf = SHLConfiguracaoController.Instancia.GetAll().FirstOrDefault();
                    conf.Classificacao = Selecionado;
                    SHLConfiguracaoController.Instancia.Salvar(conf, Acao.Alterar);
                }
                catch (Exception c)
                {
                    
                    throw c;
                }

            }
            base.AcoesDepoisSalvar();
        }

        private void FormClassificacao_Shown(object sender, EventArgs e)
        {
            chbbShlMailing.EditValue = Selecionado.bShlMailing;
        }
    }
}
