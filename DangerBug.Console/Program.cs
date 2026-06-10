using static System.Console;

using DangerBug.Core.Models;

namespace DangerBug.Console;

// TODO: build the menu loop.
//   1. List bugs   2. Add a bug   0. Exit

internal static class Program
{
    private static void Main()
    {
        List<Bug> bugs = new List<Bug>
        {
            new Mosquito(),
            new Housefly(),
            new Spider(),
            new Tick(),
            new Wasp(),
        };

        bool running = true;
        while (running)
        {
            WriteLine("\n--- DangerBug ---");
            WriteLine("1. List bugs");
            WriteLine("2. Add a bug");
            WriteLine("0. Exit");
            Write("Choice: ");

            string choice = ReadLine() ?? "";

            switch (choice)
            {
                case "1":


                default:
                    WriteLine("Invalid choice, try again");
                    break;
            }
        }
    }
    private static void ShowList(List<Bug> bugs)
    {

    }
}
