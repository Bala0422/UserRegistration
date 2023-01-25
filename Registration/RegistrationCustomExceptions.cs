using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration
{
    public class RegistrationCustomExceptions : Exception
    {
        public enum ExceptionType
        {
            EMPTY_MESSAGE,
            NO_CLASS
        }
        public readonly ExceptionType Type;

        public RegistrationCustomExceptions(ExceptionType type, string message) : base(message)
        {
            this.Type = type;
        }
    }
}
