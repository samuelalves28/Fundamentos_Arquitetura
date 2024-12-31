using DemoDI.Implementations.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers.Cliente;

/// <summary>
/// Aqui temos a implementação do contrato com a interface IClienteRepository, aonde estamos assinando o cotrato.
/// </summary>
[Route("api/adm/cad-cliente")]
public class ClienteController(IClienteRepository clienteRepository) : ControllerBase
{
    /// <summary>
    /// Quando Fazemos um AdicionarCliente ele vai la no repository do cliente para adicionar.
    /// </summary>
    [HttpPost]
    public async Task<IActionResult> CreateAsync(CancellationToken cancellationToken)
    {
        var cliente = new Model.Cliente("teste", "teste", "155555555");
        clienteRepository.AdicionarCliente(cliente);
        return Ok("Cadastro feito");
    }
}
