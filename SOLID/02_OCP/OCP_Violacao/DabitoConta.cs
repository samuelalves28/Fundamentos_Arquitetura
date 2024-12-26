namespace SOLID._02_OCP.OCP_Violacao;

/// <summary>
/// O problema desta classe e que ela não está fechada para modificação.
/// </summary>
public class DabitoConta
{
    public void Debitar(decimal valor, string conta, TipoConta tipoConta)
    {
        if (tipoConta == TipoConta.Corrente)
        {
            // Debita Conta Corrente
        }

        if (tipoConta == TipoConta.Poupanca)
        {
            // Valida aniversário da conta
            // Debita Conta Poupança
        }
    }

}
