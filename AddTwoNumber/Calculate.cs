namespace AddTwoNumber
{
    public class Calculate
    {
        /// <summary>
        /// This method adds two integers and returns the result.
        /// </summary>
        /// <param name="num1">The first integer to add</param>
        /// <param name="num2">The second integer to add</param>
        /// <returns>The sum of the two integers</returns>
        public static int AddNumber(int num1, int num2)
        {
            try
            {
                int sum = checked(num1 + num2); //checked to check arithmetic operation and it will throw overflow or underflow

                return sum;
            }

            catch (OverflowException e) //this occurs when the result exceed max value that can be store in int datatype
            {
                Console.WriteLine("Error: {0}", e.Message); //to print error message on console
                return 0;
            }

        }

    }
}
