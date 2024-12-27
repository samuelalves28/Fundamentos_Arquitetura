namespace SOLID._03_LSP.LSP_Violacao;

/// <summary>
/// A gente fala que o quadrado e um tipo de retagulo, só que tentamos colocar no lugar do retangulo não conseguimos
/// fazer essa troca, pelo simples fato que o quadrado tem que ter a mesma altura e largura, e o retangulo não.
/// </summary>
public class Quadrado : Retangulo
{
    public override double Altura
    {
        set => base.Altura = base.Largura = value;
    }

    public override double Largura
    {
        set => base.Largura = base.Altura = value;
    }
}
