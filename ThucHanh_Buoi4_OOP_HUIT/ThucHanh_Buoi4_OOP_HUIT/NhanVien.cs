using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh_Buoi4_OOP_HUIT
{
    internal class NhanVien
    {
        string maNV;

        string tenNV;
        int namVL;
        double heSoLG;
        int soNN;

        public static double LuongCB = 2340000;

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public double HeSoLG { get => heSoLG; set => heSoLG = value; }
        public int NamVL 
        {
            get => namVL; 
            set
            {
                namVL = value;
                if (namVL >= DateTime.Today.Year)
                    namVL = DateTime.Today.Year;
            }
           
        }
        public int SoNN
        {
            get => soNN;
            set
            {
                soNN = value;
                if(soNN <= 0)
                    soNN = 0;
            }
        }

        public NhanVien()
        {
            MaNV = "NV01";
            TenNV = "Nguyen Van A";
            NamVL = 0;
            HeSoLG = 0;
            SoNN = 0;
        }

        public NhanVien(string maNV, string tenNV, double heSoLG)
        {
            MaNV = maNV;
            TenNV = tenNV;
            HeSoLG = heSoLG;
            NamVL = DateTime.Today.Year;
            SoNN = 0;
        }

        public NhanVien(string maNV, string tenNV, int namVL, double heSoLG, int soNN)
        {
            MaNV = maNV;
            TenNV = tenNV;
            NamVL = namVL;
            HeSoLG = heSoLG;
            SoNN = soNN;
        }

        public double PCTN()
        {
            return (double)(DateTime.Today.Year - NamVL) * LuongCB / 100;
        }

        public virtual char XepLoai()
        {
            if (SoNN <= 1)
                return 'A';
            else if (SoNN <= 3)
                return 'B';
            else
                return 'C';
        }

        public virtual double tinhLuong()
        {
            if(XepLoai() == 'A')
                return (double)LuongCB * HeSoLG * 1.0 + PCTN();
            else if (XepLoai() == 'B')
                return (double)LuongCB * HeSoLG * 0.75 + PCTN();
            else
                return (double)LuongCB * HeSoLG * 0.5 + PCTN();
        }


        public void XuatNV()
        {
            Console.WriteLine("{0, -10} {1, -23} {2, -5} {3, -5} {4, -5} {5, -5} {6, -9}", MaNV, TenNV, NamVL, HeSoLG, SoNN, XepLoai(), tinhLuong());
        }
    }
}
