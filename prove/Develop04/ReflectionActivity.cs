using System;
using System.Runtime.CompilerServices;

public class ReflectingActivity : Activity
{
     private List<string> _prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
     };

     private List<string> _questions = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
       
     };

    Random randint = new Random();
    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "The activity will help you reflect on times in your life when you have shown strength and resilience.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        DisplayPrompt();
        Console.WriteLine();

        Console.WriteLine("press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");

        Console.Write("Start..: ");
        showCountdown(3);
        Console.Clear();

        DisplayQuestions();

        Thread.Sleep(200);
        Console.WriteLine();
        DisplayEndingMessage();


    }

    public string GetRandomPrompt()
    {
        int r = randint.Next(0, _prompts.Count);
        string randPrompt = _prompts[r];
        return randPrompt;
    }

    public string GetRandomQuestion()
    {
        int r = randint.Next(0, _questions.Count);
        string randQuestion = _questions[r];
        return randQuestion;
    }

    public void DisplayPrompt()
    {
        
        Console.WriteLine(); 
        Console.WriteLine($"Consider the Following Prompt \n\n --- {GetRandomPrompt()} ---");
    }

    public void DisplayQuestions()
    {

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        

        while (DateTime.Now < endTime) 
        {
            Console.Write($"> {GetRandomQuestion()} ");
            showSpinner(5);
            Console.WriteLine();
        }
    }
}
