using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_PhanSiThinh_2001230933
{
    class ChiTietSanPham
    {
        string maSP;

        public string MaSP
        {
            get
            {
                return maSP;
            }
            set
            {
                maSP = value;
                
            }
        }
        string tenSP;

        public string TenSP
        {
            get
            {
                return tenSP;
            }
            set
            {
                tenSP = value;
            }
        }
        float donGia;

        public float DonGia
        {
            get
            {
                return donGia;
            }
            set
            {
               
                donGia = value;
                

            }
        }
        int soLuong;

        public int SoLuong
        {
            get
            {
                return soLuong;
            }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Số lượng không được nhỏ hơn 1!");
                    soLuong = 1;
                }
                else
                    soLuong = value;
            }
        }

        string loaiSP;

        public string LoaiSP
        {
            get
            {
                return loaiSP;
            }
            set 
            {
                if(value != "tra" && value != "coffe")
                {
                    Console.WriteLine("Sai thong tin loai san pham!");
                    loaiSP = "tra";
                }
                else 
                {
                    loaiSP = value;
                }
            }
        }

        public ChiTietSanPham()
        {
            MaSP = "SP001";
            TenSP = "Tra lai Tan Chau";
            DonGia = 150000f;
            SoLuong = 1;
            LoaiSP = "tra";
        }

        

        public ChiTietSanPham(string maSP, string tenSP, float donGia, int soLuong, string loaiSP)
        {
            MaSP = maSP;
            TenSP = tenSP;
            DonGia = donGia;
            SoLuong = soLuong;
            LoaiSP = loaiSP;
        }

        public double thanhTien()
        {
            return (double)SoLuong * DonGia * (1 + 0.1f);
        }


        public double uuDai()
        {
            if (LoaiSP == "coffe" && SoLuong >= 50)
                return thanhTien() * 0.1;
            else if (LoaiSP == "coffe" && SoLuong >= 20)
                return thanhTien() * 0.05;
            else if (LoaiSP == "coffe" && SoLuong < 20)
                return 0;
            else
            {
                return thanhTien() * 0.02;
            }
               
        }

        public double thanhTienChiTiet()
        {
            return (double)thanhTien() - uuDai();
        }

        public void XuatSP()
        {
            Console.WriteLine("{0, -6} {1, -20} {2, -5} {3, -11} {4, -11}", MaSP, TenSP, SoLuong, uuDai().ToString("0,0"), thanhTienChiTiet().ToString("0.0"));
            
        }

    }
}
