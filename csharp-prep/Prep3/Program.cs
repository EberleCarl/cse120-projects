using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int MagicNumber = randomGenerator.Next(1, 100);
        int guess = -1;
        while (guess != MagicNumber)
        {
            Console.Write("What is your guess of the Magic Number? ");
            guess = int.Parse(Console.ReadLine());
            if (MagicNumber > guess)
            {
                Console.WriteLine("Higher");
            
            }
            else if (MagicNumber < guess)
            {
                Console.WriteLine("Lower");
            
            }
            else
            {
                Console.WriteLine("You guessed the Magic Number!");
            }
        }
    }
}