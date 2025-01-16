namespace DesingPatterns._01___Creational._1._2_Factory_Method;

public class ExecucaoFactoryMethod
{
    public static void Executar()
    {
        var sqlCon = DbFactory.Database(DataBase.EnumTipoDataBase.SqlServer)
            .CreateConnector("minhaCs")
            .Connect();


        sqlCon.ExecuteCommand("Select * from tabelaSql");
        sqlCon.Close();

        Console.WriteLine("");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("");

        var oracleCn = DbFactory.Database(DataBase.EnumTipoDataBase.Oracle)
            .CreateConnector("minhaCs")
            .Connect();


        sqlCon.ExecuteCommand("Select * from tabelaOracle");
        sqlCon.Close();
    }
}
