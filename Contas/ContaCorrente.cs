using bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        private int numero_agencia;

        public int Numero_agencia
        {
            get { return numero_agencia; }
            private set
            {
                if (value > 0)
                {
                    this.numero_agencia = value;
                }
            }
        }

        public string Conta { get; set; }

        private double saldo;

        public Cliente titular;

        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
                this.saldo = valor;
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public static int TotalDeContasCriadas { get; private set; }

        public ContaCorrente(int numero_agencia, string numero_conta)
        {
            this.Numero_agencia = numero_agencia;
            this.Conta = numero_conta;
            TotalDeContasCriadas++;
        }

        public void Depositar(double valor)
        {
            saldo += valor;

        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }
    }
}
