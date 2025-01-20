namespace DesingPatterns._02___Structural._2._2_Facade.Models;

public class Produto(int id, string nome, decimal valor )
{
    public int Id { get;  set; } = id;
    public string Nome { get;  set; } = nome;
    public decimal Valor { get;  set; } = valor;
}
