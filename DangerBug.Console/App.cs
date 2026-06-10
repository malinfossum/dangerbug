using static System.Console;

using DangerBug.Core.Models;

namespace DangerBug.Console;

internal class App
{
    private readonly List<Bug> _bugs = new List<Bug>
    {
        new Mosquito(),
        new Housefly(),
        new Spider(),
        new Tick(),
        new Wasp(),
    };

    public void Run()
    {
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
                    ShowList();
                    break;
                case "2":
                    AddBug();
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

    private void ShowList()
    {
        WriteLine("\nBugs");
        for (int i = 0; i < _bugs.Count; i++)
        {
            WriteLine($"{i + 1}. {_bugs[i].Name}");
        }

        Write("Pick a number for bug details");
        string input = ReadLine() ?? "";
        if (int.TryParse(input, out int number) && number >= 1 && number <= _bugs.Count)
        {
            WriteLine();
            Write(_bugs[number - 1].Describe());
        }
        else if (input != "")
        {
            WriteLine("No bug with that number");
        }
    }

    private void AddBug()
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

        _bugs.Add(bug);
        WriteLine($"{name} added!");
    }
}
