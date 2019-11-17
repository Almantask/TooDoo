using System;

namespace TooDoo.Models.Exceptions
{
    public class CircularReferenceException: Exception
    {
        public CircularReferenceException(string objectName): base($"{objectName} cannot be linked with itself.")
        { }
    }
}
