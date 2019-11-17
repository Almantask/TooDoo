using System;

namespace TooDoo.Models
{
    public class ToDo
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DoTime { get; set; }

        public DateTime CreatedAt { get; }
        public DateTime? CompletedAt { get; private set; }
        public bool IsCompleted => CompletedAt != null;

        public static bool operator ==(ToDo todo1, ToDo todo2) => todo1?.Title == todo2?.Title;
        public static bool operator !=(ToDo todo1, ToDo todo2) => todo1?.Title != todo2?.Title;

        public override string ToString() => $"{Title}- {Description}";

        public ToDo(string title, DateTime doTime, string description = "")
        {
            Title = title;
            Description = description;
            DoTime = doTime;
        }
    }
}
