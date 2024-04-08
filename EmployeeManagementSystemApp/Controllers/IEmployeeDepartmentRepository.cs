using EmployeeManagementSystemApp.Models;

namespace EmployeeManagementSystemApp.Controllers
{
    public interface IEmployeeDepartmentRepository
    {
        void DeleteEmployeeDepartment(int id);
        string? GetEmployeeDepartment(int id);
        object GetEmployeeDepartments();
        void UpdateEmployeeDepartment(int id, EmployeeDepartment employeeDepartment);
    }
}