namespace OOP._02_Pilares_OOP.EstadoComportamento;

/// <summary>
/// Estado e entender que as propriedades da classe possui informações, já o comportamento são métodos que processa uma informação.
/// </summary>
public class Pessoa
{
    /// <summary>
    /// Isso aqui representa o estado, ou seja, as propriedades da própria classe. O estado refere-se aos dados que estão armazenados e gerenciados internamente pela classe.
    /// </summary>
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }


    /// <summary>
    /// Quando você define uma ação dentro de uma classe, isso representa um comportamento. Um comportamento não precisa necessariamente retornar um valor; ele pode 
    /// simplesmente executar uma tarefa ou alterar o estado da classe, como demonstrado no exemplo 2.
    /// </summary>
    public int CalcularIdade()
    {
        var dataAtual = DateTime.Now;
        var idade = dataAtual.Year - DataNascimento.Year;

        if (dataAtual.Month < DateTime.Now.Month) idade--;

        return idade;
    }

    public void Update(string nome, DateTime dataNascimento)
    {
        Nome = nome;
        DataNascimento = dataNascimento;
    }
}