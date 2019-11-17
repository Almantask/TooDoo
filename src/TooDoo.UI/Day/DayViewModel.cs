using System;
using System.Collections.Generic;
using System.Text;

namespace TooDoo.UI.Day
{
    public class DayViewModel
    {
        public DayOfWeek DayOfWeek { get; }
        public int DayOfMonth { get; }

        public DayViewModel(DateTime dateTime)
        {
            DayOfWeek = dateTime.DayOfWeek;
            DayOfMonth = dateTime.Day;
        }
    }
}
