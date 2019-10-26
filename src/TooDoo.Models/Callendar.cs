using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace TooDoo.Models
{
    public class MonthActivity
    {
        public Month Month;
        public IEnumerable<Day> Days { get; set; }

        private readonly int _monthIndex;

        public MonthActivity(Month month, IEnumerable<ToDo> todos)
        {
            Month = month;
            _monthIndex = (int)month;
        }

        private void LoadDays(IEnumerable<ToDo> todos)
        {
            Days = new List<Day>();

            var forThisMonth = todos.Where(t => 
                t.Deadline == null &&

                                                )
            foreach (var todo in todos)
            {
                
            }
        }

        private bool BelongsToMonth(ToDo todo) => 
            (todo.CreatedAt.Month <= _monthIndex && 
             todo.CompletedAt == null) ||
            (todo.CreatedAt.Month < _monthIndex &&
                todo.CompletedAt?.Month == 1);

        private bool IsOngoingThisMonth(ToDo todo) =>
            (!todo.IsCompleted &&
             todo.CreatedAt.Month <= _monthIndex);

        private bool IsCompletedThisMonth(ToDo todo) =>
            (todo.CompletedAt?.Month == _monthIndex);





    }
}
