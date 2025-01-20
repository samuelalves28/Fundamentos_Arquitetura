using DesingPatterns._02___Structural._2._2_Facade.Models;

namespace DesingPatterns._02___Structural._2._2_Facade.Implementations.Interfaces;

public interface IPagamentoService
{
    Pagamento RealizarPagamento(Pedido pedido);
}
