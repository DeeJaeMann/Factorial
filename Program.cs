namespace Factorial
{
    /// <summary>
    /// Simple factorial example
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Simple factorial example
        /// </summary>
        static void Main()
        {
            Console.WriteLine(Factorial(0));
            Console.WriteLine(Factorial(1));
            Console.WriteLine(Factorial(2));
            Console.WriteLine(Factorial(3));
            Console.WriteLine(Factorial(4));
        }

        /// <summary>
        /// Perfroms factorial calculation on given number
        /// </summary>
        /// <param name="number">Int to perform calculation on</param>
        /// <returns>Calculation result</returns>
        static int Factorial(int number)
        {
            int result = 1;
            // Edge cases where no calculation is needed
            if (number == 0 | number == 1) return result;
            for(int currNum = number; currNum > 1; currNum--)
            {
                result *= currNum;
            }
            return result;
        }
    }
}
