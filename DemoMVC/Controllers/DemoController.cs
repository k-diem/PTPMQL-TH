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
            // Tính hiệu 2 số
            int difference = number1 - number2;
            ViewBag.differenceResult = $"Hiệu của {number1} và {number2} là {difference}";

            // Tính tích 2 số
            int product = number1 * number2;
            ViewBag.productResult = $"Tích của {number1} và {number2} là {product}";

            // Thực hiện phép chia lấy nguyên và lấy dư 2 số
            int quotient = number1 / number2;
            int remainder = number1 % number2;
            ViewBag.quotientResult = $"Phép chia lấy nguyên của {number1} và {number2} là {quotient}";
            ViewBag.remainderResult = $"Phép chia lấy dư của {number1} và {number2} là {remainder}";

            return View(); // Tạo một cái view tương ứng với action
        }
    }
}
//DUONG KHANH DIEM - 2021050130