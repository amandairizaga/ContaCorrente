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
    

            // cria um objeto conta1 para atribuir os valores relacionados
            // a classe ContaCorrente
            ContaCorrente conta1 = new ContaCorrente();
            conta1.conta = "2055-X";
            conta1.agencia = 5;
            conta1.saldo = 664.20;
            conta1.titular.nomeTitular = "José";
            conta1.titular.cpfTitular = "555.321.467-00";
            conta1.titular.profissaoTitular = "Marceneiro";
            conta1.titular = new Cliente();
            // adiciona ao atributo titular (da classe ContaCorrente)
            // o objeto pessoa2, que possui os valores relacionados a classe Cliente

            Console.WriteLine(conta1.titular.nomeTitular);

   
            ContaCorrente conta2 = new ContaCorrente();
            conta2.titular = new Cliente();
            conta2.titular.nomeTitular = "Amanda";
            conta2.titular.cpfTitular = "555-000-345-28";
            conta2.titular.profissaoTitular = "Professora";
            conta2.conta = "1037-X";
            conta2.agencia = 12;
            conta2.saldo = 1210.98;
            

            conta2.Transferir(1000, conta1);
            //Console.WriteLine("O novo saldo da conta 1 é:R$" + conta1.saldo);
            //Console.WriteLine("O novo saldo da conta 2 é:R$" + conta2.saldo);

            Cliente pessoa = new Cliente();
            pessoa.nomeTitular = "Zé";
            pessoa.profissaoTitular = "Motorista";
            pessoa.cpfTitular = "087.634.125-00";

            ContaCorrente conta3= new ContaCorrente();
            conta3.conta = "1020";
            conta3.agencia = 51;
            conta3.saldo = 590.25;

            conta3.titular = pessoa;

            Console.WriteLine("Quem é: "+ conta3.titular.nomeTitular);



            Console.ReadKey();
        }

    }
}
