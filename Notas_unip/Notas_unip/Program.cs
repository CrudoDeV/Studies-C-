using System;

namespace Notas_unip
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double np1, np2, aps,media;
            Console.WriteLine("Digite a nota da NP1");
            np1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota da NP2");
            np2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota da APS");
            aps = double.Parse(Console.ReadLine());
            if (np1 >10 || np1 <0 || np2 >10 || np2 <0 || aps>10 || aps <0) {
                Console.WriteLine("ERROR System 32 Time");
            }
            else {

                media = (np1 + np2 + aps) / 3;
            if (media >= 7 )
            {
                Console.WriteLine("Você está APROVADO");
            }
            else if (media >=3 && media <=7) {
                Console.WriteLine("Você está de EXAME");
            }
           
            if (media <3) {
                Console.WriteLine("VocÊ está REPROVADO");
            }

            
            }
            Console.ReadLine();
           






        }
    }
}
