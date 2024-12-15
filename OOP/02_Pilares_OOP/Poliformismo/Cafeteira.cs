using OOP._02_Pilares_OOP.Abestracao;

namespace OOP._02_Pilares_OOP.Poliformismo;


/// <summary>
/// Polimorfismo significa que tem muiltiplos comportamentos.
/// Quando você herda de uma classe que é abstract ela simplesmente e você tem metodos que são abstract ele
/// te obriga simpplesmente instanciar eles na clsse.
/// </summary>
public class Cafeteira : Eletrodomestico
{
    public Cafeteira(string nome, int voltagem) : base(nome: nome, voltagem: voltagem)
    {

    }

    public Cafeteira() : base(nome: "Padrão", voltagem: 220)
    {

    }

    private static void AquecerAguar() { }

    private static void MoerGraos() { }

    public void PrepararCafe()
    {
        AquecerAguar();
        MoerGraos();
    }

    /// <summary>
    /// Esses métodos override indicam que estão sobrescrevendo os métodos ligar e desligar, que foram definido
    /// como funções abstratas na classe base Eletrodomestico. Agora se tivemos classes que não são abstratas 
    /// na classe pai não conseguimos fazer oberride nela. O polimofismo está aqui também pois iremos ter varias
    /// implementações de ligar e desligar mas cada um vai ter uma peculiaridade.
    /// </summary>
    public override void Ligar()
    {
        //Ligar somente quando a agua estiver aquecida.
    }

    public override void Desligar()
    {
    }
}

