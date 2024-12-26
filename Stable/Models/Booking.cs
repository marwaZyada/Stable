using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stable.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        public DateTime Start_date_time { get; set; }
        public DateTime End_date_time { get; set; }
        [ForeignKey(nameof(Horse))]
        public string? HorseId { get; set; }
        public Horse Horse { get; set; }
        [ForeignKey(nameof(Land))]
        public string? LandId { get; set; }
        public Land Land { get; set; }
        [ForeignKey(nameof(Trainer))]
        public string? TrainerId { get; set; }
        public Trainer Trainer { get; set; }
    }
}
