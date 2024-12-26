using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stable.Models
{
    public class Horse:BaseEntity
    {
     
      

        public string Name { get; set; }
        public string Gender { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public string Hoof_Condition { get; set; }
        public string Health_Status { get; set; }
        public string Physical_Condition { get; set; }
        public string Training_Type { get; set; }
        public double Rental_Price_Per_Hour { get; set; }
        public double Selling_Price { get; set; }
        public bool Is_For_Sale { get; set; }
        public DateTime Last_Checkup_Date { get; set; }
        [ForeignKey(nameof(Owner))]
        public string? OwnerId { get; set; }
        public Owner Owner { get; set; }
        [ForeignKey(nameof(Land))]
        public string? LandId { get; set; }
        public Land Land { get; set; }
        [ForeignKey(nameof(Trainer))]
        public string? TrainerId { get; set; }
        public Trainer Trainer { get; set; }
        public List<Booking>? Bookings { get; set; } = new List<Booking>();
        public List<CarePachage>? Pachages { get; set; }=new List<CarePachage>();
    }
}
