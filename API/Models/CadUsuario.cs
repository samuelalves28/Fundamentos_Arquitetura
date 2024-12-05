using infrastructure.Base.Model;

namespace API.Models;

public class CadUsuario(string nome, string email, string passwordHash) : BaseModel
{
    #region Campos

    public string Nome { get; private set; } = nome;
    public string Email { get; private set; } = email;
    public string PasswordHash { get; private set; } = passwordHash;

    #endregion

    #region Métodos públicos

    public void Update(string nome, string email, string passwordHash)
    {
        Nome = nome;
        Email = email;
        PasswordHash = passwordHash;
    }

    #endregion
}

