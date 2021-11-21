using System;
using System.Threading;

namespace Patinhos
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdpatinhos,c;

            Console.Clear();
            Console.Beep();

            inicio:
            Console.Write("Quantos patinhos? : ");
            qtdpatinhos = int.Parse(Console.ReadLine());

            c = qtdpatinhos;

            if(c < 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Digite pelo menos 2 patinhos");
                Console.ResetColor();
                goto inicio;
            }
            else
            {
                while(c>=1)
                {
                    if(c > 2)
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine($"\n{c} patinhos foram passear " +
                        "\nAlém das montanhas Para brincar " +
                        "\nA mamãe gritou: Quá, quá, quá, quá " +
                        $"\nMas só {c-1} patinhos voltaram de lá. ");
                    }

                    else if(c == 2)
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine($"\n{c} patinhos foram passear " +
                        "\nAlém das montanhas Para brincar " +
                        "\nA mamãe gritou: Quá, quá, quá, quá " +
                        $"\nMas só {c-1} patinho voltou de lá. ");
                    }
                    else if(c == 1)
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine($"\n{c} patinho foi passear " +
                        "\nAlém das montanhas Para brincar " +
                        "\nA mamãe gritou: Quá, quá, quá, quá " +
                        $"\nMas nenhum patinho voltou de lá. ");
                    }
                c--;
                }
                Thread.Sleep(1000);
                Console.WriteLine("\nA mamãe patinha foi procurar" +
                "\nAlém das montanhas Na beira do mar" +
                "\nA mamãe gritou: Quá, quá, quá, quá" +
                $"\nE os {qtdpatinhos} patinhos voltaram de lá.");
            }
            
        }
    }
}
