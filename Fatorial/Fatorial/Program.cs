using System;

namespace Fatorial
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Número a ser fatorado");
            numero = int.Parse(Console.ReadLine());
            int fatorial;
            fatorial = numero;
            for (int i = numero - 1; i > 1;i--){
                fatorial *= i;
            }
            Console.WriteLine("Valor total do fatorial:" + fatorial);
            Console.Read();


        }
    }
}
