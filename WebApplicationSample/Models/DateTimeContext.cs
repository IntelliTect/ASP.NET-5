using System;

namespace WebApplicationSample.Models
{
    public interface IDateTimeContext
    {
        DateTime Now { get; }
    }

    public class DateTimeContext : IDateTimeContext
    {
        public DateTime Now => DateTime.Now;
    }
}