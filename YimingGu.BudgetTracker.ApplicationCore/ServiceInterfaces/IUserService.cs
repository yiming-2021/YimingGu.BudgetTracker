using System.Collections.Generic;
using System.Threading.Tasks;
using YimingGu.BudgetTracker.ApplicationCore.Models;


namespace YimingGu.BudgetTracker.ApplicationCore.ServiceInterfaces
{
    public interface IUserService
    {
        Task<UserRequestModel> CreateUser(UserRequestModel model);
        Task<UserRequestModel> UpdateUser(UserRequestModel model);
        Task<UserRequestModel> DeleteUser(int id);
        Task<List<UserRequestModel>> ListAllUser();
        Task<UserDetailsResponseModel> GetUserById(int id);
        Task<List<IncomeResponseModel>> GetIncomes(int userId);
        Task<List<ExpResponseModel>> GetExpenditures(int userId);
    }
}
