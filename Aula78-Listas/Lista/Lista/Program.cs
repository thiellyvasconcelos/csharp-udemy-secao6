using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de funcionários: ");
            int qnt = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Funcionario> list = new List<Funcionario>();
            
            for (int i = 1; i <= qnt; i++)
            {
                Console.WriteLine($"Funcionário {i}");
                Console.Write($"Id do funcionário: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write($"Nome do funcionário: ");
                string nome = Console.ReadLine();
                Console.Write("Salário atual do funcionário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Digite o Id do funcionário que deseja aumentar o salário: ");
            int buscaId = int.Parse(Console.ReadLine());

            // Expressão Lambda, cujo vai identificar na lista se o Id informado anteriormente existe
            Funcionario func = list.Find(x => x.Id == buscaId);
            if( func != null)
            {
                Console.Write("Digite a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.IncrementarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("O Id informado não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de funcionários atualizada - ");
            foreach(Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
