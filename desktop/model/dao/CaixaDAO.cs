using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace desktop.model.dao
{
    public class CaixaDAO
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;
        public void abrir(Caixa caixa)
        {
            conn = new ConnectionFactory().getConnection();
            try
            {
                string sql = "insert into caixa values(@cod, @dtA, @dtF, @valor)";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cod", caixa.codCaixa);
                cmd.Parameters.AddWithValue("@dtA", caixa.dataAbertura);
                cmd.Parameters.AddWithValue("@dtF", caixa.dataFechamento);
                cmd.Parameters.AddWithValue("@valor",caixa.totalDiario);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException erro )
            {
                throw new InvalidExpressionException(erro.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void fechar(Caixa caixa)
        {
            conn = new ConnectionFactory().getConnection();
            try
            {
                string sql = "update caixa set codCaixa = @cod, dataFechamento = @dtF, totalDiario = @valor where codCaixa = @cod";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cod", caixa.codCaixa);
                cmd.Parameters.AddWithValue("@dtF", caixa.dataFechamento);
                cmd.Parameters.AddWithValue("@valor", caixa.totalDiario);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException erro)
            {
                throw new InvalidExpressionException(erro.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public bool verificarCaixaDiario()
        {
            conn = new ConnectionFactory().getConnection();
            MySqlDataReader dr;
            bool retorno = false;
            try
            {
                string sql = "select * from caixa where dataAbertura = @data";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    if (dr[0] == null)
                        retorno = false;
                    else
                        retorno = true;
                }
                return retorno;
                
            }
            catch (MySqlException erro)
            {
                throw new InvalidExpressionException(erro.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
