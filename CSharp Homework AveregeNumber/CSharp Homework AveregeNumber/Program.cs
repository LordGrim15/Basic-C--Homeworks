using System;

namespace CSharp_Homework_AveregeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int number1 = InputChecker();
            Console.WriteLine("Please enter the second number:");
            int number2 = InputChecker();
            Console.WriteLine("Please enter the third number:");
            int number3 = InputChecker();
            Console.WriteLine("Please enter the fourth number:");
            int number4 = InputChecker();

            int result = (number1 + number2 + number3 + number4) / 4;

            Console.WriteLine($"The averege of the four numbers is {result}");

            Console.ReadLine();
        }

        static int InputChecker()
        {
            bool parsingNumber = int.TryParse(Console.ReadLine(), out int parsedNumber);

            while (!parsingNumber)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Please enter a number!");
                Console.ForegroundColor = ConsoleColor.White;
                parsingNumber = int.TryParse(Console.ReadLine(), out parsedNumber);
            }

            return parsedNumber;
        }
    }
}
