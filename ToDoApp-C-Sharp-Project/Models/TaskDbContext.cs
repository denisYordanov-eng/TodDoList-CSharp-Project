using System;
using System.Data.Entity;
using System.Linq;
using System.Xml;

namespace ToDoApp_C_Sharp_Project.Models
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext()
            : base("name=TaskDbContex")
        {
        }

         public virtual DbSet<Task> Tasks { get; set; }
    }

   
}