using System;

namespace CSharp_Homework_SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number:");
            int number1 = inputNumbers();
            Console.WriteLine("Please enter the second number:");
            int number2 = inputNumbers();

            //int tempNumber = number1;
            //number1 = number2;
            //number2 = tempNumber;

            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;

            Console.WriteLine($"After changing the numbers \nThe first number is {number1} \nAnd the second number is {number2}");

            Console.ReadLine();
        }
        static int inputNumbers()
        {
            bool parsingValue = int.TryParse(Console.ReadLine(), out int parsedValue);
            while (!parsingValue)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Please enter a number!");
                Console.ForegroundColor = ConsoleColor.White;
                parsingValue = int.TryParse(Console.ReadLine(), out parsedValue);
            }

            return parsedValue;
        }
    }
}
