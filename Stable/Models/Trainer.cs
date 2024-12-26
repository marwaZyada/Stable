namespace Stable.Models
{
    public class Trainer : BaseEntity
    {

        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int Experience_Years { get; set; }
        public List<Booking>? Bookings { get; set; } = new List<Booking>();

        public List<Horse>? Horses { get; set; } = new List<Horse>();
        public List<Language>? Languages { get; set; } = new List<Language>();


        public void AddLanguage(string name)
        {
            var lang = new Language
            {
                Name = name,
            };
            Languages.Add(lang);
        }

        public void AddBooking(Booking booking)
        {
            Bookings.Add(booking);
        }
        
    }
}
