using System;
using Prova_3Bimestre;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo ao GuruDev!\n");
        List<Funcionarios> listaFuncionarios = new List<Funcionarios>();
        List<Medico> listaMedico = new List<Medico>();
        List<Administrativo> listaAdministrativo = new List<Administrativo>();

        while (true)
        {
            Console.WriteLine("\nSelecione uma opção!");
            Console.WriteLine("1 - Cadastrar um novo Funcionario");
            Console.WriteLine("2 - Visualizar funcionarios");
            Console.WriteLine("3 - Sair");
            int escolha = Convert.ToInt32(Console.ReadLine());    
            
            if(escolha == 1)
            {
                Console.WriteLine("\nInforme o Nome do funcionario");
                string nome = Console.ReadLine();
                Console.WriteLine("\nInforme o Cpf do funcionario");
                string cpf = Console.ReadLine();
                Console.WriteLine("\nInforme a matricula do funcionario");
                int matricula = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nInforme a data de nascimento do funcionario");
                string dataNascimento = Console.ReadLine();
                DateOnly dataNascimento1 = DateOnly.Parse(dataNascimento);
                Console.WriteLine("\nInforme o sexo do funcionario");
                string sexo = Console.ReadLine();
                Console.WriteLine("\nInforme o salario do funcionario");
                double salario = Convert.ToDouble(Console.ReadLine());         

                Console.WriteLine("\nQual o tipo de funcionario?");
                Console.WriteLine("1 - Medico");
                Console.WriteLine("2 - Administrativo");
                Console.WriteLine("3 - Nenhum");
                int escolha2 = Convert.ToInt32(Console.ReadLine());
            
                    if (escolha2 == 1)
                    {                       
                        Console.WriteLine("\nInforme o CRM do funcionario");
                        string cRM = Console.ReadLine();
                        Console.WriteLine("\nInforme o valor extra do funcionario");
                        double valorHora = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\nInforme a especialidade do funcionario");
                        string especialidade = Console.ReadLine();
                        
                        Medico m = new Medico(cRM, valorHora, especialidade, nome, cpf, matricula, dataNascimento1, sexo, salario);
                        listaMedico.Add(m);
                        
                    }
                    if (escolha2 == 2)
                    {          
                        Console.WriteLine("\nInforme a função do funcionario");
                        string funcao = Console.ReadLine();
                        
                        Administrativo a = new Administrativo(funcao, nome, cpf, matricula, dataNascimento1, sexo, salario);
                        listaAdministrativo.Add(a);
                        
                    }                  
                    if (escolha2 == 3)
                    {
                        Funcionarios f = new Funcionarios(nome, cpf, matricula, dataNascimento1, sexo, salario);
                        listaFuncionarios.Add(f);                      
                    }
                    if(escolha != 1 && escolha != 2 && escolha != 3)
                    {
                        Console.WriteLine("\nErro, escolha outra opção");
                    }          
            }
            if(escolha == 2)
            {
                Console.WriteLine("Funcionarios com mais de 2000 reais de salario");
                foreach (Funcionarios f1 in listaFuncionarios)
                {
                    if(f1.Salario > 2000.00)
                    {
                        Console.WriteLine($"\nNome: {f1.Nome}\nCpf: {f1.Cpf}\nMatricula: {f1.Matricula}\nData de nascimento: {f1.DataNascimento}\nSexo: {f1.Sexo}\nSalario: {f1.Salario}");
                    }
                }
                foreach (Medico m1 in listaMedico)
                {
                    if (m1.SalarioTotal() > 2000.00)
                    {
                        Console.WriteLine($"\nNome: {m1.Nome}\nCpf: {m1.Cpf}\nMatricula: {m1.Matricula}\nData de nascimento: {m1.DataNascimento}\nSexo: {m1.Sexo}\nCRM: {m1.CRM}\nValor por hora: {m1.ValorHora}\nEspecialidade: {m1.Especialidade}\nSalario total: {m1.SalarioTotal()}");
                    }
                }
                foreach (Administrativo a1 in listaAdministrativo)
                {
                    if (a1.SalarioTotal() > 2000.00)
                    {
                        Console.WriteLine($"\nNome: {a1.Nome}\nCpf: {a1.Cpf}\nMatricula: {a1.Matricula}\nData de nascimento: {a1.DataNascimento}\nSexo: {a1.Sexo}\nFuncao: {a1.Funcao}\nSalario total: {a1.SalarioTotal()}");
                    }

                }
            }
            if(escolha == 3)
            {
                Console.WriteLine("Obrigado por usar este programa!");
                break; ;
            }
            if (escolha != 1 && escolha != 2 && escolha != 3)
            {
                Console.WriteLine("Erro, escolha outra opção");
            }
        }
    }
}