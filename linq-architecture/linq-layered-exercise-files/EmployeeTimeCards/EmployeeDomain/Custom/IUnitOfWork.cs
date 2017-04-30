using System;

namespace EmployeeDomain.Custom
{

    public interface IUnitOfWork : IDisposable 
    {
        IRepository<Employee> Employees { get; }
        IRepository<TimeCard> TimeCards { get; }
        void Commit();
    }

}