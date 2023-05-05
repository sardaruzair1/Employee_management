using Employee_management.Models;
using Microsoft.AspNetCore.Mvc;
using Employee_management.Data;
using Employee_management.Models.Domain;

namespace Employee_management.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly EmployeeDbContext employeeDbContext;

        public EmployeesController(EmployeeDbContext employeeDbContext)
        {
            this.employeeDbContext = employeeDbContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Add(AddEmployeeViewModel addEmployeeViewRequest)
        {
            var employee = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = addEmployeeViewRequest.Name,
                City = addEmployeeViewRequest.City,
                State = addEmployeeViewRequest.State,
                Salary = addEmployeeViewRequest.Salary,
            };
            await employeeDbContext.Employees.AddAsync(employee);
            await employeeDbContext.SaveChangesAsync();
            return RedirectToAction("Add");
        }
    }
}
