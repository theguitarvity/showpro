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
                string sql = "INSERT INTO lote VALUES(@cod, @numero, @preco, @maximo, @evento)";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cod", lote.codLote);
                cmd.Parameters.AddWithValue("@numero", lote.numeroLote);
                cmd.Parameters.AddWithValue("@preco", lote.valor);
                cmd.Parameters.AddWithValue("@maximo", lote.maximo);
                cmd.Parameters.AddWithValue("@evento", lote.evento.codEvento);
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
        public List<Lote> listarPorEvento(Evento evento)
        {
            conn = new ConnectionFactory().getConnection();
            MySqlDataReader dr;
            List<Lote> lista = new List<Lote>();
            try
            {
                string sql = "select * from lote where codEvento = @evento ";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@evento", evento.codEvento);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Lote lote = new Lote();
                    lote.codLote = Convert.ToInt64(dr[0]);
                    lote.numeroLote = Convert.ToInt32(dr[1]);
                    lote.valor = Convert.ToDecimal(dr[2]);
                    lote.maximo = Convert.ToInt32(dr[3]);
                    lista.Add(lote);
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
