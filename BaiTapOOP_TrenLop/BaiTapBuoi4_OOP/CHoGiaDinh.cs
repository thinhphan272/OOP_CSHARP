using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi4_OOP
{
    public class HoGiaDinh
    {
        private string maHo;
        private string tenChuHo;
        private double soDienDauKy;
        private double soDienCuoiKy;
        private string loaiHoGD;

        private const int GiaDien = 3000;

        public string MaHo
        {
            get { return maHo; }
            set { maHo = value; }
        }

        public string TenChuHo
        {
            get { return tenChuHo; }
            set { tenChuHo = value; }
        }

        public double SoDienDauKy
        {
            get { return soDienDauKy; }
            set { soDienDauKy = value >= 0 ? value : 0; }
        }

        public double SoDienCuoiKy
        {
            get { return soDienCuoiKy; }
            set { soDienCuoiKy = value >= soDienDauKy ? value : soDienDauKy; }
        }

        public string LoaiHoGD
        {
            get { return loaiHoGD; }
            set { loaiHoGD = value; }
        }

        public double SoDienTieuThu
        {
            get { return SoDienCuoiKy - SoDienDauKy; }
        }

        public double UuTien
        {
            get
            {
                if (LoaiHoGD == "A") return 10;
                else if (LoaiHoGD == "B") return 5;
                else return 0;
            }
        }

        public double TienDien
        {
            get { return (SoDienTieuThu - UuTien) * GiaDien; }
        }

        // Constructor mặc định
        public HoGiaDinh()
        {
            MaHo = "";
            TenChuHo = "";
            SoDienDauKy = 0;
            SoDienCuoiKy = 0;
            LoaiHoGD = "C";
        }

        // Constructor có tham số
        public HoGiaDinh(string maHo, string tenChuHo, double soDienDauKy, double soDienCuoiKy, string loaiHoGD)
        {
            MaHo = maHo;
            TenChuHo = tenChuHo;
            SoDienDauKy = soDienDauKy;
            SoDienCuoiKy = soDienCuoiKy;
            LoaiHoGD = loaiHoGD;
        }

        // Constructor sao chép
        public HoGiaDinh(HoGiaDinh other)
        {
            MaHo = other.MaHo;
            TenChuHo = other.TenChuHo;
            SoDienDauKy = other.SoDienDauKy;
            SoDienCuoiKy = other.SoDienCuoiKy;
            LoaiHoGD = other.LoaiHoGD;
        }
    }
}
