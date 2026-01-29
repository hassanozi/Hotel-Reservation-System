using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class RoomReservation : BaseModel
    {
        public string ReservationNumber { get; set; }
        public DateTime checkInDate { get; set; }
        public DateTime checkOutDate { get; set; }
        public short numberOfAdults { get; set; }
        public short numberOfChildren { get; set; }
        public ReservationStatus Status { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid FeedbackId { get; set; }
        public Feedback Feedback { get; set; }

        public Guid InvoiceId { get; set; }
        public Invoice Invoice { get; set; }

    }
}
