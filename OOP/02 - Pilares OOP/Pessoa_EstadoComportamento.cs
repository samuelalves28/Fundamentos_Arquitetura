namespace OOP._02___Pilares_OOP;

// Estado e entender que as propriedades da classe possui informações, já o comportamento são métodos que processa uma informação.
public class Pessoa_EstadoComportamento
{
    // Isso aqui é estado são as propriedades da própria classe. E quando você tem os dados está armazenado na classe.
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }

    // E quando você tem uma ação dentro da classe, isso quer dizer que é um comportamento. Não necessariamente temos que retonar pode fazer
    // com que ele simplemente altere uma informação, como é mostrado no exemplo 2.
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
