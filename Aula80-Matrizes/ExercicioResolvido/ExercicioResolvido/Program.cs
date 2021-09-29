using System;

namespace ExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Informe os {n} valores em uma mesma linha, separando apenas por um espaço entre eles:");

            int[,] mat = new int[n, n];
            for(int i = 0; i < n; i++)
            {
                string[] coluna = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(coluna[j]);
                }
            }

            Console.WriteLine("Diagonal principal: ");
            for (int i = 0; i< n; i++)
            {
                Console.Write($"{mat[i,i]} ");
            }
            Console.WriteLine();

            int valornegativo = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        valornegativo++;
                    }
                }
            }
            Console.WriteLine($"Números negativos contidos na Matriz: {valornegativo}");
        }
    }
}