using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_Interface
{
    public class ChuyenXe
    {
        public TaiKhoanTaiXe TaiXe { get; set; }
        public TaiKhoanKhachHang KhachHang { get; set; }
        public string DiaChiDon { get; set; }
        public string DiaChiDen { get; set; }
        public int KhoangCach { get; set; } // km
        public DateTime ThoiGianBatDau { get; set; }
        public decimal ThanhTien { get; set; }

        public ChuyenXe(TaiKhoanTaiXe taiXe, TaiKhoanKhachHang khachHang,
                       string diaChiDon, string diaChiDen, int khoangCach,
                       DateTime thoiGianBatDau)
        {
            TaiXe = taiXe;
            KhachHang = khachHang;
            DiaChiDon = diaChiDon;
            DiaChiDen = diaChiDen;
            KhoangCach = khoangCach;
            ThoiGianBatDau = thoiGianBatDau;
            ThanhTien = taiXe.TinhTienChuyenXe(this);

            // Tăng số chuyến của khách hàng
            khachHang.TangSoChuyen();

            // Thêm chuyến vào danh sách của tài xế
            taiXe.ThemChuyenXe(this);
        }
    }
}
