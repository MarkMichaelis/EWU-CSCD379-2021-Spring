using System;

namespace UserGroup.Data
{
    public class Event
    {
        public Event() { }
        public Event(int id, string name) => (Id, Name) = (id, name);

        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string? Description { get; set; } = "";
        public DateTime? Date { get; set; }
        public string? Location { get; set; } = "";
        public int? SpeakerId { get; set; }
    }
}
