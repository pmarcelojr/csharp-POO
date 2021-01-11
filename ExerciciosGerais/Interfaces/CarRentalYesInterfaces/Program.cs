using System;
using System.Globalization;
using CarRentalYesInterfaces.Entities;
using CarRentalYesInterfaces.Services;

namespace CarRentalYesInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per Hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per Day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental car = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService()); 

            rentalService.ProcessInvoice(car);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(car.Invoice);
        }
    }
}
