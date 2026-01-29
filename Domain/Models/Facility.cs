using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Facility :BaseModel
    { 
        public string Facility { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsPaid { get; set; }
        public decimal Price { get; set; }
    }
}
