namespace DesingPatterns._01___Creational._1._2_Factory_Method;

public  class SqlFactory : DbFactory
{
    public override DbConnector CreateConnector(string connectionString)
    {
        return new SqlServerConnector(connectionString);
    }
}
