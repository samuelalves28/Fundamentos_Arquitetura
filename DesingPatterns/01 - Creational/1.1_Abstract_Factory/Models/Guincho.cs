namespace DesingPatterns._01___Creational._1._1_Abstract_Factory.Models;

public abstract class Guincho
{
    protected Guincho(Veiculo.Porte porte)
    {
        Porte = porte;
    }

    public abstract void Socorrer(Veiculo veiculo);
    public Veiculo.Porte Porte { get; private set; }
}

public class GuinchoPequeno : Guincho
{
    public GuinchoPequeno(Veiculo.Porte porte) : base(porte) { }

    public override void Socorrer(Veiculo veiculo)
    {
        Console.WriteLine("Socorrendo Carro Pequeno = modelo : " + veiculo.Modelo);
    }
}

public class GuinchoMedio : Guincho
{
    public GuinchoMedio(Veiculo.Porte porte) : base(porte) { }

    public override void Socorrer(Veiculo veiculo)
    {
        Console.WriteLine("Socorrendo Carro Médio = modelo : " + veiculo.Modelo);
    }
}

public class GuinchoGrande : Guincho
{
    public GuinchoGrande(Veiculo.Porte porte) : base(porte) { }

    public override void Socorrer(Veiculo veiculo)
    {
        Console.WriteLine("Socorrendo Carro Grande = modelo : " + veiculo.Modelo);
    }
}

public class GuinchoCreator
{
    public static Guincho Criar(Veiculo.Porte porte)
    {
        return porte switch
        {
            Veiculo.Porte.Pequeno => new GuinchoPequeno(porte),
            Veiculo.Porte.Medio => new GuinchoMedio(porte),
            Veiculo.Porte.Grande => new GuinchoGrande(porte),
            _ => throw new ApplicationException("Porte de Guincho desconhecido"),
        };
    }
}
