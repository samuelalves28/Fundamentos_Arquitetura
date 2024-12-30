namespace SOLID._05_DIP.DIP_Solucao.Interface;

public interface IEmailService
{
    void Enviar(string de, string para, string assunto, string mensagem);
}
