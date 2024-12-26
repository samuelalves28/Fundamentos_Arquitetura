namespace SOLID._02_OCP.OCP_Solucao;

/// <summary>
/// Aqui estou herdando a classe base DebitoConta e implementando o método abstrato debitar. Sendo assim 
/// estou herdando a classe base e não modificando ela.
/// </summary>
public class DebitoContaCorrente : DebitoConta
{
    public override string Debitar(decimal valor, string conta)
    {
        // Debita conta corrente
        return FormatarTransacao();
    }
}
