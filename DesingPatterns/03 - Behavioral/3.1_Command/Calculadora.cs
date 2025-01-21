using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns._03___Behavioral._3._1_Command;

public class Calculadora
{
    private int _valor = 0;

    public void Operacao(char operador, int valor)
    {
        switch (operador)
        {
            case '+': _valor += valor; break;
            case '-': _valor -= valor; break;
            case '*': _valor *= valor; break;
            case '/': _valor /= valor; break;
        }
        Console.WriteLine("(dado {1} {2}) - valor atual = {0,3}", _valor, operador, valor);
    }
}
