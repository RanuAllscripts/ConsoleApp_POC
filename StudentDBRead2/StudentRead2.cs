﻿using Microsoft.EntityFrameworkCore;
using StudentDBRead2.Context;
using StudentDBRead2.Model;

namespace StudentDBRead2
{
    public class StudentRead2
    {
        public static void GetStudentDetails(int Id)
        
        {
            using(var results = new StudentContext())
            {
                var stud = results.Student.Where(x => x.Roll == Id).FirstOrDefault(); 
                
                Console.WriteLine("Name: {0} \nGender: {1} \nDOB: {2}", stud.Name, stud.Gender, stud.DOB.ToShortDateString());
                
            }
            
        }
        
    }

    
}