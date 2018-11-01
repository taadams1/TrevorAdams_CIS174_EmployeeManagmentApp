using EmployeeManager.Shared.Orchestrators;
using EmployeeManager.Shared.ViewModels;
using EmployeeManager.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManager.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeOrchestrator _employeeOrchestrator = new EmployeeOrchestrator();
        
        public async Task<ActionResult> Index(CreateEmployeeModel employee)
        {
            if (string.IsNullOrWhiteSpace(employee.FirstName))
                return View();

            var updatedCount = await _employeeOrchestrator.CreateEmployee(new EmployeeViewModel
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
                EmployeeID = Guid.NewGuid(),
                AvailableHours = employee.AvailableHours
            });

            return View();
        }
        // GET: Employees
        public async Task<ActionResult> Employees()
        {
            var employeeDisplayModel = new EmployeeDisplayModel
            {
                Employees = await _employeeOrchestrator.GetAllEmployees()
            };

            return View(employeeDisplayModel);
        }
    }
}