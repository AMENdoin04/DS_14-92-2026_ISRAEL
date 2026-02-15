using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Digite o primeiro numero:");
            n1 = int.Parse(Console.ReadLine());
            
            if (n1 < 0 || n1 > 10)
            {
                Console.WriteLine("Os numeros devem estar entra 0 e 10, ouve um ERRO, o numero sera 0");
                n1 = 0;
            }
            
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine("Digite outro numero:");
                n2 = int.Parse(Console.ReadLine());
                if ((n2 < 0 || n2 > 10))
                {
                    Console.WriteLine("Os numeros devem estar entra 0 e 10, ouve um ERRO, o numero sera 0");
                    n2 = 0;
                    n1 = n1 + 0;
                }
                else
                {
                    n1 = n1 + n2;
                }
                
            }

            Console.WriteLine(n1/10);
        }
    }
}