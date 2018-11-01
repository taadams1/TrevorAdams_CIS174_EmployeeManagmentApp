using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManager.Shared.ViewModels;

namespace EmployeeManager.Shared.Orchestrators.Interfaces
{
    interface IEmployeeOrchestrator
    {
        Task<List<EmployeeViewModel>> GetAllEmployees();
        Task<int> CreateEmployee(EmployeeViewModel employee);
    }
}
