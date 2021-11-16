using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YimingGu.BudgetTracker.ApplicationCore.Entities;
using YimingGu.BudgetTracker.ApplicationCore.Models;
using YimingGu.BudgetTracker.ApplicationCore.RepositoryInterfaces;
using YimingGu.BudgetTracker.ApplicationCore.ServiceInterfaces;

namespace YimingGu.BudgetTracker.Infrastructure.Services
{
    public class ExpService : IExpService
    {
        private readonly IExpRepository _expRepository;

        public ExpService(IExpRepository expRepository)
        {
            _expRepository = expRepository;
        }


        public async Task<ExpRequestModel> CreateExpenditure(ExpRequestModel model)
        {
            var exp = new Expenditure
            {
                Id = model.Id,
                UserId = model.UserId,
                Amount = model.Amount,
                Description = model.Description,
                ExpDate = model.ExpDate,
                Remarks = model.Remarks
            };
            var createdExp = await _expRepository.Add(exp);
            var result = new ExpRequestModel
            {
                Id = createdExp.Id,
                UserId = createdExp.UserId,
                Amount = createdExp.Amount,
                Description = createdExp.Description,
                ExpDate = createdExp.ExpDate,
                Remarks = createdExp.Remarks
            };
            return result;
        }

        public async Task<ExpRequestModel> DeleteExpenditure(int id)
        {
            var exist = await _expRepository.GetExists(e => e.Id == id);
            if (!exist)
            {
                throw new Exception($"Not Found Expenditure For Id={id}");
            }

            var exp = await _expRepository.GetById(id);
            var deletedExp = await _expRepository.Delete(exp);
            var result = new ExpRequestModel
            {
                Id = deletedExp.Id,
                UserId = deletedExp.UserId,
                Amount = deletedExp.Amount,
                Description = deletedExp.Description,
                ExpDate = deletedExp.ExpDate,
                Remarks = deletedExp.Remarks
            };
            return result;
        }



        public async Task<List<ExpRequestModel>> ListAllExpenditure()
        {
            var exps = await _expRepository.GetAll();
            var results = new List<ExpRequestModel>();
            foreach (var exp in exps)
            {
                var _exp = new ExpRequestModel
                {
                    Id = exp.Id,
                    UserId = exp.UserId,
                    Amount = exp.Amount,
                    Description = exp.Description,
                    ExpDate = exp.ExpDate,
                    Remarks = exp.Remarks
                };
                results.Add(_exp);
            }

            return results;
        }

        public async Task<ExpRequestModel> UpdateExpenditure(ExpRequestModel model)
        {
            var exist = await _expRepository.GetExists(c => c.Id == model.Id);
            if (!exist)
            {
                throw new Exception($"Not Found Expenditure For Id={model.Id}");
            }

            var exp = new Expenditure
            {
                Id = model.Id,
                UserId = model.UserId,
                Amount = model.Amount,
                Description = model.Description,
                ExpDate = model.ExpDate,
                Remarks = model.Remarks
            };
            var updatedCustomer = await _expRepository.Update(exp);
            return model;
        }



    }
}
