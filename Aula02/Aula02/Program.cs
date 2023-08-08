using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Escrava a idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Acompanhado [false]Não - [true]Sim");
            bool acom = bool.Parse(Console.ReadLine());
            if(idade>=18 || idade<18 && acom == true)
            {
                Console.WriteLine("Pode entrar");
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }*/
            /*for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }*/
            Console.WriteLine("Escreva um número: ");
            int num = int.Parse(Console.ReadLine());
            int i = 0;
            /*for(i = 1; i<=10; i++)
            {
                Console.WriteLine(num + " X " + i + " = " + num * i);
            }*/
            /*while (i <= 10)
            {
                Console.WriteLine(num + " X " + i + " = " + num * i);
                i++;
            }*/
            do
            {
                Console.WriteLine(num + " X " + i + " = " + num * i);
                i++;
            } while (i <= 10);

            Console.ReadLine();
        }
    }
}
