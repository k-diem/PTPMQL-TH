using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class PhuongTrinhController : Controller
    {
        public IActionResult BacNhat()
        {
            return View(new PhuongTrinhBacNhat()); // Trả về view để giải phương trình bậc nhất
        }

        [HttpPost]
        public IActionResult BacNhat(PhuongTrinhBacNhat model)
        {
            double ketQua = model.GiaiPhuongTrinhBacNhat();
            ViewBag.KetQua = ketQua;
            return View(model);
        }

        public IActionResult BacHai()
        {
            return View(new PhuongTrinhBacHai()); // Trả về view để giải phương trình bậc hai
        }

        [HttpPost]
        public IActionResult BacHai(PhuongTrinhBacHai model)
        {
            Tuple<double, double> ketQua = model.GiaiPhuongTrinhBacHai();
            ViewBag.KetQua1 = ketQua.Item1;
            ViewBag.KetQua2 = ketQua.Item2;
            return View(model);
        }
    }
}
// DUONG KHANH DIEM - 2021050130