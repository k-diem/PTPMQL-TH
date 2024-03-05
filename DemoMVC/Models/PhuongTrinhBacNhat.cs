namespace DemoMVC.Models
{
    public class PhuongTrinhBacNhat
    {
        public double HeSoA { get; set; }
        public double HeSoB { get; set; }

        public double GiaiPhuongTrinhBacNhat()
        {
            if (HeSoA == 0)
            {
                if (HeSoB == 0)
                {
                    // Phương trình vô số nghiệm
                    return double.PositiveInfinity;
                }
                else
                {
                    // Phương trình vô nghiệm
                    return double.NaN;
                }
            }
            else
            {
                // Phương trình có một nghiệm duy nhất
                return -HeSoB / HeSoA;
            }
        }
    }
}
// DUONG KHANH DIEM - 2021050130