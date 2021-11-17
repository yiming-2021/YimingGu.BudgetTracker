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
            var user = await _userService.CreateUser(model);
            return Ok(user);
        }

        [HttpDelete]
        [Route("delete/{id:int}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _userService.DeleteUser(id);
            if (user == null)
            {
                return BadRequest("User Not Found");
            }
            return Ok(user);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _userService.GetUserById(id);
            if (user == null)
            {
                return NotFound("User Not Found");
            }
            return Ok(user);
        }

        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> ListAllUser()
        {
            var users = await _userService.ListAllUser();
            if (!users.Any())
            {
                return NotFound("User Not Found");
            }
            return Ok(users);
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateUser([FromBody] UserRequestModel model)
        {
            var user = await _userService.UpdateUser(model);
            if (user == null)
            {
                return BadRequest("User Not Found");
            }
            return Ok(user);
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