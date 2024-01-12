using System;

class Program
{
    static void Main(string[] args)
    {
    
         // prompt the user to enter there course grade
        Console.Write("What is your course grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

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

        Console.WriteLine($"Your course grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed the course");
        }
        else
        {
            Console.WriteLine("Good luck next time!");
        }
    }
}