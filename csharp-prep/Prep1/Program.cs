using System;

class Program
{
    static void Main(string[] args)
    {
        //prompt the user to enter there first and the last name 
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}.");
    
    }
}