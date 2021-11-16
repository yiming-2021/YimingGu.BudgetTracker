using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YimingGu.BudgetTracker.ApplicationCore.Entities;
using YimingGu.BudgetTracker.ApplicationCore.Models;
using YimingGu.BudgetTracker.ApplicationCore.RepositoryInterfaces;
using YimingGu.BudgetTracker.ApplicationCore.ServiceInterfaces;

namespace YimingGu.BudgetTracker.Infrastructure.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        
        public async Task<UserRequestModel> CreateUser(UserRequestModel model)
        {
            var user = new User
            {
                Id = model.Id,
                Email = model.Email,
                Password = model.Password,
                Fullname = model.Fullname,
                JoinedOn = model.JoinedOn
            };
            var createdUser = await _userRepository.Add(user);
            var result = new UserRequestModel
            {
                Id = createdUser.Id,
                Email = createdUser.Email,
                Password = createdUser.Password,
                Fullname = createdUser.Fullname,
                JoinedOn = createdUser.JoinedOn
            };
            return result;
        }

        public async Task<UserRequestModel> DeleteUser(int id)
        {
            var exist = await _userRepository.GetExists(c => c.Id == id);
            if (!exist)
            {
                throw new Exception($"Not Found Customer For Id={id}");
            }
            var user = await _userRepository.GetById(id);
            var deletedUser = await _userRepository.Delete(user);
            var result = new UserRequestModel
            {
                Id = deletedUser.Id,
                Email = deletedUser.Email,
                Password = deletedUser.Password,
                Fullname = deletedUser.Fullname,
                JoinedOn = deletedUser.JoinedOn
            };
            return result;
        }

 

        public async Task<List<UserRequestModel>> ListAllUser()
        {
            var users = await _userRepository.GetAll();
            var results = new List<UserRequestModel>();
            foreach (var user in users)
            {
                var _user = new UserRequestModel
                {
                    Id = user.Id,
                    Email = user.Email,
                    Password = user.Password,
                    Fullname = user.Fullname,
                    JoinedOn = user.JoinedOn
                };
                results.Add(_user);
            }
            return results;
        }

        public async Task<UserRequestModel> UpdateUser(UserRequestModel model)
        {
            var exist = await _userRepository.GetExists(c => c.Id == model.Id);
            if (!exist)
            {
                throw new Exception($"Not Found Customer For Id={model.Id}");
            }
            var user = new User
            {
                Id = model.Id,
                Email = model.Email,
                Password = model.Password,
                Fullname = model.Fullname,
                JoinedOn = model.JoinedOn
            };
            var updatedCustomer = await _userRepository.Update(user);
            return model;
        }
        
        public async Task<UserDetailsResponseModel> GetUserById(int id)
        {
            var userDetails = new UserDetailsResponseModel();
            var user = await _userRepository.GetById(id);

            // map user entity to UserDetailsResponseModel
            userDetails.Id = user.Id;
            userDetails.Email = user.Email;
            userDetails.Fullname = user.Fullname;
            userDetails.JoinedOn = user.JoinedOn;

            userDetails.Incomes = new List<IncomeResponseModel>();
            userDetails.Expenditures = new List<ExpResponseModel>();

   
            return userDetails;
        }
        
        public async Task<List<IncomeResponseModel>> GetIncomes(int userId)
        {
            var user = await _userRepository.GetUserIncomeById(userId);
            var incomes = new List<IncomeResponseModel>();
            foreach (var i in user.Incomes)
            {
                incomes.Add(new IncomeResponseModel()
                {
                    Id = i.Id,
                    Amount = i.Amount,
                    Description = i.Description,
                    IncomeDate = i.IncomeDate
                });
            }
            return incomes;
        }

        public async Task<List<ExpResponseModel>> GetExpenditures(int userId)
        {
            var user = await _userRepository.GetUserExpById(userId);
            var expenditures = new List<ExpResponseModel>();
            foreach (var e in user.Expenditures)
            {
                expenditures.Add(new ExpResponseModel()
                {
                    Id = e.Id,
                    Amount = e.Amount,
                    Description = e.Description,
                    ExpDate =  e.ExpDate
                });
            }
            return expenditures;
        }
    }
}