

namespace Criptografiaaps
{

    using System;
    using System.IO;
    using System.Security.Cryptography;
    class ManagedAesSample
    {
        public static void Main()
        {
          
            Console.WriteLine("Digite o texto que precisa ser criptografado...");
            string data = Console.ReadLine();
            EncryptAesManaged(data);
            Console.ReadLine();
        }
        static void EncryptAesManaged(string raw)
        {
            try
            {
                // Cria Aes que gera uma nova chave e vetor de inicialização (IV).
                // Mesma chave deve ser usada na criptografia e descriptografia   
                using (AesManaged aes = new AesManaged())
                {
                    // Criptografar string    
                    byte[] encrypted = Encrypt(raw, aes.Key, aes.IV);
                    // Imprime uma string criptografada    
                    Console.WriteLine("Dados a serem criptografados: {System.Text.Encoding.UTF8.GetString(encrypted)}");
                    // Decriptografa os bytes para uma string.    
                    string decrypted = Decrypt (encrypted, aes.Key, aes.IV);
                    // Imprime uma string decriptografada. Deve ser o mesmo que dados brutos    
                    Console.WriteLine("Dados descriptografados: {decrypted}");
                }}
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            Console.ReadKey();
        }
        static byte[] Encrypt(string plainText, byte[] Key, byte[] IV)
        {
            byte[] encrypted;
            // Cria um novo AesManaged.    
            using (AesManaged aes = new AesManaged())
            {
                // Cria um encriptador    
                ICryptoTransform encryptor = aes.CreateEncryptor(Key, IV);
                // Cria um MemoryStream    
                using (MemoryStream ms = new MemoryStream())
                {
                    // Cria um fluxo de criptografia usando a classe CryptoStream. Esta classe é a chave para criptografia
                    // criptografa e descriptografa dados de qualquer fluxo fornecido. Neste caso, vamos passar um fluxo de memória
                    // para criptografar
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        // Cria StreamWriter e grava dados em um fluxo   
                        using (StreamWriter sw = new StreamWriter(cs))
                            sw.Write(plainText);
                        encrypted = ms.ToArray();
                    }
                }
            }
            // Retorna dados criptografados    
            return encrypted;
        }

        private static string Decrypt(byte[] cipherText, byte[] Key, byte[] IV)
        {
            string plaintext = null;
            // Cria AesManaged    
            using (AesManaged aes = new AesManaged())
            {
                // Cria um decriptador    
                ICryptoTransform decryptor = aes.CreateDecryptor(Key, IV);
                // Cria os fluxos usados ​​para descriptografia.   
                using (MemoryStream ms = new MemoryStream(cipherText))
                {
                    // Criar fluxo de criptografia    
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        // Leia o fluxo de criptografia  
                        using (StreamReader reader = new StreamReader(cs))
                            plaintext = reader.ReadToEnd();
                    }
                }
            }

        }
    }
}

            
        
