using System;

namespace Calcular_quadrado_de_um_numero
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n,cont,soma,x;
            soma = 0;
            x = 1;
            Console.Write("Digite um numero para calular o quadrado:");
            n = int.Parse(Console.ReadLine());
            for (cont = 1; cont <= n;cont++){
                soma = soma + x;
                x = x + 2;

            }
            Console.Write("O numero ao quadrado de {0} é {1}",n, soma);
            Console.Read();






            }

        }
    }

