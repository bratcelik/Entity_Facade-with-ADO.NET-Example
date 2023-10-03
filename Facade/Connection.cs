namespace Facade
{
    public class Connection
    {
        public static string ConnectionString
        {
            get
            {
                return "Server=localhost;Database=NORTHWND;Trusted_Connection=True;";
            }
        }
    }
}
