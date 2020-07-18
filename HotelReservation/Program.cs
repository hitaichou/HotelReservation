using System;
using HotelReservation.Entities;
using HotelReservation.Entities.Exceptions;

namespace HotelReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Room NUmber: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            
            //Forma MUITO RUIM de teste
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
                */
            /*
             * Enviei o teste abaixo para a classe RESERVATION
            //Pego o instante atual
            DateTime now = DateTime.Now;
            if(checkIn < now || checkOut < now)
            {
                Console.WriteLine("Reservation error: Reservation dates for update must be future dates.");
            }
            else if (checkOut <= checkIn)
            {
                Console.WriteLine("Reservation error: Check-out date must be after check-in date.");
            }*/
            /***************************************************/
            //Este método é RUIM
            //Pois, o retorno do string não tem sentido no momento de atualizar a reserva
            //A reserva deveria ser uma operação VOID
            //Se precisasse retornar um string, teríamos um conflito de retorno.
            /*string error = reservation.UpdateDates(checkIn, checkOut);

            if (error != null)
            {
                Console.WriteLine("Error in reservation: " + error);
            }
            else
            {
                //reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            */

            /****************************************************/
            //Melhor forma, o código fica mais coeso e simples.
            /***************************************************/

            try
            { 
                Console.Write("Room Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
                //-----
                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                //Atualizo as datas
                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error Reservation: " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
