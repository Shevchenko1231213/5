using System.Data.SqlClient;

namespace Lab5.Dal.Data
{
    public class DatabaseConnection
    {
        public static SqlConnection CreateConnection()
        {
            return new SqlConnection("Data Source=DESKTOP-ELR5B0P;Initial Catalog=Organization;Integrated Security=True;");
        }
    }
}
