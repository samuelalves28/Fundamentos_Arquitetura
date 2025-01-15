using System.ComponentModel;

namespace DesingPatterns._01___Creational._1._2_Factory_Method;

public class DataBase
{
    public enum EnumTipoDataBase
    {
        [Description("Mongo")]
        Mongo = 1,
        [Description("SqlServer")]
        SqlServer = 2,
        [Description("Oracle")]
        Oracle = 3,
    }

    public EnumTipoDataBase EnumDataBases { get; set; }
}
