using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mission6.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {

        }

        public DbSet<Task> task { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Quadrant> quadrant{ get; set; }
    }
}
