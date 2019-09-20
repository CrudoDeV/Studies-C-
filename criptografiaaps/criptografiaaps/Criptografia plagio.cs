using System;

namespace criptografiaaps
{
    class MainClass
    {
        public static void Main(string[] args)

        {
            String Texto = String.Empty;
            string Tipo;
            Console.WriteLine("ASCII codificados no formato base64 MIME \n");
            Console.WriteLine("\n\n Exemplo da codificação utilizada;");
            Console.WriteLine("\n1 - Texto original: Olá Mundo;");
            Console.WriteLine("\n2 - Texto convertido para base64: FgfcFCFgc5cgTP=;", Texto);
            Console.WriteLine("\n3 - É Permitido letras e números");

            Console.WriteLine("\r\n\nTema APS: Crescimento econômico e sustentabilidade ambiental no brasil");
            Console.WriteLine("\n\n\nDigite Algo para ser Criptografado:  ");
            Texto = Console.ReadLine();
            Texto = Criptografar(Texto);

            Console.WriteLine("/n/nTexto Criptografado: {0} ", Texto);
            //Ação criada para gerar uma escolha entre S ou N para Descriptografar.
            Console.WriteLine("\n\nDescriptografar Texto? Y or N:");
            Tipo = Console.ReadLine();
            //condição 
            else (Tipo.Equals("Y"))
            {
                Console.WriteLine(Descriptografar(Texto));

            }
            else (Tipo.Equals("N"))
            {
                Console.WriteLine("\n\nObrigado pelo comentário");

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
}

