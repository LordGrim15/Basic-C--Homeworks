using System;

namespace Homework_CSharp_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if(number1 > number2)
            {
                if (number1 % 2 == 0)
                {
                    Console.WriteLine($"The larger number is {number1} and the number is even!");
                }
                else
                {
                    Console.WriteLine($"The larger number is {number1} and the number is odd!");
                }
            }
            else if(number1 == number2)
            {
                Console.WriteLine("The numbers are equal!");
            }
            else
            {
                if (number2 % 2 == 0)
                {
                    Console.WriteLine($"The larger number is {number2} and the number is even!");
                }
                else
                {
                    Console.WriteLine($"The larger number is {number2} and the number is odd!");
                }
            }
            Console.ReadLine();
        }
    }
}
