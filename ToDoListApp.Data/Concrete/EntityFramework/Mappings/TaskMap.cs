using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListApp.Entities.Concrete;

namespace ToDoListApp.Data.Concrete.EntityFramework.Mappings
{
   public class TaskMap:EntityTypeConfiguration<ToDoTask>
    {
        public TaskMap()
        {
            ToTable("Tasks", "dbo");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.Content).HasColumnName("Content").HasMaxLength(500);
            Property(x => x.StartingDate).HasColumnName("StartingDate");
            Property(x => x.DueDate).HasColumnName("DueDate");
            Property(x => x.ComplationDate).HasColumnName("ComplationDate");
            Property(x => x.CreationDate).HasColumnName("CreationDate");
            Property(x => x.IsDone).HasColumnName("HasDone");
            Property(x => x.IsDeleted).HasColumnName("IsDeleted");
        }
    }
}
