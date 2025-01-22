using DesingPatterns._02___Structural._2._2_Facade.Implementations.Interfaces;
using DesingPatterns._02___Structural._2._2_Facade.Models;

namespace DesingPatterns._03___Behavioral._3._2_Strategy.Services;

public class PedidoService(IPagamentoService pagamentoService)
{
    public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
    {
        return pagamentoService.RealizarPagamento(pedido, pagamento);
    }
}
