using DesingPatterns._02___Structural._2._2_Facade.Implementations.Interfaces;
using DesingPatterns._02___Structural._2._2_Facade.Models;
using DesingPatterns._03___Behavioral._3._2_Strategy.Implementations.Interfaces;

namespace DesingPatterns._03___Behavioral._3._2_Strategy.Services;

public class PagamentoBoletoService(IPagamentoBoletoFacade pagamentoBoletoFacade) : IPagamentoService
{
    public Pagamento RealizarPagamento(Pedido pedido)
    {
        throw new NotImplementedException();
    }

    public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
    {
        var valor = pedido.Produtos.Sum(s => s.Valor);
        Console.WriteLine("Iniciando pagamento via boleto - valor R$" + valor);

        pagamentoBoletoFacade.RealizaPagamento(pedido, valor);
        return new Pagamento(valor, "Aguardando pagamento");
    }
}
