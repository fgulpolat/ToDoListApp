using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListApp.Data.Abstract;
using ToDoListApp.Entities.Concrete;

namespace Business.Concrete
{
    public class TaskManager : ITaskService
    {
        public readonly ITaskDal _taskDal;

        public TaskManager(ITaskDal taskDal)
        {
            _taskDal = taskDal;
        }
        public ToDoTask Add(ToDoTask task)
        {
            _taskDal.Add(task);
            return task;
        }

        public void Delete(ToDoTask task)
        {
            _taskDal.Delete(task);
        }

        public ToDoTask Get(int id)
        {
            return _taskDal.Get(x => x.Id == id);
        }

        public IList<ToDoTask> GetTasks()
        {
            return _taskDal.GetAll(x=>x.IsDeleted!=true);
        }

        public ToDoTask Update(ToDoTask task)
        {
            _taskDal.Update(task);
            return task;
        }
    }
}
