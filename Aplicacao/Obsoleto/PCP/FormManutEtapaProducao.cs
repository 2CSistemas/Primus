using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Aplicacao.PCP
{
    public partial class FormManutEtapaProducao : Aplicacao.Base.ManutBase
    {
        private List<Modelo.Objeto.pxyEtapaProducao> etapas;
        private Modelo.Objeto.pxyEtapaProducao objEtapa;

        public FormManutEtapaProducao(Modelo.DataClassesDataContext pDb, List<Modelo.Objeto.pxyEtapaProducao> pEtapas)
        {
            InitializeComponent();
            this.lkServico.OnIDChanged += new System.EventHandler(this.lkServico_IDChanged);
            this.Name = "FormManutEtapaProducao";
            etapas = pEtapas;
            db = pDb;
            lkServico.ContextoLinq = db;
        }

        public override void CarregaObjeto()
        {
            switch (cwAcao)
            {
                case 1:
                    objEtapa = new Modelo.Objeto.pxyEtapaProducao();
                    if (etapas.Count > 0)
                        objEtapa.Sequencia = (short)(etapas.Max(e => e.Sequencia) + 1);
                    else
                        objEtapa.Sequencia = 1;
                    break;
                default:
                    objEtapa = etapas.Where(i => i.Sequencia == cwID && i.Acao != 3).First();
                    lkServico.ID = objEtapa.IDServico;
                    lkServico.Localizar(lkServico.ID);
                    txtTitulo.EditValue = objEtapa.Titulo;
                    txtObservacao.EditValue = objEtapa.Observacao;
                    break;
            }
            txtSequencia.Value = objEtapa.Sequencia;
        }

        public override Dictionary<string, string> Salvar()
        {
            Dictionary<string, string> ret = new Dictionary<string, string>();

            if (txtSequencia.Value <= 0)
                ret.Add("txtSequencia", "A sequência deve ser maior do que zero(0).");
            else if (etapas.Where(e => e.Sequencia == txtSequencia.Value && e.ID != objEtapa.ID).Count() > 0)
                ret.Add("txtSequencia", "Já existe uma etapa cadastrada com a sequência " + txtSequencia.Text + ".");
            if (lkServico.ID <= 0)
                ret.Add("lkServico", "Selecione o serviço.");
            if (String.IsNullOrEmpty(txtTitulo.Text))
                ret.Add("txtTitulo", "Digite o título.");

            if (ret.Count == 0)
            {
                objEtapa.IDServico = lkServico.ID;
                objEtapa.Sequencia = Convert.ToInt16(txtSequencia.Value);
                objEtapa.Titulo = txtTitulo.Text;
                objEtapa.Observacao = txtObservacao.Text;
                if (objEtapa.ID == 0 && cwAcao == 2)
                    objEtapa.Acao = 1;
                else
                    objEtapa.Acao = cwAcao;

                if (cwAcao == 1)
                {
                    etapas.Add(objEtapa);
                }
            }

            return ret;
        }

        private void lkbServico_Click(object sender, EventArgs e)
        {
            cwkGestao.Modelo.Servico servicoSelecionado = null;
            if (lkServico.ID > 0)
                servicoSelecionado = cwkGestao.Negocio.ServicoController.Instancia.LoadObjectById(lkServico.ID);

            GridGenerica<cwkGestao.Modelo.Servico> grid = new GridGenerica<cwkGestao.Modelo.Servico>(cwkGestao.Negocio.ServicoController.Instancia.GetAll(), new FormServico(), servicoSelecionado, false);
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            {
                grid.Selecionando = true;
                grid.ShowDialog();

                if (grid.Selecionado != null)
                {
                    lkServico.Localizar(grid.Selecionado.ID);
                }
            }
            lkServico.Focus();
        }

        private void lkServico_IDChanged(object sender, EventArgs e)
        {
        }
    }
}
