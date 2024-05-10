using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models
{
    public class Student
    {
        [Key]
        public string StudentId { get; set; }
        public string StudentName { get; set; }
    }
}
// DUONG KHANH DIEM - 2021050130