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
        public void inserir(List<Ingresso> ingressos)
        {
            foreach (Ingresso ing in ingressos)
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
        public List<Lote> listarLotesPorEvento(long cod)
        {
            MySqlDataReader dr;
            List<Lote> lista = new List<Lote>();
            conn = new ConnectionFactory().getConnection();
            try
            {
                string sql = "select lote.codLote, lote.numero, lote.preco  from lote,evento, ingresso where lote.codLote = ingresso.codIngresso and ingresso.evento = @cod";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cod", cod);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Lote lote = new Lote();
                    lote.codLote = Convert.ToInt64(dr[0]);
                    lote.numeroLote = Convert.ToInt32(dr[1]);
                    lote.valor = Convert.ToDecimal(dr[2]);
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
        public bool validar(Evento evento ,String barras)
        {
            conn = new ConnectionFactory().getConnection();
            try
            {
                MySqlDataReader dr;
                string sql = "select * from ingresso where codigoBarras = @barras and evento = @evento";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@barras", barras);
                cmd.Parameters.AddWithValue("@evento", evento.codEvento);
                dr = cmd.ExecuteReader();
                if (dr.RecordsAffected > 0)
                    return true;
                else
                    return false;
            }
            catch (MySqlException erro)
            {
                throw new InvalidExpressionException(erro.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

    }
   
}
