using Employee_Manager.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_Manager.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext employeeDb;

        public EmployeeRepository(EmployeeDbContext employeeDb)
        {
            this.employeeDb = employeeDb;
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            var result = await employeeDb.Employees.AddAsync(employee);
           await employeeDb.SaveChangesAsync();
            return result.Entity;
        }


        public async Task<Employee> GetEmployee(int id)
        {
            return await employeeDb.Employees.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await employeeDb.Employees.ToListAsync();
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {

            var updateEmployee = await employeeDb.Employees.FirstOrDefaultAsync(em => em.Id == employee.Id);
            if(updateEmployee != null)
            {
                updateEmployee.Firstname = employee.Firstname;
                updateEmployee.Lastname = employee.Lastname;
                updateEmployee.Email = employee.Email;
                updateEmployee.Gender = employee.Gender;

               await employeeDb.SaveChangesAsync();
                return updateEmployee;

            }
            return null;
         
        }


        public async Task<Employee> DeleteEmployee(int id)
        {
            var deletedEmployee = await employeeDb.Employees.FirstOrDefaultAsync(e => e.Id == id);

            if (deletedEmployee != null)
            {
                employeeDb.Employees.Remove(deletedEmployee);
                await employeeDb.SaveChangesAsync();
            }

            return null;

        }


    }
    }
