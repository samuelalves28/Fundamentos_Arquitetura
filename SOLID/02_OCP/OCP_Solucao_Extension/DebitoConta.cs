﻿namespace SOLID._02_OCP.OCP_Solucao_Extension;
public class DebitoConta
{
    public string NumeroTransacao { get; private set; }
    public decimal Valor { get; private set; }
    public string NumeroConta { get; private set; }

    public DebitoConta(decimal valor, string numeroConta)
    {
        Valor = valor;
        NumeroConta = numeroConta;
    }

    public string FormatarTransacao()
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        var random = new Random();

        NumeroTransacao = new string(Enumerable.Repeat(chars, 15)
            .Select(s => s[random.Next(s.Length)]).ToArray());

        return NumeroTransacao;
    }
}