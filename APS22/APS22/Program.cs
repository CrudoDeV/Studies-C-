using System;
using System.Security.Cryptography;
using System.Text;

namespace APS22
{
   
            class Program
        {
            static void Main(string[] args)
            {
                //1ª forma
                const string chavePublica = "<RSAKeyValue><Modulus>0T+cB1Xbnz3GhopJhmopF0UBStuREv6fQ6OQQVnietwlXIMjSVQLrrRRNK/fPw9dtn" +
                                            "U15641copbWG7CC1ggCxpT8W4evi0iyjQva7hjS8ZCG2a/zABlnbu9t3Oa+FFfpjRB0G2qZDpbpU+PS99rRVtSUj2slcN" +
                                            "RTZWI1qSTaCk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";



                var texto = Encoding.UTF8.GetBytes("usuariosenha");

                using (var rsa = new RSACryptoServiceProvider())
                {
                    try
                    {
                        rsa.FromXmlString(chavePublica);
                        var encryptedData = rsa.Encrypt(texto, false);

                        //Base64
                        //var base64Encrypted = Convert.ToBase64String(encryptedData);
                        //Console.WriteLine(base64Encrypted);

                        //Hex
                        var sb = new StringBuilder();
                        foreach (var b in encryptedData)
                            sb.Append(b.ToString("X2"));

                        Console.WriteLine(sb.ToString());

                    }
                    finally
                    {
                        rsa.PersistKeyInCsp = false;
                    }

                }
            }
        }
    }

