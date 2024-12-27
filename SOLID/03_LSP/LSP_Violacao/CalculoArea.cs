namespace SOLID._03_LSP.LSP_Violacao;

/// <summary>
/// Então subclasses devem ser substituíveis por suas superclasses. Com isso mesmo que a gente calcule um quadrado, nós 
/// devo poder trocar pela superclasse retângulo, sem que der errado. Se der errado então a gente está violando o 
/// princípio de LSP. Então se tentamos calcular de um rentangugulo e instarciamos um quadrado, e não der certo, então
/// o quadrado não tem que ser herdado de retangulo.
/// </summary>
public class CalculoArea
{
    private static void ObterAreaRetangulo(Retangulo retangulo)
    {
        Console.Clear();
        Console.WriteLine("Calculo da área do retângulo");
        Console.WriteLine();
        Console.WriteLine(retangulo.Altura + " * " + retangulo.Largura);
        Console.WriteLine();
        Console.WriteLine(retangulo.Area);
        Console.ReadKey();
    }

    public static void Calcular()
    {
        Retangulo retangulo = new Quadrado()
        {
            Altura = 10,
            Largura = 5
        };

        ObterAreaRetangulo(retangulo);
    }
}
