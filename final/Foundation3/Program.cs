//Inheritance with Event Planning project. I have made considerable progress in crafting a base class for events, as well as creating derived classes for different types of events like lecture, reception, and outdoor gathering.
using System;

class Program
{
    static void Main()
    { 
        Console.WriteLine("EVENTS !");

        
        Address lectureAddress = new Address("456 Main Street", "New York", "NY", "USA");
        Lecture lecture = new Lecture("Advanced Machine Learning", "Explore advanced techniques in machine learning", DateTime.Now, new TimeSpan(13, 0, 0), lectureAddress, "Alice Johnson", 75);
        
       
        Address receptionAddress = new Address("766 State St", "Middle Metropolis", "VA", "USA");
        Reception reception = new Reception("Industry Networking Event", "Connect with professionals across various industries", DateTime.Now.AddDays(1), new TimeSpan(17, 0, 0), receptionAddress, "rsvp@networkingevent.com");
        
        
        Address gatheringAddress = new Address("456 Lake Road", "Lakeside", "Stateville", "Countryland");
        OutdoorGathering gathering = new OutdoorGathering("Summer Picnic", "Enjoy a picnic with games and activities", DateTime.Now.AddDays(2), new TimeSpan(16, 0, 0), gatheringAddress, "Sunny");

        
        
        Console.WriteLine(lecture.GetMessage()); 
        Console.WriteLine("\n-------------------");
        Console.WriteLine(reception.GetMessage()); 
        Console.WriteLine("\n-------------------");
        Console.WriteLine(gathering.GetMessage()); 
       
    } 
}