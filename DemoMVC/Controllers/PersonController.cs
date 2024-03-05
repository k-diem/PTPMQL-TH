using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View(new Person()); // Tạo một đối tượng Person mới và truyền vào view
        }

        [HttpPost]
        public IActionResult Index(Person person)
        {
            ViewBag.thongBao = "Sinh vien " + person.FullName + " o " + person.Address +  " "+  person.Age + " tuoi"; // Hiển thị thông tin đối tượng Person
            return View(person); // Trả về view với đối tượng Person đã nhập
        }
    }
}
