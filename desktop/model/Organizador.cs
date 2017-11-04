using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop.model
{
    class Organizador:Funcionario
    {
        public string privilegio { get; set; }
        public Organizador(long cod, string email, string senha, string nome, string cpf, DateTime dtNasc, DateTime dtIni, string cargo, string privilegio) : base(cod, email, senha, nome, cpf, dtNasc, dtIni, cargo)
        {
            base.codUsuario = cod;
            base.emailUsuario = email;
            base.senhaUsuario = senha;
            base.nomeFuncionario = nome;
            base.cpfFuncionario = cpf;
            base.dataInicioFuncionario = dtIni;
            base.dataNascFuncionario = dtNasc;
            base.cargoFuncionario = cargo;
            this.privilegio = privilegio;
        }
    }
}
