using StudentWriteDB;

namespace StudentMainWriteDB
{
    class Progam
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Write data in DB");
            Console.WriteLine("1. Add Student Details");
            Console.WriteLine("2. Update Student Details");
            Console.WriteLine("3. Press any number to exit");
            Console.WriteLine("Choose one");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:StudentWrite1.AddStudentDetails();
                    break;
                case 2: StudentWrite1.UpdateStudentDetails();
                    break;
                case 3: Console.WriteLine();
                    break;
            }


        }
    }
}