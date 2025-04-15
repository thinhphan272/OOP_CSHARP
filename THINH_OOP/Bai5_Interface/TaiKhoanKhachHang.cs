using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_Interface
{
    public class TaiKhoanKhachHang : TaiKhoan
    {
        public string LoaiKhach { get; set; } // VIP, Thuong
        public int SoChuyenDaDi { get; set; }

        public TaiKhoanKhachHang(string username, string password, string soDienThoai)
            : base(username, password, soDienThoai)
        {
            LoaiKhach = "Thuong";
            SoChuyenDaDi = 0;
        }

        public void GoiXe(string loaiXe, string diaChiDon)
        {
            DangNhap();
            Console.WriteLine($"Khách hàng {Username} gọi xe {loaiXe} tại địa chỉ {diaChiDon}");
        }

        public void TangSoChuyen()
        {
            SoChuyenDaDi++;
            if (SoChuyenDaDi >= 10)
            {
                LoaiKhach = "VIP";
            }
        }
    }
}
