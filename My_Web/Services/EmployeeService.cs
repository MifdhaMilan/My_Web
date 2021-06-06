using My_Web.IServices;
using My_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Web.Services
{
   
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeDbContext _ctx;
        public EmployeeService(EmployeeDbContext employeeDbContext)
        {
            _ctx = employeeDbContext;
        }

        public Employee AddEmployee(Employee employee)
        {
            _ctx.Add(employee);
            _ctx.SaveChanges();
            return employee;
        }

        public void DeleteEmployee(int Id)
        {
            var deleteEmployee = _ctx.Employee.FirstOrDefault(x => x.Id == Id);
            if(deleteEmployee!= null)
            {
                _ctx.Remove(deleteEmployee);
                _ctx.SaveChanges();
            }
        
        }

        public List<Employee> GetAllEmployees()
        {
            return _ctx.Employee.ToList();
        }

        public Employee GetEmployee(int Id)
        {
            return _ctx.Employee.FirstOrDefault(x => x.Id == Id);
        }

        public void UpdateEmployee(Employee employee)
        {
            _ctx.Employee.Update(employee);
            _ctx.SaveChanges();
        }
      
    }
}
