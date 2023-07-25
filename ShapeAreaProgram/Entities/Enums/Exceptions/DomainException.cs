using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaProgram.Entities.Enums.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string menssage) 
            : base(menssage) { }
    }
}
