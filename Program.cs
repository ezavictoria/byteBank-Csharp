using bytebank.Contas;
using bytebank.Titular;
using System.Drawing;

Cliente clienteEza = new Cliente();
clienteEza.nome = "Eza Lôbo";
clienteEza.cpf = "123456789";
clienteEza.profissao = "Analista";

ContaCorrente contaDaEza = new ContaCorrente(15, "1010-X");
contaDaEza.titular = clienteEza;
contaDaEza.SetSaldo(200);

Console.WriteLine("========= Dados da Conta ========= ");
Console.WriteLine("Titular: " + contaDaEza.titular.nome);
Console.WriteLine("CPF: " + contaDaEza.titular.cpf);
Console.WriteLine("Profissão: " + contaDaEza.titular.profissao);
Console.WriteLine("Saldo: " + contaDaEza.GetSaldo());
Console.WriteLine("Agência: " + contaDaEza.Numero_agencia);
Console.WriteLine("Conta: " + contaDaEza.Conta);
Console.WriteLine("================================== ");

Cliente clienteIgor = new Cliente();
clienteIgor.nome = "Igor Amaral";
clienteIgor.cpf = "123456789";
clienteIgor.profissao = "Tester";

ContaCorrente contaDoIgor = new ContaCorrente(20, "1515-X");
contaDoIgor.titular = clienteIgor;
contaDoIgor.SetSaldo(250);

Console.WriteLine("========= Dados da Conta ========= ");
Console.WriteLine("Titular: " + contaDoIgor.titular.nome);
Console.WriteLine("CPF: " + contaDoIgor.titular.cpf);
Console.WriteLine("Profissão: " + contaDoIgor.titular.profissao);
Console.WriteLine("Saldo: " + contaDoIgor.GetSaldo());
Console.WriteLine("Agência: " + contaDoIgor.Numero_agencia);
Console.WriteLine("Conta: " + contaDoIgor.Conta);
Console.WriteLine("================================== ");

Console.WriteLine("===== Total de Contas Criadas ==== ");

Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

Console.WriteLine("================================== ");

double deposito = 100;
double saque = 50;
double transferencia = 300;

Console.WriteLine("=========== Transações =========== ");

Console.WriteLine("O saldo inicial da conta da Eza é: " + contaDaEza.GetSaldo());

contaDaEza.Depositar(deposito);
Console.WriteLine("Valor do depósito = " + deposito);
Console.WriteLine("Saldo da Conta da Eza após depósito = " + contaDaEza.GetSaldo());

if (contaDaEza.Sacar(saque) == true){
    Console.WriteLine("Valor do saque = " + saque);
    Console.WriteLine("Saldo da Conta da Eza após saque = " + contaDaEza.GetSaldo());
}else
{
    Console.WriteLine("Não é possível realizar saque. Saldo insuficiente.");
}

Console.WriteLine("Saldo da Conta do Igor = " + contaDoIgor.GetSaldo());

contaDaEza.Transferir(transferencia, contaDoIgor);
Console.WriteLine("Valor do transferência = " + transferencia);

if (contaDaEza.Transferir(transferencia, contaDoIgor) == true)
{
    Console.WriteLine("Saldo da Conta da Eza após transferência = " + contaDaEza.GetSaldo());
    Console.WriteLine("Saldo da Conta do Igor após transferência = " + contaDoIgor.GetSaldo());
}
else
{
    Console.WriteLine("Saldo insuficiente para transferência.");
}

Console.WriteLine("================================== ");



