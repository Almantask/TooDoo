using System;
using System.Collections.Generic;
using System.Text;

namespace TooDoo.Models.Exceptions
{
    public class CircularReferenceException: Exception
    {
        public CircularReferenceException(string objectName): base($"{objectName} cannot be linked with itself.")
        { }
    }
}
