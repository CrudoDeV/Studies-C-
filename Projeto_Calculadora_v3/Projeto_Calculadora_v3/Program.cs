using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Calculadora_v3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, r;
            String op;
            Console.WriteLine("Digite o Valor 1");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Valor 2");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Operador");
            op = Console.ReadLine();
            r = 0;
            if (op == "f")
            {
                r = n1 + n2;
            }
            else
            {
                if (op == "-")
                {
                    r = n1 - n2;
                }
                else
                {
                    if (op == "*")
                    {
                        r = n1 * n2;
                    }
                    else
                    {
                        if (op == "/")
                        {
                            if (n2 != 0)
                            {
                                r = n1 / n2;

                            }

                            else
                            {
                                Console.WriteLine("Divisão por 0");
                            }
                        }
                    
                            else{
                            Console.WriteLine("Operador Inválido");
                        }
                        Console.WriteLine("Resultado = {0}", r);
                        Console.Read();
                    }
                }

            }
        }
    }
}

           
