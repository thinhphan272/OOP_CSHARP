using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi05
{
    public class CNhanVien
    {
        private string maNV;
        private string tenNV;
        private double heSoLuong;
        private string phongBan;
        private int soNgayLamVc;
       

        public CNhanVien() { }
        
        public CNhanVien(string maNV, string tenNV, double heSoLuong, string phongBan, int soNgayLamVc)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.heSoLuong = heSoLuong;
            this.phongBan = phongBan;
            this.soNgayLamVc = soNgayLamVc;
        }

        public CNhanVien(CNhanVien obj)
        {
            maNV = obj.maNV;
            tenNV = obj.tenNV;
            heSoLuong = obj.heSoLuong;
            phongBan = obj.phongBan;
            soNgayLamVc = obj.soNgayLamVc;
        }

        public virtual   void XepLoai()
        {
            if (soNgayLamVc > 25)
            {
                Console.WriteLine("Xếp loại A");
            }
            else if (soNgayLamVc > 22)
            {
                Console.WriteLine("Xếp loại B");
            }
            else
            {
                Console.WriteLine("Xếp loại C");
            }    
        }

        public double tinhThuNhap()
        {

            if (soNgayLamVc > 25)
                return 1210 * heSoLuong * 1.0;
            else if (soNgayLamVc > 22)
                return 1210 * heSoLuong * 0.75;
            else
                return 1210 * heSoLuong * 0.5;
             
        }

    }

    public class CCanBoQL : CNhanVien
    {
        private string chucVu;
        private double heSoChucVu;

        public CCanBoQL()
        {

        }

        public CCanBoQL(string maNV, string tenNV, double heSoLuong, string phongBan, int soNgayLamVc, string chucVu, double heSoChucVu):base(maNV, tenNV, heSoLuong, phongBan, soNgayLamVc)
        {
            this.chucVu = chucVu;
            this.heSoChucVu = heSoChucVu;
        }



    }
    
    
    
}
