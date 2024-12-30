using SOLID._05_DIP.DIP_Solucao.Interface;
using System.Net.Mail;

namespace SOLID._05_DIP.DIP_Solucao.Service;

public class EmailService : IEmailService
{
    public void Enviar(string de, string para, string assunto, string mensagem)
    {
        var mail = new MailMessage(de, para);
        var client = new SmtpClient
        {
            Port = 25,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Host = "smtp.google.com"
        };

        mail.Subject = assunto;
        mail.Body = mensagem;
        client.Send(mail);
    }
}
