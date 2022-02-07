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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Home" },
                new Category { CategoryId = 2, CategoryName = "School" },
                new Category { CategoryId = 3, CategoryName = "Work" },
                new Category { CategoryId = 4, CategoryName = "Church" }
             );

            mb.Entity<Quadrant>().HasData(
               new Quadrant { QuadrantId = 1, QuadrantName = "Important/Urgent"},
               new Quadrant { QuadrantId = 2, QuadrantName = "Important/Not Urgent" },
               new Quadrant { QuadrantId = 3, QuadrantName = "Not Important/Urgent" },
               new Quadrant { QuadrantId = 4, QuadrantName = "Not Important/Not Urgent" }
            );

        }
    }
}
