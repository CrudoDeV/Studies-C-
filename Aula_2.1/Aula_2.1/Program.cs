using System;

namespace Aula_2
{
    class Program
    {
        static void Main(string[] args)
        {

            double volume, raio, altura;
            raio = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Altura");
            altura = double.Parse(Console.ReadLine());
            volume = Math.PI * Math.Pow(raio, 2) * altura;
            Console.WriteLine("volume = {0}", volume);
            Console.ReadLine();

        }
    }

}

