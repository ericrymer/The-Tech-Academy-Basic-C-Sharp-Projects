using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class NotDayException : Exception
    {
        public NotDayException() { }

        public NotDayException(string message)
            : base(message) { }

        public NotDayException(string message, Exception inner)
            : base(message, inner) { }
    }
}