using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListApp.Data.Concrete.EntityFramework.Mappings;
using ToDoListApp.Entities.Concrete;

namespace ToDoListApp.Data.Concrete.EntityFramework
{
   public class ToDoContext:DbContext
    {
        public ToDoContext():base("name=ToDoContext")
        {
          
        }
        public DbSet<ToDoTask> ToDoTask { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new TaskMap());
        }
    }
}
