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
        public List<Atracao> listarAtracoes(long cod)
        {
            List < Atracao >lista  = new List<Atracao>();
            conn = new ConnectionFactory().getConnection();
            MySqlDataReader dr;
            try
            {

                string sql = "select * from atracao, evento_atracao where evento_atracao.codEvento = @cod and evento_atracao.codAtracao = atracao.codAtracao  ";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cod", cod);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Atracao atracao = new Atracao();
                    atracao.codAtracao = Convert.ToInt64(dr[0]);
                    atracao.nomeAtracao = Convert.ToString(dr[1]);
                    atracao.tipoAtracao = Convert.ToString(dr[2]);
                    atracao.detalhesAtracao = Convert.ToString(dr[3]);
                    lista.Add(atracao);

                }
                return lista;
            }
            catch (MySqlException erro)
            {
                throw new InvalidExpressionException(erro.Message);
            }
            finally
            {

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
