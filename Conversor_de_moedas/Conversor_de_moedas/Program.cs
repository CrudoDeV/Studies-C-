using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            float US, RS, conversao;
            Console.WriteLine("Digite o valor desejado para conversão.");
            conversao = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor em dólar");
            US = float.Parse(Console.ReadLine());
            RS = conversao * US;
            Console.WriteLine("Valor em Reais {0}", RS);
            Console.ReadLine();

        }
    }
}