using System;

namespace DemoMVC.Models
{
    public class PhuongTrinhBacHai
    {
        public double HeSoA { get; set; }
        public double HeSoB { get; set; }
        public double HeSoC { get; set; }

        public Tuple<double, double> GiaiPhuongTrinhBacHai()
        {
            double delta = Math.Pow(HeSoB, 2) - 4 * HeSoA * HeSoC;
            if (delta < 0)
            {
                // Phương trình vô nghiệm
                return Tuple.Create(double.NaN, double.NaN);
            }
            else if (delta == 0)
            {
                // Phương trình có một nghiệm kép
                double x = -HeSoB / (2 * HeSoA);
                return Tuple.Create(x, x);
            }
            else
            {
                // Phương trình có hai nghiệm phân biệt
                double x1 = (-HeSoB + Math.Sqrt(delta)) / (2 * HeSoA);
                double x2 = (-HeSoB - Math.Sqrt(delta)) / (2 * HeSoA);
                return Tuple.Create(x1, x2);
            }
        }
    }
}
// DUONG KHANH DIEM - 2021050130