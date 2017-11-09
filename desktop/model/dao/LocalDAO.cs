using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace desktop.model.dao
{
    class LocalDAO
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;

        public void inserir(Local local)
        {
            conn = new ConnectionFactory().getConnection();
            try
            {
                string sql = "INSERT INTO local(@cod, @nome, @endereco, @detalhes)";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cod", local.codLocal);
                cmd.Parameters.AddWithValue("@nome",local.nomeLocal);
                cmd.Parameters.AddWithValue("@endereco",local.enderecoLocal.codEndereco);
                cmd.Parameters.AddWithValue("@detalhes", local.detalhesLocal);
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
