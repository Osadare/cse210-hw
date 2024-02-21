using System;

public class Running : Activity
{
    private double Distance { get; set; }

    public Running(DateTime date, int lengthInMinutes, double distance)
    {
        Date = date;
        LengthInMinutes = lengthInMinutes;
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return Distance / (LengthInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return LengthInMinutes / Distance;
    }

    public override string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} Running ({LengthInMinutes} min) - Distance: {Distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min/mile";
    }
}