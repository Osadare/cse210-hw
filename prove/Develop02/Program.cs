 // Exceeding the requirements:
//  Added a method Delete to the Menu to delete save file from the Journal
    
 
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        Journal newJournal = new Journal();
        do
        {
            Console.WriteLine("Welcome to the Journal app!");
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Delete");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do:");
            option = int.Parse(Console.ReadLine());

            if (option == 1) // Write
            {
                PGenerator newPrompt = new PGenerator();
                string prompt = newPrompt.GetRandomPrompt();

                DateTime theCurrentTime = DateTime.Now;
                string entryText = Console.ReadLine();

                Entry entry = new Entry(theCurrentTime.ToShortDateString(), prompt, entryText);

                newJournal.AddEntry(entry);
            }
            else if (option == 2) // Display
            {
                DisplayAll(newJournal);
            }
            else if (option == 3) // Load
            {
                Console.WriteLine("What is the filename? ");
                string name = Console.ReadLine();
                newJournal.LoadFromFile(name);
            }
            else if (option == 4) // Save
            {
                Console.WriteLine("What is the filename? ");
                string name = Console.ReadLine();
                newJournal.SaveToFile(name);
            }
            else if (option == 5) // Delete
            {
                Console.WriteLine("What is the filename to delete? ");
                string name = Console.ReadLine();
                DeleteFile(name);
            }
        } while (option != 6);
    }

    private static void DisplayAll(Journal newJournal)
    {
        Console.WriteLine("Journal entries:");
        foreach (var entry in newJournal.GetEntries())
        {
            entry.Display();
        }
    }

    private static void DeleteFile(string filename)
    {
        if (File.Exists(filename))
        {
            File.Delete(filename);
            Console.WriteLine("File has been deleted successfully.");
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }
}