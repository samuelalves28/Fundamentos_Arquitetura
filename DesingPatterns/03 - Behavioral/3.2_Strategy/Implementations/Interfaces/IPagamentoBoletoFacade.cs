using DesingPatterns._02___Structural._2._2_Facade.Models;

namespace DesingPatterns._03___Behavioral._3._2_Strategy.Implementations.Interfaces;

public interface IPagamentoBoletoFacade
{
    bool RealizaPagamento(Pedido pedido, decimal valor);
}
