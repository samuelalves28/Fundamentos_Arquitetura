using infrastructure.Base.ViewModel;

namespace API.Controllers.CadUsuario.ViewModel;

public class UpsertRequestViewModel : BaseViewModel
{
    public required string Nome { get; set; }
    public required string Email { get; set; }
    public required string Senha { get; set; }
}