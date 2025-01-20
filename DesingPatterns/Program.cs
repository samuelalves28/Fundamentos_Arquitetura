using DesingPatterns._01___Creational._1._1_Abstract_Factory;
using DesingPatterns._01___Creational._1._2_Factory_Method;
using DesingPatterns._01___Creational._1._3_Singleton;
using DesingPatterns._02___Structural._2._1_Adapter;

namespace DesingPatterns;

class Program
{
    private static void Main()
    {
        Console.WriteLine("Escolha a operação: ");
        Console.WriteLine("--------------------");
        Console.WriteLine("Creational Patterns ");
        Console.WriteLine("1 - Abstract Factory ");
        Console.WriteLine("2 - Method Factory ");
        Console.WriteLine("3 - Singleton ");
        Console.WriteLine("--------------------");
        Console.WriteLine("Structural Patterns ");
        Console.WriteLine("--------------------");
        Console.WriteLine("4 - Adapter");
        Console.WriteLine("5 - Facade");
        Console.WriteLine("--------------------");
        Console.WriteLine("Behavioral Patterns ");
        Console.WriteLine("--------------------");
        Console.WriteLine("6 - Commad");
        Console.WriteLine("7 - Strategy");
        Console.WriteLine("");
        Console.Write("Escolha: ");


        var opcao = Console.ReadKey();

        Console.WriteLine("");
        Console.WriteLine("--------------------");
        Console.WriteLine("");

        switch (opcao.KeyChar)
        {
            case '1':
                ExecucaoAbstractFactory.Executar();
                break;
            case '2':
                ExecucaoFactoryMethod.Executar();
                break;
            case '3':
                ExecucaoSingleton.Executar();
                break;
            case '4':
                ExecuteAdapter.Executar();
                break;
            default:
                break;
        }

        Console.ReadKey();
        Console.Clear();
        Main();
    }
}