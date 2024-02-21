using System;

public class Cycling : Activity
{
    private double Speed { get; set; }

    public Cycling(DateTime date, int lengthInMinutes, double speed)
    {
        Date = date;
        LengthInMinutes = lengthInMinutes;
        Speed = speed;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetDistance()
    {
        return Speed * (LengthInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return 60.0 / Speed;
    }

    public override string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} Cycling ({LengthInMinutes} min) - Distance: {GetDistance()} miles, Speed: {Speed} mph, Pace: {GetPace()} min/mile";
    }
}