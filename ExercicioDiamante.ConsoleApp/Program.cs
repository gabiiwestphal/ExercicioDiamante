using System;

namespace ExercicioDiamante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            
            Console.WriteLine("Informe um número impar qualquer: ");
            n =int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine(" não é um número ímpar");
            }
                else
            {

                for (int i = 1; i <= n; i++)
                {
                    int espacos;

                    if (i <= (n + 1) / 2)
                    {
                        espacos = (n - 2 * i + 1) / 2;
                    }
                    else
                    {
                        espacos = (2 * i - n - 1) / 2;
                    }

                    int j = 1;
                     // while é igual ao número de espaços que tem antes dos asterísticos mais o número de asterísticos.
                    while (j <= n - espacos)
                    {
                        if (j <= espacos)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                        j++;

                    }
                    Console.Write("\n");
                }
            }

        }
    }
}
