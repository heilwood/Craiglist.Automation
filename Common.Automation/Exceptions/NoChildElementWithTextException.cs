using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Automation.Exceptions
{
    public class NoChildElementWithTextException : Exception
    {
        public NoChildElementWithTextException()
        {
        }

        public NoChildElementWithTextException(string message)
            : base(message)
        {
        }

        public NoChildElementWithTextException(string message, Exception inner)
            : base(message, inner)
        {
        }

    }
}
