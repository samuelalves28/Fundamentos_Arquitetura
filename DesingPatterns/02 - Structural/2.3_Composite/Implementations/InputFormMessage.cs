using DesingPatterns._02___Structural._2._3_Composite.Implementations.Interfaces;

namespace DesingPatterns._02___Structural._2._3_Composite.Implementations;

public class InputFormMessage : IMessage
{
    public string Nome { get; set; }

    public InputFormMessage(string nome)
    {
        Nome = nome;
    }

    public void ExibirMensagens(int sub)
    {
        Console.WriteLine(new string('-', sub) + Nome);
    }
}
