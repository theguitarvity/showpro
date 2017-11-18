using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace desktop.model.dao
{
    class EventoDAO
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;

        public void inserir(Evento ev)
        {
            conn = new ConnectionFactory().getConnection();

            try
            {
                string sql = "INSERT INTO evento VALUES(@cod, @nome, @dt, @hr, @deta, @tipo, @local)";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cod", ev.codEvento);
                cmd.Parameters.AddWithValue("@nome", ev.nomeEvento);
                cmd.Parameters.AddWithValue("@dt", ev.dtEvento.Date);
                cmd.Parameters.AddWithValue("@hr", ev.horaEvento);
                cmd.Parameters.AddWithValue("@deta",ev.detalhesEvento);
                cmd.Parameters.AddWithValue("@tipo", ev.tipoEvento.codTipo);
                cmd.Parameters.AddWithValue("@local", ev.localEvento.codLocal);

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
        public List<Evento> listar()
        {
            conn = new ConnectionFactory().getConnection();
            try
            {
                List<Evento> eventos = new List<Evento>();
                MySqlDataReader dr;
                string sql = "SELECT * FROM evento ORDER BY dtEvento desc";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Evento evento = new Evento();
                    evento.codEvento = Convert.ToInt64(dr[0]);
                    evento.nomeEvento = Convert.ToString(dr[1]);
                    evento.dtEvento = Convert.ToDateTime(dr[2]);
                    evento.horaEvento = Convert.ToDateTime(dr[3]);
                    evento.detalhesEvento = Convert.ToString(dr[4]);
                    eventos.Add(evento);
                }
                return eventos;
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
        public Evento buscarPorID(long id)
        {
            conn = new ConnectionFactory().getConnection();
            try
            {
                MySqlDataReader dr;
                Evento evento = new Evento();
                string sql = "SELECT * FROM evento WHERE codEvento = @cod ";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cod", id);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    
                    evento.codEvento = Convert.ToInt64(dr[0]);
                    evento.nomeEvento = Convert.ToString(dr[1]);
                    evento.dtEvento = Convert.ToDateTime(dr[2]);
                    evento.horaEvento = Convert.ToDateTime(dr[3]);
                    evento.detalhesEvento = Convert.ToString(dr[4]);
                }
                return evento;
            }
            catch (MySqlException e)
            {
                throw new InvalidExpressionException(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
