using System.Collections;

namespace EmployeeManagementSystemApp.Controllers
{
    public interface IEmployeeRepository
    {
        IEnumerable GetEmployees();
    }
}