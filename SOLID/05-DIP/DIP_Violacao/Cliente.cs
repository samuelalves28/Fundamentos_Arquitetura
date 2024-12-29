namespace SOLID._05_DIP.DIP_Violacao;

public class Cliente
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public string Cpf { get; private set; }
    public DateTime DataCadastro { get; private set; }

    public Cliente(int id, string nome, string email, string cpf, DateTime dataCadastro)
    {
        if (!email.Contains('@')) throw new Exception("Email inválido");

        if (cpf.Length != 11) throw new Exception("CPF inválido");

        Id = id;
        Nome = nome;
        Email = email;
        Cpf = cpf;
        DataCadastro = dataCadastro;
    }

    public void Update(int id, string nome, string email, string cpf, DateTime dataCadastro)
    {
        if (!email.Contains('@')) throw new Exception("Email inválido");

        if (cpf.Length != 11) throw new Exception("CPF inválido");

        Id = id;
        Nome = nome;
        Email = email;
        Cpf = cpf;
        DataCadastro = dataCadastro;
    }
}
