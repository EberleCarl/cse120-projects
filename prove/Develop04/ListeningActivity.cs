using System;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who have you helped this week?",
        "Who are some of your personal heroes?",
        "When have you felt the Holy Ghost this month?"
    };

    public ListingActivity()
        : base(
            name: "Listing Activity",
            description: "This activity will help you reflect on the good things in your life.")
    {
    }

    public void Run()
    {
        StartActivity();

        Random random = new Random();

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();

        Console.WriteLine($"--- {_prompts[random.Next(_prompts.Count)]} ---");

        Console.WriteLine();
        Console.Write("You may begin in: ");

        ShowCountdown(5);

        Console.WriteLine();

        List<string> items = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {items.Count} items!");

        EndActivity();
    }

    private double GetDuration()
    {
        throw new NotImplementedException();
    }
}