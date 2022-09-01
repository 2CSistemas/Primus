using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using Aplicacao.Modulos.Producao;
using cwkGestao.Negocio.Utils;

namespace Aplicacao
{
    public partial class FormFichaTecnicaPCP : Aplicacao.IntermediariasTela.FormManutFichaTecnicaPCPIntermediaria
    {
        private FichaTecnicaPCPController ft = FichaTecnicaPCPController.Instancia;
        private Produto p;
        private IList<FichaTecnicaPCP> ListaExclusao = new List<FichaTecnicaPCP>();
        private IList<FichaTecnicaPCP> ListaNova;
        private bool result;

        public FichaTecnicaPCP fichaTecnica { get; set; }

		protected override void InitializeChildComponents()
		{
			InitializeComponent();
		}

        public FormFichaTecnicaPCP(Produto prod)
        {
            p = prod;
            result = PreparaFichasTecnicas(p);
            if (result)
            {
                PreencheFichaTecnica();
                this.Text = "Fichas Técnicas - " + p.Nome;
            }
            
        }

        public DialogResult ShowForm()
        {
            if (result)
            {
                return this.ShowDialog();
            }
            else
            {
                return DialogResult.None;
            }
        }

        private bool PreparaFichasTecnicas(Produto p)
        {
            ListaNova = new List<FichaTecnicaPCP>();
            p.FichaTecnicaPCP = FichaTecnicaPCPController.Instancia.GetAllPorIDProduto(p.ID);
            if (p.FichaTecnicaPCP == null || p.FichaTecnicaPCP.Count == 0)
            {
                String nome;
                Aplicacao.InputBox ib = new InputBox();
                ib.Name = "Nova Ficha Técnica - " + p.Nome;
                if (ib.Show("Versão 01", "Forneça um nome de versão para este produto:", out nome))
                {
                    ListaNova.Add(new FichaTecnicaPCP(p, nome));
                }
                else
                {
                    return false;
                }
            }
            else
            {
                foreach (FichaTecnicaPCP f in p.FichaTecnicaPCP)
                {
                    ListaNova.Add(f);
                }
            }
            return true;
        }

        public void PreencheFichaTecnica()
        {
            foreach (FichaTecnicaPCP ficha in ListaNova)
            {
                tcVersao.TabPages.Add(NovaAba(ficha));
                tcVersao.TabPages.Move(tcVersao.TabPages.Count, tpAdicionar);
            }
            tcVersao.SelectedTabPageIndex = 0;
        }

        public void AdicionaFichaTecnica()
        {
            String nome = CriaNomeFichaTecnica(null);
            if ((nome == null) || (nome == ""))
            {
                tcVersao.SelectedTabPageIndex = tcVersao.SelectedTabPageIndex - 1;
                return;
            }
            FichaTecnicaPCP f = new FichaTecnicaPCP(p, nome);
            tcVersao.TabPages.Add(NovaAba(f));
            tcVersao.TabPages.Move(tcVersao.TabPages.Count, tpAdicionar);
            tcVersao.Refresh();
            tcVersao.Enabled = true;
            ListaNova.Add(f);
            tcVersao.SelectedTabPageIndex = tcVersao.TabPages.Count - 2;
        }

        public DevExpress.XtraTab.XtraTabPage NovaAba(FichaTecnicaPCP ficha)
        {
            DevExpress.XtraTab.XtraTabPage aba = new DevExpress.XtraTab.XtraTabPage();
            TabPCP componente = new TabPCP(ficha);
            componente.Name = "tabpcp" + ficha.ID;
            componente.Size = new System.Drawing.Size(869, 624);
            componente.Location = new System.Drawing.Point(3, 3);
            componente.BotaoEAN13Clicado += new EventHandler(componente_BotaoEAN13Clicado);
            componente.BotaoCarregaFichaClicado += new EventHandler(componente_BotaoCarregaFichaClicado);
            componente.PreencheTab();
            componente.Parent = aba;
            componente.Dock = DockStyle.Fill;
            aba.Text = ficha.Nome;
            aba.Name = "TabFichaTecnica" + componente.Ficha.ID ;
            aba.Size = new System.Drawing.Size(874, 639);
            aba.Controls.Add(componente);

            return aba;
        }

        public void componente_BotaoEAN13Clicado(object sender, EventArgs e)
        {
            List<string> CodBarras = new List<string>();
            string cod = "";
            for (int i = 0; i < tcVersao.TabPages.Count - 1; i++)
            {
                cod = ((TabPCP)tcVersao.TabPages[i].Controls[0]).txtCodBarras.Text;
                if (cod != "")
                {
                    string x = cod.Remove(cod.Length - 1);
                    CodBarras.Add(x);
                }
                
            }
            cod = ProdutoController.Instancia.GetProximoCodigoBarrasEAN13(CodBarras);
            ((TabPCP)tcVersao.SelectedTabPage.Controls[0]).txtCodBarras.EditValue = cod;
        }

