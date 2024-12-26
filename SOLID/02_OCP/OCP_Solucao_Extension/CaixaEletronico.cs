namespace SOLID._02_OCP.OCP_Solucao_Extension;

public class CaixaEletronico
{
    public static void Operacoes()
    {
        MenuOperacoes();

        var opcao = Console.ReadKey();
        var retorno = string.Empty;

        var debitoConta = DadosDebito();

        switch (opcao.KeyChar)
        {
            case '1':
                retorno = debitoConta.ContaCorrente();
                break;
            case '2':
                retorno = debitoConta.ContaPoupanca();
                break;
            default:
                retorno = "Operação inválida";
                break;
        }
    }

    private static void MenuOperacoes()
    {
        Console.WriteLine("Caixa Eletrônico SOLID");
        Console.WriteLine("Escolha a operação desejada:");
        Console.WriteLine("1 - Débito Conta Corrente");
        Console.WriteLine("2 - Débito Conta Poupança");
        Console.WriteLine("3 - Débito Conta Investimento");
    }

    private static DebitoConta DadosDebito()
    {
        Console.WriteLine("Digite o número da conta:");
        var conta = Console.ReadLine();

        Console.WriteLine("Digite o valor do débito:");
        var valor = Convert.ToDecimal(Console.ReadLine());

        return new DebitoConta(valor, conta);
    }
}
