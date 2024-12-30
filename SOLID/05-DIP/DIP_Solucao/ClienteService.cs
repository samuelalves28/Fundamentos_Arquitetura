using SOLID._05_DIP.DIP_Solucao.Interface;

namespace SOLID._05_DIP.DIP_Solucao;

/// <summary>
/// Aqui estamos implementando as funcionalidades de cadastrar um cliente e enviar um email através de contratos, utilizando abstrações.
/// Abaixo, realizamos a injeção de dependência para utilizar as funcionalidades do repositório e do serviço de email, que contêm as regras definidas nos contratos.
/// Declaramos as dependências através de interfaces, ou seja, estamos dependendo de abstrações, que são os próprios contratos. Aqui no construtor estamos injetando as dependências,
/// com isso estamos implementando. 
/// 
/// O ClienteService está meio que dizendo que estamos recebendo as injeções de dependência, com isso temos uma responsabilidade única, que é cadastrar um cliente e enviar um email, 
/// sendo assim ela fala que ela não é obrigada a saber como saber criar uma instacia de um clienterepository e um emailservice, não é responsabilidade dela, com isso ela só precisa 
/// saber que tem que chamar esses métodos.
/// </summary>
public class ClienteService(IClienteRepository clienteRepository, IEmailService emailService)
{

    public string AdicionarCliente(Cliente cliente)
    {
        if (!cliente.Email.Contains('@')) return "Email inválido";

        if (cliente.Cpf.Length != 11) return "CPF inválido";

        /// Como temos um método que está sendo chamado, que é o AdicionarCliente que vem de uma interface que está sendo injetado no construtor, ele fala que como tem o contrato 
        /// em mãos, ele sabe que tem um método chamado AdicionarCliente.
        clienteRepository.AdicionarCliente(cliente);
        emailService.Enviar("seuemail@email.com", cliente.Email, "Bem vindo", "Parabéns está Cadastrado");

        return "Cliente cadastrado com sucesso";
    }
}

