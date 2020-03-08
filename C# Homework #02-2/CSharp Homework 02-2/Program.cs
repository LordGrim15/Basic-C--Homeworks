using System;

namespace CSharp_Homework_02_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number from 1 to 3!");
            int parsedNumber;
            bool selectedNumber = Int32.TryParse(Console.ReadLine(), out parsedNumber);

            if (selectedNumber)
            {
                if (parsedNumber > 3 || parsedNumber < 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: You can't enter a number higher then 3 or lower then 1!");
                }
                else 
                {
                    switch (parsedNumber)
                    {
                        case 1:
                            Console.WriteLine("You got a new car!");
                            break;
                        case 2:
                            Console.WriteLine("You got a new plane!");
                            break;
                        case 3:
                            Console.WriteLine("You got a new bike!");

                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You can't enter characters other then numbers!");
            }
            Console.ReadLine();
        }
    }
}
