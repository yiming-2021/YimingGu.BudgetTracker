using System.Collections.Generic;
using System.Threading.Tasks;
using YimingGu.BudgetTracker.ApplicationCore.Models;


namespace YimingGu.BudgetTracker.ApplicationCore.ServiceInterfaces
{
    public interface IExpService
    {
        Task<ExpRequestModel> CreateExpenditure(ExpRequestModel model);
        Task<ExpRequestModel> UpdateExpenditure(ExpRequestModel model);
        Task<ExpRequestModel> DeleteExpenditure(int id);
        Task<List<ExpRequestModel>> ListAllExpenditure();

    }
}

