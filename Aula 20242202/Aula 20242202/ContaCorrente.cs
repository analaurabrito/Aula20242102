using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_20242202
{
    internal class ContaCorrente
    {
        private Proprietario proprietario;
        public double saldo { get; private set; }
        private string log { get; set; }

        public ContaCorrente(Proprietario proprietario, double saldo)
            {
            this.proprietario = proprietario;
            this.saldo = saldo;
            this.log = "EXTRATO DE "+this.proprietario+ "\n";
        }

        public Boolean Sacar(double valor_saque)
        {
            if (saldo >= valor_saque)
            {
                saldo =- valor_saque;
                Console.WriteLine("Saque realizado.\n");
                this.log += "\nSaque realizado no valor " +valor_saque.ToString();
                return true;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.\n");
                this.log += "\nTentativa de Saque mal sucedida".ToString();
                return false;
            }
        }

        public Boolean Depositar(double valor_deposito)
        {
            saldo =+ valor_saque;
            Console.WriteLine("Deposito realizado.");
            this.log += "\Deposito realizado no valor " + valor_saque.ToString();
            return true;
        }

    }
}
