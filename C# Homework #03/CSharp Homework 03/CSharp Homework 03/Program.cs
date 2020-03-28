using System;

namespace CSharp_Homework_03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //// Task 1
            //string[] group1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            //string[] group2 = { "Petar", "Stefan", "Angela", "Peco", "Natasa" };
            //int counter = 1;

            //Console.WriteLine("Please enter student group number that you want to view...");
            //bool parsedInt = int.TryParse(Console.ReadLine(), out int groupNum);

            //while (!parsedInt || groupNum > 2 || groupNum < 1)
            //{
            //    if (!parsedInt)
            //    {
            //        Console.WriteLine("Please enter a proper number! Press enter to try again...");
            //        Console.ReadLine();
            //        Console.Clear();
            //        Console.WriteLine("Please enter student group number that you want to view...");
            //        parsedInt = int.TryParse(Console.ReadLine(), out groupNum);
            //    }
            //    else
            //    {
            //        Console.WriteLine("There are only two groups! Press enter to try again...");
            //        Console.ReadLine();
            //        Console.Clear();
            //        Console.WriteLine("Please enter student group number that you want to view...");
            //        parsedInt = int.TryParse(Console.ReadLine(), out groupNum);
            //    }
            //}

            //if (groupNum == 1)
            //{
            //    Console.WriteLine("Here are the students from group 1...");
            //    foreach (var student in group1)
            //    {
            //        Console.WriteLine($"{counter}. {student}");
            //        counter++;
            //    }
            //    Console.WriteLine("Press Enter to exit...");
            //    Console.ReadLine();
            //    Environment.Exit(0);
            //}
            //else
            //{
            //    Console.WriteLine("Here are the students from group 2...");
            //    foreach (var student in group2)
            //    {
            //        Console.WriteLine($"{counter}. {student}");
            //        counter++;
            //    }
            //    Console.WriteLine("Press Enter to exit...");
            //    Console.ReadLine();
            //    Environment.Exit(0);
            //}
            #endregion

            #region Task 2 - Sum of Even
            //// Task 2 - Sum of Even

            //int[] inputNumbers = new int[6];
            //int sum = 0;

            //Console.WriteLine("Please enter 6 numbers one by one...");
            //Console.WriteLine("First Number...");
            //inputNumbers[0] = ParserToInt();
            //Console.WriteLine("Second Number...");
            //inputNumbers[1] = ParserToInt();
            //Console.WriteLine("Third Number...");
            //inputNumbers[2] = ParserToInt();
            //Console.WriteLine("Fourth Number...");
            //inputNumbers[3] = ParserToInt();
            //Console.WriteLine("Fifth Number...");
            //inputNumbers[4] = ParserToInt();
            //Console.WriteLine("Sixth Number...");
            //inputNumbers[5] = ParserToInt();

            //foreach (var number in inputNumbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        sum += number;
            //    }
            //}

            //Console.WriteLine($"The sum of the even numbers you entered is {sum}!");

            #endregion

            #region Task 3 - Bonus
            string[] trainers = { "martin", "ivo", "dejan", "aleksandar" };
            string[] group1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] group2 = { "Petar", "Stefan", "Angela", "Peco", "Natasa" };
            string[] group3 = { "Aleksandar", "Izabela", "Magdalena", "Angel", "Jakov" };
            string[] students = { "zdravko", "petko", "stanko", "branko", "trajko", "petar", "stefan", "angela", "peco", "natasa", "aleksandar", "izabela", "magdalena", "angel", "jakov" };
            string[] subjects = { "HTML5", "CSS3", "Basic JS", "Advanced JS", "C#" };
            string[] announcments = { "Class is canceled!", "The exam will be on Friday!" };
            int counter = 1;

            Console.WriteLine("Are you a trainer or a student...");
            string studentTrainerInput = Console.ReadLine().ToLower();

            while (studentTrainerInput != "student" && studentTrainerInput != "trainer")
            {
                Console.WriteLine("Please input \"trainer\" or \"student\"...");
                studentTrainerInput = Console.ReadLine().ToLower();
            }

            if (studentTrainerInput == "trainer")
            {
                Console.WriteLine("Please enter your name...");
                string trainerName = Console.ReadLine().ToLower();
                int indexOfTrainer = Array.IndexOf(trainers, trainerName);
                while (indexOfTrainer == -1)
                {
                    Console.WriteLine("There is no such trainer! Press enter to try again...");
                    Console.ReadLine();
                    Console.WriteLine("Please enter your name...");
                    trainerName = Console.ReadLine().ToLower();
                    indexOfTrainer = Array.IndexOf(trainers, trainerName);
                }

                Console.WriteLine($"Welcome {trainerName}!");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("a. List all students from a group (G1, G2, G3)");
                Console.WriteLine("b. Enter new announcement");

                string choice = Console.ReadLine().ToLower();

                while(choice != "a" && choice != "b")
                {
                    Console.WriteLine("Please choose one of the options provided! Press enter to try again...");
                    Console.ReadLine();
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine("a. List all students from a group (G1, G2, G3)");
                    Console.WriteLine("b. Enter new announcement");
                    choice = Console.ReadLine().ToLower();
                }

                if (choice == "a")
                {
                    Console.WriteLine("Which group would you like to see?(Just enter the number)");
                    int groupChooser = ParserToInt();
                    while (groupChooser > 3 || groupChooser < 1)
                    {
                        Console.WriteLine("Please choose one of the existing groups...");
                        groupChooser = ParserToInt();
                    }

                    switch (groupChooser)
                    {
                        case 1:
                            foreach (string student in group1)
                            {
                                Console.WriteLine($"{counter}. {student}");
                                counter++;
                            }
                            break;
                        case 2:
                            foreach (string student in group2)
                            {
                                Console.WriteLine($"{counter}. {student}");
                                counter++;
                            }
                            break;
                        case 3:
                            foreach (string student in group3)
                            {
                                Console.WriteLine($"{counter}. {student}");
                                counter++;
                            }
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Array.Resize(ref announcments, announcments.Length + 1);
                    Console.WriteLine("Please enter the announcment.");
                    announcments[announcments.Length - 1] = Console.ReadLine();
                    foreach (string announcment in announcments)
                    {
                        Console.WriteLine($"{counter}. {announcment}");
                        counter++;
                    }
                }
                Console.WriteLine("Press enter to exit...");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please enter your name...");
                string studentName = Console.ReadLine().ToLower();
                int indexOfTrainer = Array.IndexOf(students, studentName);
                while (indexOfTrainer == -1)
                {
                    Console.WriteLine("There is no such student! Press enter to try again...");
                    Console.ReadLine();
                    Console.WriteLine("Please enter your name...");
                    studentName = Console.ReadLine().ToLower();
                    indexOfTrainer = Array.IndexOf(students, studentName);
                }
                Console.WriteLine($"Welcome {studentName}!");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("a. List all academy subjects");
                Console.WriteLine("b. List all announcements");
                string choice = Console.ReadLine().ToLower();

                while (choice != "a" && choice != "b")
                {
                    Console.WriteLine("Please choose one of the options provided! Press enter to try again...");
                    Console.ReadLine();
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine("a. List all academy subjects");
                    Console.WriteLine("b. List all announcements");
                    choice = Console.ReadLine().ToLower();
                }

                if (choice == "a")
                {
                    foreach (string subject in subjects)
                    {
                        Console.WriteLine($"{counter}. {subject}");
                        counter++;
                    }
                }
                else
                {
                    foreach (string announcment in announcments)
                    {
                        Console.WriteLine($"{counter}. {announcment}");
                        counter++;
                    }
                }
                Console.WriteLine("Press enter to exit...");
                Console.ReadLine();
                Environment.Exit(0);
            }

            #endregion







            Console.ReadLine();
        }
        static int ParserToInt()
        {
            bool parsedInt = int.TryParse(Console.ReadLine(), out int number);
            while (!parsedInt)
            {
                Console.WriteLine("Please enter a proper number! Press enter to try again...");
                Console.ReadLine();
                parsedInt = int.TryParse(Console.ReadLine(), out number);
            }

            return number;
        }
    }
}
