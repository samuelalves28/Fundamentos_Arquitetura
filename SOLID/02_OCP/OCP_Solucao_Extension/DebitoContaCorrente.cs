namespace SOLID._02_OCP.OCP_Solucao_Extension;

/// <summary>
/// Aqui estou usando o extension method para extender a classe DebitoConta e implementar o método debitar. Oque eu preciso 
/// para ser um extensio method é que a classe seja estática e o método também seja estático e ter o this no paramentro.
/// </summary>
public static class DebitoContaCorrente
{
    public static string ContaCorrente(this DebitoConta debitoConta)
    {
        // Logica de negocio para debito em conta corrente.
        return debitoConta.FormatarTransacao();
    }
}
