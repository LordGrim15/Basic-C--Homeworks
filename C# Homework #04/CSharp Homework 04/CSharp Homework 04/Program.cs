using System;

namespace CSharp_Homework_04
{
    class Program
    {
        static void Substrings()
        {
            string message = "Hello from SEDC Codecademy v7.0";

            Console.WriteLine($"Please enter a number from 1 to {message.Length}");

            bool parsedInput = int.TryParse(Console.ReadLine(), out int numInput);

            while (!parsedInput || numInput < 1 || numInput > message.Length)
            {
                Console.WriteLine($"ERROR: Please enter a proper number from 1 to {message.Length}...");
                Console.WriteLine("Press enter to try again...");
                Console.ReadLine();
                Console.WriteLine($"Please enter a number from 1 to {message.Length}");
                parsedInput = int.TryParse(Console.ReadLine(), out numInput);
            }

            string substringedMsg = message.Substring(0, numInput);
            Console.WriteLine(substringedMsg);
            Console.WriteLine($"The length of the message is {substringedMsg.Length}.");

        }

        static int AgeCalc(int birthDay, int birthMonth, int birthYear)
        {
            DateTime today = DateTime.Now;
            int currentYear = today.Year;
            int currentMonth = today.Month;
            int currentDay = today.Day;
            int userAge = currentYear - birthYear;
            int userMonths = currentMonth - birthMonth;
            int userDay = currentDay - currentDay;

            if ((birthMonth == currentMonth && birthDay == currentDay) || (userMonths <= 0 && userDay <= 0))
            {
                if (birthMonth == currentMonth && birthDay == currentDay)
                {
                    userAge += 1;
                }
                if (userMonths <= 0 && userDay <= 0)
                {
                    userAge -= 1;
                }
            }

            return userAge;

        }

        static void Main(string[] args)
        {
            //Task 1
            //Substrings();


            #region Task 2
            ////Task 2
            //DateTime today = DateTime.Now;
            //DateTime currentDate = today.Date;

            //DateTime format3DaysFromNow = currentDate.AddDays(3);
            //DateTime format1MonthFromNow = currentDate.AddMonths(1);
            //DateTime format1MonthAnd3DaysFromNow = currentDate.AddDays(3).AddMonths(1);
            //DateTime format1YearAnd2MonthAgo = currentDate.AddYears(-1).AddMonths(-2);

            //string threeDaysFromToday = format3DaysFromNow.ToString("MMMM/dd/yyyy");
            //string oneMonthFromToday = format1MonthFromNow.ToString("MMMM/dd/yyyy");
            //string oneMonthAnd3Days = format1MonthAnd3DaysFromNow.ToString("MMMM/dd/yyyy");
            //string oneYearAnd2MonthAgo = format1YearAnd2MonthAgo.ToString("MMMM/dd/yyyy");
            //string onlyMonth = currentDate.ToString("MMMM");
            //string onlyYear = currentDate.ToString("yyyy");


            //Console.WriteLine($"The day 3 days from now is {threeDaysFromToday}");
            //Console.WriteLine($"The day 1 month from now is {oneMonthFromToday}");
            //Console.WriteLine($"The day 1 month and 3 days from now is {oneMonthAnd3Days}");
            //Console.WriteLine($"The day that was 1 year and 2 months ago is {oneYearAnd2MonthAgo}");
            //Console.WriteLine($"The current month is {onlyMonth}");
            //Console.WriteLine($"The current year is {onlyYear}");
            #endregion

            #region Task 3
            DateTime today = DateTime.Now;
            int currentYear = today.Year;


            Console.WriteLine("Enter your birth year...");
            bool parseBirthdate = int.TryParse(Console.ReadLine(), out int birthYear);
            while (!parseBirthdate || birthYear > currentYear || birthYear.ToString().Length < 4 || birthYear.ToString().Length > 4)
            {
                Console.WriteLine("Please enter a proper year!");
                Console.WriteLine("Press enter to try again...");
                Console.ReadLine();
                Console.WriteLine("Enter your birth year...");
                parseBirthdate = int.TryParse(Console.ReadLine(), out birthYear);
            }

            Convert.ToInt32(birthYear);

            Console.WriteLine("Now enter your birth month...");
            parseBirthdate = int.TryParse(Console.ReadLine(), out int birthMonth);
            while (!parseBirthdate || birthMonth > 12 || birthMonth < 1 || birthMonth.ToString().Length < 1 || birthMonth.ToString().Length > 2)
            {
                Console.WriteLine("Please enter a proper month!");
                Console.WriteLine("Press enter to try again...");
                Console.ReadLine();
                Console.WriteLine("Enter your birth month...");
                parseBirthdate = int.TryParse(Console.ReadLine(), out birthMonth);
            }

            Convert.ToInt32(birthMonth);

            Console.WriteLine("And lastly enter your birth day...");
            parseBirthdate = int.TryParse(Console.ReadLine(), out int birthDay);
            while (!parseBirthdate || birthDay > 31 || birthDay < 1 || birthDay.ToString().Length < 1 || birthDay.ToString().Length > 2)
            {
                Console.WriteLine("Please enter a proper day!");
                Console.WriteLine("Press enter to try again...");
                Console.ReadLine();
                Console.WriteLine("Enter your birth day...");
                parseBirthdate = int.TryParse(Console.ReadLine(), out birthDay);
            }

            Convert.ToInt32(birthDay);

            Console.WriteLine(birthMonth + " " + birthDay + " " + birthYear);

            int userAge = AgeCalc(birthDay, birthMonth, birthYear);

            Console.WriteLine("Your age is {0}", userAge);

            #endregion




            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
