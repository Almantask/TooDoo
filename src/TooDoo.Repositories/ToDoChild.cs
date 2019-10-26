using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TooDoo.Models;

namespace TooDoo.Repositories
{
    public class ToDoChild
    {
        [Key]
        public int Id { get; set; }
        public ToDo ToDo { get; set; }
    }
}
