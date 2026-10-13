using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private Random random = new Random();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response},{entry.Tags}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        foreach (string line in File.ReadAllLines(filename))
        {
            string[] parts = line.Split(',');
            if (parts.Length >= 4)
            {
                entries.Add(new Entry(parts[0], parts[1], parts[2], parts[3]));
            }
        }
    }

    public void SearchEntries(string keyword)
    {
        foreach (Entry entry in entries)
        {
            if (entry.Response.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                entry.Tags.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            {
                entry.Display();
            }
        }
    }

    public string GeneratePrompt()
    {
        string[] prompts =
        {
            "What made you smile today?",
            "What challenge did you overcome?",
            "What are you grateful for?",
            "What did you learn today?"
        };

        return prompts[random.Next(prompts.Length)];
    }
}
