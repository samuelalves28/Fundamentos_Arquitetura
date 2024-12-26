using System.Data;
using System.Data.SqlClient;

namespace SOLID._01_SRP.SRP_Solucao;

public class ClienteRepository
{
    public void AdicionarCliente(Cliente cliente)
    {
        using var conn = new SqlConnection();
        var cmd = new SqlCommand();

        conn.ConnectionString = "MinhaConnectionString";
        cmd.Connection = conn;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "INSERT INTO CLIENTES (NOME, EMAIL, CPF, DATA_CADASTRO) VALUES (@NOME, @EMAIL, @CPF, @DATA_CADASTRO)";

        cmd.Parameters.AddWithValue("NOME", cliente.Nome);
        cmd.Parameters.AddWithValue("EMAIL", cliente.Email);
        cmd.Parameters.AddWithValue("CPF", cliente.Cpf);
        cmd.Parameters.AddWithValue("DATA_CADASTRO", cliente.DataCadastro);

        conn.Open();
        cmd.ExecuteNonQuery();
    }
}
