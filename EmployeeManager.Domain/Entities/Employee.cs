using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.Domain.Entities
{
    public enum SalaryEnum
    {
        Hourly,
        Annual
    }
    public class Employee
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public decimal Salary { get; set; }
        public SalaryEnum SalaryType { get; set; }
        public Guid EmployeeId { get; set; }
        public string AvailableHours { get; set; }

    }
}
