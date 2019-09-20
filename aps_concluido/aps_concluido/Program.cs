using System;

namespace criptografiaaps
{
    class MainClass
    {
        public static void Main(string[] args)

        {
            String Texto = String.Empty;
            String Tipo;
            Console.WriteLine("");
            Console.WriteLine("\n\nExemplo abaixo da codificação usada;");
            Console.WriteLine("\nTexto original:Descarte Consciente - 20/11/2018 - terça-feira;");
            Console.WriteLine("\nTexto convertido para base64: RGVzY2FydGUgQ29uc2NpZW50ZSAyMC8xMS8yMDE4IC0gVGVyP2EtZmVpcmE= ", Texto);


            Console.WriteLine("Tema do APS: Descarte Consciente");
            Console.WriteLine("Digite o texto a ser Criptografado:  ");
            Texto = Console.ReadLine();
            Texto = Criptografar(Texto);

            Console.WriteLine("Texto Criptografado: {0} ", Texto);
            //Ação criada para gerar uma escolha entre Sim ou Não para Descriptografar o texto.
            Console.WriteLine("Deseja Descriptografar seu Texto? Y or N:");
            Tipo = Console.ReadLine();
            //condição 
            if (Tipo.Equals("Y"))
            {
                Console.WriteLine(Descriptografar(Texto));

            }
            if (Tipo.Equals("n"))
            {
                Console.WriteLine("Obrigado por Utilizar a Aplicação :)");

            }
            Console.ReadLine();
        }

        public static String Criptografar(String valor)
        {//String para Criptografar o texto.
            String chaveCripto;
            Byte[] cript = System.Text.ASCIIEncoding.ASCII.GetBytes(valor);
            chaveCripto = Convert.ToBase64String(cript);
            return chaveCripto;

        }
        public static String Descriptografar(String valor)
        {//String para Descriptografar.
            String chaveCripto;
            Byte[] cript = Convert.FromBase64String(valor);
            chaveCripto = System.Text.ASCIIEncoding.ASCII.GetString(cript);
            return chaveCripto;

        }

    }
}

