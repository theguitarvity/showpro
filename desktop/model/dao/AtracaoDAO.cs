using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace desktop.model.dao
{
    class AtracaoDAO
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;
        
        public void inserir(Atracao atracao)
        {
            conn = new ConnectionFactory().getConnection();

            try
            {
                string sql = "INSERT INTO atracao VALUES(@cod, @nome, @tipo, @detalhes)";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cod", atracao.codAtracao);
                cmd.Parameters.AddWithValue("@nome", atracao.nomeAtracao);
                cmd.Parameters.AddWithValue("@tipo", atracao.tipoAtracao);
                cmd.Parameters.AddWithValue("@detalhes", atracao.detalhesAtracao);
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
    }
}
