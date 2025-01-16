namespace DesingPatterns._01___Creational._1._2_Factory_Method;

public  class OracleFactory : DbFactory
{
    public override DbConnector CreateConnector(string connectionString)
    {
        return new OracleDbConnector(connectionString);
    }
}
