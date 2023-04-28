namespace ConnectionStringClass
{
    public class ConnectionString
    {
        //static me baar baar object ni bnana pdega
        public static string ManageConnection ()
        {
            string connectionString = "Data Source=R933277-W10;Initial Catalog=StudentDB;Integrated Security=True";
            return connectionString;
        }
    }
}