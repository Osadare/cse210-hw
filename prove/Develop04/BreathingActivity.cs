using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax . Clear your mind and focus on your breathing.";
    }

    public void run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            showCountdown(4);

            Console.Write("\n");

            Console.Write("Now breathe out...");
            showCountdown(6);
            Console.WriteLine("\n");
            Thread.Sleep(500);

           
            TimeSpan timeElapsed = DateTime.Now - startTime;
            
            if (timeElapsed.TotalSeconds >= _duration) {
                break;   }
        }
        DisplayEndingMessage();
    }
}

