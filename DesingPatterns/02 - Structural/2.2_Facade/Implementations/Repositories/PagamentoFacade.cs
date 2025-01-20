using DesingPatterns._02___Structural._2._2_Facade.Implementations.Interfaces;
using DesingPatterns._02___Structural._2._2_Facade.Models;

namespace DesingPatterns._02___Structural._2._2_Facade.Implementations.Repositories;

public class PagamentoFacade : IPagamentoFacade
{
    // TODO: Implementar depois a integração com o PayPal ou Mercado Pago
    public bool RealizaPagamento(Pedido pedido, decimal valor)
    {

        return true;
    }
}
