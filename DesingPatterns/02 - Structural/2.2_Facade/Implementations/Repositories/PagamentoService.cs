using DesingPatterns._02___Structural._2._2_Facade.Implementations.Interfaces;
using DesingPatterns._02___Structural._2._2_Facade.Models;

namespace DesingPatterns._02___Structural._2._2_Facade.Implementations.Repositories;

public class PagamentoService(IPagamentoFacade pagamentoFacade) : IPagamentoService
{
    public Models.Pagamento RealizarPagamento(Pedido pedido)
    {
        var valor = pedido.Produtos.Sum(s => s.Valor);
        var mensagem = "Cartão de crédito recusado!";

        Console.WriteLine("Inciando o pagamento via cartão de Crédito - Valor R$ " + valor);

        if (pagamentoFacade.RealizaPagamento(pedido, valor)) mensagem = "Pagamento via Cartão de crédito";

        return new Models.Pagamento(valor, mensagem);
    }

    public Models.Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
    {
        var valor = pedido.Produtos.Sum(s => s.Valor);
        var mensagem = "Cartão de crédito recusado!";

        Console.WriteLine("Inciando o pagamento via cartão de Crédito - Valor R$ " + valor);

        if (pagamentoFacade.RealizaPagamento(pedido, valor)) mensagem = "Pagamento via Cartão de crédito";

        return new Models.Pagamento(valor, mensagem);
    }
}
