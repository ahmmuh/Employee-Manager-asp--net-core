using Employee_Manager.Models;

namespace Employee_Manager.Data
{
    public interface IEmployeeRepository 
    {
         Task<IEnumerable<Employee>> GetEmployees();
         Task<Employee> GetEmployee(int id);
        Task<Employee> UpdateEmployee(Employee employee);
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> DeleteEmployee(int id);
    
    
    }
}
