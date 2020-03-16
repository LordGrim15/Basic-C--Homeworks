using System;

namespace Heroes_Journey
{
    public class Character
    {
        public string name;
        public string raceName;
        public string className;
        public int health;
        public int strength;
        public int agility;

        public Character(string name, string raceName, string className, int health, int strength, int agility)
        {
            this.name = name;
            this.raceName = raceName;
            this.className = className;
            this.health = health;
            this.strength = strength;
            this.agility = agility;
        }
    }

    public class Race
    {
        public string name;
        public int health;
        public int strength;
        public int agility;

        public Race(String name, int health, int strength, int agility)
        {
            this.name = name;
            this.health = health;
            this.strength = strength;
            this.agility = agility;
        }

    }
    public class CharacterClass
    {
        public string className;

        public CharacterClass(string className)
        {
            this.className = className;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] emailArr = { "jojo@mail.com", "cool@mail.com" };
            string[] passArr = { "jojo123", "cool123" };
            bool continueToCharCreation = false;
            int wrongTriesCounter = 1;


            while (!continueToCharCreation)
            {
                Console.WriteLine("Welcome to Hero Journey!");
                Console.Write("Enter e-mail: ");
                string emailInput = Console.ReadLine().ToLower();
                Console.Write("Enter password: ");
                string passInput = Console.ReadLine().ToLower();
                EmptyInputs(emailInput, passInput, wrongTriesCounter);
                MailChecker(emailInput, passInput, wrongTriesCounter);
                if (emailArr[0] == emailInput && passArr[0] == passInput)
                {
                    Console.WriteLine($"Welcome {emailInput}!");
                    Console.WriteLine($"Press Enter to start with character creation...");
                    continueToCharCreation = true;
                }
                else if (emailArr[1] == emailInput && passArr[1] == passInput)
                {
                    Console.WriteLine($"Welcome {emailInput}!");
                    Console.WriteLine($"Press Enter to start with character creation...");
                    continueToCharCreation = true;
                }
                else
                {
                    Console.WriteLine("E-mail or password did not match!");
                    Console.WriteLine("Press Enter to try again!");
                    Console.ReadLine();
                    Console.Clear();
                    continueToCharCreation = false;
                }
            }

            Game();

            Console.ReadLine();
        }

