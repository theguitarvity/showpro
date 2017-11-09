using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
