namespace OOP._02_Pilares_OOP.Abestracao;

/// <summary>
/// Quando uma classe é declarada como abstrata, ela não pode ser instanciada diretamente, sendo projetada 
/// apenas para ser herdada por outras classes. Essa abordagem protege a classe base, evitando que seja utilizada 
/// de forma inadequada ou fora do escopo previsto e serve como um modelo genérico para outras classes derivadas.
/// O objetivo de uma classe abstrata é oferecer uma estrutura comum, permitindo que subclasses implementem 
/// ou expandam comportamentos específicos. Por exemplo, ao criarmos uma classe abstrata Eletrodomestico, 
/// podemos definir propriedades e métodos gerais, como ligar() e desligar(). Uma classe derivada, como
/// Cafeteira, herdará essas características e poderá adicionar comportamentos específicos, como 
/// aquecerAlimentos(). Assim, a abstração facilita a reutilização de código e promove um design mais 
/// organizado e coeso.
/// </summary>
public abstract class Eletrodomestico(string nome, int voltagem)
{
    private readonly string _nome = nome;
    private readonly int _voltagem = voltagem;


    /// <summary>
    /// Quando colocamos funcao abstract não é necessario implemntar algo, mas te obriga a sobrescrevelo
    /// na classe que vai herdar essa classe Eletrodomestico. Agora se criamos uma funcao que é virtual 
    /// ele te obriga a fazer a implementação mas não te obriga a sobrescrever.
    /// </summary>
    public abstract void Ligar();
    public abstract void Desligar();

    public virtual void Testar() { }
}
