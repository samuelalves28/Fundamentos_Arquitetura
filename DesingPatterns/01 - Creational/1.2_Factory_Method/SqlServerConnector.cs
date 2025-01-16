namespace DesingPatterns._01___Creational._1._2_Factory_Method;

public class SqlServerConnector : DbConnector
{
    public SqlServerConnector(string connectionString) : base(connectionString)
    {
        ConnectionString = connectionString;
    }

    public override Connection Connect()
    {
        Console.WriteLine("Conectando ao banco Sql...");
        var connection = new Connection(ConnectionString);
        connection.Open();

        return connection;
    }
}
