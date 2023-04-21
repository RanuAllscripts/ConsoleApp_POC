using System.Data.SqlClient;

namespace StudentDBRead1
{
    public class StudentRead1
    {
        /// <summary>
        /// Method with name GetStudent
        /// </summary>
        /// <param name="Id"></param>
        public static void GetStudent(int Id)
        {

            // Set up the connection string to the database
            string connectionString = "Data Source=R933277-W10;Initial Catalog=StudentDB;Integrated Security=True";

            // Create a new SqlConnection object using the connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            { 
                // Open the connection to the database -> use db
                connection.Open();

                //ADO.Net
                string cmd = $"SELECT * FROM Student WHERE Roll = {Id}";
                
                // Create a new SqlCommand object to execute a query
                SqlCommand command = new SqlCommand(cmd, connection);

                command.CommandType = System.Data.CommandType.Text;
                //command.Parameters =  // this is list
                //another way is this -> SqlCommand command = new SqlCommand($"SELECT * FROM Student WHERE Roll = {Id}", connection);
                // It Doesn't Works -> SqlCommand command = new SqlCommand("SELECT * FROM Student WHERE Roll = ${Id}", connection);

                // Execute the query and get a SqlDataReader object to read the results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Loop through the results and display each student's details to the console
                    while (reader.Read())
                    {
                        Console.WriteLine("Roll: {0}\nName: {1}\nGender: {2}\nDOB: {3}\n", reader["Roll"], reader["Name"], reader["Gender"], reader["DOB"]);
                    } //
                }

            }

        }
    }
}