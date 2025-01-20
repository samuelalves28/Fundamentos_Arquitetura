using DesingPatterns._02___Structural._2._1_Adapter.Repositories;

namespace DesingPatterns._02___Structural._2._1_Adapter;

public class ExecuteAdapter
{
    public static void Executar()
    {
        var pagamentoLogPadrao = new TransacaoService(new Logger());
        pagamentoLogPadrao.RealizarTransacao();

        var pagamentoLogCustom = new TransacaoService(new LogAdapter(new LogNetMaster()));
        pagamentoLogCustom.RealizarTransacao();
    }
}
