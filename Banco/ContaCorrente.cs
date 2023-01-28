using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco;


    public class ContaCorrente
    {
        public int agencia = 0;
        public string conta = "";
        public string nome = "";
        public double saldo = 0.0;

        public void Depositar(double valor)
        {
            this.saldo += valor;

        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
        if (this.saldo < valor)
            return false;
        else
        {
            this.saldo -= valor;
            destino.saldo += valor;
            return true;
        }
        }

        public bool Sacar(double valor)
        {
            if (valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }
            else
                return false;

        }

    }

