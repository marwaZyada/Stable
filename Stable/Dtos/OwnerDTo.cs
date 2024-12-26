using Stable.Models;
using System.ComponentModel.DataAnnotations;

namespace Stable.Dtos
{
    public class OwnerDTo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Nationality { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public List<IFormFile> Photos { get; set; } = new List<IFormFile>();
    }
}