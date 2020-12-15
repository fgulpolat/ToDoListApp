using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListApp.Core.Data.Concrete.EntityFramework;
using ToDoListApp.Data.Abstract;
using ToDoListApp.Entities.Concrete;

namespace ToDoListApp.Data.Concrete.EntityFramework
{
   public class EfTaskDal: EfEntityRepositoryBase<ToDoTask,ToDoContext>, ITaskDal
    {

    }
}
