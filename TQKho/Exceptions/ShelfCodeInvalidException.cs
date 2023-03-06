using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TQKho.Exceptions
{
    [Serializable]
    public class ShelfCodeInvalidException : Exception
    {
        public ShelfCodeInvalidException() { }

        public ShelfCodeInvalidException(string message) : base(message) { }
    }
}
