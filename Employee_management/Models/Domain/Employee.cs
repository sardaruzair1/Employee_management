using System.ComponentModel.DataAnnotations;

namespace Employee_management.Models.Domain
{
    public class Employee
    {
       
        public int Id { get; set; }
       
        public string? Name { get; set; } 
        
        public string? City { get; set; } 
       
        public string? State { get; set; }
       
        public long Salary { get; set; }

        public static implicit operator Employee(Employee v)
        {
            throw new NotImplementedException();
        }
    }
}
