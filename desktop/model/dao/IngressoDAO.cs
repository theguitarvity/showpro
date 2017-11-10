using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace desktop.model.dao
{
    class IngressoDAO
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;


        public void inserir(Ingresso ing)
        {
            conn = new ConnectionFactory().getConnection();
            try
            {
                string sql = "INSERT INTO ingresso VALUES(@cod, @lote, @evento, @barras)";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@cod", ing.codIngresso);
                cmd.Parameters.AddWithValue("@lote", ing.lote.codLote);
                cmd.Parameters.AddWithValue("@evento", ing.evento.codEvento);
                cmd.Parameters.AddWithValue("@barras", ing.codigoBarras);
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
