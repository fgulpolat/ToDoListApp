using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoListApp.Entities.Concrete;

namespace ToDoListApp.Models
{
    public class ToDoListViewModel
    {
       public IList<ToDoTask> ToDoTasks { get; set; }
       public ToDoTask ToDoTask { get; set; }
    }
}