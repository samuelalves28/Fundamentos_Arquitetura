namespace DesingPatterns._01___Creational._1._2_Factory_Method;

public abstract class DbFactory
{
    public abstract DbConnector CreateConnector(string connectionString);

    public static DbFactory Database(DataBase.EnumTipoDataBase dataBase)
    {
        if (dataBase == DataBase.EnumTipoDataBase.SqlServer) return new SqlFactory();
        else if (dataBase == DataBase.EnumTipoDataBase.Oracle) return new OracleFactory();

        throw new ApplicationException("Banco não reconhecido");
    }
}
