using System;
using Exceptions1._2SolucaoRuim.Entities;

namespace Exceptions1._2SolucaoRuim
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Room Number; ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Checkin-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Checkin-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in Reservation: CheckOut date must be after check-in date ");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Checkin-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Checkin-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                string error = reservation.UpdateDates(checkIn, checkOut);

                if(error != null)
                {
                    Console.WriteLine("Erro in reservation: " + error);
                }

                else
                {                 
                    Console.WriteLine("Reservation: " + reservation);
                }
            }
        }
    }
}

