namespace DesingPatterns._01___Creational._1._2_Factory_Method;

public abstract class DbConnector
{
    public DbConnector(string connectionString)
    {
        ConnectionString = connectionString;
    }

    public string ConnectionString { get; set; }

    // Esse cara é abstrato porque eu tenho que implementar as funções dele na hora da execução;
    public abstract Connection Connect();
}
