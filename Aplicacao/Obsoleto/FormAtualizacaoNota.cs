using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Aplicacao.Util;
using cwkGestao.Negocio;
using Cwork.Utilitarios.Funcoes.Sintegra;
using System.Data.SqlClient;

namespace Aplicacao
{
    public partial class FormAtualizacaoNota : Aplicacao.Base.ManutBase
    {
        Modelo.Pessoa objPessoa = new Modelo.Pessoa();
        cwkGestao.Negocio.NotaController notaController = cwkGestao.Negocio.NotaController.Instancia;
        public FormAtualizacaoNota()
        {
            InitializeComponent();
            lkPessoa.ContextoLinq = db;
            this.Text = "Atualização de Nota";
        }

        public override Dictionary<string, string> Salvar()
        {
            string erro, CNPJ_CPF, InscricaoEst, RG;
            Dictionary<string, string> ret = new Dictionary<string, string>();

            string ValidaIE = ConfiguracaoLocalController.GetValidaIE();

            if (lkPessoa.ID > 0)
            {
                if (objPessoa.TipoPessoa == "Jurídica")
                {
                    CNPJ_CPF = txtCNPJ.Text;
                    InscricaoEst = txtInscricao.Text;
                    

                    Modelo.Endereco objEndereco = (from endereco in objPessoa.Enderecos
                                                   where endereco.bPrincipal == 1
                                                   select endereco).Single();

                    if (!InscricaoEstadual.InscricaoEstadualValida(InscricaoEst, objEndereco.Cidade.UF.Sigla) && ValidaIE == "1")
                    {
                        MessageBox.Show("Inscricao Estadual Inválida.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ret.Add("", "");
                        return ret;
                    }
                    else if (!notaController.ValidarCNPJ(CNPJ_CPF, out erro))
                    {
                        MessageBox.Show("CNPJ Inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ret.Add("", "");
                        return ret;
                    }
                    else
                    {
                        if (dtInicial.DateTime != new DateTime() && dtFinal.DateTime != new DateTime())
                        {
                            try
                            {
                                objPessoa.CNPJ_CPF = CNPJ_CPF;
                                objPessoa.Inscricao = InscricaoEst;
                                if (MessageBox.Show("Deseja Atualizar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    AtualizaDadosNota();
                                    MessageBox.Show("Atualização concluída com sucesso.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Preencha as datas corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            ret.Add("", "");
                            return ret;
                        }
                    }
                }
                else
                {
                    RG = txtRG.Text;
                    CNPJ_CPF = txtCPF.Text;
                    

                    if (String.IsNullOrEmpty(RG))
                    {
                        MessageBox.Show("RG Inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ret.Add("", "");
                        return ret;
                    }
                    else if (!notaController.ValidarCPF(CNPJ_CPF, out erro))
                    {
                        MessageBox.Show("CPF Inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ret.Add("", "");
                        return ret;
                    }
                    else
                    {
                        if (dtInicial.DateTime != new DateTime() && dtFinal.DateTime != new DateTime())
                        {
                            try
                            {
                                objPessoa.CNPJ_CPF = CNPJ_CPF;
                                objPessoa.RG = RG;
                                if (MessageBox.Show("Deseja Atualizar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    AtualizaDadosNota();
                                    MessageBox.Show("Atualização concluída com sucesso.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Preencha as datas corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            ret.Add("", "");
                            lkPessoa.Focus();
                            return ret;
                        }
                    }
                }
                return ret;
            }
            else
            {
                MessageBox.Show("Selecione um cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ret.Add("", "");
                return ret;
            }
        }

        private void AtualizaDadosNota()
        {
            StringBuilder sql = new StringBuilder();
            object[] parms = new object[0];


            sql.AppendLine("UPDATE Nota SET PessoaCNPJCPF = '" + objPessoa.CNPJ_CPF + "'");
            sql.AppendLine(" , PessoaInscRG = '" + (objPessoa.TipoPessoa == "Física" ? objPessoa.RG : objPessoa.Inscricao) + "'");
            sql.AppendLine(" WHERE Dt >= '" + String.Format("{0:yyyy/MM/dd}", dtInicial.DateTime) + "' AND Dt <= '" + String.Format("{0:yyyy/MM/dd}", dtFinal.DateTime) + "'");
            sql.AppendLine(" AND IDPessoa = " + objPessoa.ID);

            db.ExecuteCommand(sql.ToString(), parms);

            sql = new StringBuilder();

            if (objPessoa.TipoPessoa == "Jurídica")
            {
                sql.AppendLine("UPDATE Pessoa SET CNPJ_CPF = '" + objPessoa.CNPJ_CPF + "'");
                sql.AppendLine(" , Inscricao = '" + objPessoa.Inscricao + "'");
                sql.AppendLine(" WHERE ID = " + objPessoa.ID);
            }
            else
            {
                sql.AppendLine("UPDATE Pessoa SET CNPJ_CPF = '" + objPessoa.CNPJ_CPF + "'");
                sql.AppendLine(" , RG = '" + objPessoa.RG + "'");
                sql.AppendLine(" WHERE ID = " + objPessoa.ID);
            }
            db.ExecuteCommand(sql.ToString(), parms);

        }

        private void lkPessoa_Leave(object sender, EventArgs e)
        {
            if (lkPessoa.ID > 0)
            {
                objPessoa = (from p in db.Pessoas
                             where p.ID == lkPessoa.ID
                             select p).Single();
                if (objPessoa.TipoPessoa == "Física")
                {
                    labelControl18.Text = "CPF:";
                    labelControl19.Text = "RG:";
                    labelControl19.Location = new Point(330, 40);
                    txtCNPJ.Visible = false;
                    txtCPF.Visible = true;
                    txtInscricao.Visible = false;
                    txtRG.Visible = true;
                    txtCPF.Text = objPessoa.CNPJ_CPF;
                    txtRG.Text = objPessoa.RG;
                }
                else
                {
                    labelControl18.Text = "CNPJ:";
                    labelControl19.Text = "Inscrição Estadual:";
                    labelControl19.Location = new Point(255, 40);
                    txtCPF.Visible = false;
                    txtCNPJ.Visible = true;
                    txtInscricao.Visible = true;
                    txtRG.Visible = false;
                    txtCNPJ.Text = objPessoa.CNPJ_CPF;
                    txtInscricao.Text = objPessoa.Inscricao;
                }
            }
            else
            {
                txtCPF.Text = "";
                txtCNPJ.Text = "";
                txtInscricao.Text = "";
                txtRG.Text = "";              
            }
        }

        private void btPessoa_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookupPessoa(lkPessoa, PessoaController.Instancia.GetAllClientes(), "Cliente", typeof(FormPessoa));
        }
    }
}
