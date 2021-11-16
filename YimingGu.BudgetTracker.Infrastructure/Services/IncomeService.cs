using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YimingGu.BudgetTracker.ApplicationCore.Entities;
using YimingGu.BudgetTracker.ApplicationCore.Models;
using YimingGu.BudgetTracker.ApplicationCore.RepositoryInterfaces;
using YimingGu.BudgetTracker.ApplicationCore.ServiceInterfaces;

namespace YimingGu.BudgetTracker.Infrastructure.Services
{
    public class IncomeService : IIncomeService
    {
        private readonly IIncomeRepository _incomeRepository;

        public IncomeService(IIncomeRepository incomeRepository)
        {
            _incomeRepository = incomeRepository;
        }


        public async Task<IncomeRequestModel> CreateIncome(IncomeRequestModel model)
        {
            var income = new Income
            {
                Id = model.Id,
                UserId = model.UserId,
                Amount = model.Amount,
                Description = model.Description,
                IncomeDate = model.IncomeDate,
                Remarks = model.Remarks
            };
            var createdIncome = await _incomeRepository.Add(income);
            var result = new IncomeRequestModel
            {
                Id = createdIncome.Id,
                UserId = createdIncome.UserId,
                Amount = createdIncome.Amount,
                Description = createdIncome.Description,
                IncomeDate = createdIncome.IncomeDate,
                Remarks = createdIncome.Remarks
            };
            return result;
        }

        public async Task<IncomeRequestModel> DeleteIncome(int id)
        {
            var exist = await _incomeRepository.GetExists(c => c.Id == id);
            if (!exist)
            {
                throw new Exception($"Not Found Customer For Id={id}");
            }

            var income = await _incomeRepository.GetById(id);
            var deletedIncome = await _incomeRepository.Delete(income);
            var result = new IncomeRequestModel
            {
                Id = deletedIncome.Id,
                UserId = deletedIncome.UserId,
                Amount = deletedIncome.Amount,
                Description = deletedIncome.Description,
                IncomeDate = deletedIncome.IncomeDate,
                Remarks = deletedIncome.Remarks
            };
            return result;
        }



        public async Task<List<IncomeRequestModel>> ListAllIncome()
        {
            var incomes = await _incomeRepository.GetAll();
            var results = new List<IncomeRequestModel>();
            foreach (var income in incomes)
            {
                var _income = new IncomeRequestModel
                {
                    Id = income.Id,
                    UserId = income.UserId,
                    Amount = income.Amount,
                    Description = income.Description,
                    IncomeDate = income.IncomeDate,
                    Remarks = income.Remarks
                };
                results.Add(_income);
            }

            return results;
        }

        public async Task<IncomeRequestModel> UpdateIncome(IncomeRequestModel model)
        {
            var exist = await _incomeRepository.GetExists(c => c.Id == model.Id);
            if (!exist)
            {
                throw new Exception($"Not Found Customer For Id={model.Id}");
            }

            var income = new Income
            {
                Id = model.Id,
                UserId = model.UserId,
                Amount = model.Amount,
                Description = model.Description,
                IncomeDate = model.IncomeDate,
                Remarks = model.Remarks
            };
            var updatedCustomer = await _incomeRepository.Update(income);
            return model;
        }

        // public async Task<IncomeResponseModel> GetIncomeById(int id)
        // {
        //     var incomeDetails = new IncomeResponseModel();
        //     var income = await _incomeRepository.GetById(id);
        //
        //     // map income entity to IncomeDetailsResponseModel
        //     incomeDetails.Id = income.Id;
        //     incomeDetails.UserId = income.UserId,
        //     incomeDetails.Amount = income.Amount,
        //     incomeDetails.Description = income.Description,
        //     incomeDetails.IncomeDate = income.IncomeDate,
        //     incomeDetails.Remarks = income.Remarks
        //
        //
        //     return incomeDetails;
        // }


    }
}
