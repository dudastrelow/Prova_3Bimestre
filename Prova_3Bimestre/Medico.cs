using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_3Bimestre
{
    internal class Medico : Funcionarios
    {
        public string CRM { get; set; }
        public double ValorHora { get; set; }
        public string Especialidade { get; set; }

        public Medico()
        {

        }
        public Medico(string cRM, double valorHora, string especialidade, string nome, string cpf, int matricula, DateOnly dataNascimento, string sexo, double salario) : base(nome, cpf, matricula, dataNascimento, sexo, salario)
        {
            CRM = cRM;
            ValorHora = valorHora;
            Especialidade = especialidade;
        }

        public double SalarioTotal()
        {
            return Salario * 0.22 + Salario;
        }
    }
}
