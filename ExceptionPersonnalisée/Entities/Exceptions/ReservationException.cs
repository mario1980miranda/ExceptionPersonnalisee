using System;

namespace ExceptionPersonnalisee.Entities.Exceptions
{
    class ReservationException : ApplicationException
    {
        public ReservationException(string message) : base(message)
        {

        }
    }
}
