namespace SOLID._04_ISP.ISP_Violacao;

/// <summary>
/// Aqui é um exemplo disso é a classe CadastroProduto que implementa a interface ICadastro. O problema é que a classe
/// não vai mandar email, mas ela é obrigada a implementar o método EnviarEmail. Mesmo se retiramos ele aqui a implementação
/// quando fazemos um contrato com a interface, temos que implementar todos os métodos.
/// </summary>
public class CadastroProduto : ICadastroCliente
{
    public void EnviarEmail()
    {
    }

    public void SalvarBanco()
    {
    }

    public void ValidarDados()
    {
    }
}
