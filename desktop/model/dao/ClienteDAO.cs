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
        public List<Cliente> listar()
        {
            conn = new ConnectionFactory().getConnection();
            try
            {
                List<Cliente> lista = new List<Cliente>();
                MySqlDataReader dr;
                String sql = "select * from cliente";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Cliente cli = new Cliente();
                    cli.codCliente = Convert.ToInt64(dr[0]);
                    cli.nomeCliente = Convert.ToString(dr[1]);
                    cli.cpfCliente = Convert.ToString(dr[2]);
                    cli.emailCliente = Convert.ToString(dr[3]);
                    
                    cli.dataNascCliente = Convert.ToDateTime(dr[5]);
                   
                    lista.Add(cli);

                }
                return lista;
            }
            catch (MySqlException erro)
            {
                throw new InvalidExpressionException(erro.Message);
            }
        }
        public Cliente buscarPorCpf(String cpf)
        {
            conn = new ConnectionFactory().getConnection();
            MySqlDataReader dr;
            Cliente cli = new Cliente();
            try
            {
                string sql = "select * from cliente where cpfCliente = @cpf";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cpf", cpf);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //cli = new Cliente();
                    cli.codCliente = Convert.ToInt64(dr[0]);
                    cli.nomeCliente = Convert.ToString(dr[1]);
                    cli.cpfCliente = Convert.ToString(dr[2]);
                    cli.emailCliente = Convert.ToString(dr[3]);
                    cli.dataNascCliente = Convert.ToDateTime(dr[4]);
                }
                return cli;
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
