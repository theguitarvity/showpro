using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace desktop.model.dao
{
    class PedidoDAO
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;

        public void inserir(Pedido pedido)
        {
            conn = new ConnectionFactory().getConnection();
            try
            {
                string sql = "insert into pedido values(@cod, @cliente, @total)";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cod", pedido.codPedido);
                cmd.Parameters.AddWithValue("@cliente", pedido.cliente.codCliente);
                cmd.Parameters.AddWithValue("@total", pedido.totalPedido);
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
