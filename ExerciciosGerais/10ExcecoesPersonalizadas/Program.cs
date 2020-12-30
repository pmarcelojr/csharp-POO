using System;
using _10ExcecoesPersonalizadas.Entities;
using _10ExcecoesPersonalizadas.Entities.Exception;

namespace _10ExcecoesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Clear();
                Console.Write("Room Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-In date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-Out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine($"Reservation:\n{reservation}");

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-In date (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-Out date (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkin, checkout);
                Console.WriteLine($"Reservation Update:\n{reservation}");
            }
            catch(DomainException e) {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e) {
                Console.WriteLine($"Format erro: {e.Message}");
            }
            catch(Exception e) {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }
        }
    }
}
