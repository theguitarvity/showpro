using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop.model
{
    class Funcionario : Usuario
    {

        #region atributos
        public String nomeFuncionario { get; set; }
        public String cpfFuncionario { get; set; }
        public DateTime dataNascFuncionario { get; set; }
        public DateTime dataInicioFuncionario { get; set; }
        public String cargoFuncionario { get; set; }
        #endregion


        #region construtor
        public Funcionario(long cod, string email, string senha, string nome, string cpf, DateTime dtNasc, DateTime dtIni, string cargo) : base(cod, email, senha)
        {
            base.codUsuario = cod;
            base.emailUsuario = email;
            base.senhaUsuario = senha;
            this.nomeFuncionario = nome;
            this.cpfFuncionario = cpf;
            this.dataInicioFuncionario = dtIni;
            this.dataNascFuncionario = dtNasc;
            this.cargoFuncionario = cargo;
        }

        #endregion



    }
}
