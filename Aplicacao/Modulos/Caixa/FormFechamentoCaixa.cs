using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Modelo;
using System.Linq;

namespace Aplicacao
{
    public partial class FormFechamentoCaixa : Aplicacao.IntermediariasTela.FormManutFechamentoCaixaIntermediaria
    {
        public FormFechamentoCaixa()
        {

        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            //lkbBanco.SubForm = new FormBanco();
            lkbBanco.SubFormType = typeof(FormBanco);
            lkpBanco.Sessao = BancoController.Instancia.getSession();
        }


        private bool CamposValidos()
        {
            dxErroProvider.ClearErrors();

            if (lkpBanco.EditValue == null)
                dxErroProvider.SetError(lkpBanco, "Campo obrigatório");
            if (txtDtInicio.EditValue == null)
                dxErroProvider.SetError(txtDtInicio, "Campo obrigatório");
            if (txtDtFinal.EditValue == null)
                dxErroProvider.SetError(txtDtFinal, "Campo obrigatório");
            else if (txtDtFinal.DateTime < txtDtInicio.DateTime)
                dxErroProvider.SetError(txtDtFinal, "A data final deve ser maior do que a data inicial.");

            return !dxErroProvider.HasErrors;
        }

        private void Atualizar()
        {
            if (CamposValidos())
            {
                if (((Banco)lkpBanco.Selecionado).UtilizaFechamentoCaixa)
                {
                    var teste = FechamentoCaixaController.Instancia.GetFechamentoCaixaGrid((Banco)lkpBanco.Selecionado, (DateTime)txtDtInicio.EditValue, (DateTime)txtDtFinal.EditValue);
                    gcPrincipal.DataSource = teste;
                    gvPrincipal.MoveLast();
                }
                else
                {
                    MessageBox.Show("O Banco selecionado não está configurado para utilizar fechamento de caixa. Verifique !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void btCarregar_Click_1(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void sbExcluirFechamento_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            if (gvPrincipal.RowCount > 0)
            {
                if (MessageBox.Show("Deseja fechar o caixa desta data ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (FechamentoCaixaController.Instancia.ExisteFechamentoPosterior(GetRegistroSelecionado().Data, (Banco)lkpBanco.Selecionado))
                    {
                        if (FechamentoCaixaController.Instancia.PodeFecharCaixa(GetRegistroSelecionado().Data, (Banco)lkpBanco.Selecionado) || FechamentoCaixaController.Instancia.GetAll().Where(x => x.bFechado == true && x.Banco.ID == ((Banco)lkpBanco.Selecionado).ID).ToList().Count == 0)
                        {
                            if (GetRegistroSelecionado().Fechado == false)
                            {
                                if (GetRegistroSelecionado().UsuarioFechamento == "")
                                {
                                    var teste = GetRegistroSelecionado();
                                    Console.WriteLine(teste);
                                    FechamentoCaixa fechamento = new FechamentoCaixa();
                                    fechamento.UsuarioFechamento = cwkControleUsuario.Facade.getUsuarioLogado.Nome;
                                    fechamento.DtFechamento = DateTime.Now;
                                    fechamento.Banco = (Banco)lkpBanco.Selecionado;
                                    fechamento.DtConciliacao = GetRegistroSelecionado().Data;
                                    fechamento.Saldo = GetRegistroSelecionado().SaldoFinal;
                                    fechamento.SaldoInicial = GetRegistroSelecionado().SaldoInicial;
                                    fechamento.ValorEntrada = GetRegistroSelecionado().Entrada;
                                    fechamento.ValorSaida = GetRegistroSelecionado().Saida;
                                    fechamento.bFechado = true;
                                    FechamentoCaixaController.Instancia.Salvar(fechamento, Acao.Incluir);
                                    MessageBox.Show("Fechamento efetuado com sucesso !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    Atualizar();
                                }
                                else
                                {
                                    var fec = FechamentoCaixaController.Instancia.GetFechamentoPorData(GetRegistroSelecionado().Data, (Banco)lkpBanco.Selecionado);
                                    fec.bFechado = true;
                                    FechamentoCaixaController.Instancia.Salvar(fec, Acao.Alterar);
                                    MessageBox.Show("Fechamento efetuado com sucesso !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    Atualizar();
                                }

                            }
                            else
                            {
                                MessageBox.Show("Caixa já fechado !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Não foi realizado o fechamento de caixa do dia anterior. Verifique !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Existem fechamentos posteriores. Verifique !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
                MessageBox.Show("Selecione um registro !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public FechamentoCaixaEmMemoria GetRegistroSelecionado()
        {
            return (FechamentoCaixaEmMemoria)gvPrincipal.GetRow(gvPrincipal.GetSelectedRows()[0]);
        }

        private void gcPrincipal_DoubleClick(object sender, EventArgs e)
        {
            if (gvPrincipal.RowCount > 0)
            {
                var form = new Aplicacao.Modulos.Caixa.GridMovCaixa(MovCaixaController.Instancia.GetPorBancoEData((Banco)lkpBanco.Selecionado, GetRegistroSelecionado().Data, GetRegistroSelecionado().Data), null, false, typeof(FormMovCaixa));
                if (cwkControleUsuario.Facade.ControleAcesso(form))
                    form.ShowDialog();
                Atualizar();
            }
            else
            {
                MessageBox.Show("Selecione um registro !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        protected override void Cancelar()
        {
            if (gvPrincipal.RowCount > 0)
            {
                if (MessageBox.Show("Deseja excluir o fechamento de caixa desta data ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (GetRegistroSelecionado().Fechado == true)
                    {
                        if (FechamentoCaixaController.Instancia.PodeAbrirCaixa(GetRegistroSelecionado().Data, (Banco)lkpBanco.Selecionado))
                        {
                            var fec = FechamentoCaixaController.Instancia.GetFechamentoPorData(GetRegistroSelecionado().Data, (Banco)lkpBanco.Selecionado);
                            FechamentoCaixaController.Instancia.Salvar(fec, Acao.Excluir);
                            MessageBox.Show("Caixa aberto com sucesso !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Atualizar();
                        }
                        else
                            MessageBox.Show("Existem dias posteriores com fechamento de caixa para este banco. Verifique !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                        MessageBox.Show("O caixa já está aberto !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Selecione um registro !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void FormFechamentoCaixa_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "");
                    break;
            }

        }

        private void FormFechamentoCaixa_Shown(object sender, EventArgs e)
        {
            txtDtInicio.EditValue = DateTime.Now.AddDays(-7);
            txtDtFinal.EditValue = DateTime.Now;
        }

        private void gvPrincipal_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            Bitmap groupPanelImage;
            groupPanelImage = (Bitmap)Aplicacao.Properties.Resources.HeaderGrid;
            groupPanelImage.MakeTransparent();
            Brush brush = e.Cache.GetGradientBrush(e.Bounds, Color.White, Color.WhiteSmoke,
              System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(brush, e.Bounds);
            Image img = groupPanelImage;
            Rectangle r = new Rectangle(e.Bounds.X + e.Bounds.Width - img.Size.Width - 5,
              e.Bounds.Y + (e.Bounds.Height - img.Size.Height) / 2, img.Width, img.Height);
            e.Graphics.DrawImageUnscaled(img, r);
            e.Handled = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Fechamento Geral do Caixa.

            if (gvPrincipal.RowCount > 0)
            {
                if (MessageBox.Show("Deseja fechar o caixa desta data e todos os anteriores ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (FechamentoCaixaController.Instancia.ExisteFechamentoPosterior(GetRegistroSelecionado().Data, (Banco)lkpBanco.Selecionado))
                    {
                        var FechamentoCaixaMemoria = GetRegistroSelecionado();
                        if (FechamentoCaixaMemoria.Fechado == false)
                        {
                            if (FechamentoCaixaMemoria.SaldoFinal < 0)
                                FechamentoCaixaMemoria.Entrada += (FechamentoCaixaMemoria.SaldoFinal * -1);
                            else if (FechamentoCaixaMemoria.SaldoFinal > 0)
                                FechamentoCaixaMemoria.Saida += (FechamentoCaixaMemoria.SaldoFinal);

                            FechamentoCaixaMemoria.SaldoFinal = 0;

                            if (FechamentoCaixaMemoria.UsuarioFechamento == "")
                            {
                                FechamentoCaixa fechamento = new FechamentoCaixa();
                                fechamento.UsuarioFechamento = cwkControleUsuario.Facade.getUsuarioLogado.Nome;
                                fechamento.DtFechamento = DateTime.Now;
                                fechamento.Banco = (Banco)lkpBanco.Selecionado;
                                fechamento.DtConciliacao = FechamentoCaixaMemoria.Data;
                                fechamento.Saldo = FechamentoCaixaMemoria.SaldoFinal;
                                fechamento.SaldoInicial = FechamentoCaixaMemoria.SaldoInicial;
                                fechamento.ValorEntrada = FechamentoCaixaMemoria.Entrada;
                                fechamento.ValorSaida = FechamentoCaixaMemoria.Saida;
                                fechamento.bFechado = true;
                                FechamentoCaixaController.Instancia.Salvar(fechamento, Acao.Incluir);
                                MessageBox.Show("Fechamento efetuado com sucesso !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                Atualizar();
                            }
                            else
                            {
                                var fec = FechamentoCaixaController.Instancia.GetFechamentoPorData(FechamentoCaixaMemoria.Data, (Banco)lkpBanco.Selecionado);
                                fec.bFechado = true;
                                fec.Saldo = FechamentoCaixaMemoria.SaldoFinal;
                                fec.SaldoInicial = FechamentoCaixaMemoria.SaldoInicial;
                                fec.ValorEntrada = FechamentoCaixaMemoria.Entrada;
                                fec.ValorSaida = FechamentoCaixaMemoria.Saida;

                                FechamentoCaixaController.Instancia.Salvar(fec, Acao.Alterar);
                                MessageBox.Show("Fechamento efetuado com sucesso !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                Atualizar();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Caixa já fechado !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Existem fechamentos posteriores. Verifique !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
                MessageBox.Show("Selecione um registro !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