        static void Game()
        {
            Race dwarf = new Race("Dwarf", 100, 6, 2);
            Race elf = new Race("Elf", 60, 4, 6);
            Race human = new Race("Human", 80, 5, 4);
            Race raceChosen;

            CharacterClass warrior = new CharacterClass("Warrior");
            CharacterClass rogue = new CharacterClass("Rogue");
            CharacterClass mage = new CharacterClass("Mage");
            CharacterClass chosenClass;

            Console.Clear();
            Console.Write("Choose a name: ");
            string userName = Console.ReadLine();
            while (userName.Length < 2 || userName.Length > 20)
            {
                Console.WriteLine("The name must be from 2 to 20 characters!");
                Console.WriteLine("Press Enter to try again!");
                Console.ReadLine();
                Console.Clear();
                Console.Write("Choose a name: ");
                userName = Console.ReadLine();

            }

            Console.Clear();

            Console.WriteLine("Choose a race: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1) Dwarf");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("2) Elf");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("3) Human");
            Console.ResetColor();

            bool parseRace = Int32.TryParse(Console.ReadLine(), out int chosenRace);
            while (!parseRace || chosenRace > 3 || chosenRace < 1)
            {
                Console.WriteLine("Please enter a valid number from the options!");
                Console.WriteLine("Press enter to try again...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Choose a race: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1) Dwarf");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("2) Elf");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("3) Human");
                Console.ResetColor();
                parseRace = Int32.TryParse(Console.ReadLine(), out chosenRace);
            }


            if (chosenRace == 1)
            {
                raceChosen = dwarf;
            }
            else if (chosenRace == 2)
            {
                raceChosen = elf;
            }
            else
            {
                raceChosen = human;
            }



            Console.Clear();

            Console.WriteLine("Choose a class:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1) Warrior");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("2) Rogue");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("3) Mage");
            Console.ResetColor();

            bool parseClass = Int32.TryParse(Console.ReadLine(), out int selectedClass);

            while (!parseClass || selectedClass < 1 || selectedClass > 3)
            {
                Console.WriteLine("Please enter a valid number from the options!");
                Console.WriteLine("Press enter to try again...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Choose a class:");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1) Warrior");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("2) Rogue");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("3) Mage");
                Console.ResetColor();
                parseClass = Int32.TryParse(Console.ReadLine(), out selectedClass);
            }


            if (selectedClass == 1)
            {
                chosenClass = warrior;
                raceChosen.health += 20;
                raceChosen.agility -= 1;
            }
            else if (selectedClass == 2)
            {
                chosenClass = rogue;
                raceChosen.health -= 20;
                raceChosen.agility += 1;
            }
            else
            {
                chosenClass = mage;
                raceChosen.health += 20;
                raceChosen.strength -= 1;
            }

            Character newChar = new Character(userName, raceChosen.name, chosenClass.className, raceChosen.health, raceChosen.strength, raceChosen.agility);

            Console.WriteLine("Character successfully created!");
            Console.WriteLine($"{newChar.name}({newChar.raceName}) the {newChar.className}");
            Console.WriteLine($"Status: {newChar.health}HP, {newChar.strength}STR, {newChar.agility}AGI");
            Console.WriteLine("Press Enter to start the game...");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Bandits attack you out of nowhere. They seem very dangerous...");
            Console.WriteLine($"Health: {newChar.health}");
            Console.WriteLine("1) Fight");
            Console.WriteLine("2) Run");
            bool parsedStrategy = Int32.TryParse(Console.ReadLine(), out int strategy);

            StrategyCheck(parsedStrategy, strategy, newChar);

            Strategy(strategy, newChar, 20);
            
            Console.Clear();

            Console.WriteLine("You bump into one of the guards of the nearby village. They attack you without a warning...");
            Console.WriteLine($"Health: {newChar.health}");
            Console.WriteLine("1) Fight");
            Console.WriteLine("2) Run");
            parsedStrategy = Int32.TryParse(Console.ReadLine(), out strategy);
            StrategyCheck(parsedStrategy, strategy, newChar);

            Strategy(strategy, newChar, 30);

            Console.Clear();

            Console.WriteLine("A Land Shark appears. It starts chasing you down to eat you...");
            Console.WriteLine($"Health: {newChar.health}");
            Console.WriteLine("1) Fight");
            Console.WriteLine("2) Run");
            parsedStrategy = Int32.TryParse(Console.ReadLine(), out strategy);
            StrategyCheck(parsedStrategy, strategy, newChar);

            Strategy(strategy, newChar, 50);

            Console.Clear();

            Console.WriteLine("You accidentally step on a rat. His friends are not happy. They attack...");
            Console.WriteLine($"Health: {newChar.health}");
            Console.WriteLine("1) Fight");
            Console.WriteLine("2) Run");
            parsedStrategy = Int32.TryParse(Console.ReadLine(), out strategy);
            StrategyCheck(parsedStrategy, strategy, newChar);

            Strategy(strategy, newChar, 10);

            Console.Clear();

            Console.WriteLine("You find a huge rock. It somehow comes alive and tries to smash you...");
            Console.WriteLine($"Health: {newChar.health}");
            Console.WriteLine("1) Fight");
            Console.WriteLine("2) Run");
            parsedStrategy = Int32.TryParse(Console.ReadLine(), out strategy);
            StrategyCheck(parsedStrategy, strategy, newChar);

            Strategy(strategy, newChar, 30);

            Console.Clear();

            GameCleared();
            

        }
        static void EmptyInputs(string input1, string input2, int counter)
        {
            while (input1 == "" || input2 == "")
            {
                ExitCheck(counter++);
                Console.WriteLine("E-mail or password is empty!");
                Console.WriteLine("Press Enter to try again!");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Welcome to Hero Journey!");
                Console.Write("Enter e-mail: ");
                input1 = Console.ReadLine().ToLower();
                Console.Write("Enter password: ");
                input2 = Console.ReadLine().ToLower();
            }
        }
        static void MailChecker(string input1, string input2, int counter)
        {
            while (!input1.Contains("@") || !input1.Contains("."))
            {
                ExitCheck(counter++);
                Console.WriteLine("Invalid e-mail!");
                Console.WriteLine("Press Enter to try again!");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Welcome to Hero Journey!");
                Console.Write("Enter e-mail: ");
                input1 = Console.ReadLine().ToLower();
                Console.Write("Enter password: ");
                input2 = Console.ReadLine().ToLower();
            }
        }
        static void ExitCheck(int number)
        {
            if (number == 5)
            {
                Console.WriteLine("You tried too many times! Press enter to exit...");
                Console.ReadLine();
                Console.WriteLine("Thanks for playing. Press enter to exit!");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
        static void Strategy(int inputStrategy, Character character, int number)
        {
            int randomNumber;
            Random rnd = new Random();

            if (inputStrategy == 1)
            {
                randomNumber = rnd.Next(1, 10);
                if (randomNumber < character.strength)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You won the fight!");
                    Console.ResetColor();
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lost the fight!");
                    Console.ResetColor();
                    character.health -= number;
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    HealthZero(character);
                }
            }
            else
            {
                randomNumber = rnd.Next(1, 10);
                if (randomNumber < character.agility)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You ran away!");
                    Console.ResetColor();
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You didn't manage to run away!");
                    Console.ResetColor();
                    character.health -= number;
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    HealthZero(character);
                }
            }
        }
        static void StrategyCheck(bool parseStrategy, int strategy, Character character)
        {
            while (!parseStrategy || strategy < 1 || strategy > 2)
            {
                Console.WriteLine("Please enter a valid number from the options!");
                Console.WriteLine("Press enter to try again...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Bandits attack you out of nowhere. They seem very dangerous...");
                Console.WriteLine($"Health: {character.health}");
                Console.WriteLine("1) Fight");
                Console.WriteLine("2) Run");
                parseStrategy = Int32.TryParse(Console.ReadLine(), out strategy);
            }
        }
        static void HealthZero(Character character)
        {
            if (character.health <= 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your health reached zero... You lost!");
                Console.ResetColor();
                PlayAgain();
            }
        }
        static void PlayAgain()
        {
            Console.WriteLine("Do you want to play again?");
            Console.WriteLine("1) Yes");
            Console.WriteLine("2) No");
            bool yesNo = Int32.TryParse(Console.ReadLine(), out int answer);
            while (!yesNo || answer < 1 || answer > 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a number from the options!");
                Console.ResetColor();
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
                yesNo = Int32.TryParse(Console.ReadLine(), out answer);
            }
            if (answer == 1)
            {
                Game();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Thank you for playing. Press enter to exit and have a nice day!");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
        static void GameCleared()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You beat the game!");
            Console.ResetColor();
            PlayAgain();
        }
    }
}
