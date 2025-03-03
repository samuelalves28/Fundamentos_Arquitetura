namespace DesingPatterns.Ordenacao;

public class ExecucaoOrdenacao
{
    public static async void Executar()
    {
        Console.WriteLine("Digite a lista que você quer ordenar");
        Console.Write("Lista: ");

        var console = Console.ReadLine();
        var list = console.Split(',').ToList();
        var result = OrdenacaoList(list);

        Console.WriteLine("A ordenação da lista é :" + string.Join(",", result));
    }

    private static List<string> OrdenacaoList(List<string> list)
    {
        for (int i = list.Count - 1; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (list[j].CompareTo(list[j + 1]) > 0)
                {
                    TrocarPosicao(list, j, j + 1);
                }
            }
        }

        return list;
    }

    private static List<string> TrocarPosicao(List<string> list, int i, int j)
    {
        var temp = list[i];
        list[i] = list[j];
        list[j] = temp;
        return list;
    }
}
