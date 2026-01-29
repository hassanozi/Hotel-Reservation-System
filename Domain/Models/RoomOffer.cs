using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class RoomOffer : BaseModel
    {
        public int OfferId { get; set; }
        public Offer Offer { get; set; }


    }
}
