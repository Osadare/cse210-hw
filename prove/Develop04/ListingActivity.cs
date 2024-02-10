using System;

public class ListingActivity : Activity
{
    private int _count;

    private List<string> _prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    Random randchoice = new Random();

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("List as many responses to the following prompt: ");
        GetRandomPrompt();
        
        _count = GetListFromUser().Count;
        Console.WriteLine($"You listed {_count} items! \n");
        DisplayEndingMessage();

    }

    public void GetRandomPrompt()
    {
        int r  = randchoice.Next(0, _prompts.Count);
        Console.WriteLine("Prompt: " + _prompts[r]);
        
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        

        while (DateTime.Now < endTime) {
            
            Console.Write("> "); //Displaying where input goes as to match video

            items.Add(Console.ReadLine());
        }

        return items;
    }
}
