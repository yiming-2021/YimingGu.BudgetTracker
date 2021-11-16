using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace YimingGu.BudgetTracker.ApplicationCore.RepositoryInterfaces
{
    public interface IAsyncRepository<T> where T: class
    {
        // get by id
        Task<T> GetById(int Id);
        // get all
        Task<IEnumerable<T>> GetAll();
        // get data by condition
        Task<IEnumerable<T>> Get(Expression<Func<T, bool>> predicate);
        Task<int> GetCount(Expression<Func<T, bool>> predicate);
        Task<bool> GetExists(Expression<Func<T, bool>> filter = null);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(T entity);


    }
}
