using EmployeeManager.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManager.Web.Models
{
    public class UpdateEmployeeModel
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public string BirthDateString => BirthDate.ToString();
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
        public string HireDateString => HireDate.ToString();
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public decimal Salary { get; set; }
        public SalaryEnum SalaryType { get; set; }
        public string SalaryTypeString => SalaryType.ToString();
        [DataType(DataType.Text)]
        public Guid EmployeeID { get; set; }
        public string AvailableHours { get; set; }
    }
}