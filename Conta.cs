class Conta
{
    public Titular Titular { get; }
    public int Agencia { get; }
    public int NumeroDaConta { get; }
    public double Saldo { get; }
    public double Limite { get; }

    public string Informacoes => $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";

    public Conta(Titular titular, int agencia, int numeroDaConta, double saldo, double limite)
    {
        Titular = titular;
        Agencia = agencia;
        NumeroDaConta = numeroDaConta;
        Saldo = saldo;
        Limite = limite;
    }
}