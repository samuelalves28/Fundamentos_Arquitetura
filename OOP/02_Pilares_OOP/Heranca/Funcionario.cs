using OOP._02_Pilares_OOP.EstadoComportamento;

namespace OOP._02_Pilares_OOP.Heranca;

/// <summary>
/// Aqui temos uma classe Funcionario que está herdando da classe Pessoa. Isso significa que Funcionario herda todas as propriedades e métodos definidos em Pessoa, 
/// funcionando como uma extensão. A classe Pessoa é considerada uma classe "mãe" (ou classe base), que compartilha suas informações com a classe "filha". No entanto,
/// é importante destacar que a herança não deve ser usada sem que faça sentido. Antes de optar por esse recurso, devemos avaliar cuidadosamente se 
/// a relação entre as classes realmente faz sentido no contexto do sistema. Herança não deve ser utilizada apenas para economizar código, mas sim quando há uma relação clara 
/// de "é um/uma". Por exemplo, faz sentido que Funcionario herde de Pessoa, pois um funcionário é uma pessoa. Por outro lado, seria inadequado criar uma herança entre 
/// Funcionario e uma classe chamada Livro, já que um funcionário não é um livro e não há uma relação lógica que justifique essa conexão. Ao projetar o uso de herança,
/// priorize a coerência e a clareza na modelagem do domínio da aplicação.
/// </summary>

public class Funcionario : Pessoa
{
    public DateTime DataAdmissao { get; set; }
    public string Registro { get; set; }
    public int Idade { get; set; }

    /// <summary>
    /// Aqui podemos fazer de duas formas a criação do funcionario, por um construtor ou usando a propriedades direto.
    /// Podemos observar que quando construimos um funcionario ele automaticamente puxa as propiedades da classse que herda.
    /// </summary>
    public Funcionario() { }   //Construido apenas para utilizar as propriedades direto.

    public Funcionario(string nome, DateTime dataAdmissao, DateTime dataNascimento, string registro)
    {
        Nome = nome;
        DataNascimento = Convert.ToDateTime(value: dataNascimento);
        DataAdmissao = dataAdmissao;
        Registro = registro;
    }

    public void Create()
    {
        var newFuncionario = new Funcionario
        {
            Nome = "João de Almeida",
            DataNascimento = Convert.ToDateTime(value: "1999/01/15"),
            DataAdmissao = DateTime.Today,
            Registro = "026555"
        };

        // Podemos observar aqui que além de buscar as propriedades e possivel buscar as funções também.
        Idade = newFuncionario.CalcularIdade();
    }
}

