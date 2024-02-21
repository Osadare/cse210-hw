
public class OutdoorGathering : Event
{
    public string Weather { get; set; }

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        Weather = weather;
    }

    public override string GetMessage()
    {
        return base.GetMessage() + $"\nWeather: {Weather}";
    }
}