using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TooDoo.Models;

namespace TooDoo.Repositories
{
    public class ToDoDbContext
    {
        public DbSet<ToDo> Todos;
        public DbSet<ToDoChild> Children;
    }
}
