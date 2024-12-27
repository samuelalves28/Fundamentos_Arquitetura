namespace SOLID._03_LSP.LSP_Solucao;

/// <summary>
/// O certo e você criar uma classe generica que possa ser herdada por outras classes, sendo ela abstract impossibilitando
/// a modição dela e garantindo que as classes que a herdem não possam modificar o comportamento da classe mãe. Mas na 
/// geometria o quadrado e o retangulo é um paralelogramo, então podemos criar uma classe mãe chamada Paralelogramo. 
/// Aqui estamos utilizando também o conceito de "É um" que é um dos pilares da orientação a objetos.
/// 
/// Um ponto importante é para resolver um problema de LSP e utilizando o conceito de "É um" e OCP, pois você cria uma
/// classe mãe que só pode ser herdada e não modificada e fazendo a classe mãe ter algo em comum com as filhas.
/// </summary>
public abstract class Paralelogramo(int altura, int largura)
{
    public double Altura { get; private set; } = altura;
    public double Largura { get; private set; } = largura;
    public double Area => Altura * Largura;
}
