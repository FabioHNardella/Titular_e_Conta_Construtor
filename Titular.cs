class Titular
{
    public string Nome { get; }
    public string Cpf { get; }
    public string Endereco { get; }

    public Titular(string nome, string cpf, string endereco)
    {
        Nome = nome;
        Cpf = cpf;
        Endereco = endereco;
    }
}