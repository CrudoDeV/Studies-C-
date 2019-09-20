using System;

namespace tabuada_de_qualquer_numero
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int i, n;
            Console.WriteLine("Digite um número");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= 10;i++) {
                Console.WriteLine("{0}*{1}={2}", n, i, n * i);

            }
            Console.Read();
        }
    }
}
