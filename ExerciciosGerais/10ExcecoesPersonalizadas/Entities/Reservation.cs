using System;
using _10ExcecoesPersonalizadas.Entities.Exception;

namespace _10ExcecoesPersonalizadas.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { }
        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if(checkOut <= checkIn)
                throw new DomainException("Error in reservation: Check-Out date must be after Check-In date");
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut; 
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if(checkIn < now || checkOut < now)
                throw new DomainException("Error in reservation: Reservation dates for update must be future dates");
            if(checkOut <= checkIn)
                throw new DomainException("Error in reservation: Check-Out date must be after Check-In date");

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return $"Room {RoomNumber}, Check-In: {CheckIn.ToString("dd/MM/yyyy")}, Check-Out: {CheckOut.ToString("dd/MM/yyyy")}, {Duration()} nights";
        }
    }
}