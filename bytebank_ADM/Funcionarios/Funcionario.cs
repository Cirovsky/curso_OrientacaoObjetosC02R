using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }

        internal double bonus;
        public Funcionario(string nome, string cpf, double salario) {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Salario = salario;
            bonus = 0.1;
        }

        internal double pegarBonificacao()
        {
            return this.Salario * this.bonus;
        }

        public override string ToString()
        {
            return "[nome: " + Nome + ", cpf: " + Cpf + ", salario: R$" + (Salario + pegarBonificacao()) + "]";
        }
    }
}
