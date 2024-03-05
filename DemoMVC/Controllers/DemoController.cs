using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class DemoController : Controller
    {
        // Khai báo hằng số kiểu string
        private const string StudentName = " Duong Khanh Diem";

        // Khai báo hằng số kiểu int
        private readonly int StudentAge = 2021050130;

        public IActionResult Index()
        {
            // Truyền giá trị của hằng số vào ViewBag để hiển thị trong view
            ViewBag.StudentName = StudentName;
            ViewBag.StudentAge = StudentAge;
            return View(); // Tạo một cái view tương ứng với action
        }

        [HttpPost]
        public IActionResult Index(string hoTen, int tuoi)
        {
            string strResult = "Sinh vien " + hoTen + " " + tuoi + " tuoi"; // Sửa lỗi ở đây, đúng cách khai báo biến
            ViewBag.thongBao = strResult; // Sử dụng ViewBag để truyền dữ liệu đến View
            return View(); // Tạo một cái view tương ứng với action
        }
    }
}
