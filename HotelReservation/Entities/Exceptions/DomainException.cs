using System;


namespace HotelReservation.Entities.Exceptions
{
    /*Nomenclatura Domain
     * A exceção é relacionado a Entidade Reserva, ela é
     * uma exceção do domínio do sistema.
     * Domínio é um termo técnico usado para referenciar
     * um negócio do sistema.
     * No exemplo, está referenciado a Reserva. 
     */
    class DomainException : ApplicationException 
    {
        public DomainException (string message) : base(message)
        {
        }
    }
}
