using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantenedor_oficial_salaventasOLD.Exceptions
{
    public class ReglaNegocioException : Exception
    {
        public int ErrorCode { get; }
        public ReglaNegocioException(string message, int errorCode = 0) : base(message)
        {
            ErrorCode = errorCode;
        }
    }
}
