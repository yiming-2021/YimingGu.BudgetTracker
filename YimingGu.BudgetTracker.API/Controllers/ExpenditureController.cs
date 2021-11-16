using System.Linq;
using System.Threading.Tasks;
using YimingGu.BudgetTracker.ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using YimingGu.BudgetTracker.ApplicationCore.Models;


namespace YimingGu.BudgetTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenditureController : ControllerBase
    {
        private readonly IExpService _expenditureService;
        public ExpenditureController(IExpService expenditureService)
        {
            _expenditureService = expenditureService;
        }
        
        
        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddExpenditure([FromBody] ExpRequestModel model)
        {
            var customer = await _expenditureService.CreateExpenditure(model);
            return Ok(customer);
        }

        [HttpDelete]
        [Route("delete/{id:int}")]
        public async Task<IActionResult> DeleteExpenditure(int id)
        {
            var customer = await _expenditureService.DeleteExpenditure(id);
            if (customer == null)
            {
                return BadRequest("Expenditure Not Found");
            }
            return Ok(customer);
        }


        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> ListAllExpenditure()
        {
            var customers = await _expenditureService.ListAllExpenditure();
            if (!customers.Any())
            {
                return NotFound("Expenditure Not Found");
            }
            return Ok(customers);
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateExpenditure([FromBody] ExpRequestModel model)
        {
            var customer = await _expenditureService.UpdateExpenditure(model);
            if (customer == null)
            {
                return BadRequest("Expenditure Not Found");
            }
            return Ok(customer);
        }
        
        
    }
}