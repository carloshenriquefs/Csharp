using System;

namespace ReservaHotel_Solucao2
{
    public class Reservation
    {
        public int RoomNumber { get; set; }

        public DateTime Checkin { get; set; }

        public DateTime Checkout { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }
        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int)duration.TotalDays;
        }

        public string UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (checkin < now || checkout < now) {
                return "Reservation dates for update must be future dates";
            }
            if (checkout <= checkin) {
                    return "Check-out date must be after check-in date ";
            }  
            Checkin = checkin;
            Checkout = checkout;
            return null;
        }

        public override string ToString()
        {
            return "Room " + RoomNumber + ", check-in: " + Checkin.ToString("dd/MM/yyyy") + ", check-out: " +Checkout.ToString("dd/MM/yyyy") + ", " + Duration() + " Nights";
        }
    }
}