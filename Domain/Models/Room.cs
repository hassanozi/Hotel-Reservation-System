using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Room : BaseModel
    { 
        public  string Code { get; set; }
        public  int FloorNumber { get; set; }
        public  decimal PricePerNight { get; set; }
        public  string RoomDescription { get; set; }
      public  RoomType roomType  { get; set; }
        public  string RoomView  { get; set; }
        public  RoomStatus RoomStatus { get; set; } 
        public  string RoomDescription { get; set; }

        public GUID UserID { get; set; }
        public  User  User { get; set; }

        //public  HashSet<> MyProperty { get; set; }
    }
}
