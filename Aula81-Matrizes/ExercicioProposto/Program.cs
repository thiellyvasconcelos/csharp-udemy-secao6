using System;

namespace ExercicioProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Infome um número inteiro: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Infome outro número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            Console.WriteLine();
            Console.WriteLine($"Informe agora {n} números com espaço entre eles e aperte Enter (serão {m} linhas consecutivas): ");

            for (int i = 0; i < m; i++)
            {
                string[] valor = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(valor[j]);
                }
            }
            Console.WriteLine();
            Console.Write("Digite um número inteiro: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Posição do Número {x}: {i},{j}");
                        if (j > 0)
                        {
                            Console.WriteLine($"Número à Esquerda: {mat[i, j - 1]}");
                        }
                        if (i > 0)
                        {
                            Console.WriteLine($"Número Acima: {mat[i - 1, j]}");
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine($"Número à Direita: {mat[i, j + 1]}");
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine($"Número Abaixo: {mat[i + 1, j]}");
                        }
                    }
                }
            }
        }
    }
}