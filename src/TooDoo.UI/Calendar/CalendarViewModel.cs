using System;
using System.Collections.ObjectModel;
using TooDoo.UI.Month;

namespace TooDoo.UI.Calendar
{
    public class CalendarViewModel
    {
        public Models.Month CurrentMonth { get; set; }
        public int CurrentYear { get; set; }

        public MonthViewModel Month { get; set; }

        public CalendarViewModel()
        {
            CurrentMonth = (Models.Month)DateTime.Now.Month;
            CurrentYear = DateTime.Now.Year;
            Month = new MonthViewModel(CurrentMonth, CurrentYear);
        }
    }
}
