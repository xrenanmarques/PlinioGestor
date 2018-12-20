using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model
{
    public class Funcionario : Pessoa
    {
        public string Cargo { get; set; }
        public double Salario { get; set; }
        public DateTime DataContratacao { get; set; }
    }
}
