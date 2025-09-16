using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employeemanagement.DTO;
using Employeemanagement.models;
using Employeemanagement.oprations;
using Microsoft.AspNetCore.Mvc;

namespace Employeemanagement.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeoprations _employeeoprations;
        public EmployeeController(IEmployeeoprations employeeoprations) // DI
        {
            _employeeoprations = employeeoprations;
        }

        [HttpPost]
        public IActionResult CreateEmployee(EmployeeDto employeeDto)
        {
            Employee employee = new Employee();
            employee.Name = employeeDto.Name;
            employee.Age = employeeDto.Age;
            var result = _employeeoprations.AddEmployee(employee);

            return Ok(result);
        }
        [HttpGet]
        public IActionResult GetEmployee()
        {
            var result = _employeeoprations.GetAll();
            return Ok(result);
        }

    }
}