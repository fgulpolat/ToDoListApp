using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListApp.Core.Entities;

namespace ToDoListApp.Entities.Concrete
{
   public class ToDoTask:IEntity
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ComplationDate { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsDone { get; set; }
        public bool IsDeleted { get; set; }
    }
}
