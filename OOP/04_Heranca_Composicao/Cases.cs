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

public interface IRepositorio<T>
{
    void Adicionar(T obj);
}

public interface IRepositorioPessoa
{
    void Adicionar(Pessoa pessoa);
}

public class Repositorio<T> : IRepositorio<T>
{
    public void Adicionar(T obj)
    {

    }
}

public class RepositorioPessoaHeranca : Repositorio<Pessoa>, IRepositorioPessoa
{

};

public class RepositorioPessoaComposicao : IRepositorioPessoa
{
    public void Adicionar(Pessoa pessoa)
    {
        throw new NotImplementedException();
    }
};


#endregion