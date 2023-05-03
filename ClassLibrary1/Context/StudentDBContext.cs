using Microsoft.EntityFrameworkCore;
using StudentWriteDB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWriteDB.Context
{
    public class StudentDBContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=R933277-W10;Initial Catalog=StudentDB;Integrated Security=True");
        }
        public DbSet<Student> Student { get; set; }
    }
}
