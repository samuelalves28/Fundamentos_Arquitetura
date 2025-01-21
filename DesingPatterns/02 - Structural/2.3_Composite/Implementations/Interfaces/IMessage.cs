namespace DesingPatterns._02___Structural._2._3_Composite.Implementations.Interfaces;

public interface IMessage
{
    string Nome { get; set; }
    void ExibirMensagens(int sub);
}
