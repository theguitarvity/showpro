using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showpro_model
{
    abstract class Usuario
    {
        private int codUsuario;
        private String emailUsuario;
        private String senhaUsuario;

        public Usuario(int codUsuario, String emailUsuario, String senhaUsuario) {
            this.codUsuario = codUsuario;
            this.emailUsuario = emailUsuario;
            this.senhaUsuario = senhaUsuario;
        }

    }
}
