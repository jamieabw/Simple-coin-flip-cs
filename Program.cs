using System;
class main
{
    static void Main(string[] args)
    {
        Random flip = new Random();
        List<int> headResults = new List<int>(); // seperate list - not sure if theres a way to do it in one list 
        List<int> tailsResults = new List<int>();
        Console.WriteLine("How many times would you like to flip the coin?");
        int amountOfFlips = Convert.ToInt32(Console.ReadLine());
        int totalFlips = amountOfFlips;
        for (int i = 0; i < amountOfFlips; i++)
        {
            int currentFlip = flip.Next(0, 2);
            switch (currentFlip)
            {
                case 0:
                    headResults.Add(0); 
                    break;
                case 1:
                    tailsResults.Add(1);
                    break;
            }
        }

        Console.WriteLine(headResults.Count() + " heads");
        Console.WriteLine(tailsResults.Count() + " tails");
        float headPercent = (float) (headResults.Count() / Convert.ToDouble(totalFlips)) * 100; // calculations for percentages
        float tailPercent = (float) (tailsResults.Count() / Convert.ToDouble(amountOfFlips)) * 100;
        Console.WriteLine($"{headPercent}% were heads and {tailPercent} were tails");
    }
}