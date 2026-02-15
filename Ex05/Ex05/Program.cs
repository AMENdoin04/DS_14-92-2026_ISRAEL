using System;

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            int pos = 0, neg = 0, imp = 0, par = 0, n1;
            bool loop = true;
            string resp;

            while (loop)
            {
                Console.WriteLine("Digite um numero:");
                n1 = int.Parse(Console.ReadLine());

                if (n1 > 0)
                {
                    pos++;
                }

                if (n1 < 0)
                {
                    neg++;
                }

                if (n1 % 2 == 0)
                {
                    par++;
                }

                else
                {
                    imp++;
                }

                Console.WriteLine("Voce deseja parar o programa? (sim ou nao)");
                resp = Console.ReadLine();

                if (resp == "sim")
                {
                    loop = false;
                }

            }

            Console.WriteLine("Voce digitou {0} numeros impar, {1} numeros pares, {2} numeros negativos e {3} numeros positivos", imp, par, neg, pos);

        }
    }
}