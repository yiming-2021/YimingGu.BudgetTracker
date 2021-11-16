using System.Collections.Generic;
using System.Threading.Tasks;
using YimingGu.BudgetTracker.ApplicationCore.Models;


namespace YimingGu.BudgetTracker.ApplicationCore.ServiceInterfaces
{
    public interface IIncomeService
    {
        Task<IncomeRequestModel> CreateIncome(IncomeRequestModel model);
        Task<IncomeRequestModel> UpdateIncome(IncomeRequestModel model);
        Task<IncomeRequestModel> DeleteIncome(int id);
        Task<List<IncomeRequestModel>> ListAllIncome();
        
        // Task<IncomeResponseModel> GetIncomeById(int id);
    }
}

