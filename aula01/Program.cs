using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula01
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ola Mundo!");
            Console.WriteLine("Digite um valor: ");
            int num;
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("O numero é par");
            }
            else {
                Console.WriteLine("O numero é impar");
            }
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Digite um valor de saque");
            int notas = int.Parse(Console.ReadLine());
            int qtd = 0;
            int x = 100;
            while(true)
            {
                if(notas >= x)
                {
                    qtd += 1;
                    notas -= x;
                }
                else
                {
                    Console.WriteLine("Notas de " + x + ": " + qtd);
                    if(x == 100)
                    {
                        x = 50;
                        qtd = 0;
                    }else 
                    {
                        if(x == 50)
                        {
                            x = 20;
                            qtd = 0;
                        }
                        else
                        {
                            if(x == 20)
                            {
                                x = 5;
                                qtd = 0;
                            }
                            else
                            {
                                if (x == 5)
                                {
                                    x = 2;
                                    qtd = 0;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
