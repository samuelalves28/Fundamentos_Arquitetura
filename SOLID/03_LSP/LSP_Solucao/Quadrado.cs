namespace SOLID._03_LSP.LSP_Solucao;

/// <summary>
/// Como estamos utilizando herança, a classe filha automaticamente herda as funcionalidades da classe mãe, que é uma 
/// classe abstrata. Isso permite que, ao criarmos um retângulo, possamos definir sua altura e largura, passando esses 
/// valores para a classe base. A classe base, por sua vez, realiza o cálculo da área. Além disso, a propriedade Área 
/// torna-se acessível diretamente na classe filha devido à herança. E com isso podemos colocar a regra que quisermos
/// dentro da classe filha, sem modificar a classe mãe.
/// </summary>
public class Quadrado : Paralelogramo
{
    public Quadrado(int altura, int largura) : base(altura, largura)
    {
        if (altura != largura) throw new ArgumentException("Os dois lados do quadrado precisam ser iguais");
    }
}
