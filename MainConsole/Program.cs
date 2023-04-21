using AddTwoNumber;
namespace MainConsole
{
    /// <summary>
    /// Main method is implemented here
    /// </summary>
    class Program
    {
        /// <summary>
        /// Methods to add two numbers are called here
        /// </summary>
        public static void Main(String[] args)
        {
            int num1 = int.MaxValue; //max value which a int can hold
            int num2 = int.MaxValue;

            Console.WriteLine("Enter Number 1");
            string input1 = Console.ReadLine(); //to take input from user
            int n1;

            Console.WriteLine("Enter Number 2");
            string input2 = Console.ReadLine(); //to take input from user
            int n2;

            if (int.TryParse(input1, out n1) && int.TryParse(input2, out n2))
            {
                int result = Calculate.AddNumber(n1, n2);
                Console.WriteLine("Sum of {0} and {1} is {2}", n1, n2, result); //to print result on console
            }
            else
            {
                Console.WriteLine("Please enter the integer input");
            }

            int int_result = Calculate.AddNumber(num1, num2);
            Console.WriteLine("Sum of {0} and {1} is {2}: ", num1, num2, int_result); //to print result on console
        }
    }

}
