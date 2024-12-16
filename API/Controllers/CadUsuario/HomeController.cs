using API.Controllers.CadUsuario.ViewModel;
using API.Implementations.Interfaces;
using infrastructure.Utils;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.CadUsuario;
[Route("api/adm/cad-cadastro")]
public class HomeController(ILogger<HomeController> logger, ICadUsuarioRepository cadUsuarioRepository) : ControllerBase
{
    [HttpGet("buscar")]
    public async Task<IActionResult> GetUsuariosAsync()
    {
        var users = await cadUsuarioRepository.GetAsync();
        return Ok(users);
    }

    [HttpPost]
    public async Task<IActionResult> CriarUsuariosAsync([FromBody] UpsertRequestViewModel requestViewModel)
    {
        try
        {
            var entity = new Models.CadUsuario(requestViewModel.Nome,
                requestViewModel.Email,
                HashPassword.Create(requestViewModel.Senha));

            await cadUsuarioRepository.CreateAsync(entity);

            return Ok(new { message = "Cadastro feito com sucesso!" });
        }
        catch (Exception ex)
        {
            return BadRequest($"Erro ao cadastrar o usuario.{ex}");
            throw;
        }
    }

    [HttpPut]
    public async Task<IActionResult> AtualizarUsuarioAsync([FromBody] UpsertRequestViewModel requestViewModel)
    {
        try
        {
            var entity = await cadUsuarioRepository.GetAsync(id: requestViewModel.Id.Value);
            entity.Update(requestViewModel.Nome, requestViewModel.Email, HashPassword.Create(requestViewModel.Senha));

            await cadUsuarioRepository.UpdateAsync(requestViewModel.Id.Value, entity);

            return Ok(new { message = "Cadastro editado com sucesso!" });
        }
        catch (Exception ex)
        {
            return BadRequest($"Erro ao editar o usuario.{ex}");
            throw;
        }
    }

    [HttpDelete, Route("{id}")]
    public async Task<IActionResult> DeleteUsuarioAsync(Guid id)
    {
        try
        {
            await cadUsuarioRepository.DeleteAsync(id: id);
            return Ok(new { message = "Cadastro removido com sucesso!" });
        }
        catch (Exception ex)
        {
            return BadRequest($"Erro ao remover o usuario. {ex.Message}");
        }
    }
}
