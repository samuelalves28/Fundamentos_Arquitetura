namespace SOLID._02_OCP.OCP_Solucao;

/// <summary>
/// Aqui estou herdando a classe base DebitoConta e implementando o método abstrato debitar. Colocando outas regras
/// que quero implemnetar também. 
/// </summary>
public class DebitoContaPoupanca : DebitoConta
{
    public override string Debitar(decimal valor, string conta)
    {
        // Debita conta poupança
        // Valida Data de nascimento.
        return FormatarTransacao();
    }
}
