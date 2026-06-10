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
                    ShowList(bugs);
                    break;
                case "2":
                    AddBug(bugs);
                    break;
                case "0":
                    running = false;
                    break;
                default:
                    WriteLine("Invalid choice, try again");
                    break;
            }
        }
    }

    private static void ShowList(List<Bug> bugs)
    {
        WriteLine("\nBugs");
        for (int i = 0; i < bugs.Count; i++)
        {
            WriteLine($"{i + 1}. {bugs[i].Name}");
        }

        Write("Pick a number for bug details");
        string input = ReadLine() ?? "";
        if (int.TryParse(input, out int number) && number >= 1 && number <= bugs.Count)
        {
            WriteLine();
            Write(bugs[number - 1].Describe());
        }
        else if (input != "")

        {
            WriteLine("No bug with that number");
        }

    }

    private static void AddBug(List<Bug> bugs)
    {
        Write("Bug name: ");
        string name = ReadLine() ?? "";
        if (name == "")
        {
            WriteLine("Name can't be empty.");
            return;
        }

        Bug bug = new Bug(name);

        Write("Can it fly? (y/n): ");
        bug.CanFly = (ReadLine() ?? "") == "y";

        Write("Can it bite? (y/n): ");
        bug.CanBite = (ReadLine() ?? "") == "y";

        Write("What plague does it cause? (Enter for none): ");
        bug.Plague = ReadLine() ?? "";

        bugs.Add(bug);
        WriteLine($"{name} added!");
    }

}
