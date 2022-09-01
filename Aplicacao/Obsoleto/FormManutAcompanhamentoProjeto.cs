using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Modelo;
using System.Linq;
using NHibernate.Linq;

namespace Aplicacao
{
    public partial class FormManutAcompanhamentoProjeto : Aplicacao.Base.ManutBase
    {
        Modelo.ProjetoHistorico ObjProjHistorico = new Modelo.ProjetoHistorico();
        private int acao, ID, ProjetoID;
        private string ProjetoAprovado;
        public bool Opcao { get; set; }
        private List<AgrupamentoGridElement> agrupamentos = new List<AgrupamentoGridElement>();

        public FormManutAcompanhamentoProjeto(int pAcao, int pID, int pProjetoID, string pProjetoAprovado)
        {
            
            InitializeComponent();
            this.Text = "Acompanhamento do Projeto";
            acao = pAcao;
            ID = pID;
            ProjetoID = pProjetoID;
            ProjetoAprovado = pProjetoAprovado;            
            CarregaObjeto();
            
        }

        public void SetDb(DataClassesDataContext dxcde3fgvcb)
        {
            db = dxcde3fgvcb;
        }

        private void InicializaGridAgrupamento()
        {
            
            //Projeto projAprovado = (Projeto) db.Projetos.First(prok => prok.ID == ProjetoID);
            var x = db.Projeto_ProdutoServicos.Where(abc => abc.IDProjeto == ProjetoID && abc.Servico != null);
            foreach(Projeto_ProdutoServico servico in x) {
                AgrupamentoGridElement age = new AgrupamentoGridElement();
                if (agrupamentos.Where(ag => ag.Agrupamento == servico.Agrupamento).Count() > 0)
                    age = agrupamentos.First(ag => ag.Agrupamento == servico.Agrupamento);
                age.Agrupamento = servico.Agrupamento;
                age.ServicosLista.Add(servico);
                if(!agrupamentos.Contains(age)) agrupamentos.Add(age);
            }
            gcAgrupamentos.DataSource = agrupamentos;
            gcAgrupamentos.RefreshDataSource();
            gvAgrupamentos.RefreshData();
        }

        public override void CarregaObjeto()
        {
            switch (acao)
            {
                case 1://incluir
                    Opcao = false;
                    txtData.DateTime = DateTime.Now;
                    db.ProjetoHistoricos.InsertOnSubmit(ObjProjHistorico);
                    break;

                case 2://alterar
                    PreencheValores();
                    break;

                case 3://excluir
                    PreencheValores();
                    db.ProjetoHistoricos.DeleteOnSubmit(ObjProjHistorico);
                    MontaTela();
                    sbGravar.Text = "&OK";
                    break;

                case 4://consultar
                    PreencheValores();
                    MontaTela();
                    sbGravar.Enabled = false;
                    break;
            }
        }

        private void MontaTela()
        {
            txtDescricao.Enabled = false;
            txtData.Enabled = false;
        }

        private void PreencheValores()
        {
            ObjProjHistorico = (Modelo.ProjetoHistorico)ObjProjHistorico.getObjeto(db, ID);

            txtDescricao.Text = ObjProjHistorico.Descricao;
            txtData.DateTime = ObjProjHistorico.Data;
        }

        public override Dictionary<string, string> Salvar()
        {
            Opcao = true;
            ObjProjHistorico.Descricao = ProjetoAprovado + txtDescricao.Text;
            ObjProjHistorico.Data = txtData.DateTime;
            ObjProjHistorico.IDProjeto = ProjetoID;
            if (acao == 1){
                ObjProjHistorico.IncData = DateTime.Now.Date;
                ObjProjHistorico.IncHora = Convert.ToDateTime(DateTime.Now.ToString().Substring(10));
                ObjProjHistorico.IncUsuario = Modelo.cwkGlobal.objUsuarioLogado.Login;
            }
            else if (acao == 2) 
            {
                ObjProjHistorico.AltData = DateTime.Now.Date;
                ObjProjHistorico.AltHora = DateTime.Now;
                ObjProjHistorico.AltUsuario = Modelo.cwkGlobal.objUsuarioLogado.Login;                
            }
            foreach (var elemento in agrupamentos)
            {

                var ordemProducao = db.OrdemProducaos.Where(
                    op =>
                    op.IdProjeto == ObjProjHistorico.IDProjeto && op.Projeto_ProdutoServicos.Count > 0 && 
                    op.Projeto_ProdutoServicos.FirstOrDefault().Agrupamento == elemento.Agrupamento).FirstOrDefault();
                if(ordemProducao != null)
                    ordemProducao.Descricao = elemento.Descricao;
            }
            Projeto proj = db.Projetos.Where(pj => pj.ID == ProjetoID).First();

            foreach (var ordemProducao in proj.OrdemProducaos)
            {
                var serv = ordemProducao.Projeto_ProdutoServicos.FirstOrDefault();
                if(serv != null)
                    ordemProducao.Descricao =
                        agrupamentos.Where(ag => ag.Agrupamento == serv.Agrupamento).First().Descricao;
            }

           

            return BLL.ProjetoHistorico.Salvar(db, ObjProjHistorico);
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            InicializaGridAgrupamento();
        }
    }

    public class AgrupamentoGridElement
    {
        public AgrupamentoGridElement()
        {
            ServicosLista = new List<Projeto_ProdutoServico>();
        }

        public int Agrupamento { get; set; }
        public String Descricao { get; set; }
        public String Servicos { 
            get
            {
                String ret = "";
                ServicosLista.Where(bla => bla.Servico != null).ForEach(bla => ret += bla.Servico.nome + ";");
                return ret;
            }
        }

        public List<Projeto_ProdutoServico> ServicosLista { get; set; }

        
    }
}
