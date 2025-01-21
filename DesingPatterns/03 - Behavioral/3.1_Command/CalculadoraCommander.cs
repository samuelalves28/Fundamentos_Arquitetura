namespace DesingPatterns._03___Behavioral._3._1_Command;

internal class CalculadoraCommander(Calculadora calculadora, char operador, int valor) : Commander
{
    public char Operator
    {
        set => operador = value;
    }

    public int Valor
    {
        set => valor = value;
    }

    public override void Desfazer()
    {
        calculadora.Operacao(Desfazer(operador), valor);
    }

    public override void Executar()
    {
        calculadora.Operacao(operador, valor);
    }

    private static char Desfazer(char operador)
    {
        switch (operador)
        {
            case '+': return '-';
            case '-': return '+';
            case '*': return '/';
            case '/': return '*';
            default: throw new ArgumentException("Operador desconhecido");
        }
    }
}
