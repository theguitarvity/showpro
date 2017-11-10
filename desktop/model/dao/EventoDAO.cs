﻿using System;
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
    }
}
