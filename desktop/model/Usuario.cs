using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop.model
{
    abstract class Usuario
    {
        public long codUsuario { get; set; }
        public String emailUsuario { get; set; }
        public String senhaUsuario { get; set; }

        public Usuario(long cod, String email, String senha)
        {
            this.codUsuario = cod;
            this.emailUsuario = email;
            this.senhaUsuario = senha;
        }
    }
}
