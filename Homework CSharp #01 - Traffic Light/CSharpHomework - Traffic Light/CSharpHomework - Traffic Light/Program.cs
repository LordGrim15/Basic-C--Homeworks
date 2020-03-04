using System;
using System.Threading;

namespace HomeWork_1_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("STOP!");
            Thread.Sleep(4000);
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("READY");
            Thread.Sleep(700);
            Console.WriteLine(".");
            Thread.Sleep(700);
            Console.WriteLine(".");
            Thread.Sleep(700);
            Console.WriteLine(".");
            Thread.Sleep(700);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("GO!");
            Console.ReadLine();
        }
    }
}