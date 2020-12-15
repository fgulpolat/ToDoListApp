using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ToDoListApp.Core.Entities;

namespace ToDoListApp.Core.Data.Abstract
{
   public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        IList<T> GetAll(Expression<Func<T, bool>> predicate);
        T Get(Expression<Func<T, bool>> predicate);
        T GetById(int id);
        T Add(T entity);
        void Delete(T entity);
        T Update(T entity);
    
    }
}
