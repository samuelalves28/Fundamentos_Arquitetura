using OOP._02_Pilares_OOP.Abestracao;

namespace OOP._02_Pilares_OOP.Poliformismo;

public class Geladeira : Eletrodomestico
{
    public Geladeira(string nome, int voltagem) : base(nome, voltagem)
    {

    }

    public Geladeira() : base(nome: "Padrão", voltagem: 110)
    {

    }

    /// <summary>
    /// Podemos ver como funciona a forma do poliformismo quando temos varias funções e elas tem algumas formas de implemeta-las.
    /// </summary>
    public override void Ligar()
    {
        //Ligar ela somente quando ela tiver bem gelada ou  não tiver em um piso irregular.
    }

    public override void Desligar()
    {
    }
}

