namespace SOLID._03_LSP.LSP_Solucao;

/// <summary>
/// Como estamos utilizando herança, a classe filha automaticamente herda as funcionalidades da classe mãe, que é uma 
/// classe abstrata. Isso permite que, ao criarmos um retângulo, possamos definir sua altura e largura, passando esses 
/// valores para a classe base. A classe base, por sua vez, realiza o cálculo da área. Além disso, a propriedade Área 
/// torna-se acessível diretamente na classe filha devido à herança.
/// </summary>
public class Retangulo(int altura, int largura) : Paralelogramo(altura, largura)
{

}
