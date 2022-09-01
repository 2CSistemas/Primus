using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicaçãoPrimus.model;

namespace AplicaçãoPrimus.BancoDados
{
    public class dbProduto
    {
        Connect conect = new Connect();
        public DataTable selecionar(String Busca, int opcao)
        {
            try
            {
                String[] sql = new String[5];
                sql[0] = "SELECT * FROM Produto;";
                sql[1] = "SELECT p.ID,p.Codigo, p.nome,p.PrecoBase,p.IDUnidade, u.Sigla FROM produto as p INNER JOIN unidade as u ON p.IDUnidade = u.ID WHERE p.ID  = " + Busca + ";";

                SqlConnection con;
                con = new SqlConnection(conect.ConexaoLocal());
                con.Open();
                SqlCommand cmd = new SqlCommand(sql[opcao], con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                con.Dispose();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public DataTable selecionarProdutoFavorito(String Busca, int opcao)
        {
            try
            {
                String[] sql = new String[5];
                sql[0] = "SELECT * FROM produtosFavoristos;";
                sql[1] = "SELECT * FROM produtosFavoristos WHERE ID  = " + Busca + ";";

                SqlConnection con;
                con = new SqlConnection(conect.ConexaoLocal());
                con.Open();
                SqlCommand cmd = new SqlCommand(sql[opcao], con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                con.Dispose();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void ComandoProdutoFavorito(produtosFavoritos mod, int opcao)
        {

            int ID = mod.ID;
            int ID_Produto = mod.ID_Produto;
            String Nome = mod.Nome;
            String CaminhoImagem = mod.CaminhoImagem;


            try
            {
                String[] sql = new String[5];
                sql[0] = @"INSERT INTO produtosFavoristos(ID_Produto , Nome, CaminhoImagem)VALUES('" + ID_Produto + "', '" + Nome + "', '" + CaminhoImagem + "'); ";
                sql[1] = @"UPDATE produtosFavoristos SET ID_Produto = '" + ID_Produto + "', Nome = '" + Nome + "', CaminhoImagem = '" + CaminhoImagem + "' WHERE ID = '" + ID + "'; ";
                sql[2] = @"DELETE FROM produtosFavoristos WHERE ID = '" + ID + "'; ";

                String sqlComando = sql[opcao];
                SqlConnection con;
                con = new SqlConnection(conect.ConexaoLocal());
                con.Open();
                SqlCommand cmd = new SqlCommand(sqlComando, con);
                cmd.ExecuteNonQuery();
                con.Close();
                con.Dispose();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
