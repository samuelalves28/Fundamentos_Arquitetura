namespace OOP._03_Interface_Implementacao;

/// <summary>
/// A interface é uma espécie de contrato. Isso significa que toda classe que implementa uma interface
/// é obrigada a implementar os métodos definidos nela.
/// </summary>
public interface IRepositorio
{
    void Adicionar();
}

/// <summary>
/// Neste exemplo, podemos observar que a classe Repositorio precisa implementar o método Adicionar,
/// pois ele foi definido na interface IRepositorio que está sendo herdada.
/// </summary>
public class Repositorio : IRepositorio
{
    public void Adicionar()
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// Aqui criamos uma instância da classe Repositorio e chamamos a função Adicionar diretamente.
/// </summary>
public class UsoImplementacao
{
    public void Processo()
    {
        var repository = new Repositorio();
        repository.Adicionar();
    }
}

/// <summary>
/// Aqui utilizamos a interface como um contrato, permitindo abstrair o uso da classe concreta.
/// </summary>
public class UsoAbstracao
{
    // O repositório está representando a interface, permitindo maior flexibilidade e desacoplamento.
    private readonly IRepositorio _repositorio;

    /// <summary>
    /// Construtor que recebe uma instância de IRepositorio, implementando o padrão de injeção de dependência.
    /// Esse processo garante que estamos utilizando a interface como contrato para nossas operações.
    /// </summary>
    /// <param name="repositorio">Instância que implementa a interface IRepositorio.</param>
    public UsoAbstracao(IRepositorio repositorio)
    {
        _repositorio = repositorio;
    }

    /// <summary>
    /// Método que utiliza a função definida no contrato da interface.
    /// </summary>
    public void Processo()
    {
        _repositorio.Adicionar();
    }
}
