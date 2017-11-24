using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop.model.dao
{
    class Pedido_Ingresso
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;


        public void realizarVenda(List<Ingresso> ingressos, Pedido pedido)
        {
            foreach(Ingresso ingresso in ingressos)
            {
                conn = new ConnectionFactory().getConnection();
                try
                {

                    string sql = "insert into pedido_ingresso values(@codIngresso, @codPedido)";
                    cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@codIngresso", ingresso.codIngresso);
                    cmd.Parameters.AddWithValue("@codPedido", pedido.codPedido);
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
}
