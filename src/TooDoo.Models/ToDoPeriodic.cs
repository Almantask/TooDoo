using System;
using System.Collections.Generic;
using System.Text;

namespace TooDoo.Models
{
    public class ToDoPeriodic: ToDo
    {
        public TimeSpan RepeatInterval { get; set; }
        public DateTime NextTime => CreatedAt.Date.Add(RepeatInterval);

        public ToDoPeriodic(string title, string description, TimeSpan repeatInterval) : base(title, description)
        {
            RepeatInterval = repeatInterval;
        }
    }
}
