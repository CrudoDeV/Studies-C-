using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            float f, c, temper;
            Console.WriteLine("Qual temperatura para conversão em Fahreinheit?");
            c = float.Parse(Console.ReadLine());
            f = (9 * c + 160) / 5;
            Console.WriteLine("O valor em Fahreinheit é {0}", f);
            Console.Read();



        }
    }
}