using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente c1 = new ContaCorrente();
            ContaCorrente c2 = new ContaCorrente();
            c1.saldo = 100;
            c2.saldo = 20;
            c1.Pix(c2, 10);
            Console.WriteLine(c2.saldo);
            Console.ReadLine();
            
        }
    }
}
