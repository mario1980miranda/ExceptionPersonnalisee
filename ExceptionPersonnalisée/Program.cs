using System;
using ExceptionPersonnalisee.Entities;
using ExceptionPersonnalisee.Entities.Exceptions;

namespace ExceptionPersonnalisee
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (yyyy-MM-dd): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (yyyy-MM-dd): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (yyyy-MM-dd): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (yyyy-MM-dd): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);

                Console.WriteLine(reservation);
            }
            catch (ReservationException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
        }
    }
}
