namespace Aplicacao
{
    public partial class FormCentroCusto : IntermediariasTela.FormManutCentroCustoIntermediaria
    {      
        protected override void InitializeChildComponents()
        {
            InitializeComponent();
        }

        protected override bool ValidarFormulario()
        {
            return base.ValidarFormulario() && txtDescricao.Text.Trim().Length > 0;
        }

        protected override void OK()
        {
            Selecionado.BCentroDeCusto = true;
            if (Operacao == cwkGestao.Modelo.Acao.Incluir)
                Selecionado.Status = 2;
 
            base.OK();
        }
    }
}
