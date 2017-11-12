using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop.model.dao
{
    class AdministradorDAO
    {
        private MySqlCommand cmd;
        private MySqlConnection conn;



        public void insert(Administrador fun) {
            FuncionarioDAO funDao = new FuncionarioDAO();
            conn = new ConnectionFactory().getConnection();
            try
            {
                Funcionario funcionario = new Funcionario(fun.codUsuario, fun.emailUsuario, fun.senhaUsuario, fun.nomeFuncionario, fun.cpfFuncionario, fun.dataNascFuncionario, fun.dataInicioFuncionario, fun.cargoFuncionario);
                funDao.inserir(funcionario);
                string sql = "INSERT INTO administrador VALUES(@cod, @privi)";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cod", fun.codUsuario);
                cmd.Parameters.AddWithValue("@privi", fun.privilegio);
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
