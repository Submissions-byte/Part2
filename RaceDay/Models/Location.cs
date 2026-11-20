using System.ComponentModel.DataAnnotations.Schema;

namespace RaceDay.Models
{
    public class Location
    {
        
        public int LocationID { get; set; }
        public string Name { get; set; }
        public string GPS_coordinates { get; set; }
        public string StartingLineLocation { get; set; }
        public string FinishLineLocation { get; set; }
        public decimal RouteLength { get; set; }
        //[ForeignKey(nameof(OrganiserID))]
        public int OrganiserID { get; set; }
        public Organiser organiser { get; set; }

    }
}
