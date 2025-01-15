using System.ComponentModel;

namespace DesingPatterns._01___Creational._1._1_Abstract_Factory.Models;

public abstract class Veiculo
{
    public enum Porte : short
    {
        [Description("Pequeno")]
        Pequeno = 1,

        [Description("Medio")]
        Medio = 2,

        [Description("Grande")]
        Grande = 3,
    }

    public Veiculo(string modelo, Veiculo.Porte porteVeiculo)
    {
        Modelo = modelo;
        PorteVeiculo = porteVeiculo;
    }

    public string Modelo { get; private set; }
    public Porte PorteVeiculo { get; private set; }
}


public class VeiculoPequeno : Veiculo
{
    public VeiculoPequeno(string modelo, Porte porte) : base(modelo, porte) { }
}


public class VeiculoMedio : Veiculo
{
    public VeiculoMedio(string modelo, Porte porte) : base(modelo, porte) { }
}


public class VeiculoGrande : Veiculo
{
    public VeiculoGrande(string modelo, Porte porte) : base(modelo, porte) { }
}

public class VeiculoCreator
{
    public static Veiculo Criar(string modelo, Veiculo.Porte porte)
    {
        return porte switch
        {
            Veiculo.Porte.Pequeno => new VeiculoPequeno(modelo, porte),
            Veiculo.Porte.Medio => new VeiculoMedio(modelo, porte),
            Veiculo.Porte.Grande => new VeiculoGrande(modelo, porte),
            _ => throw new ApplicationException("Porte de Guincho desconhecido"),
        };
    }
}