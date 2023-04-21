using Dapper;
using Microsoft.Data.SqlClient;

namespace StudentDBRead3
{
    public class StudentRead3
    {
        public static void GetStudentRecords(int Id)
        {

            // Set up the connection string to the database
            string connectionString = "Data Source=R933277-W10;Initial Catalog=StudentDB;Integrated Security=True";

            // Create a new SqlConnection object using the connection string
            using (var connection = new SqlConnection(connectionString))
            {
                // Open the connection to the database -> use db
                connection.Open();

                
            }

        }

    }
}