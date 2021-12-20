using System;
using System.Collections.Generic;
using System.Text;

namespace MeterReadings.ExceptionHandling.Exception
{
    public abstract class DomainException:System.Exception
    {
        public DomainException(string message): base (message)
        {

        }
    }
    public class DomainNotFoundException: DomainException
    {
        public DomainNotFoundException(string message): base(message)
        {

        }
    }
    public class DomainBadRequestException : DomainException
    {
        public DomainBadRequestException(string message) : base(message)
        {

        }
    }
}
