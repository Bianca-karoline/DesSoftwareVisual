using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente c1 = new ContaCorrente();
            c1.titular = "12345678900";
            c1.saldo = 100;
            Console.WriteLine("Digite um valor para sacar");
            c1.Sacar(double.Parse(Console.ReadLine()));
            Console.WriteLine(c1.saldo);
            c1.Depositar(30);
            Console.WriteLine(c1.saldo);
            Console.ReadLine();
            
        }
    }
    
}
