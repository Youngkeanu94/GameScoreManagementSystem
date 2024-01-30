using System;


namespace IT391_Unit1_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*********************************************************
            //****Assignment 1, Section 1
            //*********************************************************
            Console.WriteLine();
            Console.WriteLine("**********Section 1 * *********");
            Console.WriteLine();
            Console.WriteLine("The Fibonacci value of 10 is: ");
            Console.WriteLine(fibonacci(10));
            Console.WriteLine();
            Console.WriteLine();
            //*********************************************************
            //****Assignment 1, Section 2
            //*********************************************************
            Console.WriteLine();
            Console.WriteLine("**********Section 2 * *********");
            Console.WriteLine();
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(i.ToString() + "! = " + factorial(i));
            }
            Console.WriteLine();
        }
        public static int fibonacci(int number)
        {
            if (number == 1 || number == 2)
            {
                return 1;
            }
            return fibonacci(number - 1) + fibonacci(number - 2);
        }
        public static int factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * factorial(number - 1);
        }
    }
}
