using Microsoft.EntityFrameworkCore;
using StudentDBRead2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDBRead2.Context
{
    public class StudentContext : DbContext
    {
        
        // Set up the connection string to the database
        //string connectionString = "Data Source=R933277-W10;Initial Catalog=StudentDB;Integrated Security=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=R933277-W10;Initial Catalog=StudentDB;Integrated Security=True");
        }
        public DbSet<Student> Student { get; set; }
    }
}
