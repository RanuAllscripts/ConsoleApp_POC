using ConnectionStringClass;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;

namespace StudentWriteDB
{
    public class StudentWrite1
    {
        public static void AddStudentDetails()
        {
            //create a connection string
            //string connectionString = "Data Source=R933277-W10;Initial Catalog=StudentDB;Integrated Security=True";
            string connectionString = ConnectionString.ManageConnection();

            try
            {
                //create SqlConnection object 
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //open the connection
                    connection.Open();

                    Console.WriteLine("Enter Student Roll no.");
                    
                    string input = Console.ReadLine();
                    int studRoll = int.Parse(input);
                    Console.WriteLine("Enter Student Name");
                    string studName = Console.ReadLine();
                    
                    if(string.IsNullOrEmpty(studName))
                    {
                        Console.WriteLine("Name is Required");
                        return;
                    }

                    Console.WriteLine("Enter Student Gender Male/Female");
                    string studGender = ValidateGender();
                    


                    if(string.IsNullOrEmpty(studGender))
                    {
                        return;
                    }
                    Console.WriteLine("Enter Student DOB year/month/day");

                    /*Console.Write("Enter a month: ");
                    int month = int.Parse(Console.ReadLine());
                    Console.Write("Enter a day: ");
                    int day = int.Parse(Console.ReadLine());
                    Console.Write("Enter a year: ");
                    int year = int.Parse(Console.ReadLine());
                    DateTime studBirthday = new DateTime(year, month, day);
                    */
                    // DateTime studBirthday = new DateTime(day, month, year); //Year, Month, and Day parameters describe an un-representable DateTime.

                   
                    //Another way for Date
                    DateTime studBirthday = DateTime.Parse(Console.ReadLine()); 

                    //create a sql command object
                    SqlCommand command = new SqlCommand("INSERT INTO Student(Roll, Name, Gender, DOB) VALUES (@value1, @value2, @value3, @value4)", connection);

                    command.Parameters.AddWithValue("@value1", studRoll);
                    command.Parameters.AddWithValue("@value2", studName);
                    command.Parameters.AddWithValue("@value3", studGender);
                    command.Parameters.AddWithValue("@value4", studBirthday);
                    //try with sqlParameter
                    command.ExecuteNonQuery();
                    Console.WriteLine("Student Details Added Successfully!!");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
           
        }

        public static string ValidateGender()
        {
            string studGender;
            bool isValid = false;
            string gender = string.Empty;
            do
            {
                studGender = Console.ReadLine();
                if (studGender.Equals("Male") || studGender.Equals("Female"))
                {
                    isValid = true;
                    gender = studGender;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input Gender should be Male/Female");
                    //break;
                }
            }while (isValid);
            return gender; 
        }
        public static void UpdateStudentDetails()
        {
            //string connectionString = "Data Source=R933277-W10;Initial Catalog=StudentDB;Integrated Security=True";
            string connectionString = ConnectionString.ManageConnection();
            try
            {
                
                using(SqlConnection connection = new SqlConnection(connectionString))
                {   
                    connection.Open();

                    Console.WriteLine("Enter Roll No. of Student to Update");
                    int Roll = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Student New Name");
                    string studNewName = Console.ReadLine();

                    SqlCommand command = new SqlCommand("UpdateStudentName", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    
                    command.Parameters.AddWithValue("@Roll", Roll);
                    command.Parameters.AddWithValue("@NewName", studNewName);

                    command.ExecuteNonQuery();

                    Console.WriteLine("Name Updated Successfully for Roll Number: " + Roll);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

           
        }
    }
}