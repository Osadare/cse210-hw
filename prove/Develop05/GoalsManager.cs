 
  
  
using System;
using System.Collections.Generic;

public class GoalsManager
{
    private List<Goal> goals;

    public GoalsManager()
    {
        goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        foreach (Goal goal in goals)
        {
            goal.Display();
        }
    }

    public void CompleteGoal(int index)
    {
        if (index >= 0 && index < goals.Count)
        {
            Goal goal = goals[index];
            goal.Complete();
        }
        else
        {
            Console.WriteLine("Invalid goal index!");
        }
    }
}
