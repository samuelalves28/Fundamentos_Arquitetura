namespace DesingPatterns._02___Structural._2._2_Facade.Models;

public class Pagamento( decimal valor, string status)
{
    public decimal Valor { get; private set; } = valor;
    public string Status { get; private set; } = status;
}
