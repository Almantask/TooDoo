using System;

namespace TooDoo.Models.Exceptions
{
    public class InvalidDeadlineException : Exception
    {
        public InvalidDeadlineException(DateTime deadline, DateTime start): 
            base($"Deadline {deadline} is not after start {start}")
        { }
    }
}
