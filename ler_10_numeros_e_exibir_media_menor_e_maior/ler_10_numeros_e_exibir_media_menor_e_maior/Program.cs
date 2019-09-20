using System;

namespace ler_10_numeros_e_exibir_media_menor_e_maior
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int i,n,soma,maior,menor,media;

            soma = 0;
            maior = 0;
            menor = 0;
            for (i = 1; i <= 10;i++){
                Console.WriteLine("Digite um número");
                n = int.Parse(Console.ReadLine());
                if (i==1){
                    maior = n;
                    menor = n;

                }
                if(n> maior){
                    maior = n;
                }
                if(n< menor){
                    menor = n;
                }
                soma = soma + n;
            }
            media = soma / 10;
            Console.WriteLine("media ={0}", media);
            Console.WriteLine("maior {0} e menor ={1}", maior, menor);
            Console.Read();

      

        }
    }
}
