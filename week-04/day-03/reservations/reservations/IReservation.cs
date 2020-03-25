using System;
using System.Collections.Generic;
using System.Text;

namespace reservations
{
    public interface IReservation
    {
        string GetDowBooking();
        string GetCodeBooking();
    }
}
