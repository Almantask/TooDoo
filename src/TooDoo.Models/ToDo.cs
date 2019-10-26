using System;
using System.Collections.Generic;
using System.ComponentModel;
using TooDoo.Models.Exceptions;

namespace TooDoo.Models
{
    public class ToDo
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? Deadline { get; set; }
        public DateTime CreatedAt { get; }
        public DateTime? CompletedAt { get; private set; }
        public bool IsCompleted => CompletedAt != null;

        internal int Id { get; }

        /// <summary>
        /// ToDos which will follow after this one.
        /// </summary>
        public ToDo Next { get; set; }
        public ToDo Current { get; private set; }
        public ToDo Parent { get; set; }
        /// <summary>
        /// Sub tasks that belong to this task.
        /// </summary>
        public IEnumerable<ToDo> Children { get; }

        /// <summary>
        /// For db internals
        /// </summary>
        internal ToDo(int id,
            string title,
            string description = "",
            DateTime? deadline = null,
            ToDo next = null,
            ToDo parent = null,
            IEnumerable<ToDo> children = null) : this(title, description, deadline, next, parent, children)
        {
            Id = id;
        }

        public ToDo(string title, 
            string description = "", 
            DateTime? deadline = null, 
            ToDo next = null, 
            ToDo parent = null, 
            IEnumerable<ToDo> children = null)
        {
            Title = title;
            CreatedAt = DateTime.Now;
            Description = description;

            Validate(deadline);
            Deadline = deadline;

            Validate(next);
            Next = next;
            
            Validate(parent);
            Parent = parent;

            Validate(children);
            Children = children;

            if (Children == null)
            {
                children = new List<ToDo>();
            }

            Current = this;
        }

        public void Complete()
        {
            Current = Next;
            Next = Current?.Next;
            CompletedAt = DateTime.Now;

            foreach (var child in Children)
            {
                child.Complete();
            }
        }

        public static bool operator ==(ToDo todo1, ToDo todo2) => todo1?.Title == todo2?.Title;
        public static bool operator !=(ToDo todo1, ToDo todo2) => todo1?.Title != todo2?.Title;

        public override string ToString() => $"{Title}- {Description}";

        private void Validate(DateTime? deadline)
        {
            if (deadline == null) return;
            if (CreatedAt >= deadline)
            {
                throw new InvalidDeadlineException(deadline.Value, CreatedAt);
            }
        }

        private void Validate(IEnumerable<ToDo> children)
        {
            if (children == null) return;
            foreach(var todo in children)
            {
                Validate(todo);
            }
        }

        private void Validate(ToDo next)
        {
            if (next == null) return;
            if (next == this)
            {
                throw new CircularReferenceException(next.Title);
            }
        }

    }
}
