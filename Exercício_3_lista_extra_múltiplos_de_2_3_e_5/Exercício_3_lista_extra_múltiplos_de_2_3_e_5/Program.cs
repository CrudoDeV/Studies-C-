using System;

namespace Exercício_3_lista_extra_múltiplos_de_2_3_e_5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n1;

            Console.WriteLine("Digite um número");
            n1 = int.Parse(Console.ReadLine());

            if (n1 % 2 == 0 && n1 % 3 == 0 && n1 % 5 == 0)
            {
                Console.WriteLine("O número é múltiplo de 2,3,5");
            }
            else
            {
                if (n1 % 3 == 0 && n1 % 5 == 0)
                {
                    Console.WriteLine("O número é múltiplo de 3,5");

                }

                if (n1 % 2 == 0 && n1 % 5 == 0){
                    Console.WriteLine("O número é múltiplo de 2,5");

                }
                if (n1%2==0 && n1%3==0) {
                    Console.WriteLine("O número é múltiplo de 2,3");

                }
                if (n1%2==0) {
                    Console.WriteLine("O número é múltiplo de 2");

                }
                if (n1%3==0) {
                    Console.WriteLine("O número é múltiplo de 3");

                }
                if (n1%5==0) {
                    Console.WriteLine("O número é múltiplo de 5");

                }
                if (n1%5==1 && n1%3==1 && n1%2==1){
                    Console.WriteLine("Error 0x00000000100111010101010");
                }
                Console.ReadLine();






            }
        }
    }
}
