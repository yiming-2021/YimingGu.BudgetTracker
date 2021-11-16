using YimingGu.BudgetTracker.ApplicationCore.Entities;
using YimingGu.BudgetTracker.ApplicationCore.RepositoryInterfaces;
using YimingGu.BudgetTracker.Infrastructure.Data;

namespace YimingGu.BudgetTracker.Infrastructure.Repositories
{
    public class IncomeRepository: EfRepository<Income>, IIncomeRepository
    {
        
        public IncomeRepository(BudgetTrackerDbContext dbContext) : base(dbContext)
        {
        }
    }
}