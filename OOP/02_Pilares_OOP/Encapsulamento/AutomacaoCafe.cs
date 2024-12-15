using OOP._02_Pilares_OOP.Poliformismo;

namespace OOP._02_Pilares_OOP.Encapsulamento;

/// <summary>
/// O encapsulamento permite esconder certos comportamentos internos, tornando-os privados, 
/// enquanto expõe outros comportamentos de alto nível que podem ser utilizados de forma controlada. 
/// Por exemplo, um método como PrepararCafe pode encapsular a lógica necessária para preparar o café, 
/// contendo em sua composição métodos privados que realizam etapas específicas, como aquecer a água ou moer
/// os grãos. Esses métodos privados não devem ser acessíveis diretamente, garantindo que o conceito de
/// encapsulamento seja eficaz e que a lógica interna seja protegida contra usos inadequados ou indevidos.
/// </summary>
public class AutomacaoCafe
{
    public void ServirCafe()
    {
        var espresso = new Cafeteira();
        espresso.Ligar();
        espresso.PrepararCafe();
        espresso.Desligar();
    }
}

