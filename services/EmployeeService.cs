using Employeemanagement.Database;
using Employeemanagement.models;
using Employeemanagement.oprations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employeemanagement.services
{
    public class EmployeeService : IEmployeeoprations
    {
        EmployeeDbContext _context;
        public EmployeeService(EmployeeDbContext context) // DI
        {
            _context = context;
        }

        public int AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
           return _context.SaveChanges();
            
        }

        public int DeleteById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
          return  _context.Employees.ToList();
        }

        public Employee GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Employee UpdateById(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}