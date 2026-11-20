namespace RaceDay.Models
{
    public enum Type { Run, Swim, Cycle }
    public class Event
    {
        public int EventID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateOnly EventDate { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public Type EventType { get; set; } //alter db context to use this.
        public string BannerUrl { get; set; }
        public int LocationID { get; set; }
        public Location Location { get; set; }
        public int OrganiserID { get; set; }
        public Organiser Organiser { get; set; }
    }
}
