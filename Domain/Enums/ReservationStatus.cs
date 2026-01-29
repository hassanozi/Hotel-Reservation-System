using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Enums
{
    public enum ReservationStatus
    {
        Pending = 0,
        Confirmed = 1,
        CheckedIn = 2,
        CheckedOut = 3,
        Cancelled = 4,
    }
}
