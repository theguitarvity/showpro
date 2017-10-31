using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace desktop.model.dao
{
    class FuncionarioDAO
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;

        public FuncionarioDAO()
        {
            conn = new ConnectionFactory().getConnection();
            

        }
        public void insertUser(Funcionario fun) {
            try
            {
                String sql = "INSERT INTO usuario values(@cod, @email, @senha)";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cod", fun.codUsuario);
                cmd.Parameters.AddWithValue("@email", fun.emailUsuario);
                cmd.Parameters.AddWithValue("@senha", fun.senhaUsuario);
                cmd.ExecuteNonQuery();


            }
            catch (MySqlException erro)
            {
                throw new InvalidExpressionException("Erro ao inserir o funcionario!");

            }
            finally {
                conn.Close();

            }
        }
        public void inserir(Funcionario fun) {
            try
            {
                insertUser(fun);
                string sql = "INSERT INTO funcionario values(@cod, @nome, @cpf, @dtNasc, @dtIni, @cargo)";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cod", fun.codUsuario);
                cmd.Parameters.AddWithValue("@nome", fun.nomeFuncionario);
                cmd.Parameters.AddWithValue("@cpf", fun.cpfFuncionario);
                cmd.Parameters.AddWithValue("@dtNasc", fun.dataNascFuncionario.Date);
                cmd.Parameters.AddWithValue("@dtIni", fun.dataInicioFuncionario.Date);
                cmd.Parameters.AddWithValue("@cargo", fun.cargoFuncionario);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw new InvalidExpressionException("Erro ao inserir funcionário!");
            }
            finally
            {
                conn.Close();
            }

        }
        public void alterar(Funcionario fun) {
        }
        public Boolean login(String email, String senha) {
            try
            {
                Boolean valid = true;
                String sql = "SELECT * FROM usuario WHERE emailUsuario = @email and senha = @senha";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;

            }
            catch
            {
                throw new InvalidExpressionException("Erro ao realizar o login no sistema");
            }
            finally
            {
                conn.Close();
            }
        }
        public long retornaId(String email) {
            try
            {
                long id;
                MySqlDataReader dr;
                String sql = "SELECT codUsuario from usuario WHERE emailUsuario = @email";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@email", email);
                dr = cmd.ExecuteReader();
                id =(long) Convert.ToInt64(dr[0]);
                return id;
            }
            catch
            {
                throw new InvalidExpressionException("Erro ao buscar o id");
            }
            finally{
                conn.Close();
            }
        }
        
    }
}
