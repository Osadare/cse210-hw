using System;

public class PGenerator{

 public List<string> prompts = new List<string>
        {
            "If I had one thing I could do over today, what would it be?",
            "What is the one thing you did today to be closer to your goals?",
            "What did you learn today?", 
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "What was the strongest emotion I felt today?",
            
        }; 
        

     public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        Console.WriteLine(prompts[index]);
        return prompts[index];       
    }

}