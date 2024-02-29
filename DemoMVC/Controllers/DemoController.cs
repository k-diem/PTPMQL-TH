// DUONG KHANH DIEM - 2021050130
using Microsoft.AspNetCore.Mvc;
namespace DemoMVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Tạo một cái view tương ứng với action
        }

        [HttpPost]
        public IActionResult Index(string fName, string mEmail)
        {
            string strResult = "Hello " + fName + "-" + mEmail; // Sửa lỗi ở đây, đúng cách khai báo biến
            ViewBag.thongBao = strResult; // Sử dụng ViewBag để truyền dữ liệu đến View
            return View(); // Tạo một cái view tương ứng với action
        }
    }
}
