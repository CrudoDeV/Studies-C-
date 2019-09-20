using System;

namespace Calculadora_geral_v1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double n1, n2, res;
            String op;
            Console.WriteLine("Digite um valor");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro valor");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Operação:+,-,*,/");
            op = Console.ReadLine();
            switch (op)
            {
                case "+":
                    res = n1 + n2;
                    Console.WriteLine("{0}+{1}={2}", n1, n2, res);
                    break;
                case "-":
                    res = n1 - n2;
                    Console.WriteLine("{0}-{1}={2}", n1, n2, res);
                    break;
                case "*":
                    res = n1 * n2;
                    Console.WriteLine("{0}*{1}={2}", n1, n2, res);
                    break;
                case "/":
                    if (n2 == 0)
                    {
                        Console.WriteLine("Divisão por zero");
                    }
                    else
                    {
                        res = n1 / n2;
                        Console.WriteLine("{0}/{1}={2}", n1, n2, res);

                    }
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }
            Console.Read();

        }
    }
}
