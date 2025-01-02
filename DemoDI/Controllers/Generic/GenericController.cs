using DemoDI.Implementations.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers.Generic;

/// <summary>
/// Aqui temos a implementação do contrato com a interface IClienteRepository, aonde estamos assinando o contrato, sendo assim estou falando que o repository
/// generico ele é do tipo cliente, e com isso eu posso utilizar todos os metodos que estão no contrato para o cliente.
/// </summary>
[Route("api/adm/generic")]
public class GenericController(IGenericBaseRepository<Model.Cliente> clienteRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAsync(CancellationToken cancellationToken)
    {
        await clienteRepository.GetAll();
        return Ok("Cadastro feito");
    }
}
