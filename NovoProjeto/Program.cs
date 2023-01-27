
using NovoProjeto;
using System.Runtime.CompilerServices;

ContaCorrente conta1 = new ContaCorrente();
conta1.nome = "Amanda";
conta1.conta = "2055-X";
conta1.agencia = 5;
conta1.saldo = 664.20;

/*ContaCorrente conta2 = new ContaCorrente();
conta2.nome = "João";
conta2.conta = "1037-X";
conta2.agencia = 12;
conta2.saldo = 1210.98;

Console.WriteLine("O titular da conta é a/o Sra/o " + conta1.nome);
Console.WriteLine("O número da agência é: " + conta1.agencia);
Console.WriteLine("O número da conta é: " + conta1.conta);
Console.WriteLine("O saldo da conta é de:R$"+ conta1.saldo);

Console.WriteLine("\n");

Console.WriteLine("O titular da conta é a/o Sra/o " + conta2.nome);
Console.WriteLine("O número da agência é: " + conta2.agencia);
Console.WriteLine("O número da conta é: " + conta2.conta);
Console.WriteLine("O saldo da conta é de:R$" + conta2.saldo);
*/
Console.WriteLine("\n");

conta1.Depositar(200);

Console.WriteLine("O novo saldo da conta é de:R$" + conta1.saldo);

if (conta1.Sacar(200) == true)
{
    Console.WriteLine("O novo saldo da conta é de:R$" + conta1.saldo);
}
else
    Console.WriteLine("Saldo insuficiente na Conta Corrente");


