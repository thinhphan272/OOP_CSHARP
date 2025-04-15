using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_Interface
{
    public class TaiKhoanTaiXe : TaiKhoan
    {
        public string MaSo { get; set; }
        public string TenTaiXe { get; set; }
        public string HinhThucXe { get; set; } // XeMay, OTo, OToTai
        public int SoChoNgoi { get; set; } // Chỉ dùng cho ô tô
        public int TrongTai { get; set; } // Chỉ dùng cho ô tô tải (tấn)
        public List<ChuyenXe> DanhSachChuyen { get; set; }
        public decimal DoanhThuNgay { get; set; }

        public TaiKhoanTaiXe(string username, string password, string soDienThoai,
                            string maSo, string tenTaiXe, string hinhThucXe)
            : base(username, password, soDienThoai)
        {
            MaSo = maSo;
            TenTaiXe = tenTaiXe;
            HinhThucXe = hinhThucXe;
            DanhSachChuyen = new List<ChuyenXe>();
            DoanhThuNgay = 0;
        }

        public void NhanCuocGoi(TaiKhoanKhachHang khach, string diaChiDon)
        {
            Console.WriteLine($"Tài xế {TenTaiXe} nhận cuộc gọi từ khách {khach.Username} tại vị trí {diaChiDon}");
        }

        public decimal TinhTienChuyenXe(ChuyenXe chuyen)
        {
            decimal tien = 0;
            int km = chuyen.KhoangCach;
            int gioDon = chuyen.ThoiGianBatDau.Hour;

            switch (HinhThucXe)
            {
                case "XeMay":
                    if (km <= 2) tien = 8000;
                    else tien = 8000 + (km - 2) * 5000;

                    // Phụ thu đêm
                    if (gioDon >= 22 || gioDon < 5)
                    {
                        tien += km * 3000;
                    }
                    break;

                case "OTo":
                    if (SoChoNgoi == 4)
                    {
                        if (km <= 2) tien = 15000;
                        else if (km <= 7) tien = 15000 + (km - 2) * 12000;
                        else tien = 15000 + 5 * 12000 + (km - 7) * 8000;
                    }
                    else if (SoChoNgoi == 7)
                    {
                        if (km <= 2) tien = 17000;
                        else if (km <= 7) tien = 17000 + (km - 2) * 15000;
                        else tien = 17000 + 5 * 15000 + (km - 7) * 10000;
                    }
                    // Phụ thu
                    tien += km * 500;
                    break;

                case "OToTai":
                    if (TrongTai <= 3)
                    {
                        if (km <= 5) tien = 60000;
                        else if (km <= 10) tien = 60000 + (km - 5) * 50000;
                        else tien = 60000 + 5 * 50000 + (km - 10) * 30000;
                    }
                    else
                    {
                        if (km <= 5) tien = 70000;
                        else if (km <= 10) tien = 70000 + (km - 5) * 60000;
                        else tien = 70000 + 5 * 60000 + (km - 10) * 40000;
                    }
                    // Phụ thu
                    tien += km * 5000;
                    break;
            }

            // Giảm giá cho khách VIP nếu tiền > 200000
            if (chuyen.KhachHang.LoaiKhach == "VIP" && tien > 200000)
            {
                tien *= 0.9m;
            }

            return tien;
        }

        public decimal TraPhiChoCongTy()
        {
            decimal phi = 0;
            decimal tongTien = 0;

            foreach (var chuyen in DanhSachChuyen)
            {
                tongTien += chuyen.ThanhTien;
            }

            switch (HinhThucXe)
            {
                case "XeMay": phi = tongTien * 0.05m; break;
                case "OTo": phi = tongTien * 0.1m; break;
                case "OToTai": phi = tongTien * 0.15m; break;
            }

            return phi;
        }

        public decimal TinhThuong()
        {
            decimal thuong = 0;

            if (HinhThucXe == "OTo" && DoanhThuNgay > 2000000)
            {
                thuong = 200000;
            }
            else if (HinhThucXe == "OToTai" && DoanhThuNgay > 3000000)
            {
                thuong = 300000;
            }

            return thuong;
        }

        public void ThemChuyenXe(ChuyenXe chuyen)
        {
            DanhSachChuyen.Add(chuyen);
            DoanhThuNgay += chuyen.ThanhTien;
        }
    }
}
