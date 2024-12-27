namespace SOLID._03_LSP.LSP_Violacao;

public class Retangulo
{
    public virtual double Altura { get; set; }
    public virtual double Largura { get; set; }

    public double Area => Altura * Largura;
}
