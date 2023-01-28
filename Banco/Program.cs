using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();
            conta1.nome = "Amanda";
            conta1.conta = "2055-X";
            conta1.agencia = 5;
            conta1.saldo = 664.20;

            ContaCorrente conta2 = new ContaCorrente();
            conta2.nome = "João";
            conta2.conta = "1037-X";
            conta2.agencia = 12;
            conta2.saldo = 1210.98;

            conta2.Transferir(1000,conta1);
            Console.WriteLine("O novo saldo da conta 1 é:R$"+ conta1.saldo);
            Console.WriteLine("O novo saldo da conta 2 é:R$"+ conta2.saldo);

            Console.ReadKey();
        }
        
    }
}
