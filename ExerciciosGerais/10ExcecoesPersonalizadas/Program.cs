using System;
using _10ExcecoesPersonalizadas.Entities;

namespace _10ExcecoesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-In date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-Out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if(checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation: Check-Out date must be a after Check-In");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine($"Reservation:\n{reservation}");

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-In date (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-Out date (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;
                if(checkin < now || checkout < now)
                {
                    Console.WriteLine("Error in reservation: Reservation dates for update must be future dates");
                }
                else if(checkout <= checkin)
                {
                    Console.WriteLine("Error in reservation: Check-Out date must be after Check-In date");
                }
                else
                {
                    reservation.UpdateDates(checkin, checkout);
                    Console.WriteLine($"Reservation Update:\n{reservation}");
                }
            }
        }
    }
}
