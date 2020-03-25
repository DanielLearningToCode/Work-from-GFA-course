using System;

namespace reservations
{
    class ReservationApp
    {
        static void Main(string[] args)
        {
            Reservation reservation = new Reservation();
            Console.WriteLine($"Booking# {reservation.GetCodeBooking()} for {reservation.GetDowBooking()}");
        }
    }
}
