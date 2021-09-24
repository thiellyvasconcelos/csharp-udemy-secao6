using System;

namespace Pensao
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vetor = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            int qnt = int.Parse(Console.ReadLine());

            for(int i = 1; i <= qnt; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vetor[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for(int i = 1; i < 10; i++)
            {
                if(vetor[i] != null) 
                {
                    Console.WriteLine($"Quarto: {i}, {vetor[i]}");
                }
            }
        }
    }
}
