using System.Collections.Generic;

namespace TooDoo.Models
{
    public class Day
    {
        private readonly IList<ToDo> _toDos;
        public IEnumerable<ToDo> ToDos => _toDos;

        public void AddToDo(ToDo todo) => _toDos.Add(todo);

    }
}