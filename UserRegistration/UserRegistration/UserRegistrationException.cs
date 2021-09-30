using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    public class UserRegistrationException : Exception
    {
        public enum ExceptionsType
        {
            Invalid_MESSAGE,
        }
        public ExceptionsType type;
        public UserRegistrationException(ExceptionsType Type, string message) : base(message)
        {
            this.type = Type;

        }
    }
}
