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
        public IActionResult Index(int number1, int number2)
        {
            string result;
            if (number1 < number2)
            {
                result = $"{number1} nhỏ hơn {number2}";
            }
            else if (number1 > number2)
            {
                result = $"{number1} lớn hơn {number2}";
            }
            else
            {
                result = $"{number1} bằng {number2}";
            }

            ViewBag.comparisonResult = result;

            return View(); // Tạo một cái view tương ứng với action
        }
    }
}

//DUONG KHANH DIEM - 2021050130