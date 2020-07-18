using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }
        //CONSTRUTORES
        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        //MÉTODOS
        public int Duration()
        {
            //pegar diferença entre duas datas (diferença entre um instante e outro)
            TimeSpan duration = CheckOut.Subtract(CheckIn);

            //para pegar a duração em dias
            //A propriedade TotalDays é um double
            //para converter para inteiro, é preciso usar CASTING
            return (int)duration.TotalDays;
        }

        //Atualizo as datas das reservas
        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            CheckIn = checkIn;
            CheckOut = checkOut;
        }


        //Usando sobrescrita para imprimir os dados da classe 
        //no programa principal
        public override string ToString()
        {
            return "Room "
                 + RoomNumber
                 + ", check-in: "
                 + CheckIn.ToString("dd/MM/yyyy") //formantando o tipo data
                 + ", check-out: "
                 + CheckOut.ToString("dd/MM/yyyy")
                 + ", "
                 + Duration() //chama a função
                 + " nights.";
        }
    }
}
