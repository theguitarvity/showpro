using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showpro.model.dao
{
    class FuncionarioDAO
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;

        public FuncionarioDAO()
        {
            this.conn = new ConnectionFactory().getConnection;
        }

        public void insereUser(Funcionario fun)
        {
            try
            {

                String sql = "INSERT INTO usuario values(@cod, @email, @senha)";
                cmd = this.conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cod", fun.codUsuario);
                cmd.Parameters.AddWithValue("@email", fun.emailUsuario);
                cmd.Parameters.AddWithValue("@senha", fun.senhaUsuario);
                cmd.ExecuteNonQuery();
                



            }
            catch (MySqlException erro)
            {
                throw new InvalidExpressionException("Erro ao inserir o usuário!");


            }
            finally
            {
                conn.Close();

            }

        }
        public void inserir(Funcionario fun)
        {

            try
            {
                insereUser(fun);
                String sql = "INSERT INTO funcionario VALUES(@cod, @nome, @cpf, @dtNasc, @dtIni, @cargo)";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cod", fun.codUsuario);
                cmd.Parameters.AddWithValue("@nome", fun.nomeFuncionario);
                cmd.Parameters.AddWithValue("@cpf", fun.cpfFuncionario);
                cmd.Parameters.AddWithValue("@dtNasc", fun.dataNascFuncionario);
                cmd.Parameters.AddWithValue("@dtIni", fun.dataInicioFuncionario);
                cmd.Parameters.AddWithValue("@cargo", fun.cargoFuncionario);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException erro)
            {
                throw new InvalidExpressionException("Erro ao inserir o funcionario");
            }
            finally {
                conn.Close();
            }

        }
    }
}
