using Employee_Manager.Data;
using Employee_Manager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employee_Manager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase

       
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }
     
        [HttpGet]

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _employeeRepository.GetEmployees();
        }

        [HttpGet("{id}")]
        public async Task<Employee> GetEmployee(int id)
        {
            return await _employeeRepository.GetEmployee(id);
        }


        [HttpPost]
        public async Task<Employee> AddPost(Employee newEmployee)
        {
            return await _employeeRepository.AddEmployee(newEmployee);

        }

        [HttpPut("{id}")]

        public async Task<Employee> UpdateEmployee(Employee updatedEmployee)
        {
            return await _employeeRepository.UpdateEmployee(updatedEmployee);
        }
        [HttpDelete("{id}")]

        public async Task<Employee> DeleteEmployee(int id)
        {
           return await _employeeRepository.DeleteEmployee(id);
        }

    }
}
