using TeamPulse.m1chael888.Data_Source;
using TeamPulse.m1chael888.Models;

namespace TeamPulse.m1chael888.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IEmployeeData _datasource;

        public EmployeeRepository(IEmployeeData dataSource)
        {
            _datasource = dataSource;
        }

        public List<Employee> GetAllEmployees()
        {
            return _datasource.Employees;
        }
    }
}
