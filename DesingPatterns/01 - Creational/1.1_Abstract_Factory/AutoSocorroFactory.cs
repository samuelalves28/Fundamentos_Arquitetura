namespace DesingPatterns._01___Creational._1._1_Abstract_Factory;

//Aqui é um fabrica de de construtores.
public abstract class AutoSocorroFactory
{
    public abstract Models.Guincho CriarGuincho();
    public abstract Models.Veiculo CriarVeiculo(string modelo, Models.Veiculo.Porte porte);
}
