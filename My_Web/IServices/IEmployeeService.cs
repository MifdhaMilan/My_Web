using My_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Web.IServices
{
    public interface IEmployeeService
    {
        Employee AddEmployee(Employee employee);
        List<Employee> GetAllEmployees();
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int Id);
        Employee GetEmployee(int Id);
    }
}
