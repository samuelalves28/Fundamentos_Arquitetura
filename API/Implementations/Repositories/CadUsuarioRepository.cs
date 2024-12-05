using API.Implementations.Interfaces;
using API.Models;
using infrastructure.Base.Implementations.Repositories;
using infrastructure.Data;
using Microsoft.Extensions.Options;
namespace API.Implementations.Repositories;

public class CadUsuarioRepository(IOptions<DataBaseSettings> databaseSettings) : BaseRepository<CadUsuario>(databaseSettings), ICadUsuarioRepository
{

}
