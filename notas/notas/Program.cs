using System;

namespace notas
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double n1, n2, n3, media;
            Console.WriteLine("Digite três notas");

            n1 = double.Parse(Console.ReadLine("nota1",n1));
            n2 = double.Parse(Console.ReadLine("nota2",n2));
            n3 = double.Parse(Console.ReadLine("nota3",n3));
            media = (n1 + n2 + n3) / 3;
            Console.ReadLine();


                }
            }


        }
    
