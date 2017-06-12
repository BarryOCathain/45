using System;

namespace _45.Exceptions
{
    class CardException : Exception
    {
        public CardException()
            : base()
        {
           
        }

        public CardException(string message) 
            : base(message)
        {
        }

        public CardException(string message, Exception innerException) 
            : base(message, innerException)
        {
        }
    }
}
