namespace DemoDI.Model;

public class Cliente(string nome, string email, string cpf)
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Nome { get; private set; } = nome;
    public string Email { get; private set; } = email;
    public string Cpf { get; private set; } = cpf;
    public DateTime DataCadastro { get; private set; } = DateTime.Now;
}
