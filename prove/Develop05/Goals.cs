using System;

public abstract class Goal
{
    public string Name { get; protected set; }
    public int Value { get; protected set; }
    public bool IsComplete { get; protected set; }

    public Goal(string name, int value)
    {
        Name = name;
        Value = value;
        IsComplete = false;
    }

    public abstract void Display();
    public abstract void Complete();
}

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value) : base(name, value)
    {
    }

    public override void Display()
    {
        Console.WriteLine(Name + " - Value: " + Value + " - Completed: " + IsComplete);
    }

    public override void Complete()
    {
        IsComplete = true;
        Console.WriteLine(Name + " has been marked as complete!");
    }
}

public class LongTermGoal : Goal
{
    public LongTermGoal(string name, int value) : base(name, value)
    {
    }

    public override void Display()
    {
        Console.WriteLine(Name + " - Value: " + Value + " - Completed: " + IsComplete);
    }

    public override void Complete()
    {
        Console.WriteLine("Cannot complete a long-term goal at this time.");
    }
}

public class MilestoneGoal : Goal
{
    public int TargetMilestone { get; private set; }
    public int CurrentMilestone { get; private set; }

    public MilestoneGoal(string name, int value, int targetMilestone) : base(name, value)
    {
        TargetMilestone = targetMilestone;
        CurrentMilestone = 0;
    }

    public override void Display()
    {
        Console.WriteLine(Name + " - Value: " + Value + " - Completed: " + IsComplete + " - Progress: " + CurrentMilestone + "/" + TargetMilestone);
    }

    public override void Complete()
    {
        if (CurrentMilestone < TargetMilestone)
        {
            CurrentMilestone++;
            if (CurrentMilestone == TargetMilestone)
            {
                IsComplete = true;
                Console.WriteLine(Name + " has reached the target milestone and is marked as complete!");
            }
            else
            {
                Console.WriteLine("Progress has been updated for " + Name + ".");
            }
        }
        else
        {
            Console.WriteLine("Goal has already been completed!");
        }
    }
}


