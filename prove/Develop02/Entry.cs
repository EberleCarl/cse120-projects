using System;

public class Entry
{
    public string Date { get; }
    public string Prompt { get; }
    public string Response { get; }
    public string Tags { get; }

    public Entry(string date, string prompt, string response, string tags)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
        Tags = tags;
    }

    public void Display()
    {
        Console.WriteLine($"[{Date}] {Prompt}");
        Console.WriteLine(Response);
        Console.WriteLine($"Tags: {Tags}\n");
    }
}
