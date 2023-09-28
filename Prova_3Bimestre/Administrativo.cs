using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_3Bimestre
{
    internal class Administrativo : Funcionarios
    {
        public string Funcao { get; set; }
        public Administrativo()
        {

        }
        public Administrativo(string funcao, string nome, string cpf, int matricula, DateOnly dataNascimento, string sexo, double salario) : base(nome, cpf, matricula, dataNascimento, sexo, salario)
        {
            this.Funcao = funcao;
        }
        public double SalarioTotal()
        {
            return Salario * 0.17 + Salario + 250;
        }

    }
}
