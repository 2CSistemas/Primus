using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;
using System.Threading;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Telefonia
{
    public partial class GridArquivoLigacao : Aplicacao.IntermediariasTela.GridArquivoLigacaoIntermediaria
    {
        private Aplicacao.Util.CwkMessageBox<vazio> form;
        delegate void CloseForm();
        CloseForm FechaForm;

        public GridArquivoLigacao()
        {
        }
        public GridArquivoLigacao(IList<Tel_ArquivoLigacao> lista, IFormManut<Tel_ArquivoLigacao> formManut, bool adicionarFiltro)
            : base(lista, formManut, false)
        {
        }
        public GridArquivoLigacao(IList<Tel_ArquivoLigacao> lista, IFormManut<Tel_ArquivoLigacao> formManut, Tel_ArquivoLigacao selecionado, bool adicionarFiltro)
            : base(lista, formManut, selecionado, adicionarFiltro)
        {
            EsconderBotoes(Botao.Incluir | Botao.Alterar);
            sbConsultar.Location = sbAlterar.Location;
        }

        protected override void Consultar()
        {
            Thread t = new Thread(new ThreadStart(AbrirForm));
            t.Start();

            FechaForm = new CloseForm(FechaFormMethod);

            var registroSelecionado = GetRegistroSelecionado(); 

           

            if (registroSelecionado != null)
            {
                var x = Tel_FaturaLigacaoController.Instancia.GetAllPorIDArquivo(registroSelecionado.ID);
                registroSelecionado.Ligacoes = (IList<Tel_Ligacao>)x;
                var formManut = new FormArquivoLigacao(registroSelecionado);
                formManut.Operacao = cwkGestao.Modelo.Acao.Consultar;
                form.Invoke(FechaForm);
                formManut.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AbrirForm() 
        {
            form = new Aplicacao.Util.CwkMessageBox<vazio>("Aguarde", "\nPor Favor Aguarde enquanto os dados são carregados.");
            form.ControlBox = false;
            form.ShowDialog();
        }

        public void FechaFormMethod()
        {
            form.Close();
        }

        private enum vazio{};
    }
}
