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

        
        public void insertUser(Funcionario fun) {
            conn = new ConnectionFactory().getConnection();
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
                throw new InvalidExpressionException(erro.Message);

            }
            finally {
                

            }
        }
        public void inserir(Funcionario fun) {
            conn = new ConnectionFactory().getConnection();
            try
            {
                
                insertUser(fun);
                string sql = "INSERT INTO funcionario(codFuncionario, nomeFuncionario, cpfFuncionario, dataNascimento, dataInicio, cargoFuncionario) values(@cod, @nome, @cpf, @dtNasc, @dtIni, @cargo)";
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
            catch(MySqlException e)
            {
                throw new InvalidExpressionException(e.Message);
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
        public List<Funcionario> listar() {
            conn = new ConnectionFactory().getConnection();
            try
            {
                List<Funcionario> funcionarios = new List<Funcionario>();
                MySqlDataReader dr;
                String sql = "select codUsuario, emailUsuario, senhaUsuario, nomeFuncionario, cpfFuncionario, dataNascimento, dataInicio, cargoFuncionario from usuario, funcionario where funcionario.codFuncionario = usuario.codUsuario;";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Funcionario fun = new Funcionario();
                    fun.codUsuario = Convert.ToInt64(dr[0]);
                    fun.emailUsuario = Convert.ToString(dr[1]);
                    fun.senhaUsuario = Convert.ToString(dr[2]);
                    fun.nomeFuncionario = Convert.ToString(dr[3]);
                    fun.cpfFuncionario = Convert.ToString(dr[4]);
                    fun.dataNascFuncionario = Convert.ToDateTime(dr[5]);
                    fun.dataInicioFuncionario = Convert.ToDateTime(dr[6]);
                    fun.cargoFuncionario = Convert.ToString(dr[7]);
                    funcionarios.Add(fun);

                }
                return funcionarios;
            }
            catch (MySqlException erro)
            {
                throw new InvalidExpressionException(erro.Message);
            }
        }
    }
}
