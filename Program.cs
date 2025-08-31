using System.Globalization;
using BancoAspire.Services;

ContaBancaria conta;

Console.Write("Entre com o número da conta: ");
int numeroConta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Entre o titular da conta: ");
string titularConta = Console.ReadLine();
Console.Write("Haverá depósito inicial (s/n)? ");
char temDepositoInicial = char.Parse(Console.ReadLine());

if (temDepositoInicial == 's')
{
  Console.Write("Entre o valor do depósito inicial: ");
  double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
  conta = new(numeroConta: numeroConta, nome: titularConta, deposito: depositoInicial);
}
else
{
  conta = new(numeroConta: numeroConta, nome: titularConta);
}

Console.WriteLine();
Console.WriteLine("Dados da conta: ");
Console.WriteLine(conta);

Console.Write("Entre um valor para depósito: ");
double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Deposito(valorDeposito);

Console.Write("Entre um valor para saque: ");
double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Saque(valorSaque);