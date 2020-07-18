using System;
using HotelReservation.Entities;

namespace HotelReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room NUmber: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            //Forma ruim de teste
            //Usando if-else, os testes são feitos repetidos no código continuamente.
            //A lógica da reseva deveria estar dentro de um bloco só.
            if (checkOut <= checkIn)
            {
                Console.WriteLine("Reservation error: Check-out date must be after check-in date.");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation = new Reservation(number, checkIn, checkOut);

                //Pego o instante atual
                DateTime now = DateTime.Now;
                if(checkIn < now || checkOut < now)
                {
                    Console.WriteLine("Reservation error: Reservation dates for update must be future dates.");
                }
                else if (checkOut <= checkIn)
                {
                    Console.WriteLine("Reservation error: Check-out date must be after check-in date.");
                }
                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reservation: " + reservation);
                }

            }
           
        }
    }
}
