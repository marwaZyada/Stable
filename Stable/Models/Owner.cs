﻿using System.ComponentModel.DataAnnotations;

namespace Stable.Models
{
    public class Owner:BaseEntity
    {
    
        
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Nationality { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public List<Horse>? Horses { get; set; }=new List<Horse>();
    }
}
