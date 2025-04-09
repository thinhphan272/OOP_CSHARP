using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi4_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<HoGiaDinh> danhSachHoGD = new List<HoGiaDinh>();

            Console.Write("Nhập số hộ gia đình: ");
            int soHo = int.Parse(Console.ReadLine());

            for (int i = 0; i < soHo; i++)
            {
                Console.WriteLine($"Nhập thông tin hộ gia đình {i + 1}:");
                Console.Write("Mã hộ: ");
                string maHo = Console.ReadLine();
                Console.Write("Tên chủ hộ: ");
                string tenChuHo = Console.ReadLine();
                Console.Write("Số điện đầu kỳ: ");
                double soDienDauKy = double.Parse(Console.ReadLine());
                Console.Write("Số điện cuối kỳ: ");
                double soDienCuoiKy = double.Parse(Console.ReadLine());
                Console.Write("Loại hộ gia đình (A/B/C): ");
                string loaiHoGD = Console.ReadLine();

                danhSachHoGD.Add(new HoGiaDinh(maHo, tenChuHo, soDienDauKy, soDienCuoiKy, loaiHoGD));
            }

            // Tổng điện tiêu thụ
            double tongDien = danhSachHoGD.Sum(h => h.SoDienTieuThu);
            Console.WriteLine($"Tổng số điện tiêu thụ: {tongDien}");

            // Hộ tiêu thụ nhiều điện nhất
            var hoNhieuDienNhat = danhSachHoGD.OrderByDescending(h => h.SoDienTieuThu).First();
            Console.WriteLine($"Hộ tiêu thụ nhiều điện nhất: {hoNhieuDienNhat.TenChuHo}, {hoNhieuDienNhat.SoDienTieuThu} kWh");

            // Sắp xếp danh sách theo số điện tiêu thụ giảm dần
            var danhSachSapXep = danhSachHoGD.OrderByDescending(h => h.SoDienTieuThu).ToList();
            Console.WriteLine("Danh sách hộ theo thứ tự giảm dần của số điện tiêu thụ:");
            foreach (var ho in danhSachSapXep)
            {
                Console.WriteLine($"{ho.TenChuHo} - {ho.SoDienTieuThu} kWh - Tiền điện: {ho.TienDien} VND");
            }

            Console.ReadKey();
        }
    }
}
