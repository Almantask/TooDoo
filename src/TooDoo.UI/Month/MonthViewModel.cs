using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TooDoo.UI.Day;

namespace TooDoo.UI.Month
{
    public class MonthViewModel
    {
        public Models.Month Month { get; set; }
        public ObservableCollection<DayViewModel> Days { get; set; }

        public MonthViewModel(Models.Month month, int year)
        {
            Month = month;

            Days = new ObservableCollection<DayViewModel>();
            var monthIndex = (int) Month;
            var totalDays = DateTime.DaysInMonth(year, monthIndex);
            for (int dayIndex = 0; dayIndex < totalDays; dayIndex++)
            {
                var date = new DateTime(year, monthIndex, dayIndex);
                var day = new DayViewModel(date);
                Days.Add(day);
            }
        }
    }
}
