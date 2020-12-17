using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListApp.Entities.Concrete;

namespace Business.Abstract
{
   public interface ITaskService
    {
        IList<ToDoTask> GetAll();
        ToDoTask Get(int id);
        ToDoTask Add(ToDoTask task);
        ToDoTask Update(ToDoTask task);
        void Delete(ToDoTask task);
    }
}
