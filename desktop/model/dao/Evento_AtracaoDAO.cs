using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace desktop.model.dao
{
    class Evento_AtracaoDAO
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;


        public void vincular(Evento ev, Atracao atra)
        {

            conn = new ConnectionFactory().getConnection();
            try
            {
                string sql = "INSERT INTO evento_atracao VALUES(@codev, @codat)";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@codev", ev.codEvento);
                cmd.Parameters.AddWithValue("@codat", atra.codAtracao);
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
