namespace DesingPatterns._01___Creational._1._1_Abstract_Factory;

internal class SocorroVeiculoPequenoFactory : AutoSocorroFactory
{
    public override Models.Guincho CriarGuincho()
    {
        return Models.GuinchoCreator.Criar(Models.Veiculo.Porte.Medio);
    }

    public override Models.Veiculo CriarVeiculo(string modelo, Models.Veiculo.Porte porte)
    {
        return Models.VeiculoCreator.Criar(modelo, porte);
    }
}