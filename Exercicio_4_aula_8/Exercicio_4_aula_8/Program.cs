using System;

namespace Exercicio_4_aula_8
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] B = new int[10];
            int[] v = new int[10];
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o valor {0}", i + 1);

                v[i] = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                    B[i] = v[i] * 5;
                else
                    B[i] = v[i] + 5;

                for (i = 0; i < 10; i++)
                {
                }


            }
        }
    }
}
