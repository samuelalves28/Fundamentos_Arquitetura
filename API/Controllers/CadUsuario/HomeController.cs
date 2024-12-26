using API.Controllers.CadUsuario.ViewModel;
using API.Implementations.Interfaces;
using infrastructure.Utils;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.CadUsuario;
[Route("api/adm/cad-cadastro")]
public class HomeController(ILogger<HomeController> logger, ICadUsuarioRepository cadUsuarioRepository) : ControllerBase
{
    [HttpGet("buscar")]
    public async Task<IActionResult> GetUsuariosAsync(CancellationToken cancellationToken)
    {
        var users = await cadUsuarioRepository.GetAsync(cancellationToken);
        return Ok(users);
    }

    [HttpPost]
    public async Task<IActionResult> CriarUsuariosAsync([FromBody] UpsertRequestViewModel requestViewModel, CancellationToken cancellationToken)
    {
        try
        {
            var entity = new Models.CadUsuario(requestViewModel.Nome,
                requestViewModel.Email,
                HashPassword.Create(requestViewModel.Senha));

            await cadUsuarioRepository.CreateAsync(entity, cancellationToken);

            return Ok(new { message = "Cadastro feito com sucesso!" });
        }
        catch (Exception ex)
        {
            return BadRequest($"Erro ao cadastrar o usuario.{ex}");
            throw;
        }
    }

    [HttpPut]
    public async Task<IActionResult> AtualizarUsuarioAsync([FromBody] UpsertRequestViewModel requestViewModel, CancellationToken cancellationToken)
    {
        try
        {
            var entity = await cadUsuarioRepository.GetAsync(id: requestViewModel.Id.Value, cancellationToken);
            entity.Update(requestViewModel.Nome, requestViewModel.Email, HashPassword.Create(requestViewModel.Senha));

            await cadUsuarioRepository.UpdateAsync(requestViewModel.Id.Value, entity, cancellationToken);

            return Ok(new { message = "Cadastro editado com sucesso!" });
        }
        catch (Exception ex)
        {
            return BadRequest($"Erro ao editar o usuario.{ex}");
            throw;
        }
    }

    [HttpDelete, Route("{id}")]
    public async Task<IActionResult> DeleteUsuarioAsync(Guid id, CancellationToken cancellationToken)
    {
        try
        {
            await cadUsuarioRepository.DeleteAsync(id: id, cancellationToken);
            return Ok(new { message = "Cadastro removido com sucesso!" });
        }
        catch (Exception ex)
        {
            return BadRequest($"Erro ao remover o usuario. {ex.Message}");
        }
    }
}
