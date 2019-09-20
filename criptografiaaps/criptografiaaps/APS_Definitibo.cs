using System;

namespace criptografiaaps
{
    class MainClass
    {
        public static void Main(string[] args)

        {
            String Texto = String.Empty;
            String Tipo;
            Console.WriteLine("ASCII codificados no formato base64 MIME");
            Console.WriteLine("Exemplo da codificação utilizada;");
            Console.WriteLine(" 1 - Texto original:Descarte Consciente 20/11/2018 - Terça-feira;");
            Console.WriteLine(" 2 - Texto convertido para base64:RGVzY2FydGUgQ29uc2NpZW50ZSAyMC8xMS8yMDE4IC0gVGVyP2EtZmVpcmE=  ;", Texto);
            Console.WriteLine(" 3 - É Permitido letras e números");

            Console.WriteLine("Tema APS:Descarte Consciente");
            Console.WriteLine("Digite o Texto a ser Criptografado:  ");
            Texto = Console.ReadLine();
            Texto = Criptografar(Texto);

            Console.WriteLine("Texto Criptografado: {0} ", Texto);
            //Ação criada para gerar uma escolha entre Sim ou Não para Descriptografar o texto.
            Console.WriteLine("Deseja Descriptografar o seu texto? Y or n:");
            Tipo = Console.ReadLine();
            //condição 
            if (Tipo.Equals("Y"))
            {
                Console.WriteLine(Descriptografar(Texto));


            }
            if (Tipo.Equals("N"))
            {
                Console.WriteLine("Obrigado por utilizar a aplicação");

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

