using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop.model.dao
{
    class TipoEventoDAO
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;

        public void inserir(TipoEvento tipo)
        {
            conn = new ConnectionFactory().getConnection();
            try
            {
                String sql = "INSERT INTO tipo VALUES(@cod, @nome)";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cod", tipo.codTipo);
                cmd.Parameters.AddWithValue("@nome", tipo.nomeTipo);
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
