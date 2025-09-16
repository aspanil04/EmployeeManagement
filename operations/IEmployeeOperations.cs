using Employeemanagement.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employeemanagement.oprations
{
    public interface IEmployeeoprations
    {
       int AddEmployee(Employee employee); // poor approach(strongly recommanded implement TPL)
       IEnumerable<Employee> GetAll();
       Employee GetById(int Id);
       int DeleteById(int Id);
       Employee UpdateById(Employee employee);
    }
}