public class Reception : Event
{
    public string RSVP { get; set; }

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvp)
        : base(title, description, date, time, address)
    {
        RSVP = rsvp;
    }

    public override string GetMessage()
    {
        return base.GetMessage() + $"\nRSVP: {RSVP}";
    }
}