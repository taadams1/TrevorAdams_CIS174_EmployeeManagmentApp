﻿using EmployeeManager.Domain;
using EmployeeManager.Domain.Entities;
using EmployeeManager.Shared.Orchestrators.Interfaces;
using EmployeeManager.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.Shared.Orchestrators
{
    public class EmployeeOrchestrator : IEmployeeOrchestrator
    {
        private EmployeeContext _employeeContext;

        public EmployeeOrchestrator()
        {
            _employeeContext = new EmployeeContext();
        }

        public async Task<int> CreateEmployee(EmployeeViewModel employee)
        {
            _employeeContext.Employees.Add(new Employee
            {
                FirstName = employee.FirstName,
                MiddleName = employee.MiddleName,
                LastName = employee.LastName,
                BirthDate = employee.BirthDate,
                HireDate = employee.HireDate,
                Department = employee.Department,
                JobTitle = employee.JobTitle,
                Salary = employee.Salary,
                SalaryType = employee.SalaryType,
                EmployeeID = employee.EmployeeID,
                AvailableHours = employee.AvailableHours
            });

            return await _employeeContext.SaveChangesAsync();
        }

        public async Task<List<EmployeeViewModel>> GetAllEmployees()
        {
            var employees = await _employeeContext.Employees.Select(x => new EmployeeViewModel
            {
                FirstName = x.FirstName,
                MiddleName = x.MiddleName,
                LastName = x.LastName,
                BirthDate = x.BirthDate,
                HireDate = x.HireDate,
                Department = x.Department,
                JobTitle = x.JobTitle,
                Salary = x.Salary,
                SalaryType = x.SalaryType,
                EmployeeID = x.EmployeeID,
                AvailableHours = x.AvailableHours
            }).ToListAsync();

            return employees;
        }
    }
}
