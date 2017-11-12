using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop.model.dao
{
    class OrganizadorDAO
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;

        public void inserirOrganizador(Organizador fun)
        {
            FuncionarioDAO funDao = new FuncionarioDAO();
            conn = new ConnectionFactory().getConnection();
            try
            {
                Funcionario funcionario = new Funcionario(fun.codUsuario, fun.emailUsuario, fun.senhaUsuario, fun.nomeFuncionario, fun.cpfFuncionario, fun.dataNascFuncionario, fun.dataInicioFuncionario, fun.cargoFuncionario);
                funDao.inserir(funcionario);
                string sql = "INSERT INTO organizador VALUES(@cod, @privi)";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cod", fun.codUsuario);
                cmd.Parameters.AddWithValue("@privi", fun.privilegio);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException erro)
            {
                throw new System.Data.InvalidExpressionException(erro.Message);
            }
            finally
            {

            }
        }

    }
}
