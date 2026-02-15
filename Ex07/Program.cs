using System;

namespace exerc7
{
    class Program
    {
        static void Main(string[] args)
        {
            int d1, d2, m1, m2;

            Console.WriteLine("que dia a primeira pessoa faz aniversario?");
            d1 = int.Parse(Console.ReadLine());
            Console.WriteLine("que mês a primeira pessoa faz aniversario?");
            m1 = int.Parse(Console.ReadLine());

            Console.WriteLine("que dia a segunda pessoa faz aniversario?");
            d2 = int.Parse(Console.ReadLine());
            Console.WriteLine("que mês a segunda pessoa faz aniversario?");
            m2 = int.Parse(Console.ReadLine());

            if (d1 < d2)
            {
                Console.WriteLine("a primeira pessoa faz aniversario antes");
            }
            if (d1 > d2)
            {
                Console.WriteLine("a segunda pessoa faz aniversario antes");
            }
            if (d1 == d2)
            {
                if (m1 < m2)
                {
                    Console.WriteLine("a primeira pessoa faz aniversario antes");
                }
                if (m1 > m2)
                {
                    Console.WriteLine("a segunda pessoa faz aniversario antes");
                }
            }

        }

    }
}