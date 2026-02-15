using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Digite o primeiro numero:");
            n1 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 14; i++)
            {
                Console.WriteLine("Digite outro numero:");
                n2 = int.Parse(Console.ReadLine());
                if (n1 <= n2)
                {
                    n1 = n2;
                }
            }
            Console.WriteLine(n1);
        }
    }
}