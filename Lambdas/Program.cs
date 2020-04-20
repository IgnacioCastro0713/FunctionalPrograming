using System;

namespace Lambdas
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /* lambda = anonymous function */
            
            // one param lambda function
            Func<int, bool> isEven = number => number % 2 == 0;
            Console.WriteLine($"The number is even: {isEven(10)}");
            
            // two params lambda function
            Func<int, int, int> sum = (num1, num2) => num1 + num2;
            Console.WriteLine($"The sum is: {sum(3, 5)}");
            
            // Body lambda function
            Func<string, bool> validEmail = s =>
            {
                if (s.EndsWith("@gmail.com", StringComparison.CurrentCulture)) 
                    return true;
                Console.WriteLine("> this email is invalid.");
                return false;
            };
            Console.WriteLine($"The email is valid");
            
            // Lambda expressions functions without return
            Action<string> print = s => Console.WriteLine(s);
            print("I am lambda function!");
        }
    }
}