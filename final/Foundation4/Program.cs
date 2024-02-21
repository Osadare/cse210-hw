 //Polymorphism with Exercise Tracking project.I have made progress in designing the base class for activities and implementing derived classes for running,cycling and swimming. 
using System;


public class Program
{
    public static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new DateTime(2024, 2, 14), 30, 3.0));
        activities.Add(new Cycling(new DateTime(2024, 1, 29), 30, 6.0));
        activities.Add(new Swimming(new DateTime(2024, 1, 20), 30, 10));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    } 
}    
