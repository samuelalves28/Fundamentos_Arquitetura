namespace DesingPatterns._01___Creational._1._2_Factory_Method;

public class Connection
{
    public Connection(string connectionString)
    {
        ConnectionString = connectionString;
    }

    public string ConnectionString { get; set; } = "";
    public bool Opened { get; set; }

    public void ExecuteCommand(string command)
    {
        Console.WriteLine("Executando o comando: " + command);
    }

    public void Open() => Opened = true;
    public void Close() => Opened = false;
}
