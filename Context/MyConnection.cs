using System.Data.SqlClient;

namespace ConsoleApp2.Context
{
    public class MyConnection
    {
        private static readonly string connectionString =
        "Data Source=INDOMIEGORENG;Database=db_booking_room;Integrated Security = True; Connect Timeout = 30; Encrypt=False;";

        public static SqlConnection Get()
        {
            return new SqlConnection(connectionString);
        }
    }
}
