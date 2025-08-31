namespace BancoAspire.Services
{
  public class ContaBancaria(int numeroConta, string nome)
  {
    private const int taxaSaque = 5;
    private readonly int _numeroConta = numeroConta;
    private string _nomeTitular = nome;
    private double _saldo;

    public ContaBancaria(int numeroConta, string nome, double deposito) : this(numeroConta, nome)
    {
      Saldo = deposito;
    }

    public int NumeroConta => _numeroConta;
    public string NomeTitular
    {
      get => _nomeTitular;
      set => _nomeTitular = value;
    }
    public double Saldo
    {
      get => _saldo;
      private set => _saldo = value;
    }

    public void Deposito(double quantia)
    {
      Saldo += quantia;
      Console.WriteLine("Dados da conta atualizados: ");
      Console.WriteLine(this);
    }

    public void Saque(double quantia)
    {
      Saldo -= quantia + taxaSaque;
      Console.WriteLine("Dados da conta atualizados: ");
      Console.WriteLine(this);
    }

    public override string ToString()
    {
      return $"Conta {NumeroConta}, Titular: {NomeTitular}, Saldo: $ {Saldo: 0.00}\n";
    }
  }
}