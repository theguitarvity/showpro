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
        private ClienteDAO cli;
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
        public List<Pedido> listar()
        {
            conn = new ConnectionFactory().getConnection();
            List<Pedido> lista = new List<Pedido>();
            try
            {
                MySqlDataReader dr;

                string sql = "select * from pedido";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Pedido ped = new Pedido();
                    ped.codPedido = Convert.ToInt64(dr[0]);
                    //ped.cliente = cli.listar().Find(x=>x.codCliente==Convert.ToInt64(dr[1]));
                    ped.totalPedido = Convert.ToDecimal(dr[2]);
                    lista.Add(ped);
                }
                return lista;
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
