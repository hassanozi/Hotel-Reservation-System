using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Offer : BaseModel
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndtDate { get; set; }
        public decimal DiscountValue { get; set; }

    }
}
