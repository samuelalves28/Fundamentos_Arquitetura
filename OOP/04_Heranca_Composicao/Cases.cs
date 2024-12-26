using OOP._02_Pilares_OOP.EstadoComportamento;

namespace OOP._04_Heranca_Composicao;

#region Caso 1

// Aqui temos um caso de herança.
public class PessoaFisica : Pessoa
{
    public string Cpf { get; set; }
}

// Aqui temos um caso de Composição.
public class PessoaFisica2
{
    public Pessoa Pessoa { get; set; }
    public string Cpf { get; set; }
}

public class TestesHerancaComposicao
{
    public TestesHerancaComposicao()
    {
        var pessoaHeranca = new PessoaFisica
        {
            Nome = "Teste agora",
            Cpf = "155545454",
            DataNascimento = DateTime.Now,

        };

        var pessoaComposicao = new PessoaFisica2
        {
            Pessoa = new Pessoa
            {
                Nome = "Teste Aqui",
                DataNascimento = DateTime.Now
            },
            Cpf = "155151515"
        };
    }
}

#endregion

#region Caso 2 

/// <summary>
/// Aqui T pode ser qualquer tipo de objeto, sendo ele uma classe ou uma model. Com isso conseguimos criar um repositório genérico.
/// </summary>
public interface IRepositorio<T>
{
    void Adicionar(T obj);
}

/// <summary>
/// Aqui temos diferente do repository de cima, onde ele é genérico, aqui ele é específico para Pessoa.
/// </summary>
public interface IRepositorioPessoa
{
    void Adicionar(Pessoa pessoa);
}

/// <summary>
/// Aqui temos um repositório genérico que implementa a interface IRepositorio que é generica. Sendo assim quando instanciamos o Repositorio,
/// ele vai vim todas as funções que estão definidas na interface IRepositorio de forma genérica.
/// </summary>
public class Repositorio<T> : IRepositorio<T>
{
    public void Adicionar(T obj)
    {

    }
}

/// <summary>
/// OBSERVAÇÃO:
/// 1º Quando você herda você tem um acoplamento muito forte, pois você está herdando tudo que a classe pai tem. Já quando você compõe,
/// você tem um acoplamento mais fraco, pois você está injetando a classe pai no construtor.
/// 
/// 2º So quando usamos composição, que a gente consegue fazer a injeção de dependência, e com isso nós podemos falar oque eu quero implementar,
/// já na herança, a gente não consegue fazer isso, pois a gente tem que herdar tudo que a classe pai tem.
/// 
/// 3º Prefira sempre a composição, pois ela é mais flexível e menos acoplada, já a herança é mais rígida e tem um forte acoplamento.
/// </summary>


/// <summary>
/// Aqui temos um implementação de um repositorio genérico, mas quando colocamos pessoa , ele se torna específico para pessoa. Sendo assim, ele fica
/// específico para pessoa. Com isso fazemos o método de hereança.
/// </summary>
public class RepositorioPessoaHeranca : Repositorio<Pessoa>, IRepositorioPessoa
{

};

/// <summary>
/// Aqui temos um exemplo de composição, onde passamos um repositório de pessoa para a classe RepositorioPessoaComposicao. Sendo assim a gente está
/// injetando o repositório de pessoa o construtor.
/// </summary>
public class RepositorioPessoaComposicao(IRepositorio<Pessoa> repositorio) : IRepositorioPessoa
{
    public void Adicionar(Pessoa pessoa)
    {
        throw new NotImplementedException();
    }
};

#endregion