//Exceeds the requirement add randomScriptures ,the user get a random scripture.
using System;

class Program
{
    static void Main(string[] args)
    {
        RandomScriptures randomScriptures = new RandomScriptures();
        Console.Clear(); 

            Scripture scripture = randomScriptures.GetRandomScripture();
          
        while (true)
        {
            Console.WriteLine(scripture.GetDisplayText());
            
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
                break;

            scripture.HideRandomWords();

            if (scripture.IsCompletelyHidden())
            {
                break;
            }
        }
    }
}