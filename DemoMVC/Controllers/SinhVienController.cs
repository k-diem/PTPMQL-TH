using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class SinhVienController : Controller
    {
        public IActionResult Index()
        {
            return View(new SinhVien()); // Trả về view để nhập thông tin sinh viên mới
        }

        [HttpPost]
        public IActionResult Index(SinhVien sinhVien)
        {
            // Xử lý dữ liệu và hiển thị kết quả
            ViewBag.Message = "Thông tin sinh viên: " + sinhVien.HoTen;
            return View(sinhVien);
        }
    }
}
