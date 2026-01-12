using TeamPulse.m1chael888.Data_Source;
using TeamPulse.m1chael888.Models;

namespace TeamPulse.m1chael888.Repositories
{
    public class EmployeeRepository
    {
        private readonly EmployeeData _datasource = new();
        public List<Employee> GetAllEmployees()
        {
            return _datasource.Employees;
        }
    }
}
