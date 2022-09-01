using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using System.Linq;

namespace Aplicacao
{
    public partial class FormManutServicoOS : Aplicacao.Base.ManutBase
    {
        private cwkGestao.Modelo.ServicoOS objServicoOS;
        private cwkGestao.Modelo.OrdemServico objOrdemServico;
        private ServicoOSController servicoOSController = ServicoOSController.Instancia;

        public FormManutServicoOS(cwkGestao.Modelo.OrdemServico pOrdemServico)
        {
            InitializeComponent();
            objOrdemServico = pOrdemServico;
            CarregaComboResponsavel();
            CarregaComboServico();
        }

        private void CarregaComboServico()
        {
            using (Modelo.DataClassesDataContext dc = new Modelo.DataClassesDataContext())
            {
                Modelo.Servico objServico = new Modelo.Servico();
                cbIdServico.Properties.DataSource = objServico.getListaCombo(dc);
            }
        }

        private void CarregaComboResponsavel()
        {
            cbIdResponsavel.Properties.DataSource = cwkControleUsuario.Facade.GetAllUsuarios();
        }

        public override void CarregaObjeto()
        {
            switch (cwAcao)
            {
                case 1:
                    objServicoOS = new cwkGestao.Modelo.ServicoOS();
                    txtCodigo.EditValue = servicoOSController.MaxCodigo(objOrdemServico.ServicoOS);
                    break;
                default:
                    objServicoOS = objOrdemServico.ServicoOS.Where(v => v.Codigo == cwID).First();
                    txtCodigo.EditValue = objServicoOS.Codigo;
                    txtResumo.EditValue = objServicoOS.Resumo;
                    txtDescricao.EditValue = objServicoOS.Descricao;
                    txtDataInicio.EditValue = objServicoOS.DataInicio;
                    txtDataTermino.EditValue = objServicoOS.DataTermino;
                    txtTempoHoras.EditValue = objServicoOS.TempoHoras;
                    cbIdResponsavel.EditValue = objServicoOS.IDResponsavel;
                    cbIdServico.EditValue = objServicoOS.IDServico;
                    break;
            }
        }

        private void CopiaPropriedades(cwkGestao.Modelo.ServicoOS origem, cwkGestao.Modelo.ServicoOS destino)
        {
            destino.Codigo = origem.Codigo;
            destino.Resumo = origem.Resumo;
            destino.Descricao = origem.Descricao;
            destino.DataInicio = origem.DataInicio;
            destino.DataTermino = origem.DataTermino;
            destino.TempoHoras = origem.TempoHoras;
            destino.IDResponsavel = origem.IDResponsavel;
            destino.IDServico = origem.IDServico;
        }

        public override Dictionary<string, string> Salvar()
        {
            cwkGestao.Modelo.ServicoOS clone = new cwkGestao.Modelo.ServicoOS();
            CopiaPropriedades(objServicoOS, clone);

            objServicoOS.Codigo = Convert.ToInt32(txtCodigo.Value);
            objServicoOS.Resumo = txtResumo.Text;
            objServicoOS.Descricao = txtDescricao.Text;
            objServicoOS.DataInicio = (DateTime?)txtDataInicio.EditValue;
            objServicoOS.DataTermino = (DateTime?)txtDataTermino.EditValue;
            objServicoOS.TempoHoras = (DateTime?)txtTempoHoras.EditValue;
            objServicoOS.IDResponsavel = (int?)cbIdResponsavel.EditValue;
            objServicoOS.IDServico = (int?)cbIdServico.EditValue;
            //objServicoOS.Resumo = txtObservacao.Text;
            switch (cwAcao)
            {
                case 1:
                    objServicoOS.Incdata = DateTime.Now;
                    objServicoOS.Incusuario = Modelo.cwkGlobal.objUsuarioLogado.Login;
                    break;
                case 2:
                    objServicoOS.Altdata = DateTime.Now;
                    objServicoOS.Altusuario = Modelo.cwkGlobal.objUsuarioLogado.Login;
                    break;
            }
            Dictionary<string, string> ret = servicoOSController.Salvar(objServicoOS, (cwkGestao.Modelo.Acao)cwAcao, objOrdemServico);
            if (ret.Count > 0)
                CopiaPropriedades(clone, objServicoOS);
            return ret;
        }

        private void sbAdServico_Click(object sender, EventArgs e)
        {
            cwkGestao.Modelo.Servico servicoSelecionado = null;
            if (cbIdServico.EditValue != null && (int)cbIdServico.EditValue > 0)
                servicoSelecionado = cwkGestao.Negocio.ServicoController.Instancia.LoadObjectById((int)cbIdServico.EditValue);

            GridGenerica<cwkGestao.Modelo.Servico> grid = new GridGenerica<cwkGestao.Modelo.Servico>(cwkGestao.Negocio.ServicoController.Instancia.GetAll(), new FormServico(), servicoSelecionado, false);
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            {
                grid.Selecionando = true;
                grid.ShowDialog();

                if (grid.Selecionado != null)
                {
                    cbIdServico.EditValue = grid.Selecionado.ID;
                    CarregaComboServico();
                }
            }
            cbIdServico.Focus();
        }
    }
}
