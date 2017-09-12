using System;

namespace Factorial
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number you would like to find the factorial of: ");

            int num = int.Parse(Console.ReadLine());

            int factorial = FindFactorial(num);

            Console.WriteLine("The factorial of {0} is {1}.", num, factorial);
        }

        private static int FindFactorial(int num)
        {

            if (num == 0) 
            {
                return 1;
            } 
            else 
            {
                return num * FindFactorial(num - 1);
            }

        }
    }
}
