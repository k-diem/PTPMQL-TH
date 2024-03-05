using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View(new Student()); // Trả về view để nhập thông tin sinh viên mới
        }

        [HttpPost]
        public IActionResult Index(Student student)
        {
            // Xử lý dữ liệu và hiển thị kết quả
            ViewBag.Message = "Thông tin sinh viên: " + student.FullName;
            return View(student);
        }
    }
}
// DUONG KHANH DIEM - 2021050130