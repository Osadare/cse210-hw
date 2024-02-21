using System;

public class Swimming : Activity
{
    private int Laps { get; set; }

    public Swimming(DateTime date, int lengthInMinutes, int laps)
    {
        Date = date;
        LengthInMinutes = lengthInMinutes;
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (LengthInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return LengthInMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} Swimming ({LengthInMinutes} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min/km";
    }
}