using System;

bool running = true;

while (running)
{
    Console.Clear();

    Console.WriteLine("Mindfulness Program");
    Console.WriteLine();
    Console.WriteLine("1. Start Breathing Activity");
    Console.WriteLine("2. Start Reflection Activity");
    Console.WriteLine("3. Start Listing Activity");
    Console.WriteLine("4. Quit");
    Console.WriteLine();

    Console.Write("Select a choice from the menu: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            BreathingActivity breathing = new BreathingActivity();
            breathing.Run();
            break;

        case "2":
            ReflectionActivity reflection =
                new("Reflection Activity", "Reflect on times when you have shown strength and resilience.", true);
            reflection.Run();
            break;

        case "3":
            ListingActivity listing =
                new ListingActivity();
            listing.Run();
            break;

        case "4":
            running = false;
            break;
    }
}

class BreathingActivity
{
    public void Run()
    {
        Console.WriteLine("Take a moment to focus on your breathing.");
        Console.WriteLine("Breathe in slowly, then breathe out slowly.");
        Console.WriteLine("Press Enter when you are finished.");
        Console.ReadLine();
    }
}