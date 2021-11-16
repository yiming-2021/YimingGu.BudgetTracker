using System.Linq;
using System.Threading.Tasks;
using YimingGu.BudgetTracker.ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using YimingGu.BudgetTracker.ApplicationCore.Models;


namespace YimingGu.BudgetTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
        
        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddUser([FromBody] UserRequestModel model)
        {
            var customer = await _userService.CreateUser(model);
            return Ok(customer);
        }

        [HttpDelete]
        [Route("delete/{id:int}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var customer = await _userService.DeleteUser(id);
            if (customer == null)
            {
                return BadRequest("User Not Found");
            }
            return Ok(customer);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var customer = await _userService.GetUserById(id);
            if (customer == null)
            {
                return NotFound("User Not Found");
            }
            return Ok(customer);
        }

        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> ListAllUser()
        {
            var customers = await _userService.ListAllUser();
            if (!customers.Any())
            {
                return NotFound("User Not Found");
            }
            return Ok(customers);
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateUser([FromBody] UserRequestModel model)
        {
            var customer = await _userService.UpdateUser(model);
            if (customer == null)
            {
                return BadRequest("User Not Found");
            }
            return Ok(customer);
        }
        
        
        
        [HttpGet]
        [Route("income/{id:int}")]
        public async Task<IActionResult> GetIncomesByUser(int id)
        {
            var income = await _userService.GetIncomes(id);

            if (income == null)
            {
                return NotFound($"No incomes Found for {id}");
            }

            return Ok(income);
        }
        
        
        [HttpGet]
        [Route("expenditure/{id:int}")]
        public async Task<IActionResult> GetExpenditureByUser(int id)
        {
            var exp = await _userService.GetExpenditures(id);

            if (exp == null)
            {
                return NotFound($"No expenditure Found for {id}");
            }

            return Ok(exp);
        }
        
    }
}