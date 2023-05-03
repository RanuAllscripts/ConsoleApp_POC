using StudentWriteDB;

namespace StudentMainWriteDB
{
    class Progam
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Write data in DB");
            Console.WriteLine("1. Add Student Details - ADO.NET");
            Console.WriteLine("2. Update Student Details - ADO.NET");
            Console.WriteLine("3. Add Student Details - EF");
            Console.WriteLine("4. Update Student Details - EF");
            Console.WriteLine("5. Press any number to exit");
            Console.WriteLine("Choose one");
            int ch = int.Parse(Console.ReadLine());

            bool repeat = true;
            while (repeat)
            {
                switch (ch)
                {
                    case 1:
                        StudentWrite1.AddStudentDetails();
                        break;
                    case 2:
                        StudentWrite1.UpdateStudentDetails();
                        break;
                    case 3:
                        StudentWrite2.AddStudentDetails();
                        break;
                    case 4:
                        StudentWrite2.UpdateStudentDetails();
                        break;
                    case 5:
                        //Console.WriteLine();
                        break;
                }
                Console.WriteLine("Do you want to repeat the switch case (Y/N): ");
                string ans = Console.ReadLine();
                if (ans.ToUpper() != "Y")
                {
                    repeat = false;
                }
            }
            


        }
    }
}