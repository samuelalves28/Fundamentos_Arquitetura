using DesingPatterns._01___Creational._1._1_Abstract_Factory.Models;

namespace DesingPatterns._01___Creational._1._1_Abstract_Factory;

public class AutoSocorro
{
    private readonly Veiculo _veiculo;
    private readonly Guincho _guincho;

    public AutoSocorro(AutoSocorroFactory factory, Veiculo veiculo)
    {
        _veiculo = factory.CriarVeiculo(veiculo.Modelo, veiculo.PorteVeiculo);
        _guincho = factory.CriarGuincho();
    }

    public void RealizarAtendimento()
    {
        _guincho.Socorrer(_veiculo);
    }

    public static AutoSocorro CriarAutoSocorro(Veiculo veiculo)
    {
        return veiculo.PorteVeiculo switch
        {
            Veiculo.Porte.Pequeno => new AutoSocorro(new SocorroVeiculoPequenoFactory(), veiculo),
            Veiculo.Porte.Medio => new AutoSocorro(new SocorroVeiculoMedioFactory(), veiculo),
            Veiculo.Porte.Grande => new AutoSocorro(new SocorroVeiculoGrandeFactory(), veiculo),
            _ => throw new ApplicationException("Não foi possível identificar o veículo"),
        };
    }
}
