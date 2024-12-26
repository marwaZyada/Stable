namespace Stable.Models
{
    public class Land:BaseEntity
    {
       
        public string Location { get; set; }
        public double Area { get; set; }
        public double Hourly_Price { get; set; }
        public List<Booking>? Bookings { get; set; } = new List<Booking>();
      
        public List<Horse>? Horses { get; set; } = new List<Horse>();
    }
}
