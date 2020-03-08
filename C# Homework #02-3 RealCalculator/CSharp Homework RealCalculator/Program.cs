using System;

namespace CSharp_Homework_RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string op;
            double parsedNum1;
            double parsedNum2;
            bool operatorChecker = false;

            Console.WriteLine("Please enter a number: ");
            bool parsingNumber1 = double.TryParse(Console.ReadLine(), out parsedNum1);

            while(!parsingNumber1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Please re-enter a number!");
                Console.ForegroundColor = ConsoleColor.White;
                parsingNumber1 = double.TryParse(Console.ReadLine(), out parsedNum1);
            }

            Console.WriteLine("Please enter another number: ");
            bool parsingNumber2 = double.TryParse(Console.ReadLine(), out parsedNum2);

            while (!parsingNumber2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Please re-enter a number!");
                Console.ForegroundColor = ConsoleColor.White;
                parsingNumber2 = double.TryParse(Console.ReadLine(), out parsedNum2);
            }

            Console.WriteLine("Enter an operator: ");
            op = Console.ReadLine();

            //while (!operatorChecker)
            //{
            //    if (op != "+" || op != "-" || op != "*" || op != "/")
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("ERROR: You need to enter an operator! ( + , - , * , / )");
            //        Console.ForegroundColor = ConsoleColor.White;
            //        Console.WriteLine("Please re-enter operator!");
            //        op = Console.ReadLine();
            //        operatorChecker = false;
            //    }
            //    else
            //    {
            //        operatorChecker = true;
            //    }
            //} Nesto ne raboti "!=" ili ne moze vaka vo c#?

            while (!operatorChecker)
            {
                if (op == "+" || op == "-" || op == "*" || op == "/")
                {
                    operatorChecker = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: You need to enter an operator! ( + , - , * , / )");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Please re-enter operator!");
                    op = Console.ReadLine();
                    operatorChecker = false;
                }
            }

            switch (op)
            {
                case "+":
                    Console.WriteLine($"The result is: {parsedNum1 + parsedNum2}");
                    break;
                case "-":
                    Console.WriteLine($"The result is: {parsedNum1 - parsedNum2}");
                    break;
                case "*":
                    Console.WriteLine($"The result is: {parsedNum1 * parsedNum2}");
                    break;
                case "/":
                    Console.WriteLine($"The result is: {parsedNum1 / parsedNum2}");
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }
    }
}
