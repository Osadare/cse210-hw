 //Exceeds the requirement Add goals that have ability to make progress towards a large goal and getting value for work
  
  
   using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a GoalsManager object
        GoalsManager goalsManager = new GoalsManager();

        while (true)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Add a goal");
            Console.WriteLine("2. Display goals");
            Console.WriteLine("3. Complete a goal");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddGoal(goalsManager);
                    break;
                case "2":
                    DisplayGoals(goalsManager);
                    break;
                case "3":
                    CompleteGoal(goalsManager);
                    break;
                case "4":
                    Console.WriteLine("Exiting the program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AddGoal(GoalsManager goalsManager)
    {
        Console.WriteLine("Enter the goal details:");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Value: ");
        int value = int.Parse(Console.ReadLine());

        Console.WriteLine("Select the goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Milestone Goal");
        Console.WriteLine("3. Long-Term Goal");
        Console.Write("Enter your choice: ");
        string goalTypeChoice = Console.ReadLine();

        switch (goalTypeChoice)
        {
            case "1":
                Goal simpleGoal = new SimpleGoal(name, value);
                goalsManager.AddGoal(simpleGoal);
                Console.WriteLine("Simple goal added successfully!");
                break;
            case "2":
                Console.Write("Target Milestone: ");
                int targetMilestone = int.Parse(Console.ReadLine());
                Goal milestoneGoal = new MilestoneGoal(name, value, targetMilestone);
                goalsManager.AddGoal(milestoneGoal);
                Console.WriteLine("Milestone goal added successfully!");
                break;
            case "3":
                Goal longTermGoal = new LongTermGoal(name, value);
                goalsManager.AddGoal(longTermGoal);
                Console.WriteLine("Long-term goal added successfully!");
                break;
            default:
                Console.WriteLine("Invalid goal type. Goal not added.");
                break;
        }
    }

    static void DisplayGoals(GoalsManager goalsManager)
    {
        Console.WriteLine("Current Goals:");
        goalsManager.DisplayGoals();
    }

    static void CompleteGoal(GoalsManager goalsManager)
    {
        Console.Write("Enter the index of the goal to complete: ");
        int index = int.Parse(Console.ReadLine());
        goalsManager.CompleteGoal(index);
    }
}