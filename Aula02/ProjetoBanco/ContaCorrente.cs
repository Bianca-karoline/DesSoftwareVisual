using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    public class ContaCorrente
    {
        public string titular;
        public int numero;
        public int agencia;
        public double saldo;

        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                Console.WriteLine("Saldo indisponivel");
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine("Deposito realizado com sucesso");
            }
            else
            {
                Console.WriteLine("Deposito invalido");
            }
        }
    }
}
