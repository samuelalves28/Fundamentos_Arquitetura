namespace OOP.Clssse_X_Objeto;


/// <summary>
/// Definicação de classe, ela te o objetivo de mapear um objeto do mundo real.
/// </summary>

public class Casa
{
    public int TamanhoM2 { get; set; }
    public int Andares { get; set; }
    public decimal Valor { get; set; }
    public int NumeroVagas { get; set; }
}

public class Objeto
{
    /// <summary>
    /// E quando você instancia ela na memoria, no código. Um objeto e quando você traz aquela classe para a realidade do código.
    /// </summary>
    public Objeto()
    {
        var casa = new Casa
        {
            TamanhoM2 = 1,
            Andares = 1,
            Valor = 1,
            NumeroVagas = 1
        };
    }
}

