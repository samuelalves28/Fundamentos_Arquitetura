namespace SOLID._05_DIP.DIP_Violacao;

/// <summary>
/// O cliente service é um modulo de alto nivel, ele depende de modulos de baixo nivel que é o ClienteRepository.
/// </summary>
public class ClienteService
{
    public string AdicionarCliente(Cliente cliente)
    {
        if (!cliente.Email.Contains('@')) return "Email inválido";

        if (cliente.Cpf.Length != 11) return "CPF inválido";

        //Aqui temos uma violação do DIP, pois a classe ClienteService depende de classes concretas, isso aqui é uma implementação 
        //ela não é obrigada a saber de como é feito a criação do clienteRepository.
        var clienteRepository = new ClienteRepository();
        clienteRepository.AdicionarCliente(cliente);

        EmailService.Enviar("seuemail@email.com", cliente.Email, "Bem vindo", "Parabéns está Cadastrado");

        return "Cliente cadastrado com sucesso";
    }
}
