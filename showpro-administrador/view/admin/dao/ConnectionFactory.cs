using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showpro.model.dao
{
    class ConnectionFactory
    {
        private MySqlConnection conn;

        public MySqlConnection getConnection()
        {
            try
            {
                conn = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=showpro;allowuservariables=True");
                conn.Open();
                return conn;

            }
            catch (MySqlException erro)
            {
                throw new NullReferenceException("Banco de dados não encontrado");
            }
        }
    }
}
