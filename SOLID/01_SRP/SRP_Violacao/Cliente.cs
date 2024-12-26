using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SOLID._01_SRP.SRP_Violacao;

/// <summary>
/// Aqui eu tenho uma violação do SRP, pois a classe Cliente tem mais de uma responsabilidade.
/// 
/// 1º Conexão com o banco de dados, classe não é reposanvel pela conexão com o banco de dados.
/// 2º Não é responsabilidade da classe enviar e-mail.
/// 
/// A classe Cliente ela funcional mas ela não e recomendada, pois ela tem mais de uma responsabilidade. Por exemplo se mudamos a forma de envio de e-mail, 
/// teriamos que mudar a classe Cliente. Se muda a forma de conexão com o banco de dados, teriamos que mudar a classe Cliente.
/// 
/// Outro ponto é que a classe não é coesa pois se eu cadastro no banco mas não envio o e-mail, ele cadastrou com sucesso? Ou se eu envio o e-mail 
/// mas não cadastro no banco, ele cadastrou com sucesso? a resposta é não pois não é coeso. Com isso o teste unitário também não é coeso, pois temos
/// mais de uma responsabilidade a gente não sabe aonde está o erro.
/// </summary>
public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Cpf { get; set; }
    public DateTime DataCadastro { get; set; }

    public string AdicionarCliente()
    {
        if (!Email.Contains('@'))
            return "Email inválido";

        if (Cpf.Length != 11)
            return "CPF inválido";

        using var conn = new SqlConnection();

        var cmd = new SqlCommand();

        conn.ConnectionString = "MinhaConnectionString";
        cmd.Connection = conn;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "INSERT INTO CLIENTES (NOME, EMAIL, CPF, DATA_CADASTRO) VALUES (@NOME, @EMAIL, @CPF, @DATA_CADASTRO)";

        cmd.Parameters.AddWithValue("NOME", Nome);
        cmd.Parameters.AddWithValue("EMAIL", Email);
        cmd.Parameters.AddWithValue("CPF", Cpf);
        cmd.Parameters.AddWithValue("DATA_CADASTRO", DataCadastro);

        conn.Open();
        cmd.ExecuteNonQuery();

        var mail = new MailMessage("empresa@gmail.com", Email);
        var client = new SmtpClient
        {
            Port = 25,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Host = "smtp.google.com"
        };

        mail.Subject = "Bem-vindo";
        mail.Body = "Parabéns! Você está cadastrado.";
        client.Send(mail);

        return "Cliente cadastrado com sucesso";
    }
}
