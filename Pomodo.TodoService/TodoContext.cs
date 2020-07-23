using Microsoft.EntityFrameworkCore;
using Pomodo.TodoService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pomodo.TodoService
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> opt) : base(opt)
        {

        }
        public DbSet<TodoModel> Todos { get; set; }
    }
}
