using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace desktop.model.dao
{
    class LoteDAO
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;

        public void inserir(Lote lote)
        {
            conn = new ConnectionFactory().getConnection();
            try
            {
                string sql = "INSERT INTO lote VALUES(@cod, @numero, @preco,)";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cod", lote.codLote);
                cmd.Parameters.AddWithValue("@numero", lote.numeroLote);
                cmd.Parameters.AddWithValue("@preco", lote.valor);
                cmd.ExecuteNonQuery();

            }
            catch(MySqlException erro)
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
