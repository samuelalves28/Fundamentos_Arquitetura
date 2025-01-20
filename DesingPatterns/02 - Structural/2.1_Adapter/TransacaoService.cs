using DesingPatterns._02___Structural._2._1_Adapter.Interfaces;

namespace DesingPatterns._02___Structural._2._1_Adapter;

public class TransacaoService(ILogger logger)
{
    public void RealizarTransacao()
    {
        logger.Log("Transação realizada");
    }
}
