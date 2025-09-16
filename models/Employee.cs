using System;
using System.ComponentModel.DataAnnotations;

namespace Employeemanagement.models
{
    public class Employee
    {
        [Key]
        public int ID {  get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}