        public void componente_BotaoCarregaFichaClicado(object sender, EventArgs e)
        {
            FichaTecnicaPCP ft = ((TabPCP)tcVersao.SelectedTabPage.Controls[0]).Ficha;
            ListaNova[tcVersao.SelectedTabPageIndex] = ft;
            tcVersao.SelectedTabPage.Text = ft.Nome;
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            //p.FichaTecnicaPCP = ListaOriginal;
            this.Dispose();
        }

        private void tcVersao_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if ((tcVersao.SelectedTabPageIndex == tcVersao.TabPages.IndexOf(tpAdicionar)) && tcVersao.TabPages.Count != 1)
            {
                AdicionaFichaTecnica();
            }
        }

        protected override void OK()
        {
            if(ListaExclusao.Count > 0)
            {
                ExcluirFichas();
            }
            if (ListaNova.Count != 0)
            {
                DevExpress.XtraTab.XtraTabPageCollection tabs = tcVersao.TabPages;
                for (int i = 0; i < tabs.Count; i++)
                {
                    if (!(tabs[i] == tpAdicionar))
                    {
                        TabPCP c = (TabPCP)tabs[i].Controls[0];

                        if (!c.CamposValidos())
                        {
                            tcVersao.SelectedTabPageIndex = i;
                            new Aplicacao.Base.FormErro("Existem erros na Ficha Tecnica " + tabs[i].Text
                                , "Favor verificar os campos obrigatórios").ShowDialog();
                            return;
                        }

                        c.PreencheFicha(p);
                        if (i < ListaNova.Count)
                        {
                            ListaNova.RemoveAt(i);
                        }
                        ListaNova.Insert(i, c.Ficha);
                    }
                }
            }

            p.FichaTecnicaPCP = ListaNova;
            try
            {
                FichaTecnicaPCPController.Instancia.SalvarFichas(p);
            }
            catch (Exception c)
            {

                new Aplicacao.Base.FormErro(c).ShowDialog();
                return;
            }
            
            this.Dispose();
        }

        private void ExcluirFichas()
        {
            foreach (FichaTecnicaPCP item in ListaExclusao)
            {
                FichaTecnicaPCPController.Instancia.Salvar(item, Acao.Excluir);
            }
        }

        private void FormFichaTecnicaPCP_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < tcVersao.TabPages.Count; i++)
            {
                if (tcVersao.TabPages[i] != tpAdicionar)
                {
                    ((TabPCP)tcVersao.TabPages[i].Controls[0]).PreencheTab();
                }
            }
        }

        private void tcVersao_DoubleClick(object sender, EventArgs e)
        {
            if (tcVersao.SelectedTabPage != tpAdicionar)
            {
                String NovoNome = CriaNomeFichaTecnica(tcVersao.SelectedTabPage.Text);
                tcVersao.SelectedTabPage.Text = NovoNome;
                ((TabPCP)tcVersao.SelectedTabPage.Controls[0]).Ficha.Nome = NovoNome;

            }
        }

        private String CriaNomeFichaTecnica(String NomeAtual)
        {
            Aplicacao.InputBox ib = new InputBox();
            String Caption = NomeAtual == null ? "Nova Ficha Técnica - " + p.Nome : 
                "Alterar Nome Atual - " + p.Nome;
            //ib.Name = Caption;
            //ib.Text = "Forneça um nome de versão para este produto:";
            String nome;
            if (ib.Show(NomeAtual == null ? "Versão " + (tcVersao.TabPages.Count < 10 ? 
                "0" + tcVersao.TabPages.Count.ToString() :
                tcVersao.TabPages.Count.ToString()) : NomeAtual,
                Caption, out nome))
            {
                return nome;
            }
            else
            {
                return NomeAtual;
            }
        }

        private void sbExcluiFichaTecnica_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja excluir esta Ficha Técnica?"+"\r\n"+
                tcVersao.SelectedTabPage.Text, "Cwork Gestão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int idx = tcVersao.SelectedTabPageIndex;
                IList<FichaTecnicaPCPItem> vinculos = FichaTecnicaPCPItemController.Instancia.GetFichaTecnicaPCPItensVinculadosComFichaTecnica(ListaNova[idx].ID);
                if (vinculos.Count == 0)
                {
                    ListaExclusao.Add(ListaNova[idx]);
                    ListaNova.RemoveAt(idx);
                    tcVersao.TabPages.RemoveAt(idx);
                    tcVersao.SelectedTabPageIndex = idx - 1;
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (FichaTecnicaPCPItem item in vinculos)
                    {
                        string nomeProduto = (item.Produto.Nome == "" || item.Produto.Nome == null) ? "(Sem Nome)" : item.Produto.Nome;
                        nomeProduto = nomeProduto + " - " + item.Produto.Codigo;
                        sb.AppendLine(nomeProduto + ": " + item.FichaTecnicaPCP.Nome);
                    }
                    string msg = "Esta Ficha Técnica não pode ser excluída pois está vinculada com as Fichas Técnicas informadas abaixo: \r\n\r\n" + sb.ToString();
                    MessageBox.Show(msg, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            }

            if (tcVersao.TabPages.Count == 1)
            {
                OK();
            }
        }
    }
}
