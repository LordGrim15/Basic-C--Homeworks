using System;

namespace Break_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool parsedVal;

            Console.WriteLine("Please enter true or false!");
            bool inputVal = bool.TryParse(Console.ReadLine(), out parsedVal);

            while (!inputVal)
            {
                Console.WriteLine("Invalid input! Please try again!");
                inputVal = bool.TryParse(Console.ReadLine(), out parsedVal);
            }

            switch (parsedVal)
            {
                case true:
                    Console.WriteLine("false");
                    break;
                case false:
                    Console.WriteLine("true");
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }
    }
}
