using TeamPulse.m1chael888.Repositories;
using TeamPulse.m1chael888.Models;

namespace TeamPulse.m1chael888.Services
{
    public class EmployeeService
    {
        private readonly EmployeeRepository _employeeRepository = new();
        public List<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetAllEmployees();
        }
    }
}
