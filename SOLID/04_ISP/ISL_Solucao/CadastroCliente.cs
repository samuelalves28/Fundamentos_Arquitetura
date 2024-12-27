namespace SOLID._04_ISP.ISP_Solucao;

/// <summary>
/// Como diz a o conceito do ISP, uma classe não deve ser forçada a implementar métodos que ela não vai usar. Então criamos
/// outras interfaces para que as classes que herdem elas implementem os métodos que elas realmente vão usar.
/// </summary>
public class CadastroCliente : ICadastroCliente
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
