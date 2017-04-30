using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace EmployeeDomain.Custom
{
    

    public interface IRepository<T> 
                    where T : class, IEntity 
    {
        IQueryable<T> FindAll();
        IEnumerable<T> FindAllAsEnumerable();

        IQueryable<T> FindWhere(Expression<Func<T, bool>> predicate);
        T FindById(int id);        
        void Add(T newEntity);
        void Remove(T entity);  
    }

    interface IEmployeeRepository : IRepository<Employee>
    {
        IQueryable<Employee> FindManagers();
    }
}