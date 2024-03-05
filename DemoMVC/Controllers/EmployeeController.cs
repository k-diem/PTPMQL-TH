using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View(new Employee()); // Trả về view để nhập thông tin nhân viên mới
        }

        [HttpPost]
        public IActionResult Index(Employee employee)
        {
            // Xử lý dữ liệu và hiển thị kết quả
            ViewBag.Message = "Thông tin nhân viên: " + employee.EmployeeId + " tuoi " + employee.Age;
            return View(employee);
        }
    }
}
// DUONG KHANH DIEM - 2021050130
