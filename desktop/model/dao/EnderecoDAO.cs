using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace desktop.model.dao
{
    class EnderecoDAO
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;
        public void inserir(Endereco endereco)
        {
            conn = new ConnectionFactory().getConnection();
            try
            {
                string sql = "INSERT INTO endereco VALUES(@cod, @log, @num, @bairro, @cidade, @uf, @cep)";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cod", endereco.codEndereco);
                cmd.Parameters.AddWithValue("@log", endereco.logradoureEndereco);
                cmd.Parameters.AddWithValue("@num", endereco.numeroEndereco);
                cmd.Parameters.AddWithValue("@bairro", endereco.bairroEndereco);
                cmd.Parameters.AddWithValue("@cidade", endereco.cidadeEndereco);
                cmd.Parameters.AddWithValue("@uf", endereco.estadoEndereco);
                cmd.Parameters.AddWithValue("@cep", endereco.cepEndereco);
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
