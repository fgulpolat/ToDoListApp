using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListApp.Core.Data.Abstract;
using ToDoListApp.Entities.Concrete;

namespace ToDoListApp.Data.Abstract
{
   public interface ITaskDal:IEntityRepository<ToDoTask>
    {

    }
}
