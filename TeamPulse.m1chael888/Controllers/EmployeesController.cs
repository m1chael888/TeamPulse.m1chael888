using Microsoft.AspNetCore.Mvc;
using TeamPulse.m1chael888.Services;

namespace TeamPulse.m1chael888.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var employees = _employeeService.GetAllEmployees;
            return Ok(employees);
        }
    }
}
