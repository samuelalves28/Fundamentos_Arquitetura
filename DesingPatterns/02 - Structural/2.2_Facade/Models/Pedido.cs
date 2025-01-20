namespace DesingPatterns._02___Structural._2._2_Facade.Models;

public class Pedido(int id, List<Produto> produtos)
{
    public int Id { get; set; } = id;
    public List<Produto> Produtos { get; private set; } = produtos;
}
