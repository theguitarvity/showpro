using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop.model.dao
{
    class Pedido_CaixaDAO
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;


        public void vincular(Caixa caixa, Pedido ped)
        {

            conn = new ConnectionFactory().getConnection();
            try
            {
                string sql = "INSERT INTO pedido_caixa VALUES(@codCaixa, @codPedido)";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@codCaixa", caixa.codCaixa);
                cmd.Parameters.AddWithValue("@codPedido", ped.codPedido);
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
