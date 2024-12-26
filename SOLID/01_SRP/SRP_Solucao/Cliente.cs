namespace SOLID._01_SRP.SRP_Solucao;

/// <summary>
/// Aqui temos uma classe de cliente que tem apenas uma responsabilidade aonde temos um construtor e um método de atualização.
/// Ela tem a responsabilidade de criar um cliente e atualizar um cliente, e com isso ela garente que não haja violação no 
/// cadastro pois ela tem o private set. Com isso ela garante que o cliente seja criado e atualizado somente nos métodos
/// públicos.
/// </summary>
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
