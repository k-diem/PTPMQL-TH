using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
// DUONG KHANH DIEM - 2021050130
namespace DemoMVC.Models
{
    [Table("Employees")]
    public class Employee : Person
    {
        public string EmployeeId { get; set; }
        public int Age { get; set; }
    }
}
