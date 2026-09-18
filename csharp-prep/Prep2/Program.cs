using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("WHat is your grade percentage in this Class? ");
        string Grade = Console.ReadLine();
        int percent = int.Parse(Grade);
        string letter = "";
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade in the class is: {letter}");
        if (percent >= 70)
        {
            Console.WriteLine("You passed the Class!");
        }
        else
        {
            Console.WriteLine($"You Failed the class with a {letter}");
        }


    }
}