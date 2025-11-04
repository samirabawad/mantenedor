using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantenedor_oficial_salaventasOLD.Exceptions
{
    public class InvalidCredentialsException: Exception
    {
        public InvalidCredentialsException() { }
        public InvalidCredentialsException(string message) : base(message) { }
        public InvalidCredentialsException(string message, Exception innerException) : base(message, innerException) { }
        public InvalidCredentialsException(string name, object key)
            : base($"Entity \"{name}\" ({key}) was not found.")
        { }
    }
}
