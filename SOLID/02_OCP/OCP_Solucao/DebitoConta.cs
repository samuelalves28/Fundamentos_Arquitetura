namespace SOLID._02_OCP.OCP_Solucao;

/// <summary>
/// Quando faço isso crio uma super classe e uma classe base para as outras. Então ela tem que implementar o método abstrato 
/// debitar.
/// </summary>
public abstract class DebitoConta
{
    public string NumeroTransacao { get; private set; }
    public abstract string Debitar(decimal valor, string conta);

    public string FormatarTransacao()
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        var random = new Random();
        NumeroTransacao = new string(Enumerable.Repeat(chars, 15)
            .Select(s => s[random.Next(s.Length)]).ToArray());

        return NumeroTransacao;
    }
}
