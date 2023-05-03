using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDBRead2.Model
{
    public class Student
    {
        [Key]
        [Column("Roll")]
        public int RNo { get; set; }

        /*[Required(ErrorMessage = "Name Field is Required")]
        [MinLength(3,ErrorMessage ="Name Shouldn't be less than 3 letters")]
        [MaxLength(50, ErrorMessage = "Name Shouldn't be More than 50 letters")]*/

        //[Required]
        public string? Name { get; set; } // ?, :?, .?/?.

        //[Required(ErrorMessage = "Gender Field is Required")]
        public string Gender { get; set; }

        //[Required(ErrorMessage = "DOB Field is Required")]
        //[Range(typeof(DateTime),"1/1/1800","{0}", ErrorMessage = "Please Enter Valid Date")] //here {0} represnets date till today it will take current date at runtim
        public DateTime DOB { get; set; }

    }
    
}

namespace StudentDBRead2
{
    public enum GenderOPtions
    {
        Female  =1,
        Male =2,
    }
}