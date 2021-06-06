using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using My_Web.IServices;
using My_Web.Models;

namespace My_Web.Controllers
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

        [Route("getAll"), HttpGet]
        public IActionResult GetEmployees()
        {
            var result =  _employeeService.GetAllEmployees();
            return Ok(result);
        }

        [Route("getEmployee/{id}"), HttpGet]
        public Employee GetEmployeeById(int id)
        {
            return _employeeService.GetEmployee(id);
          
        }

        [Route("addEmployee"), HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            var result = _employeeService.AddEmployee(employee);
            return Ok(result);
        }


        [Route("updateEmployee"), HttpPut]
        public IActionResult UpdateEmployee(Employee employee)
        {
            _employeeService.UpdateEmployee(employee);
            return Ok();
        }

        [Route("deleteEmployee/{id}"), HttpDelete]
        public IActionResult DeleteEmployee(int id)
        {
             _employeeService.DeleteEmployee(id);
            return Ok();
        }

    }
}
