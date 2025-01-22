using DesingPatterns._02___Structural._2._2_Facade.Models;
using DesingPatterns._03___Behavioral._3._2_Strategy.Implementations.Interfaces;

namespace DesingPatterns._03___Behavioral._3._2_Strategy.Implementations.Repositories;

public class PagamentoTransferenciaFacade : IPagamentoTransferenciaFacade
{
    public bool RealizaPagamento(Pedido pedido, decimal valor)
    {
        return true;
    }
}
