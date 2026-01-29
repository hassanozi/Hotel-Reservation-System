using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class RoomFacility : BaseModel
    { 
        public int RoomID { get; set; }
        public int FacilityID { get; set; }
        public bool IsActive { get; set; }
    }
}
