using YimingGu.BudgetTracker.ApplicationCore.Entities;
using YimingGu.BudgetTracker.ApplicationCore.RepositoryInterfaces;
using YimingGu.BudgetTracker.Infrastructure.Data;

namespace YimingGu.BudgetTracker.Infrastructure.Repositories
{
    public class ExpRepository: EfRepository<Expenditure>, IExpRepository
    {
        
        public ExpRepository(BudgetTrackerDbContext dbContext) : base(dbContext)
        {
        }
    }
}