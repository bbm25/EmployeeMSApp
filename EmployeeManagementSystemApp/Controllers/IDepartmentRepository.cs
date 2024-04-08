using EmployeeManagementSystemApp.Models;

namespace EmployeeManagementSystemApp.Controllers
{
    public interface IDepartmentRepository
    {
        void AddDepartment(Department department);
        void DeleteDepartment(int id);
        string? GetDepartment(int id);
        object? GetDepartments();
        void UpdateDepartment(int id, Department department);
    }
}