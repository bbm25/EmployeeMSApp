namespace EmployeeManagementSystemApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;  
        public string LastName { get; set; } = string.Empty!;
        public string Address { get; set; }
        public string Title { get; set; }
        public string Email { get; set; } = string.Empty!;
        public string Phone { get; set; }
        

    }
}
