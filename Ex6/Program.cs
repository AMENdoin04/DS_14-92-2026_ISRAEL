using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            string loop = "N";
            while (loop.ToUpper() != "S")

            {
                Console.WriteLine("Digite o numero de horas trabalhadas?");
                int N =
                int.Parse(Console.ReadLine());
                int horasNormais = N;
                int E = 0;

                if (N > 50) ;
                {
                    E = N - 50;
                    N = 50;

                }

                double SN = N * 10;
                double SE = E * 20;
                double ST = SN + SE;

                Console.WriteLine("\nSalario total: R$ " + ST);
                Console.WriteLine("\nSalario excedente: R$ " + SE);
                Console.WriteLine("\nDeseja encerrar o programa? (S/N):");
                loop = Console.ReadLine();
                Console.WriteLine();
            }
        }
    }
}