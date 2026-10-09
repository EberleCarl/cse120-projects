using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine("Welcome back! Remember: even one sentence today is progress.\n");

        bool running = true;
        while (running)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to CSV file");
            Console.WriteLine("4. Load journal from CSV file");
            Console.WriteLine("5. Search entries by keyword");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    string prompt = journal.GeneratePrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    Console.Write("Add tags (comma separated): ");
                    string tags = Console.ReadLine();

                    Entry newEntry = new Entry(DateTime.Now.ToShortDateString(), prompt, response, tags);
                    journal.AddEntry(newEntry);
                    Console.WriteLine("Entry added!\n");
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to save (example: journal.csv): ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    Console.WriteLine("Journal saved!\n");
                    break;

                case "4":
                    Console.Write("Enter filename to load (example: journal.csv): ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    Console.WriteLine("Journal loaded!\n");
                    break;

                case "5":
                    Console.Write("Enter keyword to search: ");
                    string keyword = Console.ReadLine();
                    journal.SearchEntries(keyword);
                    break;

                case "6":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option.\n");
                    break;
            }
        }
    }
}
