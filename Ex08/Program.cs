using System;

namespace exerc8
{
    class Program
    {
        static void Main(string[] args)
        {
            int car, sa, na, diff;
            double a;
            Console.WriteLine("qual é o código do seu cargo?");
            car = int.Parse(Console.ReadLine());
            Console.WriteLine("qual é o seu salario antigo?");
            sa = int.Parse(Console.ReadLine());
            switch (car)
            {
                case 101:
                    Console.WriteLine("você é um administrador");
                    a = sa * 0.80;
                    na = (int)(a + sa);
                    diff = na - sa;
                    Console.WriteLine("o seu salario antigo é:" + sa + "!!");
                    Console.WriteLine("o seu salario novo é:" + na + "!!");
                    Console.WriteLine("a diferença entre seus salarios é:" + diff + "!!");
                    break;
                case 102:
                    Console.WriteLine("você é um engennheiro");
                    a = sa * 0.65;
                    na = (int)(a + sa);
                    diff = na - sa;
                    Console.WriteLine("o seu salario antigo é:" + sa + "!!");
                    Console.WriteLine("o seu salario novo é:" + na + "!!");
                    Console.WriteLine("a diferença entre seus salarios é:" + diff + "!!");
                    break;
                case 103:
                    Console.WriteLine("você é um médico");
                    a = sa * 0.60;
                    na = (int)(a + sa);
                    diff = na - sa;
                    Console.WriteLine("o seu salario antigo é:" + sa + "!!");
                    Console.WriteLine("o seu salario novo é:" + na + "!!");
                    Console.WriteLine("a diferença entre seus salarios é:" + diff + "!!");
                    break;
                case 104:
                    Console.WriteLine("você é um outro cargo");
                    a = sa * 0.55;
                    na = (int)(a + sa);
                    diff = na - sa;
                    Console.WriteLine("o seu salario antigo é:" + sa + "!!");
                    Console.WriteLine("o seu salario novo é:" + na + "!!");
                    Console.WriteLine("a diferença entre seus salarios é:" + diff + "!!");
                    break;
            }
        }
    }
}