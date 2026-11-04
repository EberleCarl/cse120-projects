using System;
using System.Threading;

public class Activity
{
    private string _activityName;
    private string _activityDescription;
    protected int _sessionDuration;

    public Activity(string name, string description)
    {
        _activityName = name;
        _activityDescription = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"--- {_activityName} ---");
        Console.WriteLine();
        Console.WriteLine(_activityDescription);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        _sessionDuration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to begin...");
        ShowActivitySpinner(3);
    }

    public void EndActivity()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowActivitySpinner(3);

        Console.WriteLine();
        Console.WriteLine(
            $"You have completed another {_sessionDuration} seconds of the activity.");
        ShowActivitySpinner(3);
    }

    protected void ShowActivitySpinner(int seconds)
    {
        List<char> spinner = new List<char>()
        {
            '|', '/', '-', '\\'
        };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[index]);
            Thread.Sleep(250);
            Console.Write("\b \b");

            index++;

            if (index >= spinner.Count)
            {
                index = 0;
            }
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
