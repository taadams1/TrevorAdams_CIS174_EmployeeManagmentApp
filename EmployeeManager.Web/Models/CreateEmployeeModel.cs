using EmployeeManager.Domain.Entities;
using EmployeeManager.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManager.Web.Models
{
    public class CreateEmployeeModel
    {
        [Required(ErrorMessage = "Please enter first name.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter middle name.")]
        public string MiddleName { get; set; }
        [Required(ErrorMessage = "Please enter last name.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter date of birth.")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "Please enter date of hire.")]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
        [Required(ErrorMessage = "Please enter department name.")]
        public string Department { get; set; }
        [Required(ErrorMessage = "Please enter job title.")]
        public string JobTitle { get; set; }
        [Required(ErrorMessage = "Please enter salary.")]
        [DataType(DataType.Currency)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0:0.00}")]
        public decimal Salary { get; set; }
        [Required(ErrorMessage = "Please enter salary type.")]
        public SalaryEnum SalaryType { get; set; }
        public Guid EmployeeId { get; set; }
        [Required(ErrorMessage = "Please enter available hours.")]
        public string AvailableHours { get; set; }
    }
}