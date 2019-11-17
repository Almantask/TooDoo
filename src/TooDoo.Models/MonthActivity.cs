using System.Collections.Generic;
using System.Linq;

namespace TooDoo.Models
{
    public class MonthActivity
    {
        public Month Month;
        public IEnumerable<Day> ActiveDays { get; set; }

        private readonly int _monthIndex;

        public MonthActivity(Month month, IEnumerable<ToDo> todos)
        {
            Month = month;
            _monthIndex = (int)month;

            ActiveDays = ApplyToDays(todos);
        }

        private IEnumerable<Day> ApplyToDays(IEnumerable<ToDo> todos)
        {
            var dayTasks = new Dictionary<int, Day>();

            var forThisMonth = todos.Where(t => 
                t.DoTime.Month == _monthIndex);

            foreach (var todo in forThisMonth)
            {
                var dayIndex = todo.DoTime.Day;
                if (!dayTasks.ContainsKey(dayIndex))
                {
                    dayTasks.Add(dayIndex, new Day());
                }

                var day = dayTasks[dayIndex];
                day.AddToDo(todo);
            }

            return dayTasks.Values;
        }

    }
}
