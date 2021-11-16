using System.Collections.Generic;
using System.Threading.Tasks;
using YimingGu.BudgetTracker.ApplicationCore.RepositoryInterfaces;
using YimingGu.BudgetTracker.Infrastructure.Data;
using YimingGu.BudgetTracker.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace YimingGu.BudgetTracker.Infrastructure.Repositories
{
    
    public class UserRepository : EfRepository<User>, IUserRepository
    {

        public UserRepository(BudgetTrackerDbContext dbContext) : base(dbContext)
        {
        }
      
        public async Task<User> GetUserIncomeById(int id)
        {
            var user = await _dbContext.Users.Include(u => u.Incomes).ThenInclude(i => i.User).
                FirstOrDefaultAsync(u => u.Id == id);
            return user;
        }

        public async Task<User> GetUserExpById(int id)
        {
            var user = await _dbContext.Users.Include(u => u.Expenditures).ThenInclude(e => e.User).
                FirstOrDefaultAsync(u => u.Id == id);
            return user;
        }
    }
}