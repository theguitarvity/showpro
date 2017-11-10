using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace desktop.model.dao
{
    class ClienteDAO
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;
        
        public void inserir(Cliente cli)
        {
            conn = new ConnectionFactory().getConnection();
            try
            {
                string sql = "INSERT INTO cliente VALUES(@cod, @nome, @cpf, @email, @dt)";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cod", cli.codCliente);
                cmd.Parameters.AddWithValue("@nome", cli.nomeCliente);
                cmd.Parameters.AddWithValue("@cpf", cli.cpfCliente);
                cmd.Parameters.AddWithValue("@email", cli.emailCliente);
                cmd.Parameters.AddWithValue("@dt", cli.dataNascCliente.Date);
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
