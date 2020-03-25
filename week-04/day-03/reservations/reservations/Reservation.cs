using System;
using System.Collections.Generic;
using System.Text;

namespace reservations
{
    enum Days
    {
        MON,
        TUE,
        WED,
        THU,
        FRI,
        SAT,
        SUN,
    }
    class Reservation : IReservation
    {
        private string dow;
        private string code;
        public Reservation()
        {
            CreateDowBooking();
            CreateCodeBooking();
        }
        private static int RandNum(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max);
        }
        private void CreateDowBooking()
        {
            int randDay = RandNum(0, 7);
            Days day = (Days)randDay;
            this.dow = day.ToString();
        }

        private void CreateCodeBooking()
        {
            string bookingCode = "";
            for (int i = 0; i < 8; i++)
            {
                int randCharASCII = RandNum(0, 2) == 1 ? RandNum(48, 58) : RandNum(65, 91);
                char character = (char)randCharASCII;
                bookingCode += character;
            }
            this.code = bookingCode;
        }
        public string GetCodeBooking()
        {
            return code;
        }
        public string GetDowBooking()
        {
            return dow;
        }

    }
}
/*Create a `Reservation` class by implementing all the features as required by
  the interface.
- The booked reservations should look like the output below.
- Please note that the reservation code should contain 8 characters randomly
  from 0-Z, all uppercase letters.
- Also, the DOW is randomly ordered to the bookings from an array.
  - *DOW* stands for *Day of the Week* (MON, TUE, etc.)

    THU
Booking# 0V5OH7VS for WED
Booking# CV6QOAJO for MON
Booking# 03GHEJMV for SAT
Booking# M5JFB32I for THU
Booking# W30PF0E0 for SAT
Booking# S0R70GMN for SAT
Booking# 3E032B3C for WED
Booking# OD27E36J for SAT
Booking# 4MEU0657 for MON

*/
