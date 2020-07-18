using System;
using HotelReservation.Entities.Exceptions;
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
            //Usando a propriedade THROW de exceção
            //é possível usado o teste dentro do construtor
            //para evitar entrada incorreta de parâmetros
            if (checkOut <= checkIn)
            {
                throw new DomainException("Reservation error: Check-out date must be after check-in date.");
            }

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
        //public string UpdateDates(DateTime checkIn, DateTime checkOut) //removi, pois o update não é para retornar dados.
        {
            //Pego o instante atual
            DateTime now = DateTime.Now;

            //Testo as atualizações de datas e se der exceção, retorno mensagem de erro.
            if (checkIn < now || checkOut < now)
            {
                //return "Reservation error: Reservation dates for update must be future dates.";

                //throw é a propriedade que lança a mensagem de erro.
                //também corta o processo.
                throw new DomainException("Reservation error: Reservation dates for update must be future dates.");
            }
            if (checkOut <= checkIn)
            {
                //return "Reservation error: Check-out date must be after check-in date.";

                throw new DomainException("Reservation error: Check-out date must be after check-in date.");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
            //return null; //o return null diz que não houve erro.
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
