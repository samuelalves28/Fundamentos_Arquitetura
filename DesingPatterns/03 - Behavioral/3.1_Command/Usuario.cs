namespace DesingPatterns._03___Behavioral._3._1_Command;

public class Usuario
{
    private readonly Calculadora _calculadora = new();
    private readonly List<Commander> _commands = new();
    private int _total;

    public void Adicionar(char operador, int valor)
    {
        Commander command = new CalculadoraCommander(_calculadora, operador, valor);
        command.Executar();

        _commands.Add(command);
        _total++;
    }

    public void Desfazer(int niveis)
    {
        Console.WriteLine("\n---- Desfazendo {0} níveis", niveis);

        for (int i = 0; i < niveis; i++)
        {
            if (_total <=0) continue;
            Commander command = _commands[--_total];
            command.Desfazer();
        }
    }

    public void Retornar(int niveis)
    {
        Console.WriteLine("\n---- Retornando  {0} níveis", niveis);

        for (int i = 0; i < niveis; i++)
        {
            if (_total >= _commands.Count -1) continue;
            
            Commander command = _commands[_total++];
            command.Executar();
        }
    }
}
