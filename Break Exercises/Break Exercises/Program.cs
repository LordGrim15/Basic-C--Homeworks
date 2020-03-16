using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace Break_Exercise1
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public string drinkName;

        public Person(String firstName, String lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            ////Exercise 1 - Flip the boolean
            //bool parsedVal;

            //Console.WriteLine("Please enter true or false!");
            //bool inputVal = bool.TryParse(Console.ReadLine(), out parsedVal);

            //while (!inputVal)
            //{
            //    Console.WriteLine("Invalid input! Please try again!");
            //    inputVal = bool.TryParse(Console.ReadLine(), out parsedVal);
            //}

            //switch (parsedVal)
            //{
            //    case true:
            //        Console.WriteLine(false);
            //        break;
            //    case false:
            //        Console.WriteLine(true);
            //        break;
            //    default:
            //        break;
            //}

            ////Exercise 2 - Multiple of 100

            //Console.WriteLine("Please enter a number:");
            //int parsedNum;
            //int sum;

            //bool inputVal = Int32.TryParse(Console.ReadLine(), out parsedNum);
            //while (!inputVal)
            //{
            //    Console.WriteLine("Can't you read? Enter a number, not anything else!");
            //    inputVal = Int32.TryParse(Console.ReadLine(), out parsedNum);
            //}

            //sum = parsedNum % 100;

            //if (sum == 0)
            //{
            //    Console.WriteLine("You have entered a cool number!");
            //}
            //else
            //{
            //    Console.WriteLine("The number you've enterd is not cool at all!");
            //}

            //// Exercise 3 - Return name of month

            //int parsedNum;
            //string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            //Console.WriteLine("Please enter a number from 1-12!");


            //bool inputVal = Int32.TryParse(Console.ReadLine(), out parsedNum);
            //while (!inputVal || parsedNum > 12 || parsedNum < 1)
            //{
            //    Console.WriteLine("ERROR: Incorrect value! Please enter a new number!");
            //    inputVal = Int32.TryParse(Console.ReadLine(), out parsedNum);
            //}

            //Console.WriteLine(months[parsedNum - 1]);

            //// Exercise 4 - Profitable Gamble

            //double prob;
            //double prize;
            //double pay;
            //double sum;

            //Console.WriteLine("Please enter a probabilty:");
            //prob = DoubleParser();
            //Console.WriteLine("Now enter the prize:");
            //prize = DoubleParser();
            //Console.WriteLine("And now enter the cost of playing:");
            //pay = DoubleParser();

            //sum = prob * prize;
            //if (sum > pay)
            //{
            //    Console.WriteLine("Congratulations! You win!");
            //}
            //else
            //{
            //    Console.WriteLine("Too bad! You lose!");
            //}

            //// Exercise 5 - The Farm Problem

            //Console.WriteLine("Enter the ammount of chickens you have:");
            //int chickens = IntParser() * 2;
            //Console.WriteLine("Now enter the ammount of cows you have:");
            //int cows = IntParser() * 4;
            //Console.WriteLine("And lastly, enter the ammount of pigs you have:");
            //int pigs = IntParser() * 4;
            //int numberOfLegs = chickens + cows + pigs;

            //Console.WriteLine($"You have {numberOfLegs} legs on your farm!");

            // Exercise 6 - Word count

            //Console.WriteLine("Please enter something!");

            //string sentence = Console.ReadLine();
            //int numberOfWords;
            //char[] delimiters = new char[] { ' ', '\r', '\n', '\t' };
            //numberOfWords = sentence.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
            //Console.WriteLine(numberOfWords);

            // Exercise 7 - Liquor store

            //Console.WriteLine("Welcome!");
            //Console.WriteLine("Please show me your ID card!");
            //Console.WriteLine("First Name:");
            //string fName = Console.ReadLine();
            //while(Regex.IsMatch(fName, @"\d"))
            //{
            //    Console.WriteLine("Please don't use numbers and special characters in the First Name input!");
            //    fName = Console.ReadLine();
            //}
            //Console.WriteLine("Last Name:");
            //string lName = Console.ReadLine();
            //while (Regex.IsMatch(lName, @"\d"))
            //{
            //    Console.WriteLine("Please don't use numbers and special characters in the Last Name input!");
            //    lName = Console.ReadLine();
            //}
            //Console.WriteLine("Age:");
            //int age = IntParser();

            //Person newPerson = new Person(fName, lName, age);

            //if (newPerson.age >= 18)
            //{
            //    Console.WriteLine("What would you like to drink?");
            //    newPerson.drinkName = Console.ReadLine();
            //    Console.WriteLine($"Dear {newPerson.firstName} {newPerson.lastName}, here you go, a bottle of {newPerson.drinkName}, have a nice day!");
            //}
            //else
            //{
            //    Console.WriteLine($"Dear {newPerson.firstName} {newPerson.lastName}, I am sorry but you are not allowed to buy alchocol!");
            //}

            //// Exercise 8 - Coffe machine

            //double[] prices = { 2, 3.5, 4, 6, 1.5 };
            //double missingMoney;
            //Console.WriteLine("Welcome dear customer, please select a drink:");
            //Console.WriteLine($"1.Espresso...........2$\n2.Macchiato........3.5$\n3.Latte..............4$\n4.Cappuccino.........6$\n5.Tea..............1.5$");
            //int selectedDrink;
            //bool inputVal = Int32.TryParse(Console.ReadLine(), out selectedDrink);
            //while (!inputVal || selectedDrink > 5 || selectedDrink < 1)
            //{
            //    Console.WriteLine("Invalid entry! Please try again!");
            //    inputVal = Int32.TryParse(Console.ReadLine(), out selectedDrink);
            //}
            //Console.WriteLine("Choose the ammount of sweetness from 1 to 5:");
            //bool parsedSweetnessVal = Int32.TryParse(Console.ReadLine(), out int sweetnessLevel);
            //while (!parsedSweetnessVal || selectedDrink > 5 || selectedDrink < 1)
            //{
            //    Console.WriteLine("Invalid entry! Please try again!");
            //    parsedSweetnessVal = Int32.TryParse(Console.ReadLine(), out sweetnessLevel);
            //}

            //selectedDrink--;


            //Console.WriteLine("Please insert {0}$", prices[selectedDrink]);
            //double insertedMoney = DoubleParser();
            //while(insertedMoney < prices[selectedDrink])
            //{
            //    missingMoney = prices[selectedDrink] - insertedMoney;
            //    Console.WriteLine("The drink costs {0}$! You're missing {1}$!", prices[selectedDrink], missingMoney);
            //    Console.WriteLine("Please enter the remaining sum!");
            //    missingMoney = DoubleParser();
            //    insertedMoney += missingMoney;
            //}

            //if (insertedMoney > prices[selectedDrink])
            //{
            //    Console.WriteLine("You have {0}$ change!", insertedMoney - prices[selectedDrink]);
            //}

            //Console.WriteLine("Have a good day!");

            ////Exercise 9 - Future prediction

            //string[] futureArray = { "You got a jackpot of 1.000.000EUR!", "You will lose weight!", "Your girlfriend will break up with you!", "Your cousin will buy you a dog!", "You will live for 100 years!" };
            //double missingMoney;
            //Console.WriteLine($"Welcome!\nI will tell you your future for the low price of ONLY 100$!! Please insert your money here:");
            //double insertedMoney = DoubleParser();
            //while (insertedMoney < 100)
            //{
            //    missingMoney = 100 - insertedMoney;
            //    Console.WriteLine("You're missing {0}$! Please enter the remaining sum!", missingMoney);
            //    missingMoney = DoubleParser();
            //    insertedMoney += missingMoney;
            //}
            //if (insertedMoney > 100)
            //{
            //    Console.WriteLine("Thanks for your payment! You have {0}$ change!", insertedMoney - 100);
            //}
            //else
            //{
            //    Console.WriteLine("Thanks for your payment!");
            //}

            //Thread.Sleep(2000);

            //Console.WriteLine("Your future is...");
            //Random randomNum = new Random();
            //int randomFuture = randomNum.Next(0, 5);

            //Console.WriteLine(futureArray[randomFuture]);

            //Exercise 10 - Farenheit to Celsius conversion

            double celsius;
            Console.WriteLine("Please enter the number of celsius you want to convert:");
            celsius = DoubleParser();
            double fahrenheit = (celsius * 9 / 5) + 32;
            double kelvin = celsius + 273.15;

            Console.WriteLine($"{celsius}C = {fahrenheit}F\n{celsius}C = {kelvin}K");

            Console.ReadLine();
        }

        static double DoubleParser()
        {
            double doubleValue;
            bool parsedVal = double.TryParse(Console.ReadLine(), out doubleValue);

            while (!parsedVal)
            {
                Console.WriteLine("Please enter a proper number!");
                parsedVal = double.TryParse(Console.ReadLine(), out doubleValue);
            }

            return doubleValue;
        }
        static int IntParser()
        {
            int intValue;
            bool parsedVal = Int32.TryParse(Console.ReadLine(), out intValue);
            while (!parsedVal)
            {
                Console.WriteLine("Please enter a proper number!");
                parsedVal = Int32.TryParse(Console.ReadLine(), out intValue);
            }
            return intValue;
        }
    }
}