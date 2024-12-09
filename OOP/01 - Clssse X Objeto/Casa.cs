namespace OOP.Clssse_X_Objeto;


// Definicação de classe, ela te o objetivo de mapear um objeto do mundo real.

public class Casa
{
    public int TamanhoM2 { get; set; }
    public int Andares { get; set; }
    public decimal Valor { get; set; }
    public int NumeroVagas { get; set; }
}

public class Objeto
{
    // E quando você instancia ela na memoria, no código. Um objeto e quando você traz aquela classe para a realidade do código.
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

