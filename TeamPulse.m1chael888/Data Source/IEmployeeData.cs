using TeamPulse.m1chael888.Models;

namespace TeamPulse.m1chael888.Data_Source
{
    public interface IEmployeeData
    {
        List<Employee> Employees { get; set; }
        List<Employee> GetEmployees();
    }
}
