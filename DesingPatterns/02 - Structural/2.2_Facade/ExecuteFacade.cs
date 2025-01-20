using DesingPatterns._02___Structural._2._2_Facade.Implementations.Repositories;
using DesingPatterns._02___Structural._2._2_Facade.Models;

namespace DesingPatterns._02___Structural._2._2_Facade;

public class ExecuteFacade
{
    public static void Executar()
    {
        var produtos = new List<Produto>();

        produtos = [
            new Produto(  1,   "Tenis Adidas",   new Random().Next(maxValue: 500) ),
            new Produto(  2,   "Camisa Boliche",  new Random().Next(maxValue: 500) ),
            new Produto(  3,   "Raquete Tenis",  new Random().Next(maxValue: 500))
        ];

        var pedido = new Pedido(1, produtos);

        // Resolva com DI
        var pagamentoService = new PagamentoService(new PagamentoFacade());

        // TODO: Aqui tem que fazer passar o número do cartão
        var pagamentoResult = pagamentoService.RealizarPagamento(pedido);

        Console.WriteLine(pagamentoResult.Status);
    }
}
