using System;

namespace RecursionHW
{
    class Program
    {
        public int factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }
        public int fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return fibonacci(n - 1) + fibonacci(n - 2);
            }
        }
        public int exponential(int x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return x * exponential(x, n - 1);
            }
        }
        static void Main(string[] args)
        { 
            Program program = new Program();
            Console.WriteLine("Welcome to the Recursion Program!");
            Console.WriteLine("This program will calculate the Fibonacci, Exponential, and Factorial of a number using recursion.");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Fibonacci");
            Console.WriteLine("2. Exponential");
            Console.WriteLine("3. Factorial");
            Console.WriteLine("4. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            while (choice != 4)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter a number to calculate its Fibonacci:");
                        int FibNum = Convert.ToInt32(Console.ReadLine());
                        int FibResult = program.fibonacci(FibNum);
                        Console.WriteLine($"The Fibonacci number is {FibResult}");
                        break;
                    case 2:
                        Console.WriteLine("Enter a base and an exponent to calculate the exponential:");
                        int baseNum = Convert.ToInt32(Console.ReadLine());
                        int exponent = Convert.ToInt32(Console.ReadLine());
                        int ExpResult = program.exponential(baseNum, exponent);
                        Console.WriteLine($"The exponential is {ExpResult}");
                        break;
                    case 3:
                        Console.WriteLine("Enter a number to calculate its factorial:");
                        int FacNum = Convert.ToInt32(Console.ReadLine());
                        int FacResult = program.factorial(FacNum);
                        Console.WriteLine($"The factorial is {FacResult}");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.WriteLine("Please select another option or exit:");
                choice = Convert.ToInt32(Console.ReadLine());
            }
           
        }
    }
}
