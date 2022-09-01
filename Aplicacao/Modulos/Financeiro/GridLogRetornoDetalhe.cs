using Aplicacao.IntermediariasTela;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Windows.Forms;
using System;

namespace Aplicacao.Modulos.Financeiro
{
    public partial class GridLogRetornoDetalhe : GridLogRetornoDetalheIntermediaria
    {
        public GridLogRetornoDetalhe(LogRetorno LogRetorno) : base(LogRetornoDetalheController.Instancia.HqlLoadByIdLogRetorno(LogRetorno.ID), null, false)
        {
            InitializeComponent();
            textoFiltroCabecalhoRel = String.Format("{0} - {1}", LogRetorno.ID, LogRetorno.NomeArquivo);
        }

        protected override void Consultar()
        {
            var registroSelecionado = GetRegistroSelecionado();
            if (validaRegistroSelecionado(registroSelecionado))
            {
                using (var formulario = new FormDocumento())
                {
                    formulario.Selecionado = DocumentoController.Instancia.LoadObjectById(registroSelecionado.documento.ID);
                    formulario.Operacao = Acao.Consultar;
                    formulario.ShowDialog();
                }
            }
        }

        private bool validaRegistroSelecionado(LogRetornoDetalhe valida)
        {
            string mensagem = "";
            if (valida != null)
            {
                if (valida.documento == null)
                {
                    if (valida.NumeroDocumento != null || valida.NossoNumero != null)
                        mensagem = "Documento não encontrado no sistema.";
                    else
                        mensagem = "Nenhum registro selecionado.";
                }
            }
            else mensagem = "Nenhum registro selecionado.";

            if (mensagem != "")
            {
                MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else return true;
        }


        private void GridLogRetornoDetalhe_Load(object sender, System.EventArgs e)
        {
        }
    }
}