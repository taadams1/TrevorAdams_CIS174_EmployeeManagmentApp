using EmployeeManager.Api.Models;
using EmployeeManager.Domain;
using EmployeeManager.Shared.Orchestrators;
using EmployeeManager.Shared.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace EmployeeManager.Api.Controllers
{
    [Route("api/v1/employees")]
    public class EmployeeController : ApiController
    {
        private EmployeeOrchestrator _employeeOrchestrator;

        public EmployeeController()
        {
            _employeeOrchestrator = new EmployeeOrchestrator();
        }

        public async Task<ICollection<EmployeeViewModel>> GetAllEmployees()
        {
            var employees = await _employeeOrchestrator.GetAllEmployees();

            return employees;
        }
    }
}
