using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using StudentWriteDB.Context;
using StudentWriteDB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWriteDB
{
    public class StudentWrite2
    {
        public static void AddStudentDetails()
        {
            try
            {
                using (var context = new StudentDBContext())
                {
                    var newStudent = new Student();

                    Console.WriteLine("Enter Roll No.");
                    newStudent.RNo = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Name: ");
                    newStudent.Name = Console.ReadLine();

                    Console.WriteLine("Enter DOB: ");
                    newStudent.DOB = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Gender: 1.Female 2.Male ");
                    //newStudent.Gender = Console.ReadLine();
                    int genderChoice;
                    if(int.TryParse(Console.ReadLine(), out genderChoice) && Enum.IsDefined(typeof(GenderOPtions), genderChoice))
                    {
                        newStudent.Gender = (GenderOPtions)genderChoice; 
                    }

                    context.Student.Add(newStudent);
                    context.SaveChanges();
                    Console.WriteLine("Added Successfully...!!");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void UpdateStudentDetails() 
        {
            try
            {
                using (var context = new StudentDBContext())
                {
                    var student = new Student();
                    Console.WriteLine("Enter Roll number to update name: ");
                    int rollNo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter New name: ");
                    string newName = Console.ReadLine();

                    var rollNumberParam = new SqlParameter("@Roll", rollNo);
                    var newNameParam = new SqlParameter("@NewName", newName);
                    context.Database.ExecuteSqlInterpolated($"EXEC UpdateStudentName {rollNumberParam}, {newNameParam}");

                    Console.WriteLine("Updated Successfully...");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
