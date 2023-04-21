using System.Data.SqlClient;
using Dapper;
using StudentRead3DB.Model;

namespace StudentRead3DB
{
    public class StudnetRead3
    {
        public static void GetStudentDetail(int id)
        {
            // Set up the connection string to the database
            string connectionString = "Data Source=R933277-W10;Initial Catalog=StudentDB;Integrated Security=True";

            // Create a new SqlConnection object using the connection string
            //using is used here since it ensures that connection once established to the database must be disposed when we want to close it.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection to the database -> use db
                connection.Open();

                //it returns only a single object or null if the result set is empty or has more than one row.
                var student = connection.QuerySingleOrDefault<Student>("SELECT * FROM Student WHERE Roll = @RollNo", new { RollNo = id}); //without new { RollNo = id} it is giving error must declare the scalar variale id

                //If there is data in student then print those datas on console
                if (student != null)
                {
                    Console.WriteLine($"Name: {student.Name} \nGender: {student.Gender} \nDOB: {student.DOB}");
                }
                else 
                { 
                    Console.WriteLine("No Student is associated with this roll number");
                }
            }//while exiting the using block the connection is disposed.
        }
    }
}