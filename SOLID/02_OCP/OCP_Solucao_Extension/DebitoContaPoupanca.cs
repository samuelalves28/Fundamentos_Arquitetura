namespace SOLID._02_OCP.OCP_Solucao_Extension;

/// <summary>
/// Aqui estou herdando a classe base DebitoConta e implementando o método abstrato debitar. Colocando outas regras
/// que quero implemnetar também. 
/// </summary>
public static class DebitoContaPoupanca
{
    public static string ContaPoupanca(this DebitoConta debitoConta)
    {
        // Logica de negocio para debito em conta poupança.
        return debitoConta.FormatarTransacao();
    }
}
