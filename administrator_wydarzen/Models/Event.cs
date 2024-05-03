using System;


namespace administrator_wydarzen.Models
{
    public class Event
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string Priority { get; set; }

        public Event(string title, string description, DateTime date, string type, string priority)
        {
            Title = title;
            Description = description;
            Date = date;
            Type = type;
            Priority = priority;
        }
        public Event() { }
    }
}
