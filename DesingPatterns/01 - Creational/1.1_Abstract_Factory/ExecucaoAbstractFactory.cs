using DesingPatterns._01___Creational._1._1_Abstract_Factory.Models;

namespace DesingPatterns._01___Creational._1._1_Abstract_Factory;

public class ExecucaoAbstractFactory
{
    public static void Executar()
    {
        var veiculoSocorro = new List<Veiculo>
        {
            VeiculoCreator.Criar("Celta", Veiculo.Porte.Pequeno),
            VeiculoCreator.Criar("Jetta", Veiculo.Porte.Medio),
            VeiculoCreator.Criar("BMW X6", Veiculo.Porte.Grande),
        };

        veiculoSocorro.ForEach(f => AutoSocorro.CriarAutoSocorro(f).RealizarAtendimento());
    }
}
