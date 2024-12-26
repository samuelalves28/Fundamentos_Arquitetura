namespace SOLID._01_SRP.SRP_Solucao;

/// <summary>
/// Essa classe é uma de orquestração, ela é responsável por orquestrar a ação de cadastrar o cliente.
/// </summary>
public class ClienteService
{
    public string AdicionarCliente(Cliente cliente)
    {
        var repository = new ClienteRepository();
        repository.AdicionarCliente(cliente);

        EmailService.Enviar("empresa@gmail.com", cliente.Email, "Bem vindo.", "Olá");

        return "Cliente cadastrado com sucesso";
    }
}
