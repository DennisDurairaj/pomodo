using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pomodo.TodoService.Models
{
    public class TodoModel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }
        public DateTime? CompletedAt { get; set; }
    }
}
