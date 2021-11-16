using System.Linq;
using System.Threading.Tasks;
using YimingGu.BudgetTracker.ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using YimingGu.BudgetTracker.ApplicationCore.Models;


namespace YimingGu.BudgetTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncomeController : ControllerBase
    {
        private readonly IIncomeService _incomeService;
        public IncomeController(IIncomeService incomeService)
        {
            _incomeService = incomeService;
        }
        
        
        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddIncome([FromBody] IncomeRequestModel model)
        {
            var customer = await _incomeService.CreateIncome(model);
            return Ok(customer);
        }

        [HttpDelete]
        [Route("delete/{id:int}")]
        public async Task<IActionResult> DeleteIncome(int id)
        {
            var customer = await _incomeService.DeleteIncome(id);
            if (customer == null)
            {
                return BadRequest("Income Not Found");
            }
            return Ok(customer);
        }


        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> ListAllIncome()
        {
            var customers = await _incomeService.ListAllIncome();
            if (!customers.Any())
            {
                return NotFound("Income Not Found");
            }
            return Ok(customers);
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateIncome([FromBody] IncomeRequestModel model)
        {
            var customer = await _incomeService.UpdateIncome(model);
            if (customer == null)
            {
                return BadRequest("Income Not Found");
            }
            return Ok(customer);
        }
        
        
    }
}