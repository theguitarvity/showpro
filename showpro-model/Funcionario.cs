using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showpro_model
{
    class Funcionario : Usuario
    {
        private String nomeFuncionario;
        private String cpfFuncionario;
        private DateTime dataNascFuncionario;
        private DateTime dataInicioFuncionario;
        private String cargoFuncionario;

        public Funcionario(int codUsuario, string emailUsuario, string senhaUsuario, string nome, string cpf, DateTime dataNasc, DateTime dataIncio, string cargo) : base(codUsuario, emailUsuario, senhaUsuario)
        {
            this.nomeFuncionario = nome;
            this.cpfFuncionario = cpf;
            this.dataNascFuncionario = dataNasc;
            this.dataInicioFuncionario = dataIncio;
            this.cargoFuncionario = cargo;
        }
    }
}
