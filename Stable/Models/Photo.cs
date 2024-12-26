using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stable.Models
{
    public class Photo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(225)]
        public string Name { get; set; }

        [ForeignKey(nameof(Horse))]
        public string? HorseId { get; set; }
        public Horse? Horse { get; set; }
        [ForeignKey(nameof(Land))]
        public string? LandId { get; set; }
        public Land? Land { get; set; }
        [ForeignKey(nameof(Trainer))]
        public string? TrainerId { get; set; }
        public Trainer? Trainer { get; set; }
        [ForeignKey(nameof(Owner))]
        public string? OwnerId { get; set; }
        public Owner? Owner { get; set; }
        [ForeignKey(nameof(CarePachage))]
        public string? CarePachageId { get; set; }
        public CarePachage? CarePachage { get; set; }

        public Photo()
        {
          
        }
    }
}
