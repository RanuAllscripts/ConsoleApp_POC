using StudentDBRead1;
using StudentDBRead2;
using StudentRead3DB;

namespace StudentMainConsole
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("1. Method 1");
            Console.WriteLine("2. Method 2");
            Console.WriteLine("3. Method 3");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter Your Choice");

            string inp = Console.ReadLine();
            int ch = Convert.ToInt32(inp);
            switch(ch)
            {
                    case 1: Console.WriteLine("Enter Student Roll Number");
                            string Input = Console.ReadLine();
                            int Id = Convert.ToInt32(Input);
                            StudentRead1.GetStudent(Id);
                            break;

                    case 2: Console.WriteLine("Enter Student Roll Number");
                            string Input1 = Console.ReadLine();
                            int studentRoll = Convert.ToInt32(Input1);
                            StudentRead2.GetStudentDetails(studentRoll);
                            break;

                    case 3:Console.WriteLine("Enter Student Roll Number");
                           var RollNo = int.Parse(Console.ReadLine());
                           StudnetRead3.GetStudentDetail(RollNo);
                            break;

                    default: Console.WriteLine("Exiting........."); 
                            break;
            }
            
        }
    }
}