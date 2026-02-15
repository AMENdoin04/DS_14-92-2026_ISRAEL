using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Digite o primeiro numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            n2 = int.Parse(Console.ReadLine());
    

           if (n1 % 2 == 0)
           {
                n1 = n1 + 1;
           }
            while (n1 <= n2)
            {
                
                Console.WriteLine(n1);
                n1 = n1 + 2;
                
            }
        }
    }
}