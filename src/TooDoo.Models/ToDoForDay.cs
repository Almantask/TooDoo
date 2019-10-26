using System;
using System.Collections.Generic;
using System.Text;
using TooDoo.Models.Exceptions;

namespace TooDoo.Models
{
    public class ToDoForDay
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public DateTime CreatedAt { get; }
        public DateTime? CompletedAt { get; private set; }
        public bool IsCompleted => CompletedAt != null;

        public static bool operator ==(ToDoForDay todo1, ToDoForDay todo2) => todo1?.Title == todo2?.Title;
        public static bool operator !=(ToDoForDay todo1, ToDoForDay todo2) => todo1?.Title != todo2?.Title;

        public override string ToString() => $"{Title}- {Description}";
    }
}
