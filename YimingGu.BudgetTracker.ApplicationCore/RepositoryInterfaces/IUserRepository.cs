using System.Collections.Generic;
using System.Threading.Tasks;
using YimingGu.BudgetTracker.ApplicationCore.Entities;

namespace YimingGu.BudgetTracker.ApplicationCore.RepositoryInterfaces
{
    public interface IUserRepository : IAsyncRepository<User>
    {
        Task<User> GetUserIncomeById(int id);
        Task<User> GetUserExpById(int id);
    }
}