using EmployeeManager.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManager.Shared.ViewModels
{
    public class EmployeeViewModel
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Date of Birth")]
        public string BirthDateString => BirthDate.ToString();
        [Display(Name = "Date of Hire")]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
        [Display(Name = "Date of Hire")]
        public string HireDateString => HireDate.ToString();
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public decimal Salary { get; set; }
        public string SalaryString => Salary.ToString();
        public SalaryEnum SalaryType { get; set; }
        public string SalaryTypeString => SalaryType.ToString();
        public Guid EmployeeID { get; set; }
        public string EmployeeIDString => EmployeeID.ToString();
        public string AvailableHours { get; set; }
    }
}
