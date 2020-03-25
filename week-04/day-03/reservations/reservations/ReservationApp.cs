using System;

namespace reservations
{
    class ReservationApp
    {
        static void Main(string[] args)
        {
            Reservation reservationSys = new Reservation();
            Console.WriteLine($"Booking# {reservationSys.GetCodeBooking()} for {reservationSys.GetDowBooking()}");
        }
    }
}
